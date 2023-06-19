using CineGest.Controllers;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CineGest.Views {
    public partial class Inicio : UserControl {

        public string funcionario;
        public Inicio() {
            InitializeComponent();
            atendimento1.Visible = false;
            ListaSessoes.ReadOnly = true;
            ListaSessoes.EditMode = DataGridViewEditMode.EditProgrammatically;
            ListaSessoes.DataSource = null;
            cbFuncionarios.DropDownStyle = ComboBoxStyle.DropDownList;
            //ListaSessoes.DataSource = SessaoController.GetSessoes();
        }
        private void ListaSessoes_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e) {
            string sala = ListaSessoes.CurrentRow.Cells[3].Value.ToString();
            string filme = ListaSessoes.CurrentRow.Cells[4].Value.ToString();
            string sessao = ListaSessoes.CurrentRow.Cells[0].Value.ToString();

            AtendimentoController.SetInformacoesSessao(sala, sessao, filme);
            atendimento1.CarregaInformacoes();
            atendimento1.Visible = true;
            atendimento1.funcionario = this.funcionario;
            groupBox1.Visible = false;

        }
        private void PreencheComboBox() {
            if (string.IsNullOrEmpty(this.funcionario)) {
                cbFuncionarios.DataSource = FuncionarioController.GetFuncionariosString();
                cbFuncionarios.SelectedIndex = 0;
                this.funcionario= cbFuncionarios.Text;
            } else {
                cbFuncionarios.DataSource = FuncionarioController.GetFuncionariosString();
                cbFuncionarios.Text = this.funcionario;
            }
        }
        public void CarregaDatagrid() {

            groupBox1.Visible = true;
            ListaSessoes.DataSource = SessaoController.GetSessoesHoje();
            //List<int> a = BilheteController.GetLugaresOcupadosPorSessao(1);
            contaBilhesPorMes();
            PreencheComboBox();
            ListaSessoes.Columns["FilmeID"].HeaderText = "Filme";
            ListaSessoes.Columns["SalaID"].HeaderText = "Sala";
            ListaSessoes.Columns["Preco"].HeaderText = "Preço (€)";
            ListaSessoes.Columns["DataHora"].HeaderText = "Data/Hora";

        }

      
        private void contaBilhesPorMes() {
            List<int> bilhetesVendidosPorMes = BilheteController.GetBilhetesPorMes();
            int total = 0;
            foreach (var item in bilhetesVendidosPorMes) {
                total+= item;
            }
            labelQuantBilhetesMes.Text = total.ToString();
        }
        private void btMudarFuncionario_Click(object sender, System.EventArgs e) {
            this.funcionario = cbFuncionarios.Text;
        }
    }
}
