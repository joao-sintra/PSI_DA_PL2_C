using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineGest.Controllers {
    internal class CinemaController {


        public static bool ExisteCinema() {
            using (var db = new CinegestContext()) {
                var cinema = db.Cinemas.FirstOrDefault();
                if (cinema == null) {
                    return false;
                } else {
                    return true;
                }
            }
        }
        public static string GetNomeCinema() {
            using (var db = new CinegestContext()) {
                var cinema = db.Cinemas.FirstOrDefault();
                return cinema.Nome;
            }
        }
        public static string GetMoradaCinema() {
            using (var db = new CinegestContext()) {
                var cinema = db.Cinemas.FirstOrDefault();
                return cinema.Morada;
            }
        }
        public static string GetEmailCinema() {
            using (var db = new CinegestContext()) {
                var cinema = db.Cinemas.FirstOrDefault();
                return cinema.Email;
            }
        }
      
        public static void AdicionarCinema(string nome, string morada, string email) {

            using (var db = new CinegestContext()) {

                var cinema = new Cinema {Nome = nome, Morada = morada, Email=email };

               

                db.Cinemas.Add(cinema);
                db.SaveChanges();

            }
        }
        public static void AlterarCinema(string nome, string morada, string email) {

            using (var db = new CinegestContext()) {
                Cinema cinema = db.Cinemas.FirstOrDefault();

                cinema.Nome = nome;
                cinema.Morada = morada;
                cinema.Email = email;

                db.SaveChanges();

            }
        }
    }
}
