using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CineGest.Controllers {
    internal class FilmeController {
        public static List<Filme> GetFilmes() {

            using (var db = new CinegestContext()) {
                return db.Filmes.ToList();
            }
        }

        public static void AdicionarFilme(string nome, int duracao, string categoria, bool activo) {

            using (var db = new CinegestContext()) {
                var cat = db.Categorias.FirstOrDefault(x => x.Nome == categoria);

                var filmes = new Filme { Nome = nome, Duracao = duracao, Activo = activo, CategoriaID = cat };

                List<Filme> list = db.Filmes.Where(x => x.Nome == nome).ToList();

                if (list.Count > 0) {
                    MessageBox.Show("Já existe um filme com este nome (" + nome + ")!");
                    return;
                }

                db.Filmes.Add(filmes);
                db.SaveChanges();
            }
        }

        public static void AlterarFilme(int ID, string nome, int duracao, string categoria, bool activo) {

            using (var db = new CinegestContext()) {
                var cat = db.Categorias.FirstOrDefault(x => x.Nome == categoria);

                Filme fil = db.Filmes.FirstOrDefault(filmes => filmes.Id == ID);

                fil.Nome = nome;
                fil.Duracao = duracao;
                fil.CategoriaID = cat;
                fil.Activo = activo;

                db.SaveChanges();
            }
        }

        public static void EliminarFilme(int ID) {
            using (var db = new CinegestContext()) {
                Filme fi = db.Filmes.FirstOrDefault(filmes => filmes.Id == ID);

                db.Filmes.Remove(fi);

                db.SaveChanges();
            }
        }

    }
}
