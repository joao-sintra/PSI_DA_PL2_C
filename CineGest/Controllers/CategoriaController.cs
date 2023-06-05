using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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

        public static void AlterarCategoria(int selectedCategoriaID, string nome, bool activa) {
            try {
                using (var db = new CinegestContext()) {

                    Categoria cat = db.Categorias.FirstOrDefault(categorias => categorias.Id == selectedCategoriaID);

                    Categoria categ = db.Categorias
                        .Where(x => x.Nome == nome)
                        .FirstOrDefault();

                    if (categ != null && categ.Id != cat.Id) {
                        MessageBox.Show("Não podes alterar o nome desta categoria para: (" + nome + "), porque já existe!");
                        return;
                    }

                    /*
                    Filme findCat = db.Filmes
                       .Where(x => x.CategoriaID == cat)
                       .FirstOrDefault();

                    if (findCat != null) {
                        MessageBox.Show("Não podes alterar o estado desta categoria, porque ela encontra-se relacionada com um filme!");
                        return;
                    }
                    */

                    cat.Nome = nome;
                    cat.Activa = activa;

                    db.SaveChanges();
                }
            } catch (System.NotSupportedException) {
                MessageBox.Show("Não pode alterar o estado desta categoria, enquanto ela estiver relacionada com um filme! ");
            }

        }

        public static void EliminarCategoria(int selectedCategoriaID) {
            try {
                using (var db = new CinegestContext()) {
                    Categoria ca = db.Categorias.FirstOrDefault(categorias => categorias.Id == selectedCategoriaID);

                    db.Categorias.Remove(ca);

                    db.SaveChanges();
                }

            } catch (System.Data.Entity.Infrastructure.DbUpdateException) {
                MessageBox.Show("Não pode eliminar esta categoria, porque ela encontra-se relacionada com um filme! ");
            }          
        }
    }
}
