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
    public partial class Sidebar : UserControl {
        public Sidebar() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void panelInicio_Click(object sender, EventArgs e) {
            Atendimento uc = new Atendimento();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

        }
    }
}
