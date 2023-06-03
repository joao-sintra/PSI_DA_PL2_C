using CineGest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CineGest.Controllers {
    internal class SalaController {

        public static List<Sala> GetSalas() {

            using (var db = new CinegestContext()) {

                return db.Salas.ToList();
            }
        }

        public static void AdicionarSala(string nome, int colunas, int filas) {

            using (var db = new CinegestContext()) {
                var salas = new Sala { Nome = nome, Colunas = colunas, Filas = filas, Lugares = colunas*filas };
                db.Salas.Add(salas);
                db.SaveChanges();
            }
        }

        public static void AlterarSala(int ID, string txtSala, int txtNumColunas, int txtNumFilas) {

            using (var db = new CinegestContext()) {
                Sala sala = db.Salas.FirstOrDefault(salas => salas.Id == ID);

                sala.Nome = txtSala;
                sala.Colunas = txtNumColunas;
                sala.Filas = txtNumFilas;
                sala.Lugares = sala.Colunas * sala.Filas;

                db.SaveChanges();
            }
        }

        public static void EliminarSala(int ID) {
            using (var db = new CinegestContext()) {
                Sala sa = db.Salas.FirstOrDefault(salas => salas.Id == ID);

                db.Salas.Remove(sa);

                db.SaveChanges();
            }
        }

    }
}
