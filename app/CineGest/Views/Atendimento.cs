using CineGest.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CineGest.Views {
    public partial class Atendimento : UserControl {
        private bool estado;
        private string filme;
        private string sala;
        private string sessao;
        private int numSessao;
        public string funcionario;
        private SaveFileDialog saveFileDialog = new SaveFileDialog();



        public Atendimento() {
            InitializeComponent();
            listaBilhetes.ReadOnly = true;
            listaBilhetes.EditMode = DataGridViewEditMode.EditProgrammatically;
            ListaClientes.ReadOnly = true;
            ListaClientes.EditMode = DataGridViewEditMode.EditProgrammatically;

            //saveFileDialog.InitialDirectory = "C:\\bilhetes";
            saveFileDialog.Title = "Guardar Ficheiro";
            saveFileDialog.FileName = "Bilhetes";
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.DefaultExt = ".txt";

        }
        private void LimpaLugares() {
            lugares.Controls.Clear();
            lugares.RowStyles.Clear();
            lugares.ColumnStyles.Clear();
            listaLugaresMarcados.Items.Clear();

        }
        private void DrawLugares() {
            LimpaLugares();
            int colunas = SalaController.GetColunas(sala);
            int linhas = SalaController.GetLinhas(sala);
            this.numSessao = Int32.Parse(sessao);

            lugares.RowCount = linhas;
            lugares.ColumnCount = colunas;

            for (int j = 0; j < linhas; j++) {
                lugares.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / linhas));
            }

            for (int i = 0; i < colunas; i++) {
                lugares.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / colunas));
            }
            int cadeira = 1;
            for (int i = 0; i < lugares.RowCount; i++) {
                for (int j = 0; j < lugares.ColumnCount; j++) {

                    Label labelLugar = new Label();
                    labelLugar.Text = cadeira.ToString();
                    labelLugar.AutoSize = false;
                    labelLugar.TextAlign = ContentAlignment.MiddleCenter;
                    labelLugar.Dock = DockStyle.Fill;
                    labelLugar.BackColor = Color.LightGreen;

                    lugares.Controls.Add(labelLugar, j, i);
                    cadeira++;

                    labelLugar.Click += labelLugar_Click;
                }
            }
            var lugaresOcupados = BilheteController.GetLugaresOcupados(numSessao);
            foreach (var lugar in lugaresOcupados) {
                lugares.Controls[lugar - 1].BackColor = Color.Gray;

            }

        }
        private void labelLugar_Click(object sender, EventArgs e) {

            Label labelLugar = (Label)sender;
            if (labelLugar.BackColor == Color.LightGreen) {
                labelLugar.BackColor = Color.Red;
                listaLugaresMarcados.Items.Add(labelLugar.Text);
            } else if (labelLugar.BackColor == Color.Red) {
                listaLugaresMarcados.Items.Remove(labelLugar.Text);
                labelLugar.BackColor = Color.LightGreen;
            } else if (labelLugar.BackColor == Color.Gray) {
                MessageBox.Show("Lugar indisponivel!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }


        private void btEmitirBilhete_Click(object sender, EventArgs e) {
            List<string> listaLugares = new List<string>();
            int numLugar;
            int numSessao = Int32.Parse(sessao);
            string nomecliente;
            string filePath = "";
           
            if (checkBoxAnonimoCliente.Checked)
                nomecliente = "Anônimo";
            else {

                if (listaLugaresMarcados.Items.Count == 0) {
                    MessageBox.Show("Por favor, selecione o(s) lugar(es) da sala !");
                    return;
                }else if (string.IsNullOrEmpty(txtMoradaCliente.Text) || string.IsNullOrEmpty(txtNomeCliente.Text) || string.IsNullOrEmpty(txtNumFiscalCliente.Text)) {
                    MessageBox.Show("Por favor, preencha o(s) campo(s) do cliente !");
                    return;
                } else {
                    if (!int.TryParse(txtNumFiscalCliente.Text, out int nif)) {
                        MessageBox.Show("O NIF só aceita números!");
                        return;
                    }

                    if (txtNumFiscalCliente.Text.Length != 9) {
                        MessageBox.Show("O NIF tem de ter 9 digitos!");
                        return;
                    }
                    nomecliente = txtNomeCliente.Text;
                    if (ClienteController.VerificaExistenciaCliente(nomecliente)) {
                        ClienteController.AdicionarCliente(nif, txtNomeCliente.Text, txtMoradaCliente.Text);
                    }

                }
                
            }
             if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                filePath = saveFileDialog.FileName;
            } else if (saveFileDialog.ShowDialog() == DialogResult.Cancel) {
                filePath = "Bilhetes.txt";
            }
            foreach (string lugar in listaLugaresMarcados.Items) {
                numLugar = Int32.Parse(lugar);
                BilheteController.AdicionarBilhete(numLugar, true, nomecliente, funcionario, numSessao);
                listaLugares.Add(lugar);
            }
            BilheteController.ExportarBilheteTxt(listaLugares, numSessao, funcionario, nomecliente, filePath);
            RefreshListaBilhetes();
            DrawLugares();
            LimpaCamposCliente();
            RefreshListaClientes();
            MessageBox.Show("Bilhete(s) emitido(s) com sucesso!");
            
        }
        
        public void CarregaInformacoes() {
            LabelInformacoesSessao.Text = AtendimentoController.GetInformacoesSessao();
            ListaClientes.DataSource = ClienteController.GetClientes();
            this.sessao = AtendimentoController.GetSessaoSessao();
            //this.filme = AtendimentoController.GetFilmeSessao();
            this.sala = AtendimentoController.GetSalaSessao();
            //ListaBilhetes.Columns["FuncionarioID"].HeaderText = "Funcionario";
            // ListaBilhetes.Columns["ClienteID"].HeaderText = "Cliente";
            DrawLugares();
            RefreshListaBilhetes();
            OrdenaCamposClientes();
            LimpaCamposCliente();

        }
        private void RefreshListaClientes() {

            ListaClientes.DataSource = ClienteController.GetClientes();

            ListaClientes.ClearSelection();
        }

        private void RefreshListaBilhetes() {
            bilheteBindingSource.DataSource = null;
            bilheteBindingSource.DataSource = BilheteController.GetBilhetes(numSessao);
            //listaBilhetes.DataSource = null;
            listaBilhetes.DataSource = BilheteController.GetBilhetes(numSessao);

        }

        private void LimpaCamposCliente() {

            txtNumFiscalCliente.Text = string.Empty;
            txtNomeCliente.Text = string.Empty;
            txtMoradaCliente.Text = string.Empty;
            checkBoxAnonimoCliente.Checked = false;

        }

        public void OrdenaCamposClientes() {

            ListaClientes.Columns["Id"].Visible = false;
            ListaClientes.Columns["NIF"].DisplayIndex = 1;
            ListaClientes.Columns["Nome"].DisplayIndex = 0;
            ListaClientes.Columns["Morada"].DisplayIndex = 2;
        }

        private void ListaClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            txtNomeCliente.Text = ListaClientes.CurrentRow.Cells[2].Value.ToString();
            txtMoradaCliente.Text = ListaClientes.CurrentRow.Cells[3].Value.ToString();
            txtNumFiscalCliente.Text = ListaClientes.CurrentRow.Cells[0].Value.ToString();
        }

        private void checkBoxAnonimoCliente_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxAnonimoCliente.Checked) {
                txtNomeCliente.Enabled = false;
                txtMoradaCliente.Enabled = false;
                txtNumFiscalCliente.Enabled = false;
            } else {
                txtNomeCliente.Enabled = true;
                txtMoradaCliente.Enabled = true;
                txtNumFiscalCliente.Enabled = true;
            }
        }

        private void txtPesquisaClientes_KeyDown(object sender, KeyEventArgs e) {
            if (txtPesquisaClientes.Text.Length >= 2) {
                ListaClientes.DataSource = null;
                ListaClientes.DataSource = ClienteController.ProcuraCliente(txtPesquisaClientes.Text.Trim());
                OrdenaCamposClientes();
            } else if (txtPesquisaClientes.Text.Length < 2) {
                RefreshListaClientes();
                OrdenaCamposClientes();
            }
        }

        private void btLimparCamposCliente_Click(object sender, EventArgs e) {
            LimpaCamposCliente();
        }

        private void btAnularBilhete_Click(object sender, EventArgs e) {
            if (listaBilhetes.SelectedRows == null || listaBilhetes.CurrentRow == null) {
                MessageBox.Show("Selecione um bilhete para anular!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            } else {
                int idBilhete = Int32.Parse(listaBilhetes.CurrentRow.Cells[0].Value.ToString());
                BilheteController.AnulaBilhete(idBilhete);
                RefreshListaBilhetes();

            }

        }

        private void btCancelar_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Deseja cancelar a emisão dos bilhetes?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                RefreshListaBilhetes();
                RefreshListaClientes();
                LimpaCamposCliente();
                listaLugaresMarcados.Items.Clear();
                DrawLugares();
            }
        }
    }
}
