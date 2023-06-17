using System;
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
