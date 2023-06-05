using CineGest.Views;
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

        public static List<Pessoa> GetPessoas() {

            using (var db = new CinegestContext()) {

                return db.Pessoas.ToList();               
            }
        }
        

        public static List<Funcionario> GetFuncionarios() {

            using (var db = new CinegestContext()) {

                return db.Funcionarios.Include("PessoaId").ToList();
            }
        }

        public float GetSalarioFuncionario(int selectedPessoaID) {
            using (var db = new CinegestContext()) {
                Funcionario fun = db.Funcionarios.Where(x => x.Id == selectedPessoaID).FirstOrDefault();

                return fun.Salario;
            }
        }

        public string GetFuncaoFuncionario(int selectedPessoaID) {
            using (var db = new CinegestContext()) {
                Funcionario fun = db.Funcionarios.Where(x => x.Id == selectedPessoaID).FirstOrDefault();

                return fun.Funcao;
            }
        }

        public static void AdicionarPessoaFuncionario(string nome, string morada, float salario, string funcao) {

            using (var db = new CinegestContext()) {
                var pessoas = new Pessoa { Nome = nome, Morada = morada };
                
                var funcionarios = new Funcionario { Salario = salario, Funcao = funcao, PessoaId = pessoas };

                List<Pessoa> list = db.Pessoas.Where(x => x.Nome == nome).ToList();

                if (list.Count > 0) {
                    MessageBox.Show("Já existe uma pessoa com este nome (" + nome + ")!");
                    return;
                }

                db.Pessoas.Add(pessoas);
                db.Funcionarios.Add(funcionarios);
                db.SaveChanges();
            }
        }

        public static void AlterarPessoaFuncionario(int selectedPessoaID, string nome, string morada, float salario, string funcao) {

            using (var db = new CinegestContext()) {

                Pessoa pess = db.Pessoas.FirstOrDefault(p => p.Id == selectedPessoaID);

                Funcionario func = db.Funcionarios.FirstOrDefault(f => f.Id == selectedPessoaID);

                Pessoa findPess = db.Pessoas
                    .Where(x => x.Nome == nome)
                    .FirstOrDefault();

                if (findPess != null && findPess.Id != pess.Id) {
                    MessageBox.Show("Não podes alterar o nome desta pessoa para: (" + nome + "), porque já existe!");
                    return;
                }

                pess.Nome = nome;
                pess.Morada = morada;
                func.Salario = salario;
                func.Funcao = funcao;

                db.SaveChanges();
            }
        }

        public static void RemoverPessoaFuncionario(int selectedPessoaID) {
            using (var db = new CinegestContext()) {

                Pessoa pess = db.Pessoas.FirstOrDefault(p => p.Id == selectedPessoaID);
                Funcionario func = db.Funcionarios.FirstOrDefault(f => f.Id == selectedPessoaID);

                if (pess.Id == func.Id) {
                    db.Pessoas.Remove(pess);
                    db.Funcionarios.Remove(func);

                    db.SaveChanges();
                } else {
                    MessageBox.Show("Não foi possível efetuar a ação!");
                    return;
                }

                
            }
        }
    }
}
