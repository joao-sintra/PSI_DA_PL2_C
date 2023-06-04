﻿using CineGest.Views;
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

                return db.Funcionarios.ToList();
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

        public static void AlterarPessoaFuncionario(int selectedPessoaID, int selectedFuncID, string nome, string morada, float salario, string funcao) {

            using (var db = new CinegestContext()) {

                Pessoa pess = db.Pessoas.FirstOrDefault(p => p.Id == selectedPessoaID);
                Funcionario func = db.Funcionarios.FirstOrDefault(f => f.Id == selectedFuncID);

                List<Pessoa> listPNM = db.Pessoas
                    .Where(x => x.Nome == nome)
                    .Where(x => x.Morada == morada)
                    .ToList();

                if (listPNM.Count > 0) {
                    MessageBox.Show("Não podes alterar o nome desta Pessoa para: (" + nome + "), porque já existe!");
                    return;
                } 

                pess.Nome = nome;
                pess.Morada = morada;
                func.Salario = salario;
                func.Funcao = funcao;

                db.SaveChanges();
            }
        }

        public static void RemoverPessoaFuncionario(int selectedPessoaID, int selectedFuncID) {
            using (var db = new CinegestContext()) {

                Pessoa pess = db.Pessoas.FirstOrDefault(p => p.Id == selectedPessoaID);
                Funcionario func = db.Funcionarios.FirstOrDefault(f => f.Id == selectedFuncID);

                db.Pessoas.Remove(pess);
                db.Funcionarios.Remove(func);

                db.SaveChanges();
            }
        }
    }
}
