using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CineGest.Controllers {
    internal class FuncionarioController {


        public static List<Funcionario> GetFuncionarios() {

            using (var db = new CinegestContext()) {

                return db.Funcionarios.ToList();
            }
        }

        public static void AdicionarFuncionario(string nome, string morada, float salario, string funcao) {

            using (var db = new CinegestContext()) {

                var funcionarios = new Funcionario { Nome = nome, Morada = morada, Salario = salario, Funcao = funcao };

                List<Funcionario> list = db.Funcionarios.Where(x => x.Nome == nome).ToList();

                if (list.Count > 0) {
                    MessageBox.Show("Já existe um funcionário com este nome (" + nome + ")!");
                    return;
                }

                db.Funcionarios.Add(funcionarios);
                db.SaveChanges();
            }
        }



        public static void AlterarFuncionario(int selectedFuncionarioID, string nome, string morada, float salario, string funcao) {

            using (var db = new CinegestContext()) {

                Funcionario func = db.Funcionarios.Find(selectedFuncionarioID);

                Funcionario findFunc = db.Funcionarios
                    .Where(x => x.Nome == nome)
                    .FirstOrDefault();

                if (findFunc != null && findFunc.Id != func.Id) {
                    MessageBox.Show("Não podes alterar o nome deste funcionário para: (" + nome + "), porque já existe!");
                    return;
                }

                func.Nome = nome;
                func.Morada = morada;
                func.Salario = salario;
                func.Funcao = funcao;

                db.SaveChanges();
            }
        }

        public static void RemoverFuncionario(int selectedFuncionarioID) {
            using (var db = new CinegestContext()) {

                Funcionario func = db.Funcionarios.FirstOrDefault(f => f.Id == selectedFuncionarioID);

                db.Funcionarios.Remove(func);

                db.SaveChanges();
            }
        }
    }
}
