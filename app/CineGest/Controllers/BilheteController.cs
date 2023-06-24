using CineGest.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineGest.Controllers {
    internal class BilheteController {


        public static List<Bilhete> GetBilhetes() {

            using (var db = new CinegestContext()) {

                return db.Bilhetes.Include("ClienteID").Include("FuncionarioID").Include("SessaoID").ToList();
            }
        }
        public static List<Bilhete> GetBilhetes(int NrSessao) {

            using (var db = new CinegestContext()) {

                return db.Bilhetes.Include("ClienteID").Include("FuncionarioID").Include("SessaoID").Where(bilhete => bilhete.SessaoID.Id == NrSessao).ToList();
            }
        }


        public static List<int> GetLugaresOcupados(int NrSessao) {
            using (var db = new CinegestContext()) {

                List<int> lugares = db.Bilhetes
                    .Where(bilhete => bilhete.SessaoID.Id == NrSessao)
                    .Select(bilhete => bilhete.Lugar).ToList();

                return lugares;
            }

        }

        public static void AdicionarBilhete(int lugar, bool estado, string Cliente, string Funcionario, int Sessao) {

            using (var db = new CinegestContext()) {

                var cliente = db.Clientes.FirstOrDefault(x => x.Nome == Cliente);
                var funcionario = db.Funcionarios.FirstOrDefault(x => x.Nome == Funcionario);
                var sessao = db.Sessoes.FirstOrDefault(x => x.Id == Sessao);

                var bilhete = new Bilhete { Lugar = lugar, Estado = estado, ClienteID = cliente, FuncionarioID = funcionario, SessaoID = sessao };



                db.Bilhetes.Add(bilhete);
                db.SaveChanges();
            }
        }
        //função para anula um bilhetes de uma sessão pelo id
        public static void AnulaBilhete(int id) {
            using (var db = new CinegestContext()) {
                Bilhete bilhete = db.Bilhetes.Find(id);
                bilhete.Estado = false;
                db.SaveChanges();
            }
        }
        //função para exportar todas as informações para um ficheiro txt
        public static void ExportarBilheteTxt(List<string> listaLugares, int nrSessao, string nomeFuncionario, string nomeCliente, string filePath) {
            using (var db = new CinegestContext()) {
                
                var bilhetes = db.Bilhetes.Include("ClienteID").Include("FuncionarioID").Include("SessaoID").ToList();
              
                var cliente = db.Clientes.FirstOrDefault(x => x.Nome == nomeCliente);
                var funcionario = db.Funcionarios.FirstOrDefault(x => x.Nome == nomeFuncionario);
                var sessao = db.Sessoes.Include("FilmeID").Include("SalaID").FirstOrDefault(x => x.Id == nrSessao);
               
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath)) {
                    foreach (string lugar in listaLugares) {
                        file.WriteLine("Hora de compra: " + DateTime.Now.ToString());
                        file.WriteLine("Lugar: " + lugar);
                        file.WriteLine("Sessão: " + sessao.Id);
                        file.WriteLine("Data e Hora da sessão: " + sessao.DataHora);
                        file.WriteLine("Sala: " + sessao.SalaID.Nome);
                        file.WriteLine("Filme: " + sessao.FilmeID.Nome);
                        file.WriteLine("Duração: " + sessao.FilmeID.Duracao+ " Minutos");
                        file.WriteLine("Cliente: " + cliente.Nome);
                        file.WriteLine("NIF: " + cliente.NIF);
                        file.WriteLine("Funcionario: " + funcionario.Nome);

                        file.WriteLine(" ");
                    }
                }
            }
        }

      //cria uma lista com a quantidade de lugares ocupados por sessão
      public static List<int> GetLugaresOcupadosPorSessao() {
            using (var db = new CinegestContext()) {
                List<int> lugares = new List<int>();
                var sessoes = db.Sessoes.ToList();
                foreach (var sessao in sessoes) {
                    lugares.Add(db.Bilhetes.Where(bilhete => bilhete.SessaoID.Id == sessao.Id).Count());
                }
                return lugares;
            }
        }
        //cria uma lista com a quantidade de lugares ocupados por sessão
        public static List<int> GetLugaresOcupadosPorSessao(int id) {
            using (var db = new CinegestContext()) {
                List<int> lugares = new List<int>();
                var sessoes = db.Sessoes.Where(sessao => sessao.Id == id).ToList();
                foreach (var sessao in sessoes) {
                    lugares.Add(db.Bilhetes.Where(bilhete => bilhete.SessaoID.Id == sessao.Id).Count());
                }
                return lugares;
            }
        }

        
       

      

        //cria uma função que retorna a quantidade de bilhetes por mês
        public static List<int> GetBilhetesPorMes() {
            using (var db = new CinegestContext()) {
                List<int> bilhetes = new List<int>();
                var sessoes = db.Sessoes.ToList();
                foreach (var sessao in sessoes) {
                    if (sessao.DataHora > DateTime.Now.AddMonths(-1)) {
                        bilhetes.Add(db.Bilhetes.Where(bilhete => bilhete.SessaoID.Id == sessao.Id).Count());
                    }
                }
                return bilhetes;
            }
        }
        //cria uma função para retornar o valor dos bilhetes de um cliente
        public static double GetValorBilhetesCliente(string nomeCliente) {
            using (var db = new CinegestContext()) {
                double valor = 0;
                var cliente = db.Clientes.FirstOrDefault(x => x.Nome == nomeCliente);
                var bilhetes = db.Bilhetes.Include("ClienteID").Include("FuncionarioID").Include("SessaoID").Where(bilhete => bilhete.ClienteID.Id == cliente.Id).ToList();
                foreach (var bilhete in bilhetes) {
                    valor += bilhete.SessaoID.Preco;
                }
                return valor;
            }
        }
        //cria uma função para retornar a quantidade dos bilhetes de um cliente
        public static int GetQuantidadeBilhetesCliente(string nomeCliente) {
            using (var db = new CinegestContext()) {
                int quantidade = 0;
                var cliente = db.Clientes.FirstOrDefault(x => x.Nome == nomeCliente);
                var bilhetes = db.Bilhetes.Where(bilhete => bilhete.ClienteID.Id == cliente.Id).ToList();
                foreach (var bilhete in bilhetes) {
                    quantidade++;
                }
                return quantidade;
            }
        }

    }
}
