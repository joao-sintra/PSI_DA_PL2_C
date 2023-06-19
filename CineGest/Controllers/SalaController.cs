using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CineGest.Controllers {
    internal class SalaController {

        public static List<Sala> GetSalas() {

            using (var db = new CinegestContext()) {


                return db.Salas.ToList();
            }
        }
        public static List<string> GetOnlyNomesSalas() {

            using (var db = new CinegestContext()) {

                List<string> salas = db.Salas

                    .Select(sala => sala.Nome).ToList();

                return salas;
            }
        }

        public static int GetColunas(string nome) {

            using (var db = new CinegestContext()) {

                int colunas = db.Salas
                    .Where(sala => sala.Nome == nome)
                    .Select(sala => sala.Colunas).FirstOrDefault();

                return colunas;
            }
        }
        public static int GetLinhas(string nome) { 
          using (var db = new CinegestContext()) {

                int linhas = db.Salas
                    .Where(sala => sala.Nome == nome)
                    .Select(sala => sala.Filas).FirstOrDefault();

                return linhas;
            }
        }

        public static void AdicionarSala(string nome, int colunas, int filas) {

            using (var db = new CinegestContext()) {
                var salas = new Sala { Nome = nome, Colunas = colunas, Filas = filas, Lugares = colunas * filas };

                List<Sala> list = db.Salas.Where(sala => sala.Nome == nome).ToList();

                if (list.Count > 0) {
                    MessageBox.Show("Esta sala (" + nome + ") já existe!");
                    return;
                }

                db.Salas.Add(salas);
                db.SaveChanges();
            }
        }

        public static void AlterarSala(int ID, string txtSala, int txtNumColunas, int txtNumFilas) {

            using (var db = new CinegestContext()) {
                Sala sala = db.Salas.FirstOrDefault(salas => salas.Id == ID);

                List<Sala> list = db.Salas
                    .Where(x => x.Nome == txtSala)
                    .Where(x => x.Colunas == txtNumColunas)
                    .Where(x => x.Filas == txtNumFilas)
                    .ToList();

                if (list.Count > 0) {
                    MessageBox.Show("Não podes alterar o nome desta sala para: (" + txtSala + "), porque já existe!");
                    return;
                }

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
