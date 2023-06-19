using CineGest.Controllers;
using System;
using System.Windows.Forms;

namespace CineGest.Views {
    public partial class Filmes : UserControl {
        public Filmes() {
            InitializeComponent();

            cbCategoriaF.DropDownStyle = ComboBoxStyle.DropDownList;

            listaFilmes.ReadOnly = true;
            listaFilmes.EditMode = DataGridViewEditMode.EditProgrammatically;

            listaCategorias.ReadOnly = true;
            listaCategorias.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void limparLF() {
            listaFilmes.ClearSelection();
        }

        private void listaFilmes_DoubleClick(object sender, EventArgs e) {
            listaFilmes.DataSource = FilmeController.GetFilmes();
            limparLF();
        }

        private void limparCamposF() {
            txtNome.Text = "";
            txtDuracao.Text = "";
            cbCatAtiva.Checked = false;
        }

        private void refreshLF() {
            filmeBindingSource.DataSource = null;
            filmeBindingSource.DataSource = FilmeController.GetFilmes();
            listaFilmes.DataSource = null;
            listaFilmes.DataSource = FilmeController.GetFilmes();
        }

        private void btNovoF_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtDuracao.Text)) {
                MessageBox.Show("Por favor, preencha o(s) campo(s)!");

            } else {
                try {
                    bool activo = cbAtivoF.Checked;
                    int duracao = Int32.Parse(txtDuracao.Text);

                    FilmeController.AdicionarFilme(txtNome.Text, duracao, cbCategoriaF.Text, activo);

                    refreshLF();
                    limparLF();
                    limparCamposF();

                } catch (FormatException) {
                    MessageBox.Show("Campos no formato incorreto!\n\nCampo Nome: aceita tanto letras como números." +
                        "\nCampo Duração: só aceita números inteiros.\n");

                    limparCamposF();
                }
            }
        }

        private void btLimparCamposF_Click(object sender, EventArgs e) {
            limparCamposF();
            limparLF();
        }

        private void listaFilmes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            txtNome.Text = listaFilmes.CurrentRow.Cells[1].Value.ToString();
            txtDuracao.Text = listaFilmes.CurrentRow.Cells[2].Value.ToString();
            cbCategoriaF.Text = listaFilmes.CurrentRow.Cells[4].Value.ToString();
            string val = listaFilmes.CurrentRow.Cells[3].Value.ToString();

            if (val == "True") {
                cbAtivoF.Checked = true;
            } else {
                cbAtivoF.Checked = false;
            }
        }

        private void btAlterarF_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtDuracao.Text)) {
                MessageBox.Show("Só pode alterar o campo de um filme, se ele estiver adicionado e selecionado na Tabela Filmes!");
                return;

            } else {
                if (listaFilmes.SelectedRows == null || listaCategorias.CurrentRow == null) {
                    MessageBox.Show("Selecione uma linha da Tabela Filmes, se quiser alterar o seu campo!");
                    return;

                } else {
                    try {
                        string id = listaFilmes.CurrentRow.Cells[0].Value.ToString();

                        int selectedID = Int32.Parse(id);
                        bool activo = cbAtivoF.Checked;
                        int duracao = Int32.Parse(txtDuracao.Text);

                        FilmeController.AlterarFilme(selectedID, txtNome.Text, duracao, cbCategoriaF.Text, activo);

                        refreshLF();
                        limparLF();
                        limparCamposF();

                    } catch (FormatException ) {
                        MessageBox.Show("Campos no formato incorreto!\n\nCampo Nome: aceita tanto letras como números." +
                            "\nCampo Duração: só aceita números inteiros.\n");

                        limparLF();
                        limparCamposF();
                    }
                }
            }
        }

        private void btRemoverF_Click(object sender, EventArgs e) {
            if (listaFilmes.SelectedRows == null || listaCategorias.CurrentRow == null) {
                MessageBox.Show("Selecione um filme da Tabela Filmes, se pretende eliminá-lo!");
                return;
            } else {
                string id = listaFilmes.CurrentRow.Cells[0].Value.ToString();

                int selectedID = Int32.Parse(id);

                DialogResult dr = MessageBox.Show("Pretende mesmo remover este filme?", "Confirmação de eliminação de filme",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes) {
                    FilmeController.EliminarFilme(selectedID);

                    refreshLF();
                    limparLF();
                    limparCamposF();
                }
            }
        }



        //Código para as Categorias

        private void limparLC() {
            listaCategorias.ClearSelection();
        }

        private void limparCamposCat() {
            txtCat.Text = "";
            cbCatAtiva.Checked = false;
        }

        private void refreshLC() {
            listaCategorias.DataSource = null;
            listaCategorias.DataSource = CategoriaController.GetCategorias();
            cbCategoriaF.DataSource = CategoriaController.GetOnlyNomesCategorias();
        }

       

        private void btNovaCat_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtCat.Text)) {
                MessageBox.Show("Por favor, preencha o campo!");
                return;

            } else {
                try {
                    bool ativa = cbCatAtiva.Checked;

                    CategoriaController.AdicionarCategoria(txtCat.Text, ativa);

                    refreshLC();
                    limparCamposCat();

                } catch (FormatException) {
                    MessageBox.Show("Campo no formato incorreto!\n\nCampo Nome: aceita tanto letras como números.");

                    limparCamposF();
                }
            }
        }

        private void btLimparCamposCat_Click(object sender, EventArgs e) {
            limparCamposCat();
            limparLC();
        }

        private void btAlterarCat_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtCat.Text)) {
                MessageBox.Show("Só pode alterar o campo de uma categoria, se ela estiver adicionada e selecionada na Tabela Categorias!");
                return;

            } else {
                if (listaCategorias.SelectedRows == null || listaCategorias.CurrentRow == null) {
                    MessageBox.Show("Selecione uma linha da Tabela Categorias, se quiser alterar o seu campo!");
                    return;
                } else {
                    try {
                        string idCat = listaCategorias.CurrentRow.Cells[0].Value.ToString();
                        //string idFil = listaFilmes.CurrentRow.Cells[0].Value.ToString();

                        int selectedCategoriaID = Int32.Parse(idCat);
                        //int selectedFilmeID = Int32.Parse(idFil);

                        bool ativa = cbCatAtiva.Checked;

                        CategoriaController.AlterarCategoria(selectedCategoriaID, txtCat.Text, ativa);

                        refreshLC();
                        refreshLF();
                        limparLC();
                        limparCamposCat();

                    } catch (FormatException) {
                        MessageBox.Show("Não pode deixar o(s) campo(s) vazio(s)!");
                        return;
                    }
                }
            }
        }

        private void btRemoverCat_Click(object sender, EventArgs e) {
            if (listaCategorias.SelectedRows == null || listaCategorias.CurrentRow == null) {
                MessageBox.Show("Selecione uma linha da Tabela Categorias, se quiser eliminá-la!");
                return;
            } else {
                string idCat = listaCategorias.CurrentRow.Cells[0].Value.ToString();

                int selectedCategoriaID = Int32.Parse(idCat);

                bool ativa = cbCatAtiva.Checked;

                DialogResult dr = MessageBox.Show("Pretende mesmo remover esta categoria?", "Confirmação de eliminação de categoria",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes) {
                    CategoriaController.EliminarCategoria(selectedCategoriaID);

                    refreshLC();
                    limparLC();
                    limparCamposCat();
                }
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

      
        public void CarregaDataGrid() {
            listaCategorias.DataSource = CategoriaController.GetCategorias();
            cbCategoriaF.DataSource = CategoriaController.GetOnlyNomesCategorias();
            limparLC();
            listaFilmes.DataSource = FilmeController.GetFilmes();
            limparLF();
        }
    }
}
