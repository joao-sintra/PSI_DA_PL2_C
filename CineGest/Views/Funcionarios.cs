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

        }

        private void limparCamposFunc() {
            txtNomeFun.Text = "";
            txtMoradaFun.Text = "";
            txtSalarioFun.Text = "";
            txtFuncaoFun.Text = "";
        }

        private void listaFuncionarios_DoubleClick(object sender, EventArgs e) {
            listaFuncionarios.DataSource = FuncionarioController.GetFuncionarios();
        }

        private void btNovoFun_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtNomeFun.Text) || string.IsNullOrEmpty(txtMoradaFun.Text) || string.IsNullOrEmpty(txtSalarioFun.Text) || string.IsNullOrEmpty(txtFuncaoFun.Text)) {
                MessageBox.Show("Por favor, preencha o(s) campo(s)!");
            }
            
            float salario = float.Parse(txtSalarioFun.Text);

            FuncionarioController.AdicionarFuncionario(txtNomeFun.Text, txtMoradaFun.Text, salario, txtFuncaoFun.Text);

            listaFuncionarios.DataSource = null;
            listaFuncionarios.DataSource = FuncionarioController.GetFuncionarios();

            limparCamposFunc();
        }
    }
}
