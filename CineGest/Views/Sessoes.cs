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
    public partial class Sessoes : UserControl
    {
        public Sessoes()
        {
            InitializeComponent();

            DataTable tableSessoes = new DataTable();
         


            tableSessoes.Columns.Add("Id", typeof(int));
            tableSessoes.Columns.Add("Salas", typeof(string));
            tableSessoes.Columns.Add("Filmes", typeof(string));
            tableSessoes.Columns.Add("Data", typeof(DateTime));
            tableSessoes.Columns.Add("Hora", typeof(DateTime));

            tableSessoes.Rows.Add(1, "Sala 1", "LOTR", "22/04", "15:15");
            ListaSessoes.DataSource = tableSessoes;
        }
    }
}
