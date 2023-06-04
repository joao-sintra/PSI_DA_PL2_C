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
    public partial class Cinema : UserControl {
        public Cinema() {
            InitializeComponent();

            listaSalas.ReadOnly = true;
            listaSalas.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void limparLS() {
            listaSalas.ClearSelection();
        }

        private void listaSalas_DoubleClick(object sender, EventArgs e) {
            listaSalas.DataSource = SalaController.GetSalas();
            limparLS();
        }

        private void limparCampos() {
            txtSala.Text = "";
            txtNumColunas.Text = "";
            txtNumFilas.Text = "";
        }

        private void btNovoSala_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtSala.Text) || string.IsNullOrEmpty(txtNumColunas.Text) || string.IsNullOrEmpty(txtNumFilas.Text)) {
                MessageBox.Show("Por favor, preencha os campos!");

            } else {
                try {
                    int numColunas = Int32.Parse(txtNumColunas.Text);
                    int numFilas = Int32.Parse(txtNumFilas.Text);

                    SalaController.AdicionarSala(txtSala.Text, numColunas, numFilas);

                    listaSalas.DataSource = null;
                    listaSalas.DataSource = SalaController.GetSalas();
                    limparCampos();

                } catch (FormatException fe) {
                    MessageBox.Show("Campos no formato incorreto!\n\nCampo Sala: aceita tanto letras como números." +
                        "\nCampo Número de Colunas: só aceita números inteiros.\n" +
                        "Campo Número de Filas: só aceita números inteiros.");

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

                    listaSalas.DataSource = null;
                    listaSalas.DataSource = SalaController.GetSalas();
                    
                    limparLS();
                    limparCampos();

                } catch (FormatException ex) {
                    MessageBox.Show("Campos no formato incorreto!\n\nCampo Sala: aceita tanto letras como números." +
                        "\nCampo Número de Colunas: só aceita números inteiros.\n" +
                        "Campo Número de Filas: só aceita números inteiros.");

                    limparCampos();
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

                listaSalas.DataSource = null;
                listaSalas.DataSource = SalaController.GetSalas();
                
                limparLS();
                limparCampos();
            }
        }
    }
}
