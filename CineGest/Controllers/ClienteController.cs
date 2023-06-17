using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CineGest.Controllers {
    internal class ClienteController {
        public static List<Cliente> GetClientes() {

            using (var db = new CinegestContext()) {
                return db.Clientes.ToList();
            }
        }
        public static void AdicionarCliente(int nif, string nome, string morada) {

            using (var db = new CinegestContext()) {

                var clientes = new Cliente { NIF = nif, Nome = nome, Morada = morada };

                List<Cliente> list = db.Clientes
                   .Where(s => s.Nome == nome)
                   .Where(s => s.NIF == nif)
                   .ToList();

                if (list.Count > 0) {
                    MessageBox.Show("Já existe um cliente com este nome (" + nome + ")!");
                    return;
                }

                db.Clientes.Add(clientes);
                db.SaveChanges();

            }
        }
        public static void AlterarCliente(int selectedClienteID, int nif, string nome, string morada) {

            using (var db = new CinegestContext()) {
                //Procura o ID introduzido pelo utilizador (Input), e verifica se existe na Database
                Cliente func = db.Clientes.Find(selectedClienteID);

                //Procura se o nome adicionado pelo utilizador (Input) for igual ao nome da (DataBase)
                Cliente findFunc = db.Clientes
                    .Where(x => x.Nome == nome)
                    .FirstOrDefault();

                //Se existir um nome do cliente na DataBase
                //Se o id que o utilizador selecionar for diferente do id na DataBase, 
                if (findFunc != null && findFunc.Id != func.Id) {
                    MessageBox.Show("Não podes alterar o nome deste Cliente para: (" + nome + "), porque já existe!");
                    return;
                }

                //Alterar os Campos conforme o Input do Utilizador
                func.Nome = nome;
                func.Morada = morada;
                func.NIF = nif;

                db.SaveChanges();
            }
        }
        public static void RemoverCliente(int selectedClienteID) {
            using (var db = new CinegestContext()) {

                Cliente cliente = db.Clientes.FirstOrDefault(f => f.Id == selectedClienteID);

                db.Clientes.Remove(cliente);

                db.SaveChanges();
            }
        }
    }

}
