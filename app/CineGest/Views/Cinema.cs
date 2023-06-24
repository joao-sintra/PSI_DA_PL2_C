using CineGest.Controllers;
using System;
using System.Windows.Forms;

namespace CineGest.Views {
    public partial class Cinema : UserControl {
        public Cinema() {
            InitializeComponent();

            listaSalas.ReadOnly = true;
            listaSalas.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void limparLS() {
            listaSalas.ClearSelection();
        }



        private void limparCampos() {
            txtSala.Text = "";
            txtNumColunas.Text = "";
            txtNumFilas.Text = "";
        }

        private void refreshLS() {
            listaSalas.DataSource = null;
            listaSalas.DataSource = SalaController.GetSalas();
        }

        private void btNovoSala_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtSala.Text) || string.IsNullOrEmpty(txtNumColunas.Text) || string.IsNullOrEmpty(txtNumFilas.Text)) {
                MessageBox.Show("Por favor, preencha os campos!");

            } else {
                try {
                    int numColunas = Int32.Parse(txtNumColunas.Text);
                    int numFilas = Int32.Parse(txtNumFilas.Text);

                    SalaController.AdicionarSala(txtSala.Text, numColunas, numFilas);

                    refreshLS();
                    limparCampos();

                } catch (FormatException) {
                    MessageBox.Show("Campos no formato incorreto!\n" +
                        "\nCampo Sala: aceita tanto letras como números." +
                        "\nCampo Número de Colunas: só aceita números inteiros." +
                        "\nCampo Número de Filas: só aceita números inteiros.");

                    limparCampos();
                }
            }
        }

        private void btLimparCamposSala_Click(object sender, EventArgs e) {
            limparCampos();
            limparLS();
        }

        private void btAlterarSala_Click(object sender, EventArgs e) {
            if (listaSalas.SelectedRows == null || listaSalas.CurrentRow == null) {
                MessageBox.Show("Selecione uma sala da Tabela Salas, se quiser alterar os seus campos!");
                return;
            } else {
                try {
                    string id = listaSalas.CurrentRow.Cells[0].Value.ToString();

                    int selectedID = Int32.Parse(id);
                    int numColunas = Int32.Parse(txtNumColunas.Text);
                    int numFilas = Int32.Parse(txtNumFilas.Text);

                    SalaController.AlterarSala(selectedID, txtSala.Text, numColunas, numFilas);

                    refreshLS();
                    limparLS();
                    limparCampos();

                } catch (FormatException) {
                    MessageBox.Show("Campos no formato incorreto!\n" +
                        "\nCampo Sala: aceita tanto letras como números." +
                        "\nCampo Número de Colunas: só aceita números inteiros." +
                        "\nCampo Número de Filas: só aceita números inteiros.");

                    limparCampos();
                    limparLS();
                }
            }
        }


        private void listaSalas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            txtSala.Text = listaSalas.CurrentRow.Cells[1].Value.ToString();
            txtNumColunas.Text = listaSalas.CurrentRow.Cells[2].Value.ToString();
            txtNumFilas.Text = listaSalas.CurrentRow.Cells[3].Value.ToString();
        }

        private void btRemoverSala_Click(object sender, EventArgs e) {
            if (listaSalas.SelectedRows == null || listaSalas.CurrentRow == null) {
                MessageBox.Show("Selecione uma sala da Tabela Salas, se pretende eliminá-la!");
                return;
            }

            string id = listaSalas.CurrentRow.Cells[0].Value.ToString();

            int selectedID = Int32.Parse(id);

            DialogResult dr = MessageBox.Show("Pretende mesmo remover esta sala?", "Confirmação de eliminação de sala",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes) {
                SalaController.EliminarSala(selectedID);

                refreshLS();
                limparLS();
                limparCampos();
            }
        }



        public void CarregaDataGrid() {
            listaSalas.DataSource = SalaController.GetSalas();
            limparLS();
            carregaInfosCinema();
        }

        public void carregaInfosCinema() {
            txtNome.Text = CinemaController.GetNomeCinema();
            txtMorada.Text = CinemaController.GetMoradaCinema();
            txtEmail.Text = CinemaController.GetEmailCinema();
        }

        private void btAlterarCinema_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMorada.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEmail.Text)) {
                MessageBox.Show("Por favor, preencha o(s) campo(s)!");

            } else {
                try {

                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);

                    CinemaController.AlterarCinema(txtNome.Text, addr.Address, txtEmail.Text);



                } catch (FormatException) {
                    MessageBox.Show("Campos no formato incorreto!\n" +
                           "\nCampo Nome: aceita letras!" +
                           "\nCampo Morada: aceita letras e números!" +
                           "\nCampo Email: Só aceita email!");
                }

            }
        }
    }
}
