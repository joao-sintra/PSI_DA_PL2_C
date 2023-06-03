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
            this.gbAdicionarFilme = new System.Windows.Forms.GroupBox();
            this.cbCategoriaF = new System.Windows.Forms.ComboBox();
            this.cbAtivoF = new System.Windows.Forms.CheckBox();
            this.btRemoverF = new System.Windows.Forms.Button();
            this.btAlterarF = new System.Windows.Forms.Button();
            this.btLimparCamposF = new System.Windows.Forms.Button();
            this.btNovoF = new System.Windows.Forms.Button();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbAdicionarCat = new System.Windows.Forms.GroupBox();
            this.cbCatAtiva = new System.Windows.Forms.CheckBox();
            this.btRemoverCat = new System.Windows.Forms.Button();
            this.btAlterarCat = new System.Windows.Forms.Button();
            this.btLimparCamposCat = new System.Windows.Forms.Button();
            this.btNovaCat = new System.Windows.Forms.Button();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listaFilmes = new System.Windows.Forms.DataGridView();
            this.listaCategorias = new System.Windows.Forms.DataGridView();
            this.btNovaSessao = new System.Windows.Forms.Button();
            this.timer1 = new CineGest.Views.Timer();
            this.gbAdicionarFilme.SuspendLayout();
            this.gbAdicionarCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategorias)).BeginInit();
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
            // gbAdicionarFilme
            // 
            this.gbAdicionarFilme.Controls.Add(this.cbCategoriaF);
            this.gbAdicionarFilme.Controls.Add(this.cbAtivoF);
            this.gbAdicionarFilme.Controls.Add(this.btRemoverF);
            this.gbAdicionarFilme.Controls.Add(this.btAlterarF);
            this.gbAdicionarFilme.Controls.Add(this.btLimparCamposF);
            this.gbAdicionarFilme.Controls.Add(this.btNovoF);
            this.gbAdicionarFilme.Controls.Add(this.txtDuracao);
            this.gbAdicionarFilme.Controls.Add(this.txtNome);
            this.gbAdicionarFilme.Controls.Add(this.label7);
            this.gbAdicionarFilme.Controls.Add(this.label6);
            this.gbAdicionarFilme.Controls.Add(this.label5);
            this.gbAdicionarFilme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdicionarFilme.Location = new System.Drawing.Point(23, 76);
            this.gbAdicionarFilme.Name = "gbAdicionarFilme";
            this.gbAdicionarFilme.Size = new System.Drawing.Size(478, 300);
            this.gbAdicionarFilme.TabIndex = 22;
            this.gbAdicionarFilme.TabStop = false;
            this.gbAdicionarFilme.Text = "Adicionar filme";
            // 
            // cbCategoriaF
            // 
            this.cbCategoriaF.FormattingEnabled = true;
            this.cbCategoriaF.Location = new System.Drawing.Point(111, 159);
            this.cbCategoriaF.Name = "cbCategoriaF";
            this.cbCategoriaF.Size = new System.Drawing.Size(297, 29);
            this.cbCategoriaF.TabIndex = 25;
            // 
            // cbAtivoF
            // 
            this.cbAtivoF.AutoSize = true;
            this.cbAtivoF.Location = new System.Drawing.Point(318, 196);
            this.cbAtivoF.Name = "cbAtivoF";
            this.cbAtivoF.Size = new System.Drawing.Size(72, 25);
            this.cbAtivoF.TabIndex = 24;
            this.cbAtivoF.Text = "Activo";
            this.cbAtivoF.UseVisualStyleBackColor = true;
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
            this.btRemoverF.Click += new System.EventHandler(this.btRemoverF_Click);
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
            this.btAlterarF.Click += new System.EventHandler(this.btAlterarF_Click);
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
            this.btLimparCamposF.Click += new System.EventHandler(this.btLimparCamposF_Click);
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
            this.btNovoF.Click += new System.EventHandler(this.btNovoF_Click);
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
            this.label7.Location = new System.Drawing.Point(20, 162);
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
            // gbAdicionarCat
            // 
            this.gbAdicionarCat.Controls.Add(this.cbCatAtiva);
            this.gbAdicionarCat.Controls.Add(this.btRemoverCat);
            this.gbAdicionarCat.Controls.Add(this.btAlterarCat);
            this.gbAdicionarCat.Controls.Add(this.btLimparCamposCat);
            this.gbAdicionarCat.Controls.Add(this.btNovaCat);
            this.gbAdicionarCat.Controls.Add(this.txtCat);
            this.gbAdicionarCat.Controls.Add(this.label4);
            this.gbAdicionarCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdicionarCat.Location = new System.Drawing.Point(547, 76);
            this.gbAdicionarCat.Name = "gbAdicionarCat";
            this.gbAdicionarCat.Size = new System.Drawing.Size(478, 300);
            this.gbAdicionarCat.TabIndex = 23;
            this.gbAdicionarCat.TabStop = false;
            this.gbAdicionarCat.Text = "Adicionar categoria";
            // 
            // cbCatAtiva
            // 
            this.cbCatAtiva.AutoSize = true;
            this.cbCatAtiva.Location = new System.Drawing.Point(320, 159);
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
            this.btRemoverCat.Click += new System.EventHandler(this.btRemoverCat_Click);
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
            this.btAlterarCat.Click += new System.EventHandler(this.btAlterarCat_Click);
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
            this.btLimparCamposCat.Click += new System.EventHandler(this.btLimparCamposCat_Click);
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
            this.btNovaCat.Click += new System.EventHandler(this.btNovaCat_Click);
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
            // listaFilmes
            // 
            this.listaFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaFilmes.Location = new System.Drawing.Point(23, 410);
            this.listaFilmes.Name = "listaFilmes";
            this.listaFilmes.RowHeadersWidth = 51;
            this.listaFilmes.Size = new System.Drawing.Size(555, 256);
            this.listaFilmes.TabIndex = 24;
            this.listaFilmes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listaFilmes_CellMouseClick);
            this.listaFilmes.DoubleClick += new System.EventHandler(this.listaFilmes_DoubleClick);
            // 
            // listaCategorias
            // 
            this.listaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCategorias.Location = new System.Drawing.Point(637, 410);
            this.listaCategorias.Name = "listaCategorias";
            this.listaCategorias.RowHeadersWidth = 51;
            this.listaCategorias.Size = new System.Drawing.Size(353, 256);
            this.listaCategorias.TabIndex = 25;
            this.listaCategorias.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listaCategorias_CellMouseClick);
            this.listaCategorias.DoubleClick += new System.EventHandler(this.listaCategorias_DoubleClick);
            // 
            // btNovaSessao
            // 
            this.btNovaSessao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btNovaSessao.Enabled = false;
            this.btNovaSessao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaSessao.ForeColor = System.Drawing.Color.White;
            this.btNovaSessao.Location = new System.Drawing.Point(23, 682);
            this.btNovaSessao.Name = "btNovaSessao";
            this.btNovaSessao.Size = new System.Drawing.Size(189, 33);
            this.btNovaSessao.TabIndex = 23;
            this.btNovaSessao.Text = "Nova sessão";
            this.btNovaSessao.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Location = new System.Drawing.Point(809, 21);
            this.timer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(290, 42);
            this.timer1.TabIndex = 21;
            // 
            // Filmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btNovaSessao);
            this.Controls.Add(this.listaCategorias);
            this.Controls.Add(this.listaFilmes);
            this.Controls.Add(this.gbAdicionarCat);
            this.Controls.Add(this.gbAdicionarFilme);
            this.Controls.Add(this.timer1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Filmes";
            this.Size = new System.Drawing.Size(1121, 733);
            this.gbAdicionarFilme.ResumeLayout(false);
            this.gbAdicionarFilme.PerformLayout();
            this.gbAdicionarCat.ResumeLayout(false);
            this.gbAdicionarCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbAdicionarFilme;
        private System.Windows.Forms.Button btRemoverF;
        private System.Windows.Forms.Button btAlterarF;
        private System.Windows.Forms.Button btLimparCamposF;
        private System.Windows.Forms.Button btNovoF;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbAdicionarCat;
        private System.Windows.Forms.Button btRemoverCat;
        private System.Windows.Forms.Button btAlterarCat;
        private System.Windows.Forms.Button btLimparCamposCat;
        private System.Windows.Forms.Button btNovaCat;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView listaFilmes;
        private System.Windows.Forms.DataGridView listaCategorias;
        private System.Windows.Forms.CheckBox cbCatAtiva;
        private System.Windows.Forms.Button btNovaSessao;
        private System.Windows.Forms.CheckBox cbAtivoF;
        private System.Windows.Forms.ComboBox cbCategoriaF;
        private Timer timer1;
    }
}
