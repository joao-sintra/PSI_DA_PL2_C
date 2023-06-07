using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineGest.Controllers
{
    internal class SessaoController
    {
        public static List<Sessao> GetSessoes()
        {

            using (var db = new CinegestContext())
            {
                return db.Sessoes.Include("FilmeID").Include("SalaID").ToList();

            }
        }
        public static void AdicionarSessao(string Filme, string Sala, DateTime DataHora, float Preco)
        {

            using (var db = new CinegestContext())
            {
                var filme = db.Filmes.FirstOrDefault(x => x.Nome == Filme);
                var sala = db.Salas.FirstOrDefault(x => x.Nome == Sala);

                var sessao = new Sessao { DataHora = DataHora, Preco = Preco, FilmeID = filme, SalaID = sala };

                List<Sessao> list = db.Sessoes
                    .Where(s => s.DataHora == DataHora)
                    .Where(s => s.SalaID.Id == sala.Id)
                    .ToList();

                if (list.Count > 0)
                {
                    MessageBox.Show("Já existe uma sessão nesta sala e com esta data e hora. \n(" + "Sala: " + sala + " | " + "DataHora: " + DataHora + ") já existe!");
                    return;
                }

                db.Sessoes.Add(sessao);
                db.SaveChanges();


            }
        }
        public static void AlterarSessao(int ID, string Filme, string Sala, DateTime DataHora, float Preco)
        {

            using (var db = new CinegestContext())
            {

                Sessao sessao = db.Sessoes.FirstOrDefault(Sessao => Sessao.Id == ID);

                DateTime currentDateTime = DateTime.Now;

                var filme = db.Filmes.FirstOrDefault(x => x.Nome == Filme);
                var sala = db.Salas.FirstOrDefault(x => x.Nome == Sala);


                if (DataHora < currentDateTime)
                {
                    MessageBox.Show("Não podes alterar os campos desta sessão porque esta sessão já foi iniciada!\n" + DataHora);
                    return;
                }

                sessao.FilmeID = filme;
                sessao.SalaID = sala;
                sessao.DataHora = DataHora;
                sessao.Preco = Preco;

                db.SaveChanges();
            }
        }
        public static void EliminarSessao(int ID)
        {
            using (var db = new CinegestContext())
            {
                Sessao ses = db.Sessoes.FirstOrDefault(s => s.Id == ID);

                db.Sessoes.Remove(ses);

                db.SaveChanges();
            }
        }
        //public static void AlterarSala(int ID, string txtSala, int txtNumColunas, int txtNumFilas)
        //{

        //    using (var db = new CinegestContext())
        //    {
        //        Sala sala = db.Salas.FirstOrDefault(salas => salas.Id == ID);

        //        List<Sala> list = db.Salas
        //            .Where(x => x.Nome == txtSala)
        //            .Where(x => x.Colunas == txtNumColunas)
        //            .Where(x => x.Filas == txtNumFilas)
        //            .ToList();

        //        if (list.Count > 0)
        //        {
        //            MessageBox.Show("Não podes alterar o nome desta sala para: (" + txtSala + "), porque já existe!");
        //            return;
        //        }

        //        sala.Nome = txtSala;
        //        sala.Colunas = txtNumColunas;
        //        sala.Filas = txtNumFilas;
        //        sala.Lugares = sala.Colunas * sala.Filas;

        //        db.SaveChanges();
        //    }
        //}

        //public static void EliminarSala(int ID)
        //{
        //    using (var db = new CinegestContext())
        //    {
        //        Sala sa = db.Salas.FirstOrDefault(salas => salas.Id == ID);

        //        db.Salas.Remove(sa);

        //        db.SaveChanges();
        //    }
        //}
    }

}
