using CineGest.Controllers;
using System;
using System.Windows.Forms;

namespace CineGest.Views {
    public partial class Clientes : UserControl {
        public Clientes() {
            InitializeComponent();
            ListaClientes.ReadOnly = true;
            ListaClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
         
            DataGridViewTextBoxColumn coluna = new DataGridViewTextBoxColumn();
            coluna.HeaderText = "Total de bilhetes";
            coluna.Name = "TotalBilhetes";
            ListaClientes.Columns.Add(coluna);
            DataGridViewTextBoxColumn coluna2 = new DataGridViewTextBoxColumn();
            coluna2.HeaderText = "Total de dinheiro gasto";
            coluna2.Name = "TotalDinheiro";
            ListaClientes.Columns.Add(coluna2);
        }

        private void limpaCamposCliente() {

            txtNif.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtMorada.Text = string.Empty;
        }

        private void limpaListaClientes() {
            ListaClientes.ClearSelection();
        }
        private void btLimparCamposCliente_Click(object sender, EventArgs e) {
            limpaCamposCliente();
            limpaListaClientes();
        }

        public void ordenaCamposClientes() {

            ListaClientes.Columns["Id"].DisplayIndex = 0;
            ListaClientes.Columns["NIF"].DisplayIndex = 1;
            ListaClientes.Columns["Nome"].DisplayIndex = 2;
            ListaClientes.Columns["Morada"].DisplayIndex = 3;
        }

        private void refreshListaClientes() {
            ListaClientes.DataSource = null;
            ListaClientes.DataSource = ClienteController.GetClientes();
            InsereValoresLC();
        }

        private void btNovoCliente_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMorada.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtNif.Text)) {
                MessageBox.Show("Por favor, preencha o(s) campo(s)!");

            } else {
                try {

                   //valida se o nif é digitos
                   if (!int.TryParse(txtNif.Text, out int nif)) {
                        MessageBox.Show("O NIF só aceita números!");
                        return;
                    }
                    
                    if (txtNif.Text.Length != 9) {
                        MessageBox.Show("O NIF tem de ter 9 digitos!");
                        return;
                    }




                   // int nif = Int32.Parse(txtNif.Text);

                    ClienteController.AdicionarCliente(nif, txtNome.Text, txtMorada.Text);
                    refreshListaClientes();
                    limpaListaClientes();
                    ordenaCamposClientes();
                } catch (FormatException) {
                    MessageBox.Show("Campos no formato incorreto!\n" +
                           "\nCampo Nome: aceita letras!" +
                           "\nCampo Morada: aceita letras e números!" +
                           "\nCampo NIF: Só aceita números!");

                    limpaCamposCliente();
                    ordenaCamposClientes();

                }
            }
        }



        private void btAlterarCliente_Click(object sender, EventArgs e) {

            if (string.IsNullOrEmpty(txtMorada.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtNif.Text)) {
                MessageBox.Show("Só pode alterar o(s) campo(s), se o Cliente estiver adicionado e selecionado na Tabela Clientes!");
                return;


            } else {
                if (ListaClientes.SelectedRows.Count == 0 || ListaClientes.CurrentRow == null) {
                    MessageBox.Show("Tem de selecionar em linha numa ( setinha no lado esquerdo ) da tabela Clientes, se quiser alterar os campos!");
                    return;
                }

                try {
                    string id = ListaClientes.CurrentRow.Cells[3].Value.ToString();

                    int selectedID = Int32.Parse(id);
                    int nif = Int32.Parse(txtNif.Text);


                    ClienteController.AlterarCliente(selectedID, nif, txtNome.Text, txtMorada.Text);

                    refreshListaClientes();
                    limpaListaClientes();
                    ordenaCamposClientes();


                } catch (FormatException) {
                    MessageBox.Show("Campos no formato incorreto!\n" +
                          "\nCampo Nome: aceita letras!" +
                          "\nCampo Morada: aceita letras e números!" +
                          "\nCampo NIF: Só aceita números!");

                    limpaListaClientes();
                    limpaCamposCliente();
                    ordenaCamposClientes();
                }

            }
        }

        private void btRemoverCliente_Click(object sender, EventArgs e) {
            if (ListaClientes.SelectedRows.Count == 0 || ListaClientes.CurrentRow == null) {
                MessageBox.Show("Tem de selecionar em linha numa ( setinha no lado esquerdo ) da tabela Clientes, se pretende remover o Cliente!");
                return;
            }
           
            string id = ListaClientes.CurrentRow.Cells[3].Value.ToString();

            int selectedID = Int32.Parse(id);

            DialogResult dr = MessageBox.Show("Pretende mesmo remover este Cliente?", "Confirmação de eliminação do Cliente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes) {
                ClienteController.RemoverCliente(selectedID);

                refreshListaClientes();
                limpaListaClientes();
                limpaCamposCliente();
                ordenaCamposClientes();
                
            } else {
                limpaListaClientes();
                limpaCamposCliente();
                ordenaCamposClientes();
            }
        }




        private void ListaClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {

            txtNome.Text = ListaClientes.CurrentRow.Cells[4].Value.ToString();
            txtMorada.Text = ListaClientes.CurrentRow.Cells[5].Value.ToString();
            txtNif.Text = ListaClientes.CurrentRow.Cells[2].Value.ToString();

        }

        public void InsereValoresLC() {
            
            foreach (DataGridViewRow row in ListaClientes.Rows) {
                row.Cells["TotalBilhetes"].Value = BilheteController.GetQuantidadeBilhetesCliente(row.Cells["Nome"].Value.ToString());
                row.Cells["TotalDinheiro"].Value = BilheteController.GetValorBilhetesCliente(row.Cells["Nome"].Value.ToString()) + " €";
            }
        }

        public void CarregaDataGrid() {
            ListaClientes.DataSource = ClienteController.GetClientes();
            ListaClientes.Columns["Id"].HeaderText = "Nº Cliente";
            //adiciona uma coluna na lista de clientes
          
            InsereValoresLC();
            limpaCamposCliente();
            limpaListaClientes();
            ordenaCamposClientes();

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
