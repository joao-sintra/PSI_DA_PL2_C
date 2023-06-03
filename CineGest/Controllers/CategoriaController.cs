using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CineGest.Controllers {
    internal class CategoriaController {

        public static List<string> GetOnlyNomesCategorias() {

            using (var db = new CinegestContext()) {
                
                List<string> categorias = db.Categorias
                    .Where(categoria => categoria.Activa.Equals(true))
                    .Select(categoria => categoria.Nome).ToList();

                return categorias;
            }
        }

        public static List<Categoria> GetCategorias() {

            using (var db = new CinegestContext()) {

                return db.Categorias.ToList();
            }
        }

        public static void AdicionarCategoria(string nome, bool activa) {

            using (var db = new CinegestContext()) {
                var categorias = new Categoria { Nome = nome, Activa = activa };

                List<Categoria> list = db.Categorias.Where(x => x.Nome == nome).ToList();

                if (list.Count > 0) {
                    MessageBox.Show("Já existe uma categoria com este nome ("+nome+")!");
                    return;
                }

                db.Categorias.Add(categorias);
                db.SaveChanges();
            }
        }

        public static void AlterarCategoria(int ID, string nome, bool activa) {

            using (var db = new CinegestContext()) {
                Categoria cat = db.Categorias.FirstOrDefault(categorias => categorias.Id == ID);

                cat.Nome = nome;
                cat.Activa = activa;

                db.SaveChanges();
            }
        }

        public static void EliminarCategoria(int ID) {
            using (var db = new CinegestContext()) {
                Categoria ca = db.Categorias.FirstOrDefault(categorias => categorias.Id == ID);

                db.Categorias.Remove(ca);

                db.SaveChanges();
            }
        }
    }
}
