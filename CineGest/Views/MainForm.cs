using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CineGest {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            HideForms();


        }

        private void HideForms() {
            inicio1.Visible = false;
            atendimento1.Visible = false;
            //filmes1.Visible = false;
            sessoes1.Visible = false;
            //funcionarios1.Visible = false;
            //cinema1.Visible = false;
            //clientes1.Visible = false;
            panelCinema.BackColor = Color.FromArgb(34, 40, 49);
            panelClientes.BackColor = Color.FromArgb(34, 40, 49);
            panelFilmes.BackColor = Color.FromArgb(34, 40, 49);
            panelFuncionarios.BackColor = Color.FromArgb(34, 40, 49);
            panelInicio.BackColor = Color.FromArgb(34, 40, 49);
            panelSessoes.BackColor = Color.FromArgb(34, 40, 49);
        }

        private void panelFilmes_Click(object sender, EventArgs e) {
            HideForms();
          //  filmes1.Visible = true;
            panelFilmes.BackColor = Color.FromArgb(22, 26, 31);
            
        }

        private void panelCinema_Click(object sender, EventArgs e) {
            HideForms();
           // cinema1.Visible = true;
            panelCinema.BackColor = Color.FromArgb(22, 26, 31);
        }

        private void panelInicio_Click(object sender, EventArgs e) {
            HideForms();
            inicio1.Visible = true;
            panelInicio.BackColor = Color.FromArgb(22, 26, 31);
        }



        private void panelSessoes_Click(object sender, EventArgs e) {
            HideForms();
            sessoes1.Visible = true;
            panelSessoes.BackColor = Color.FromArgb(22, 26, 31);
        }

        private void panelClientes_Click(object sender, EventArgs e) {
            HideForms();
            //clientes1.Visible = true;
            panelClientes.BackColor = Color.FromArgb(22, 26, 31);
        }

        private void panelFuncionarios_Click(object sender, EventArgs e) {
            HideForms();
            //funcionarios1.Visible = true;
            panelFuncionarios.BackColor = Color.FromArgb(22, 26, 31);
        }

        private void panelTerminarSessao_Click(object sender, EventArgs e) {
            HideForms();
           // atendimento1.Visible = true;
        }
    }
}

