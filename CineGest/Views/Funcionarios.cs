using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineGest.Views {
    public partial class Funcionarios : UserControl {
        public Funcionarios() {
            InitializeComponent();

            DataTable tableFun = new DataTable();

            tableFun.Columns.Add("Id", typeof(int));
            tableFun.Columns.Add("Nome", typeof(string));
            tableFun.Columns.Add("Morada", typeof(string));
            tableFun.Columns.Add("Salário", typeof(int));
            tableFun.Columns.Add("Função", typeof(string));

            tableFun.Rows.Add(1, "António Costa", "Leiria - blablabla", "1500", "Balcão");
            ListaFuncionarios.DataSource = tableFun;
        }
    }
}
