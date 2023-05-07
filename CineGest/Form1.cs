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
            for (int i = 1; i < 50; i++) {
                item1 = new ListViewItem(i.ToString());
                listViewLugares.Items.AddRange(new ListViewItem[] { item1 });
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

        }
    }
}
