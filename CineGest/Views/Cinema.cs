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
    public partial class Cinema : UserControl {
        public Cinema() {
            InitializeComponent();
            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Salas", typeof(string));
            table.Columns.Add("Colunas", typeof(int));
            table.Columns.Add("Filas", typeof(int));
            table.Columns.Add("Lugares", typeof(int));

            table.Rows.Add(1, "Sala 1", 10, 10, 100);
            ListaSalas.DataSource = table;
        }

    }
}
