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
    public partial class CriacaoCinema : Form {
        public CriacaoCinema() {
            InitializeComponent();
        }
        private void LimpaCamposCinema() {
            txtNome.Text = "";
            txtMorada.Text = "";
            txtEmail.Text = "";
        }
        private void btNovoCliente_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMorada.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEmail.Text)) {
                MessageBox.Show("Por favor, preencha o(s) campo(s)!");

            } else {
                try {

                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);

                    CinemaController.AdicionarCinema(txtNome.Text, addr.Address, txtEmail.Text);
                    FuncionarioController.AdicionarFuncionario("Admin", "morada", 0, "Administrador");
                    ClienteController.AdicionarCliente(999999999, "Anônimo", "x");
                    CategoriaController.AdicionarCategoria("Comédia", true);
                    CategoriaController.AdicionarCategoria("Sci-fi", true);
                    CategoriaController.AdicionarCategoria("Terror", true);
                    CategoriaController.AdicionarCategoria("Romance", true);
                    CategoriaController.AdicionarCategoria("Acção", true);
                    CategoriaController.AdicionarCategoria("Thriller", true);
                    CategoriaController.AdicionarCategoria("Drama", true);
                    CategoriaController.AdicionarCategoria("Mistério", true);
                    CategoriaController.AdicionarCategoria("Crime", true);
                    CategoriaController.AdicionarCategoria("Aventura", true);
                    CategoriaController.AdicionarCategoria("Fantasia", true);
                    CategoriaController.AdicionarCategoria("Animação", true);

                    var mainForm = new MainForm();

                    mainForm.Show();
                    this.Hide();

                } catch (FormatException) {
                    MessageBox.Show("Campos no formato incorreto!\n" +
                           "\nCampo Nome: aceita letras!" +
                           "\nCampo Morada: aceita letras e números!" +
                           "\nCampo Email: Só aceita email!");
                }

            }

        }

        private void btLimparCamposCliente_Click(object sender, EventArgs e) {
            LimpaCamposCinema();
        }
    }
}
