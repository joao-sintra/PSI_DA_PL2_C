using CineGest.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CineGest.Views {
    public partial class Filmes : UserControl {
        public Filmes() {
            InitializeComponent();

            cbCategoriaF.DropDownStyle = ComboBoxStyle.DropDownList;

           // cbCategoriaF.DataSource = CategoriaController.GetOnlyNomesCategorias();
        }

        private void listaFilmes_DoubleClick(object sender, EventArgs e) {
            listaFilmes.DataSource = FilmeController.GetFilmes();
        }

        private void limparCamposF() {
            txtNome.Text = "";
            txtDuracao.Text = "";
            cbCatAtiva.Checked = false;
        }

        private void btNovoF_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtDuracao.Text)) {
                MessageBox.Show("Por favor, preencha o(s) campo(s)!");
            }

            bool activo = cbAtivoF.Checked;
            int duracao = Int32.Parse(txtDuracao.Text);
            
            FilmeController.AdicionarFilme(txtNome.Text, duracao, cbCategoriaF.Text, activo);

            listaFilmes.DataSource = null;
            listaFilmes.DataSource = FilmeController.GetFilmes();

            limparCamposF();
        }

        private void btLimparCamposF_Click(object sender, EventArgs e) {
            limparCamposF();
        }

        private void listaFilmes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            txtNome.Text = listaFilmes.CurrentRow.Cells[1].Value.ToString();
            txtDuracao.Text = listaFilmes.CurrentRow.Cells[2].Value.ToString();
            string val = listaFilmes.CurrentRow.Cells[3].Value.ToString();

            if (val == "True") {
                cbAtivoF.Checked = true;
            } else {
                cbAtivoF.Checked = false;
            }
        }

        private void btAlterarF_Click(object sender, EventArgs e) {
            try {
                if (listaFilmes.SelectedRows == null) {
                    MessageBox.Show("Selecione um filme se quiser alterar os seus campos!");
                    return;
                }

                string id = listaFilmes.CurrentRow.Cells[0].Value.ToString();

                int selectedID = Int32.Parse(id);
                bool activo = cbAtivoF.Checked;
                int duracao = Int32.Parse(txtDuracao.Text);

                FilmeController.AlterarFilme(selectedID, txtNome.Text, duracao, cbCategoriaF.Text, activo);

                listaFilmes.DataSource = null;
                listaFilmes.DataSource = FilmeController.GetFilmes();

                limparCamposF();

            } catch (FormatException fe) {
                MessageBox.Show("Não pode deixar o(s) campo(s) vazio(s)!");
            }
        }

        private void btRemoverF_Click(object sender, EventArgs e) {
            if (listaFilmes.SelectedRows == null) {
                MessageBox.Show("Selecione um filme se pretende eliminá-lo!");
                return;
            }

            string id = listaFilmes.CurrentRow.Cells[0].Value.ToString();

            int selectedID = Int32.Parse(id);

            DialogResult dr = MessageBox.Show("Pretende mesmo remover este filme?", "Confirmação de eliminação de filme",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes) {
                FilmeController.EliminarFilme(selectedID);

                listaFilmes.DataSource = null;
                listaFilmes.DataSource = FilmeController.GetFilmes();

                limparCamposF();
            }
        }



        //Código para as Categorias
        private void listaCategorias_DoubleClick(object sender, EventArgs e) {
            listaCategorias.DataSource = CategoriaController.GetCategorias();
            cbCategoriaF.DataSource = CategoriaController.GetOnlyNomesCategorias();
        }

        private void limparCamposCat() {
            txtCat.Text = "";
            cbCatAtiva.Checked = false;
        }

        private void btNovaCat_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtCat.Text)) {
                MessageBox.Show("Por favor, preencha o campo!");
            }

            bool ativa = cbCatAtiva.Checked;

            CategoriaController.AdicionarCategoria(txtCat.Text, ativa);

            listaCategorias.DataSource = null;
            listaCategorias.DataSource = CategoriaController.GetCategorias();
            cbCategoriaF.DataSource = CategoriaController.GetOnlyNomesCategorias();

            limparCamposCat();
        }

        private void btLimparCamposCat_Click(object sender, EventArgs e) {
            limparCamposCat();
        }

        private void btAlterarCat_Click(object sender, EventArgs e) {
            try {
                if (listaCategorias.SelectedRows == null) {
                    MessageBox.Show("Selecione uma categoria se quiser alterar os seus campos!");
                    return;
                }

                string id = listaCategorias.CurrentRow.Cells[0].Value.ToString();

                int selectedID = Int32.Parse(id);

                bool ativa = cbCatAtiva.Checked;

                CategoriaController.AlterarCategoria(selectedID, txtCat.Text, ativa);

                listaCategorias.DataSource = null;
                listaCategorias.DataSource = CategoriaController.GetCategorias();
                cbCategoriaF.DataSource = CategoriaController.GetOnlyNomesCategorias();

                limparCamposCat();

            } catch (FormatException fe) {
                MessageBox.Show("Não pode deixar o(s) campo(s) vazio(s)!");
            }
        }

        private void btRemoverCat_Click(object sender, EventArgs e) {
            if (listaCategorias.SelectedRows == null) {
                MessageBox.Show("Selecione uma categoria se pretende eliminá-la!");
                return;
            }

            string id = listaCategorias.CurrentRow.Cells[0].Value.ToString();

            int selectedID = Int32.Parse(id);

            DialogResult dr = MessageBox.Show("Pretende mesmo remover esta categoria?", "Confirmação de eliminação de categoria",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes) {
                CategoriaController.EliminarCategoria(selectedID);

                listaCategorias.DataSource = null;
                listaCategorias.DataSource = CategoriaController.GetCategorias();
                cbCategoriaF.DataSource = CategoriaController.GetOnlyNomesCategorias();

                limparCamposCat();
            }
        }

        private void listaCategorias_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            txtCat.Text = listaCategorias.CurrentRow.Cells[1].Value.ToString();
            string val = listaCategorias.CurrentRow.Cells[2].Value.ToString();
            
            if (val == "True") {
                cbCatAtiva.Checked = true;
            } else {
                cbCatAtiva.Checked = false;
            }
        }
    }
}
