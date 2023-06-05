using CineGest.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

            //listaFuncionarios.Columns[3].Visible = false;
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

        private void refreshLPLF() {
            listaPessoas.DataSource = null;
            listaFuncionarios.DataSource = null;
            listaPessoas.DataSource = FuncionarioController.GetPessoas();
            listaFuncionarios.DataSource = FuncionarioController.GetFuncionarios();
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

                refreshLPLF();
                limparCamposFunc();

            } catch (FormatException fe) {
                MessageBox.Show("Campos no formato incorreto!\n" +
                         "\nCampo Nome: aceita letras e números." +
                         "\nCampo Morada: aceita letras e números." +
                         "\nCampo Salário: aceita números reais." +
                         "\nCampo Função: aceita letras e números.");

                limparCamposFunc();
            }
        }

        private void btLimparCamposFun_Click(object sender, EventArgs e) {
            limparCamposFunc();
            limparDGV();
        }

        private void btAlterarFun_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtNomeFun.Text) || string.IsNullOrEmpty(txtMoradaFun.Text) || string.IsNullOrEmpty(txtSalarioFun.Text) || string.IsNullOrEmpty(txtFuncaoFun.Text)) {
                MessageBox.Show("Tem de selecionar numa linha da tabela Pessoas, se quiser alterar os campos!");
                return;

            } else {
                if ((listaPessoas.SelectedRows == null) || (listaPessoas.CurrentRow == null)) {
                    MessageBox.Show("Só pode alterar o(s) campo(s), se a pessoa estiver adicionada e selecionada na Tabelas Pessoas!");
                    return;
                } else {
                    try {
                        string idPess = listaPessoas.CurrentRow.Cells[0].Value.ToString();

                        int selectedPessoaID = Int32.Parse(idPess);

                        float salario = float.Parse(txtSalarioFun.Text);

                        FuncionarioController.AlterarPessoaFuncionario(selectedPessoaID, txtNomeFun.Text, txtMoradaFun.Text, salario, txtFuncaoFun.Text);

                        refreshLPLF();
                        limparDGV();
                        limparCamposFunc();

                    } catch (FormatException fe) {
                        MessageBox.Show("Campos no formato incorreto!\n" +
                         "\nCampo Nome: aceita letras e números." +
                         "\nCampo Morada: aceita letras e números." +
                         "\nCampo Salário: aceita números reais." +
                         "\nCampo Função: aceita letras e números.");
                    }
                }
            }
        }

        private void listaPessoas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            txtNomeFun.Text = listaPessoas.CurrentRow.Cells[1].Value.ToString();
            txtMoradaFun.Text = listaPessoas.CurrentRow.Cells[2].Value.ToString();

            txtSalarioFun.Text = listaFuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtFuncaoFun.Text = listaFuncionarios.CurrentRow.Cells[2].Value.ToString();

            //string idPess = listaPessoas.CurrentRow.Cells[0].Value.ToString();

            //int selectedPessoaID = Int32.Parse(idPess);
            //Funcionario fun = FuncionarioController.GetSalarioFuncionario(selectedPessoaID);
            //txtFuncaoFun.Text = FuncionarioController.GetFuncaoFuncionario(selectedPessoaID);
        }

        private void btRemoverFun_Click(object sender, EventArgs e) {
            try {
                if (listaPessoas.SelectedRows == null) {
                    MessageBox.Show("Tem de selecionar numa linha da tabela Pessoas, se quiser eliminá-la!");
                    return;
                }

                string idPess = listaPessoas.CurrentRow.Cells[0].Value.ToString();

                int selectedPessoaID = Int32.Parse(idPess);

                float salario = float.Parse(txtSalarioFun.Text);

                DialogResult dr = MessageBox.Show("Pretende mesmo remover este funcionário?", "Confirmação de eliminação de funcionário",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes) {
                    FuncionarioController.RemoverPessoaFuncionario(selectedPessoaID);

                    refreshLPLF();
                    limparDGV();
                    limparCamposFunc();
                }

            } catch (FormatException fe) {
                MessageBox.Show("Tem de selecionar numa linha da tabela Pessoas, se quiser eliminá-la!");
            }
        }
    }
}
