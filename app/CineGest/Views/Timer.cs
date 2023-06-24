using System;
using System.Windows.Forms;

namespace CineGest.Views {
    public partial class Timer : UserControl {
        public Timer() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            labelHoraDia.Text = DateTime.Now.ToString();
        }
    }
}
