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
    public partial class Atendimento : UserControl {
        private bool estado;
        public Atendimento() {
            InitializeComponent();
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
            if (listViewLugares.SelectedIndices.Count <= 0) {
                return;
            }
            int intSelectedIndex = listViewLugares.SelectedIndices[0];
            if (intSelectedIndex >= 0) {
                listaLugaresMarcados.Items.Add((string)listViewLugares.Items[intSelectedIndex].Text);
            }

        }
    }
}
