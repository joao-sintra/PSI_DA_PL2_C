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
    public partial class Filmes : UserControl {
        public Filmes() {
            InitializeComponent();

            DataTable tableF = new DataTable();

            tableF.Columns.Add("Id", typeof(int));
            tableF.Columns.Add("Filmes", typeof(string));
            tableF.Columns.Add("Duração", typeof(string));
            tableF.Columns.Add("Categoria", typeof(string));
            tableF.Columns.Add("Exibição", typeof(string));

            tableF.Rows.Add(1, "Guardiões", "1h30m", "Ação", "Desativado");
            ListaFilmes.DataSource = tableF;

            DataTable tableC = new DataTable();

            tableC.Columns.Add("Id", typeof(int));
            tableC.Columns.Add("Categorias", typeof(string));
            tableC.Columns.Add("Ativo", typeof(bool));


            tableC.Rows.Add(1, "Ação", true);
            ListaCategorias.DataSource = tableC;
        }

    }
}
