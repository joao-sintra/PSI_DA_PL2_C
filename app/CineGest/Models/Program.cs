using CineGest.Controllers;
using CineGest.Views;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
           bool cinema = CinemaController.ExisteCinema();
               
                if (!cinema) {
                    Application.Run(new CriacaoCinema());
                } else {
                    Application.Run(new MainForm());
                }
            }
           
            
        }
    }

