using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineGest.Controllers {
    internal class FuncionarioController {

        public static List<Funcionario> GetFuncionarios() {

            using (var db = new CinegestContext()) {

                var listFuncionario = db.Funcionarios.ToList();               

                return listFuncionario;
            }
        }

        public static void AdicionarFuncionario(string nome, string morada, float salario, string funcao) {

            using (var db = new CinegestContext()) {
                var funcionarios = new Funcionario { Nome = nome, Morada = morada, Salario = salario, Funcao = funcao };

                List<Pessoa> list = db.Pessoas.Where(x => x.Nome == nome).ToList();

                if (list.Count > 0) {
                    MessageBox.Show("Já existe uma pessoa com este nome (" + nome + ")!");
                    return;
                }

                db.Funcionarios.Add(funcionarios);
                db.SaveChanges();

            }
        }
    }
}
