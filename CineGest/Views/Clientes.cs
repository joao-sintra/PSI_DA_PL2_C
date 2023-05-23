using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineGest.Views
{
    public partial class Clientes : UserControl
    {
        public Clientes()
        {
            InitializeComponent();

            DataTable tableClien = new DataTable();


            tableClien.Columns.Add("Id", typeof(int));
            tableClien.Columns.Add("Nome", typeof(string));
            tableClien.Columns.Add("Morada", typeof(string));
            tableClien.Columns.Add("NIF", typeof(int));
            tableClien.Columns.Add("Valor Total (€)", typeof(float));

            tableClien.Rows.Add(1, "Diogo das Silvas", "Leiria - blablabla", "928743256", 10.5);
            ListaClientes.DataSource = tableClien;
        }
    }
}
