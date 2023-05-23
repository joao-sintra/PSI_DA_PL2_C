namespace CineGest.Views
{
    partial class Clientes
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
            this.ListaClientes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaClientes
            // 
            this.ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaClientes.Location = new System.Drawing.Point(25, 433);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(1059, 259);
            this.ListaClientes.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btRemoverF);
            this.groupBox1.Controls.Add(this.btAlterarF);
            this.groupBox1.Controls.Add(this.txtExibicao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btLimparCamposF);
            this.groupBox1.Controls.Add(this.btNovoF);
            this.groupBox1.Controls.Add(this.txtCategoriaF);
            this.groupBox1.Controls.Add(this.txtDuracao);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 309);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(870, 253);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 44);
            this.textBox1.TabIndex = 24;
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
            this.timer1.Location = new System.Drawing.Point(877, 41);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(218, 35);
            this.timer1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "Gestão de Clientes";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListaClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timer1);
            this.Controls.Add(this.label3);
            this.Name = "Cliente";
            this.Size = new System.Drawing.Size(1121, 733);
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRemoverF;
        private System.Windows.Forms.Button btAlterarF;
        private System.Windows.Forms.TextBox txtExibicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLimparCamposF;
        private System.Windows.Forms.Button btNovoF;
        private System.Windows.Forms.TextBox txtCategoriaF;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}
