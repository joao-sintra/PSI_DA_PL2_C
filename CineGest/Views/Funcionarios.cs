using CineGest.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineGest.Views {
    public partial class Funcionarios : UserControl {
        public Funcionarios() {
            InitializeComponent();


            listaPessoas.ReadOnly = true;
            listaPessoas.EditMode = DataGridViewEditMode.EditProgrammatically;

            listaFuncionarios.ReadOnly = true;
            listaFuncionarios.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void limparDGV() {
            listaPessoas.ClearSelection();
            listaFuncionarios.ClearSelection();
        }

        private void limparCamposFunc() {
            txtNomeFun.Text = "";
            txtMoradaFun.Text = "";
            txtSalarioFun.Text = "";
            txtFuncaoFun.Text = "";
        }

        private void listaFuncionarios_DoubleClick(object sender, EventArgs e) {
            listaFuncionarios.DataSource = FuncionarioController.GetFuncionarios();
            limparDGV();
        }
        private void listaPessoas_DoubleClick(object sender, EventArgs e) {
            listaPessoas.DataSource = FuncionarioController.GetPessoas();
            limparDGV();
        }

        private void btNovoFun_Click(object sender, EventArgs e) {
            try {
                if (string.IsNullOrEmpty(txtNomeFun.Text) || string.IsNullOrEmpty(txtMoradaFun.Text) || string.IsNullOrEmpty(txtSalarioFun.Text) || string.IsNullOrEmpty(txtFuncaoFun.Text)) {
                    MessageBox.Show("Por favor, preencha o(s) campo(s)!");
                }

                float salario = float.Parse(txtSalarioFun.Text);

                FuncionarioController.AdicionarPessoaFuncionario(txtNomeFun.Text, txtMoradaFun.Text, salario, txtFuncaoFun.Text);

                listaPessoas.DataSource = null;
                listaFuncionarios.DataSource = null;
                listaPessoas.DataSource = FuncionarioController.GetPessoas();
                listaFuncionarios.DataSource = FuncionarioController.GetFuncionarios();

                limparCamposFunc();

            } catch (FormatException fe) {
                MessageBox.Show("Campos no formato incorreto!\n\n" +
                        "Campo Nome: aceita tanto letras como números." +
                        "\nCampo Morada: aceita tanto letras como números." +
                        "\nCampo Salário: só aceita números." +
                        "\nCampo Função: aceita tanto letras como números.\n");

                limparCamposFunc();
            }
        }

        private void btLimparCamposFun_Click(object sender, EventArgs e) {
            limparCamposFunc();
            limparDGV();
        }

        private void btAlterarFun_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtNomeFun.Text) || string.IsNullOrEmpty(txtMoradaFun.Text) || string.IsNullOrEmpty(txtSalarioFun.Text) || string.IsNullOrEmpty(txtFuncaoFun.Text)) {
                MessageBox.Show("Tem de selecionar numa linha de cada tabela, se quiser alterar os seus campos!");
                return;

            } else {
                if ((listaPessoas.SelectedRows == null) || (listaFuncionarios.SelectedRows == null) || (listaPessoas.CurrentRow == null) || (listaFuncionarios.CurrentRow == null)) {
                    MessageBox.Show("Só pode alterar o(s) campo(s) de uma pessoa ou de funcionário, se ela ou ele estiverem adicionados e selecionados nas Tabelas Pessoas e Funcionários ao mesmo tempo!");
                    return;
                } else {
                    try {
                        string idPess = listaPessoas.CurrentRow.Cells[0].Value.ToString();
                        string idFunc = listaFuncionarios.CurrentRow.Cells[0].Value.ToString();

                        int selectedPessoaID = Int32.Parse(idPess);
                        int selectedFuncID = Int32.Parse(idFunc);

                        float salario = float.Parse(txtSalarioFun.Text);

                        if (selectedPessoaID == selectedFuncID) {
                            FuncionarioController.AlterarPessoaFuncionario(selectedPessoaID, selectedFuncID, txtNomeFun.Text, txtMoradaFun.Text, salario, txtFuncaoFun.Text);

                            listaPessoas.DataSource = null;
                            listaFuncionarios.DataSource = null;
                            listaPessoas.DataSource = FuncionarioController.GetPessoas();
                            listaFuncionarios.DataSource = FuncionarioController.GetFuncionarios();

                            limparDGV();
                            limparCamposFunc();
                        } else {
                            MessageBox.Show("A linha que selecionaste na Tabela Pessoas não corresponde ao funcionário escolhido na Tabela Funcionários, ou viceversa!");
                            limparDGV();
                            return;
                        }

                    } catch (FormatException fe) {
                        MessageBox.Show("Não pode deixar o(s) campo(s) vazio(s)!");
                    }
                }
            }
        }

        private void listaPessoas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            txtNomeFun.Text = listaPessoas.CurrentRow.Cells[1].Value.ToString();
            txtMoradaFun.Text = listaPessoas.CurrentRow.Cells[2].Value.ToString();
        }
        
        private void listaFuncionarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            txtSalarioFun.Text = listaFuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtFuncaoFun.Text = listaFuncionarios.CurrentRow.Cells[2].Value.ToString();
        }

        private void btRemoverFun_Click(object sender, EventArgs e) {
            try {
                if ((listaPessoas.SelectedRows == null) && (listaFuncionarios.SelectedRows == null)) {
                    MessageBox.Show("Tem de selecionar numa linha de cada tabela, se quiser eliminá-la da tabela!");
                    return;
                }

                string idPess = listaPessoas.CurrentRow.Cells[0].Value.ToString();
                string idFunc = listaFuncionarios.CurrentRow.Cells[0].Value.ToString();

                int selectedPessoaID = Int32.Parse(idPess);
                int selectedFuncID = Int32.Parse(idFunc);

                float salario = float.Parse(txtSalarioFun.Text);

                if (selectedPessoaID == selectedFuncID) {
                    DialogResult dr = MessageBox.Show("Pretende mesmo remover este funcionário?", "Confirmação de eliminação de funcionário",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (dr == DialogResult.Yes) {
                        FuncionarioController.RemoverPessoaFuncionario(selectedPessoaID, selectedFuncID);

                        listaPessoas.DataSource = null;
                        listaFuncionarios.DataSource = null;
                        listaPessoas.DataSource = FuncionarioController.GetPessoas();
                        listaFuncionarios.DataSource = FuncionarioController.GetFuncionarios();

                        limparDGV();
                        limparCamposFunc();
                    }
                    
                } else {
                    MessageBox.Show("A linha que selecionaste na tabela Pessoas não corresponde ao funcionário escolhido na tabela Funcionários!");
                    return;
                }

            } catch (FormatException fe) {
                MessageBox.Show("Tem de selecionar numa linha de cada tabela, se quiser eliminá-la da tabela!");
            }
        }
    }
}
