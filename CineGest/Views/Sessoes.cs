using CineGest.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

            cbSalaS.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilmeS.DropDownStyle = ComboBoxStyle.DropDownList;

            ListaSessoes.ReadOnly = true;
            ListaSessoes.EditMode = DataGridViewEditMode.EditProgrammatically;



        }
        private void limparCamposSessao()
        {
            datePicker.Value = DateTime.Now;
            txtPreco.Text = string.Empty;
            cbSalaS.SelectedIndex = -1;
            cbFilmeS.SelectedIndex = -1;
        }
        private void limparListaSessoes()
        {
            ListaSessoes.ClearSelection();
        }

        private void refreshListaSessoes()
        {
            ListaSessoes.DataSource = null;
            ListaSessoes.DataSource = SessaoController.GetSessoes();

        }

        private void btNovoSessao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbFilmeS.Text) || string.IsNullOrEmpty(cbSalaS.Text) || string.IsNullOrEmpty(txtPreco.Text))
            {
                MessageBox.Show("Por favor, preencha o(s) campo(s)!");

            }
            else
            {
                try
                {
                    SessaoController.AdicionarSessao(cbFilmeS.Text, cbSalaS.Text, datePicker.Value, float.Parse(txtPreco.Text));
                    refreshListaSessoes();
                    limparListaSessoes();
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Campos no formato incorreto!\n\nCampos Filmes e Salas: aceita tanto letras como números." +
                        "\n\nCampo Preço só Deve conter Dados no Formato numero!");


                    limparCamposSessao();

                }
            }

        }
        private void ListaSessoes_DoubleClick(object sender, EventArgs e)
        {
            cbFilmeS.DataSource = FilmeController.GetOnlyNomesFilmes();
            cbSalaS.DataSource = SalaController.GetOnlyNomesSalas();
            ListaSessoes.DataSource = SessaoController.GetSessoes();
            ListaSessoes.Columns["FilmeID"].HeaderText = "Filme";
            ListaSessoes.Columns["SalaID"].HeaderText = "Sala";
            ListaSessoes.Columns["Preco"].HeaderText = "Preço (€)";
            ListaSessoes.Columns["DataHora"].HeaderText = "Data/Hora";
            limparCamposSessao();
            limparListaSessoes();

        }

        private void btLimparCamposSessao_Click(object sender, EventArgs e)
        {
            limparCamposSessao();
            limparListaSessoes();
        }

        private void btAlterarSessao_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(cbFilmeS.Text) || string.IsNullOrEmpty(cbSalaS.Text) || string.IsNullOrEmpty(txtPreco.Text))
            {
                MessageBox.Show("Só pode alterar o(s) campo(s), se a sessão estiver adicionada e selecionada na Tabela Sessões!");
                return;

                
            }
            else
            {
                if (ListaSessoes.SelectedRows.Count == 0 || ListaSessoes.CurrentRow == null)
                {
                    MessageBox.Show("Tem de selecionar em linha numa ( setinha no lado esquerdo ) da tabela Sessões, se quiser alterar os campos!");
                    return;
                }

                try
                {
                    string id = ListaSessoes.CurrentRow.Cells[0].Value.ToString();

                    int selectedID = Int32.Parse(id);


                    SessaoController.AlterarSessao(selectedID, cbFilmeS.Text, cbSalaS.Text, datePicker.Value, float.Parse(txtPreco.Text));

                    refreshListaSessoes();
                    limparListaSessoes();
                 

                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Campos no formato incorreto!\n\nCampo Nome: aceita tanto letras como números." +
                        "\nCampo Duração: só aceita números inteiros.\n");

                    limparListaSessoes();
                    limparCamposSessao();
                }

            }
        }


        private void btRemoverSessao_Click(object sender, EventArgs e)
        {
            if (ListaSessoes.SelectedRows.Count == 0 || ListaSessoes.CurrentRow == null)
            {
                MessageBox.Show("Tem de selecionar em linha numa ( setinha no lado esquerdo ) da tabela Sessões, se pretende remover a Sessão!");
                return;
            }

            string id = ListaSessoes.CurrentRow.Cells[0].Value.ToString();

            int selectedID = Int32.Parse(id);

            DialogResult dr = MessageBox.Show("Pretende mesmo remover esta sessão?", "Confirmação de eliminação da sessão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dr == DialogResult.Yes)
            {
                SessaoController.EliminarSessao(selectedID);

                refreshListaSessoes();
                limparListaSessoes();
                limparCamposSessao();
            }
            else
            {
                limparListaSessoes();
                limparCamposSessao();
            }
        }

        private void ListaSessoes_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            datePicker.Text = ListaSessoes.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = ListaSessoes.CurrentRow.Cells[2].Value.ToString();
            cbSalaS.Text = ListaSessoes.CurrentRow.Cells[3].Value.ToString();
            cbFilmeS.Text = ListaSessoes.CurrentRow.Cells[4].Value.ToString();
        }

        //private void ListaSessoes_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (ListaSessoes.SelectedRows.Count == 0 || ListaSessoes.CurrentRow == null)
        //    {
        //        limparCamposSessao();
        //    }
        //    else
        //    {
        //        // Retrieve the selected row
        //        var selectedRow = ListaSessoes.CurrentRow;

        //        // Update the field values based on the selected row
        //        datePicker.Value = (DateTime)selectedRow.Cells["DataHora"].Value;
        //        txtPreco.Text = selectedRow.Cells["Preco"].Value.ToString();
        //        cbSalaS.Text = selectedRow.Cells["SalaID"].Value.ToString();
        //        cbFilmeS.Text = selectedRow.Cells["FilmeID"].Value.ToString();
        //    }
        //}


    }
}