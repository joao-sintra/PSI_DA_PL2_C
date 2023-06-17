using CineGest.Controllers;
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

        }

        private void limparCamposCliente()
        {

            txtNif.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtMorada.Text = string.Empty;
        }

        private void limparListaClientes()
        {
            ListaClientes.ClearSelection();
        }
        private void btLimparCamposCliente_Click(object sender, EventArgs e)
        {
            limparCamposCliente();
            limparListaClientes();
        }

        public void ordenarCamposClientes()
        {
           
            ListaClientes.Columns["Id"].DisplayIndex = 0;
            ListaClientes.Columns["NIF"].DisplayIndex = 1;
            ListaClientes.Columns["Nome"].DisplayIndex = 2;
            ListaClientes.Columns["Morada"].DisplayIndex = 3;
        }

        private void refreshListaClientes()
        {
            ListaClientes.DataSource = null;
            ListaClientes.DataSource = ClienteController.GetClientes();
        }

        private void btNovoCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMorada.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtNif.Text))
            {
                MessageBox.Show("Por favor, preencha o(s) campo(s)!");

            }
            else
            {
                try
                {
                    int nif = Int32.Parse(txtNif.Text);

                    ClienteController.AdicionarCliente(nif, txtNome.Text, txtMorada.Text);
                    refreshListaClientes();
                    limparListaClientes();
                    ordenarCamposClientes();
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Campos no formato incorreto!\n" +
                           "\nCampo Nome: aceita letras!" +
                           "\nCampo Morada: aceita letras e números!" +
                           "\nCampo NIF: Só aceita números!");

                    limparCamposCliente();
                    ordenarCamposClientes();

                }
            }
        }

       

        private void btAlterarCliente_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMorada.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtNif.Text))
            {
                MessageBox.Show("Só pode alterar o(s) campo(s), se o Cliente estiver adicionado e selecionado na Tabela Clientes!");
                return;


            }
            else
            {
                if (ListaClientes.SelectedRows.Count == 0 || ListaClientes.CurrentRow == null)
                {
                    MessageBox.Show("Tem de selecionar em linha numa ( setinha no lado esquerdo ) da tabela Clientes, se quiser alterar os campos!");
                    return;
                }

                try
                {
                    string id = ListaClientes.CurrentRow.Cells[1].Value.ToString();

                    int selectedID = Int32.Parse(id);
                    int nif = Int32.Parse(txtNif.Text);


                    ClienteController.AlterarCliente(selectedID, nif, txtNome.Text, txtMorada.Text);

                    refreshListaClientes();
                    limparListaClientes();
                    ordenarCamposClientes();


                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Campos no formato incorreto!\n" +
                          "\nCampo Nome: aceita letras!" +
                          "\nCampo Morada: aceita letras e números!" +
                          "\nCampo NIF: Só aceita números!");

                    limparListaClientes();
                    limparCamposCliente();
                    ordenarCamposClientes();
                }

            }
        }

        private void btRemoverCliente_Click(object sender, EventArgs e)
        {
            if (ListaClientes.SelectedRows.Count == 0 || ListaClientes.CurrentRow == null)
            {
                MessageBox.Show("Tem de selecionar em linha numa ( setinha no lado esquerdo ) da tabela Clientes, se pretende remover o Cliente!");
                return;
            }

            string id = ListaClientes.CurrentRow.Cells[1].Value.ToString();

            int selectedID = Int32.Parse(id);

            DialogResult dr = MessageBox.Show("Pretende mesmo remover este Cliente?", "Confirmação de eliminação do Cliente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                ClienteController.RemoverCliente(selectedID);

                refreshListaClientes();
                limparListaClientes();
                limparCamposCliente();
                ordenarCamposClientes();
            }
            else
            {
                limparListaClientes();
                limparCamposCliente();
                ordenarCamposClientes();
            }
        }


     

        private void ListaClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            txtNome.Text = ListaClientes.CurrentRow.Cells[2].Value.ToString();
            txtMorada.Text = ListaClientes.CurrentRow.Cells[3].Value.ToString();
            txtNif.Text = ListaClientes.CurrentRow.Cells[0].Value.ToString();

           
        }

        private void Clientes_Load(object sender, EventArgs e) {
            ListaClientes.ReadOnly = true;
            ListaClientes.EditMode = DataGridViewEditMode.EditProgrammatically;

           // ListaClientes.DataSource = ClienteController.GetClientes();
            ListaClientes.Columns["Id"].HeaderText = "Nº Cliente";
            limparCamposCliente();
            limparListaClientes();
            ordenarCamposClientes();
        }
    }
}
