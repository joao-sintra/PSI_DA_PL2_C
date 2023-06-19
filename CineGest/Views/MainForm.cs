using CineGest.Controllers;
using CineGest.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CineGest {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            HideForms();
            inicio1.Visible = true;
            inicio1.CarregaDatagrid();

        }

        private void HideForms() {
            inicio1.Visible = false;
            //atendimento1.Visible = false;
            filmes1.Visible = false;
            sessoes1.Visible = false;
            funcionarios1.Visible = false;
            cinema1.Visible = false;
            clientes1.Visible = false;
            panelCinema.BackColor = Color.FromArgb(34, 40, 49);
            panelClientes.BackColor = Color.FromArgb(34, 40, 49);
            panelFilmes.BackColor = Color.FromArgb(34, 40, 49);
            panelFuncionarios.BackColor = Color.FromArgb(34, 40, 49);
            panelInicio.BackColor = Color.FromArgb(34, 40, 49);
            panelSessoes.BackColor = Color.FromArgb(34, 40, 49);
        }

        private void panelFilmes_Click(object sender, EventArgs e) {
            HideForms();
              filmes1.Visible = true;
            filmes1.CarregaDataGrid();
            panelFilmes.BackColor = Color.FromArgb(22, 26, 31);

        }

        private void panelCinema_Click(object sender, EventArgs e) {
            HideForms();
            cinema1.Visible = true;
            cinema1.CarregaDataGrid();
            panelCinema.BackColor = Color.FromArgb(22, 26, 31);
        }

        private void panelInicio_Click(object sender, EventArgs e) {
            HideForms();
            inicio1.Visible = true;
            inicio1.CarregaDatagrid();

            panelInicio.BackColor = Color.FromArgb(22, 26, 31);
        }



        private void panelSessoes_Click(object sender, EventArgs e) {
            HideForms();
            sessoes1.Visible = true;
            sessoes1.CarregaDatagrid();
            panelSessoes.BackColor = Color.FromArgb(22, 26, 31);
        }

        private void panelClientes_Click(object sender, EventArgs e) {
            HideForms();
            clientes1.Visible = true;
            clientes1.CarregaDataGrid();
            panelClientes.BackColor = Color.FromArgb(22, 26, 31);
        }

        private void panelFuncionarios_Click(object sender, EventArgs e) {
            HideForms();
            funcionarios1.Visible = true;
            funcionarios1.CarregaDataGrid();
            panelFuncionarios.BackColor = Color.FromArgb(22, 26, 31);
        }

        private void panelTerminarSessao_Click(object sender, EventArgs e) {
            HideForms();
            

        }
    }
}

