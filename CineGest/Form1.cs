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
    public partial class Atendimento : Form {
        public Atendimento() {
            InitializeComponent();
            ListViewItem item1 = new ListViewItem();
            int colunas = 12;
            int linhas = 12;
            
            for (int i = 0; i <= linhas; i++) {
                listViewLugares.Columns.Add(i.ToString(),40, HorizontalAlignment.Center);
                for (int j = 1; j <= colunas; j++) {
                item1 = new ListViewItem(" " + i.ToString() + " ");
                listViewLugares.Items.AddRange(new ListViewItem[] { item1 });
                    listViewLugares.Items[i].SubItems.Add("99");

            }

            item1.SubItems[0].BackColor = Color.Green;

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listViewLugares.SelectedIndices.Count <= 0) {
                return;
            }
            int intSelectedIndex = listViewLugares.SelectedIndices[0];
            if (intSelectedIndex >= 0) {
                listaLugaresMarcados.Items.Add((string)listViewLugares.Items[intSelectedIndex].Text);
            }

        }

        private void buttonRemoverLugar_Click(object sender, EventArgs e) {
            
            if(listaLugaresMarcados.SelectedIndex < 0) {
                MessageBox.Show("Erro tem que selecionar um lugar");
                return;
            } else {
                listaLugaresMarcados.Items.RemoveAt(listaLugaresMarcados.SelectedIndex);
            }

           
        }

        private void btEmitirBilhete_Click(object sender, EventArgs e) {

        }
    }
}
