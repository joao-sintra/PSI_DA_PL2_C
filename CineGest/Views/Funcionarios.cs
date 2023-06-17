using CineGest.Controllers;
using System;
using System.Windows.Forms;

namespace CineGest.Views {
    public partial class Funcionarios : UserControl {
        public Funcionarios() {
            InitializeComponent();

            listaFuncionarios.ReadOnly = true;
            listaFuncionarios.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void limparDGV() {
            listaFuncionarios.ClearSelection();
        }

        private void limparCamposFunc() {
            txtNomeFun.Text = "";
            txtMoradaFun.Text = "";
            txtSalarioFun.Text = "";
            txtFuncaoFun.Text = "";
        }

        private void refreshLPLF() {

            listaFuncionarios.DataSource = null;
            listaFuncionarios.DataSource = FuncionarioController.GetFuncionarios();
        }
        public void ordenarCampos() {
            listaFuncionarios.Columns["Id"].Visible = false;
            listaFuncionarios.Columns["Nome"].DisplayIndex = 0;
            listaFuncionarios.Columns["Morada"].DisplayIndex = 1;
            listaFuncionarios.Columns["Salario"].DisplayIndex = 2;
            listaFuncionarios.Columns["Funcao"].DisplayIndex = 3;
        }



        private void btNovoFun_Click(object sender, EventArgs e) {
            try {
                if (string.IsNullOrEmpty(txtNomeFun.Text) || string.IsNullOrEmpty(txtMoradaFun.Text) || string.IsNullOrEmpty(txtSalarioFun.Text) || string.IsNullOrEmpty(txtFuncaoFun.Text)) {
                    MessageBox.Show("Por favor, preencha o(s) campo(s)!");
                }

                float salario = float.Parse(txtSalarioFun.Text);

                FuncionarioController.AdicionarFuncionario(txtNomeFun.Text, txtMoradaFun.Text, salario, txtFuncaoFun.Text);

                refreshLPLF();
                limparCamposFunc();
                ordenarCampos();

            } catch (FormatException fe) {
                MessageBox.Show("Campos no formato incorreto!\n" +
                         "\nCampo Nome: aceita letras e números." +
                         "\nCampo Morada: aceita letras e números." +
                         "\nCampo Salário: aceita números reais." +
                         "\nCampo Função: aceita letras e números.");

                limparCamposFunc();
                ordenarCampos();
            }
        }

        private void btLimparCamposFun_Click(object sender, EventArgs e) {
            limparCamposFunc();
            limparDGV();
            ordenarCampos();
        }

        private void btAlterarFun_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtNomeFun.Text) || string.IsNullOrEmpty(txtMoradaFun.Text) || string.IsNullOrEmpty(txtSalarioFun.Text) || string.IsNullOrEmpty(txtFuncaoFun.Text)) {
                MessageBox.Show("Tem de selecionar numa linha da tabela Funcionários, se quiser alterar os campos!");
                return;

            } else {
                if ((listaFuncionarios.SelectedRows == null) || (listaFuncionarios.CurrentRow == null)) {
                    MessageBox.Show("Só pode alterar o(s) campo(s), se o funcionário estiver adicionado e selecionado na Tabelas Funcionários!");
                    return;
                } else {
                    try {
                        string idFun = listaFuncionarios.CurrentRow.Cells[1].Value.ToString();

                        int selectedFuncionarioID = Int32.Parse(idFun);

                        float salario = float.Parse(txtSalarioFun.Text);

                        FuncionarioController.AlterarFuncionario(selectedFuncionarioID, txtNomeFun.Text, txtMoradaFun.Text, salario, txtFuncaoFun.Text);

                        refreshLPLF();
                        limparDGV();
                        limparCamposFunc();
                        ordenarCampos();

                    } catch (FormatException fe) {
                        MessageBox.Show("Campos no formato incorreto!\n" +
                         "\nCampo Nome: aceita letras e números." +
                         "\nCampo Morada: aceita letras e números." +
                         "\nCampo Salário: aceita números reais." +
                         "\nCampo Função: aceita letras e números.");

                        ordenarCampos();
                    }
                }
            }
        }

        private void listaPessoas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            txtNomeFun.Text = listaFuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtMoradaFun.Text = listaFuncionarios.CurrentRow.Cells[4].Value.ToString();

            txtSalarioFun.Text = listaFuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtFuncaoFun.Text = listaFuncionarios.CurrentRow.Cells[1].Value.ToString();
        }

        private void btRemoverFun_Click(object sender, EventArgs e) {
            try {
                if (listaFuncionarios.SelectedRows == null) {
                    MessageBox.Show("Tem de selecionar numa linha da tabela Funcionários, se quiser eliminá-la!");
                    return;
                }

                string idFun = listaFuncionarios.CurrentRow.Cells[2].Value.ToString();

                int selectedFuncionarioID = Int32.Parse(idFun);

                float salario = float.Parse(txtSalarioFun.Text);

                DialogResult dr = MessageBox.Show("Pretende mesmo remover este funcionário?", "Confirmação de eliminação de funcionário",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes) {
                    FuncionarioController.RemoverFuncionario(selectedFuncionarioID);

                    refreshLPLF();
                    limparDGV();
                    limparCamposFunc();
                    ordenarCampos();
                }

            } catch (FormatException fe) {
                MessageBox.Show("Tem de selecionar numa linha da tabela Funcionários, se quiser eliminá-la!");
                ordenarCampos();
            }
        }

        private void Funcionarios_Load(object sender, EventArgs e) {
            listaFuncionarios.DataSource = FuncionarioController.GetFuncionarios();
            ordenarCampos();
        }
    }
}


