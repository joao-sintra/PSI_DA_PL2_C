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

        private void InitializeComponent()
        {
            this.ListaClientes = new System.Windows.Forms.DataGridView();
            this.cliente = new System.Windows.Forms.GroupBox();
            this.btRemoverF = new System.Windows.Forms.Button();
            this.btAlterarF = new System.Windows.Forms.Button();
            this.txtExibicao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btLimparCamposF = new System.Windows.Forms.Button();
            this.btNovoF = new System.Windows.Forms.Button();
            this.txtCategoriaF = new System.Windows.Forms.TextBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new CineGest.Views.Timer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).BeginInit();
            this.cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaFilmes
            // 
            this.ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaClientes.Location = new System.Drawing.Point(25, 407);
            this.ListaClientes.Name = "ListaFilmes";
            this.ListaClientes.Size = new System.Drawing.Size(1035, 259);
            this.ListaClientes.TabIndex = 37;
            // 
            // cliente
            // 
            this.cliente.Controls.Add(this.textBox1);
            this.cliente.Controls.Add(this.label2);
            this.cliente.Controls.Add(this.btRemoverF);
            this.cliente.Controls.Add(this.btAlterarF);
            this.cliente.Controls.Add(this.txtExibicao);
            this.cliente.Controls.Add(this.label1);
            this.cliente.Controls.Add(this.btLimparCamposF);
            this.cliente.Controls.Add(this.btNovoF);
            this.cliente.Controls.Add(this.txtCategoriaF);
            this.cliente.Controls.Add(this.txtDuracao);
            this.cliente.Controls.Add(this.txtNome);
            this.cliente.Controls.Add(this.label7);
            this.cliente.Controls.Add(this.label6);
            this.cliente.Controls.Add(this.label5);
            this.cliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(25, 73);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(1065, 309);
            this.cliente.TabIndex = 35;
            this.cliente.TabStop = false;
            this.cliente.Text = "Adicionar Cliente";
            // 
            // btRemoverF
            // 
            this.btRemoverF.BackColor = System.Drawing.Color.Brown;
            this.btRemoverF.FlatAppearance.BorderSize = 0;
            this.btRemoverF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverF.ForeColor = System.Drawing.Color.White;
            this.btRemoverF.Location = new System.Drawing.Point(330, 250);
            this.btRemoverF.Name = "btRemoverF";
            this.btRemoverF.Size = new System.Drawing.Size(133, 33);
            this.btRemoverF.TabIndex = 15;
            this.btRemoverF.Text = "Remover";
            this.btRemoverF.UseVisualStyleBackColor = false;
            // 
            // btAlterarF
            // 
            this.btAlterarF.BackColor = System.Drawing.Color.Gold;
            this.btAlterarF.FlatAppearance.BorderSize = 0;
            this.btAlterarF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarF.ForeColor = System.Drawing.Color.White;
            this.btAlterarF.Location = new System.Drawing.Point(179, 250);
            this.btAlterarF.Name = "btAlterarF";
            this.btAlterarF.Size = new System.Drawing.Size(133, 33);
            this.btAlterarF.TabIndex = 22;
            this.btAlterarF.Text = "Alterar";
            this.btAlterarF.UseVisualStyleBackColor = false;
            // 
            // txtExibicao
            // 
            this.txtExibicao.Location = new System.Drawing.Point(121, 196);
            this.txtExibicao.Name = "txtExibicao";
            this.txtExibicao.Size = new System.Drawing.Size(297, 29);
            this.txtExibicao.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nº Cliente:";
            // 
            // btLimparCamposF
            // 
            this.btLimparCamposF.BackColor = System.Drawing.Color.RoyalBlue;
            this.btLimparCamposF.FlatAppearance.BorderSize = 0;
            this.btLimparCamposF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparCamposF.ForeColor = System.Drawing.Color.White;
            this.btLimparCamposF.Location = new System.Drawing.Point(30, 250);
            this.btLimparCamposF.Name = "btLimparCamposF";
            this.btLimparCamposF.Size = new System.Drawing.Size(133, 33);
            this.btLimparCamposF.TabIndex = 21;
            this.btLimparCamposF.Text = "Limpar campos";
            this.btLimparCamposF.UseVisualStyleBackColor = false;
            // 
            // btNovoF
            // 
            this.btNovoF.BackColor = System.Drawing.Color.ForestGreen;
            this.btNovoF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoF.ForeColor = System.Drawing.Color.White;
            this.btNovoF.Location = new System.Drawing.Point(343, 28);
            this.btNovoF.Name = "btNovoF";
            this.btNovoF.Size = new System.Drawing.Size(120, 33);
            this.btNovoF.TabIndex = 10;
            this.btNovoF.Text = "Novo";
            this.btNovoF.UseVisualStyleBackColor = false;
            // 
            // txtCategoriaF
            // 
            this.txtCategoriaF.Location = new System.Drawing.Point(121, 156);
            this.txtCategoriaF.Name = "txtCategoriaF";
            this.txtCategoriaF.Size = new System.Drawing.Size(297, 29);
            this.txtCategoriaF.TabIndex = 7;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(121, 116);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(297, 29);
            this.txtDuracao.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(121, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 29);
            this.txtNome.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "NIF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Morada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome:";
            // 
            // timer1
            // 
            this.timer1.Location = new System.Drawing.Point(877, 15);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(224, 35);
            this.timer1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 30);
            this.label3.TabIndex = 33;
            this.label3.Text = "Gestão de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(727, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Valor Total:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(870, 253);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 44);
            this.textBox1.TabIndex = 24;
            // 
            // Sessoes
            // 
            this.Controls.Add(this.ListaClientes);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.timer1);
            this.Controls.Add(this.label3);
            this.Name = "Sessoes";
            this.Size = new System.Drawing.Size(1121, 733);
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).EndInit();
            this.cliente.ResumeLayout(false);
            this.cliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
