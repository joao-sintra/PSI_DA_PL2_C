namespace CineGest.Views {
    partial class Filmes {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new CineGest.Views.Timer();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCatAtiva = new System.Windows.Forms.CheckBox();
            this.btRemoverCat = new System.Windows.Forms.Button();
            this.btAlterarCat = new System.Windows.Forms.Button();
            this.btLimparCamposCat = new System.Windows.Forms.Button();
            this.btNovaCat = new System.Windows.Forms.Button();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ListaFilmes = new System.Windows.Forms.DataGridView();
            this.ListaCategorias = new System.Windows.Forms.DataGridView();
            this.btNovaSessao = new System.Windows.Forms.Button();
            this.cliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gestão de Filmes";
            // 
            // timer1
            // 
            this.timer1.Location = new System.Drawing.Point(875, 18);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(224, 35);
            this.timer1.TabIndex = 21;
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
            this.cliente.Location = new System.Drawing.Point(23, 76);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(478, 300);
            this.cliente.TabIndex = 22;
            this.cliente.TabStop = false;
            this.cliente.Text = "Adicionar filme";
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
            this.txtExibicao.Location = new System.Drawing.Point(111, 196);
            this.txtExibicao.Name = "txtExibicao";
            this.txtExibicao.Size = new System.Drawing.Size(297, 29);
            this.txtExibicao.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Exibição:";
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
            this.txtCategoriaF.Location = new System.Drawing.Point(111, 156);
            this.txtCategoriaF.Name = "txtCategoriaF";
            this.txtCategoriaF.Size = new System.Drawing.Size(297, 29);
            this.txtCategoriaF.TabIndex = 7;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(111, 116);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(297, 29);
            this.txtDuracao.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(111, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 29);
            this.txtNome.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Duração:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCatAtiva);
            this.groupBox1.Controls.Add(this.btRemoverCat);
            this.groupBox1.Controls.Add(this.btAlterarCat);
            this.groupBox1.Controls.Add(this.btLimparCamposCat);
            this.groupBox1.Controls.Add(this.btNovaCat);
            this.groupBox1.Controls.Add(this.txtCat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(547, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 300);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar categoria";
            // 
            // cbCatAtiva
            // 
            this.cbCatAtiva.AutoSize = true;
            this.cbCatAtiva.Location = new System.Drawing.Point(337, 160);
            this.cbCatAtiva.Name = "cbCatAtiva";
            this.cbCatAtiva.Size = new System.Drawing.Size(71, 25);
            this.cbCatAtiva.TabIndex = 23;
            this.cbCatAtiva.Text = "Activa";
            this.cbCatAtiva.UseVisualStyleBackColor = true;
            // 
            // btRemoverCat
            // 
            this.btRemoverCat.BackColor = System.Drawing.Color.Brown;
            this.btRemoverCat.FlatAppearance.BorderSize = 0;
            this.btRemoverCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverCat.ForeColor = System.Drawing.Color.White;
            this.btRemoverCat.Location = new System.Drawing.Point(330, 250);
            this.btRemoverCat.Name = "btRemoverCat";
            this.btRemoverCat.Size = new System.Drawing.Size(133, 33);
            this.btRemoverCat.TabIndex = 15;
            this.btRemoverCat.Text = "Remover";
            this.btRemoverCat.UseVisualStyleBackColor = false;
            // 
            // btAlterarCat
            // 
            this.btAlterarCat.BackColor = System.Drawing.Color.Gold;
            this.btAlterarCat.FlatAppearance.BorderSize = 0;
            this.btAlterarCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarCat.ForeColor = System.Drawing.Color.White;
            this.btAlterarCat.Location = new System.Drawing.Point(179, 250);
            this.btAlterarCat.Name = "btAlterarCat";
            this.btAlterarCat.Size = new System.Drawing.Size(133, 33);
            this.btAlterarCat.TabIndex = 22;
            this.btAlterarCat.Text = "Alterar";
            this.btAlterarCat.UseVisualStyleBackColor = false;
            // 
            // btLimparCamposCat
            // 
            this.btLimparCamposCat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btLimparCamposCat.FlatAppearance.BorderSize = 0;
            this.btLimparCamposCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparCamposCat.ForeColor = System.Drawing.Color.White;
            this.btLimparCamposCat.Location = new System.Drawing.Point(30, 250);
            this.btLimparCamposCat.Name = "btLimparCamposCat";
            this.btLimparCamposCat.Size = new System.Drawing.Size(133, 33);
            this.btLimparCamposCat.TabIndex = 21;
            this.btLimparCamposCat.Text = "Limpar campos";
            this.btLimparCamposCat.UseVisualStyleBackColor = false;
            // 
            // btNovaCat
            // 
            this.btNovaCat.BackColor = System.Drawing.Color.ForestGreen;
            this.btNovaCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaCat.ForeColor = System.Drawing.Color.White;
            this.btNovaCat.Location = new System.Drawing.Point(343, 28);
            this.btNovaCat.Name = "btNovaCat";
            this.btNovaCat.Size = new System.Drawing.Size(120, 33);
            this.btNovaCat.TabIndex = 10;
            this.btNovaCat.Text = "Novo";
            this.btNovaCat.UseVisualStyleBackColor = false;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(154, 116);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(254, 29);
            this.txtCat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Categoria:";
            // 
            // ListaFilmes
            // 
            this.ListaFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaFilmes.Location = new System.Drawing.Point(23, 410);
            this.ListaFilmes.Name = "ListaFilmes";
            this.ListaFilmes.Size = new System.Drawing.Size(563, 270);
            this.ListaFilmes.TabIndex = 24;
            // 
            // ListaCategorias
            // 
            this.ListaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaCategorias.Location = new System.Drawing.Point(637, 410);
            this.ListaCategorias.Name = "ListaCategorias";
            this.ListaCategorias.Size = new System.Drawing.Size(318, 261);
            this.ListaCategorias.TabIndex = 25;
            // 
            // btNovaSessao
            // 
            this.btNovaSessao.BackColor = System.Drawing.Color.ForestGreen;
            this.btNovaSessao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaSessao.ForeColor = System.Drawing.Color.White;
            this.btNovaSessao.Location = new System.Drawing.Point(23, 688);
            this.btNovaSessao.Name = "btNovaSessao";
            this.btNovaSessao.Size = new System.Drawing.Size(189, 33);
            this.btNovaSessao.TabIndex = 23;
            this.btNovaSessao.Text = "Nova sessão";
            this.btNovaSessao.UseVisualStyleBackColor = false;
            // 
            // Filmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btNovaSessao);
            this.Controls.Add(this.ListaCategorias);
            this.Controls.Add(this.ListaFilmes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.timer1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Filmes";
            this.Size = new System.Drawing.Size(1121, 733);
            this.cliente.ResumeLayout(false);
            this.cliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Timer timer1;
        private System.Windows.Forms.GroupBox cliente;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRemoverCat;
        private System.Windows.Forms.Button btAlterarCat;
        private System.Windows.Forms.Button btLimparCamposCat;
        private System.Windows.Forms.Button btNovaCat;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ListaFilmes;
        private System.Windows.Forms.DataGridView ListaCategorias;
        private System.Windows.Forms.CheckBox cbCatAtiva;
        private System.Windows.Forms.Button btNovaSessao;
    }
}
