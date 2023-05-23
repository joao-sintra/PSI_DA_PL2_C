namespace CineGest.Views
{
    partial class Sessoes
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timer1 = new CineGest.Views.Timer();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.txtCategoriaF = new System.Windows.Forms.TextBox();
            this.btNovoF = new System.Windows.Forms.Button();
            this.btLimparCamposF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExibicao = new System.Windows.Forms.TextBox();
            this.btAlterarF = new System.Windows.Forms.Button();
            this.btRemoverF = new System.Windows.Forms.Button();
            this.cliente = new System.Windows.Forms.GroupBox();
            this.ListaSessoes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaSessoes)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Location = new System.Drawing.Point(877, 15);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(224, 35);
            this.timer1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sala:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Filme:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Data:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(111, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 29);
            this.txtNome.TabIndex = 5;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(111, 116);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(297, 29);
            this.txtDuracao.TabIndex = 6;
            // 
            // txtCategoriaF
            // 
            this.txtCategoriaF.Location = new System.Drawing.Point(111, 156);
            this.txtCategoriaF.Name = "txtCategoriaF";
            this.txtCategoriaF.Size = new System.Drawing.Size(297, 29);
            this.txtCategoriaF.TabIndex = 7;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hora:";
            // 
            // txtExibicao
            // 
            this.txtExibicao.Location = new System.Drawing.Point(111, 196);
            this.txtExibicao.Name = "txtExibicao";
            this.txtExibicao.Size = new System.Drawing.Size(297, 29);
            this.txtExibicao.TabIndex = 12;
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
            // cliente
            // 
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
            this.cliente.Size = new System.Drawing.Size(658, 305);
            this.cliente.TabIndex = 28;
            this.cliente.TabStop = false;
            this.cliente.Text = "Adicionar Sessão";
            // 
            // ListaSessoes
            // 
            this.ListaSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaSessoes.Location = new System.Drawing.Point(25, 407);
            this.ListaSessoes.Name = "ListaSessoes";
            this.ListaSessoes.Size = new System.Drawing.Size(1076, 303);
            this.ListaSessoes.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 30);
            this.label3.TabIndex = 34;
            this.label3.Text = "Gestão de Sessões";
            // 
            // Sessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaSessoes);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.timer1);
            this.Name = "Sessoes";
            this.Size = new System.Drawing.Size(1121, 733);
            this.cliente.ResumeLayout(false);
            this.cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaSessoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.TextBox txtCategoriaF;
        private System.Windows.Forms.Button btNovoF;
        private System.Windows.Forms.Button btLimparCamposF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExibicao;
        private System.Windows.Forms.Button btAlterarF;
        private System.Windows.Forms.Button btRemoverF;
        private System.Windows.Forms.GroupBox cliente;
        private System.Windows.Forms.DataGridView ListaSessoes;
        private System.Windows.Forms.Label label3;
    }
}
