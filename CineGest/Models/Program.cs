using System;
using System.Linq;
using System.Windows.Forms;

namespace CineGest {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            bool temCinema = false;
            using (var db = new CinegestContext()) {
                var cinema = db.Cinemas.FirstOrDefault();
                if (cinema == null) {
                    temCinema = false;
                } else {
                    temCinema = true;
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
