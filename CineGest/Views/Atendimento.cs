using System;
using System.Drawing;
using System.Windows.Forms;

namespace CineGest.Views {
    public partial class Atendimento : UserControl {
        private bool estado;
        public Atendimento() {
            InitializeComponent();


        }
        private void Atendimento_Load(object sender, EventArgs e) {
            const int colunas = 10;
            const int linhas = 10;

            lugares.RowCount = linhas;

            lugares.ColumnCount = colunas;

            for (int j = 0; j < linhas; j++) {

                lugares.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / linhas));
            }

            for (int i = 0; i < colunas; i++) {

                lugares.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / colunas));

            }


            DrawLugares();



        }
        private void DrawLugares() {
            int cadeira = 1;
            for (int i = 0; i < lugares.RowCount; i++) {
                for (int j = 0; j < lugares.ColumnCount; j++) {

                    Label labelLugar = new Label();
                    labelLugar.Text = cadeira.ToString();
                    labelLugar.AutoSize = false;
                    labelLugar.TextAlign = ContentAlignment.MiddleCenter;
                    labelLugar.Dock = DockStyle.Fill;
                    labelLugar.BackColor = Color.LightGreen;

                    lugares.Controls.Add(labelLugar, j, i);
                    cadeira++;

                    labelLugar.Click += labelLugar_Click;
                }
            }
        }
        private void labelLugar_Click(object sender, EventArgs e) {

            Label labelLugar = (Label)sender;
            if (labelLugar.BackColor == Color.LightGreen) {
                labelLugar.BackColor = Color.Red;
                listaLugaresMarcados.Items.Add(labelLugar.Text);
            } else if (labelLugar.BackColor == Color.Red) {
                listaLugaresMarcados.Items.Remove(labelLugar.Text);
                labelLugar.BackColor = Color.LightGreen;
            } else if (labelLugar.BackColor == Color.Gray) {
                MessageBox.Show("Lugar indisponivel!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }


        private void btEmitirBilhete_Click(object sender, EventArgs e) {

        }

        private void btRemoverLugar_Click(object sender, EventArgs e) {
            if (listaLugaresMarcados.SelectedIndex < 0) {
                MessageBox.Show("Erro tem que selecionar um lugar");
                return;
            } else {
                listaLugaresMarcados.Items.RemoveAt(listaLugaresMarcados.SelectedIndex);
            }
        }

        private void listViewLugares_SelectedIndexChanged(object sender, EventArgs e) {
            /* if (listViewLugares.SelectedIndices.Count <= 0) {
                 return;
             }
             int intSelectedIndex = listViewLugares.SelectedIndices[0];
             if (intSelectedIndex >= 0) {
                 listaLugaresMarcados.Items.Add((string)listViewLugares.Items[intSelectedIndex].Text);
             }*/

        }


    }
}
