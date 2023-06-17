using CineGest.Controllers;
using System;
using System.Windows.Forms;

namespace CineGest.Views {
    public partial class Sessoes : UserControl {
        public Sessoes() {
            InitializeComponent();
            cbSalaS.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilmeS.DropDownStyle = ComboBoxStyle.DropDownList;

            ListaSessoes.ReadOnly = true;
            ListaSessoes.EditMode = DataGridViewEditMode.EditProgrammatically;



        }
        private void limparCamposSessao() {
            datePicker.Value = DateTime.Now;
            txtPreco.Text = string.Empty;
            cbSalaS.SelectedIndex = -1;
            cbFilmeS.SelectedIndex = -1;
        }
        private void limparListaSessoes() {
            ListaSessoes.ClearSelection();
        }

        private void refreshListaSessoes() {
            ListaSessoes.DataSource = null;
            ListaSessoes.DataSource = SessaoController.GetSessoes();

        }


        private void btNovoSessao_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(cbFilmeS.Text) || string.IsNullOrEmpty(cbSalaS.Text) || string.IsNullOrEmpty(txtPreco.Text)) {
                MessageBox.Show("Por favor, preencha o(s) campo(s)!");

            } else {
                try {
                    SessaoController.AdicionarSessao(cbFilmeS.Text, cbSalaS.Text, datePicker.Value, float.Parse(txtPreco.Text));
                    refreshListaSessoes();
                    limparListaSessoes();
                } catch (FormatException fe) {
                    MessageBox.Show("Campos no formato incorreto!\n" +
                          "\nCampo Preço: Só aceita números!");



                    limparCamposSessao();

                }
            }

        }


        private void btLimparCamposSessao_Click(object sender, EventArgs e) {
            limparCamposSessao();
            limparListaSessoes();
        }

        private void btAlterarSessao_Click(object sender, EventArgs e) {


            if (string.IsNullOrEmpty(cbFilmeS.Text) || string.IsNullOrEmpty(cbSalaS.Text) || string.IsNullOrEmpty(txtPreco.Text)) {
                MessageBox.Show("Só pode alterar o(s) campo(s), se a sessão estiver adicionada e selecionada na Tabela Sessões!");
                return;


            } else {
                if (ListaSessoes.SelectedRows.Count == 0 || ListaSessoes.CurrentRow == null) {
                    MessageBox.Show("Tem de selecionar em linha numa ( setinha no lado esquerdo ) da tabela Sessões, se quiser alterar os campos!");
                    return;
                }

                try {
                    string id = ListaSessoes.CurrentRow.Cells[0].Value.ToString();

                    int selectedID = Int32.Parse(id);


                    SessaoController.AlterarSessao(selectedID, cbFilmeS.Text, cbSalaS.Text, datePicker.Value, float.Parse(txtPreco.Text));

                    refreshListaSessoes();
                    limparListaSessoes();


                } catch (FormatException fe) {
                    MessageBox.Show("Campos no formato incorreto!\n" +
                          "\nCampo Preço: Só aceita números!");


                    limparListaSessoes();
                    limparCamposSessao();
                }

            }
        }


        private void btRemoverSessao_Click(object sender, EventArgs e) {
            if (ListaSessoes.SelectedRows.Count == 0 || ListaSessoes.CurrentRow == null) {
                MessageBox.Show("Tem de selecionar em linha numa ( setinha no lado esquerdo ) da tabela Sessões, se pretende remover a Sessão!");
                return;
            }

            string id = ListaSessoes.CurrentRow.Cells[0].Value.ToString();

            int selectedID = Int32.Parse(id);

            DialogResult dr = MessageBox.Show("Pretende mesmo remover esta sessão?", "Confirmação de eliminação da sessão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes) {
                SessaoController.RemoverSessao(selectedID);

                refreshListaSessoes();
                limparListaSessoes();
                limparCamposSessao();
            } else {
                limparListaSessoes();
                limparCamposSessao();
            }
        }

        private void ListaSessoes_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e) {
            datePicker.Text = ListaSessoes.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = ListaSessoes.CurrentRow.Cells[2].Value.ToString();
            cbSalaS.Text = ListaSessoes.CurrentRow.Cells[3].Value.ToString();
            cbFilmeS.Text = ListaSessoes.CurrentRow.Cells[4].Value.ToString();
        }

        private void Sessoes_Paint(object sender, PaintEventArgs e) {


           // cbFilmeS.DataSource = FilmeController.GetOnlyNomesFilmes();
            //cbSalaS.DataSource = SalaController.GetOnlyNomesSalas();
            //ListaSessoes.DataSource = SessaoController.GetSessoes();
            ListaSessoes.Columns["FilmeID"].HeaderText = "Filme";
            ListaSessoes.Columns["SalaID"].HeaderText = "Sala";
            ListaSessoes.Columns["Preco"].HeaderText = "Preço (€)";
            ListaSessoes.Columns["DataHora"].HeaderText = "Data/Hora";
            limparCamposSessao();
            limparListaSessoes();
        }


        /* */

    }
}
