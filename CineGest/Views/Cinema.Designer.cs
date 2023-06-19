namespace CineGest.Views {
    partial class Cinema {
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
            this.cliente = new System.Windows.Forms.GroupBox();
            this.btAlterarSala = new System.Windows.Forms.Button();
            this.btRemoverSala = new System.Windows.Forms.Button();
            this.btLimparCamposSala = new System.Windows.Forms.Button();
            this.btNovoSala = new System.Windows.Forms.Button();
            this.txtNumFilas = new System.Windows.Forms.TextBox();
            this.txtNumColunas = new System.Windows.Forms.TextBox();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listaSalas = new System.Windows.Forms.DataGridView();
            this.timer1 = new CineGest.Views.Timer();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btAlterarCinema = new System.Windows.Forms.Button();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSalas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gestão de Salas";
            // 
            // cliente
            // 
            this.cliente.Controls.Add(this.btAlterarSala);
            this.cliente.Controls.Add(this.btRemoverSala);
            this.cliente.Controls.Add(this.btLimparCamposSala);
            this.cliente.Controls.Add(this.btNovoSala);
            this.cliente.Controls.Add(this.txtNumFilas);
            this.cliente.Controls.Add(this.txtNumColunas);
            this.cliente.Controls.Add(this.txtSala);
            this.cliente.Controls.Add(this.label7);
            this.cliente.Controls.Add(this.label6);
            this.cliente.Controls.Add(this.label5);
            this.cliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(24, 72);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(496, 217);
            this.cliente.TabIndex = 19;
            this.cliente.TabStop = false;
            this.cliente.Text = "Adicionar sala";
            // 
            // btAlterarSala
            // 
            this.btAlterarSala.BackColor = System.Drawing.Color.Gold;
            this.btAlterarSala.FlatAppearance.BorderSize = 0;
            this.btAlterarSala.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarSala.ForeColor = System.Drawing.Color.White;
            this.btAlterarSala.Location = new System.Drawing.Point(185, 168);
            this.btAlterarSala.Name = "btAlterarSala";
            this.btAlterarSala.Size = new System.Drawing.Size(133, 33);
            this.btAlterarSala.TabIndex = 22;
            this.btAlterarSala.Text = "Alterar";
            this.btAlterarSala.UseVisualStyleBackColor = false;
            this.btAlterarSala.Click += new System.EventHandler(this.btAlterarSala_Click);
            // 
            // btRemoverSala
            // 
            this.btRemoverSala.BackColor = System.Drawing.Color.Brown;
            this.btRemoverSala.FlatAppearance.BorderSize = 0;
            this.btRemoverSala.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverSala.ForeColor = System.Drawing.Color.White;
            this.btRemoverSala.Location = new System.Drawing.Point(338, 168);
            this.btRemoverSala.Name = "btRemoverSala";
            this.btRemoverSala.Size = new System.Drawing.Size(133, 33);
            this.btRemoverSala.TabIndex = 15;
            this.btRemoverSala.Text = "Remover";
            this.btRemoverSala.UseVisualStyleBackColor = false;
            this.btRemoverSala.Click += new System.EventHandler(this.btRemoverSala_Click);
            // 
            // btLimparCamposSala
            // 
            this.btLimparCamposSala.BackColor = System.Drawing.Color.RoyalBlue;
            this.btLimparCamposSala.FlatAppearance.BorderSize = 0;
            this.btLimparCamposSala.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparCamposSala.ForeColor = System.Drawing.Color.White;
            this.btLimparCamposSala.Location = new System.Drawing.Point(27, 168);
            this.btLimparCamposSala.Name = "btLimparCamposSala";
            this.btLimparCamposSala.Size = new System.Drawing.Size(133, 33);
            this.btLimparCamposSala.TabIndex = 21;
            this.btLimparCamposSala.Text = "Limpar campos";
            this.btLimparCamposSala.UseVisualStyleBackColor = false;
            this.btLimparCamposSala.Click += new System.EventHandler(this.btLimparCamposSala_Click);
            // 
            // btNovoSala
            // 
            this.btNovoSala.BackColor = System.Drawing.Color.ForestGreen;
            this.btNovoSala.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoSala.ForeColor = System.Drawing.Color.White;
            this.btNovoSala.Location = new System.Drawing.Point(338, 28);
            this.btNovoSala.Name = "btNovoSala";
            this.btNovoSala.Size = new System.Drawing.Size(133, 33);
            this.btNovoSala.TabIndex = 10;
            this.btNovoSala.Text = "Novo";
            this.btNovoSala.UseVisualStyleBackColor = false;
            this.btNovoSala.Click += new System.EventHandler(this.btNovoSala_Click);
            // 
            // txtNumFilas
            // 
            this.txtNumFilas.Location = new System.Drawing.Point(127, 121);
            this.txtNumFilas.Name = "txtNumFilas";
            this.txtNumFilas.Size = new System.Drawing.Size(191, 29);
            this.txtNumFilas.TabIndex = 7;
            // 
            // txtNumColunas
            // 
            this.txtNumColunas.Location = new System.Drawing.Point(127, 81);
            this.txtNumColunas.Name = "txtNumColunas";
            this.txtNumColunas.Size = new System.Drawing.Size(191, 29);
            this.txtNumColunas.TabIndex = 6;
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(127, 42);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(191, 29);
            this.txtSala.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nº de filas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nº de colunas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sala:";
            // 
            // listaSalas
            // 
            this.listaSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaSalas.Location = new System.Drawing.Point(24, 356);
            this.listaSalas.Name = "listaSalas";
            this.listaSalas.RowHeadersWidth = 51;
            this.listaSalas.Size = new System.Drawing.Size(554, 356);
            this.listaSalas.TabIndex = 21;
            this.listaSalas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listaSalas_CellMouseClick);
            // 
            // timer1
            // 
            this.timer1.Location = new System.Drawing.Point(877, 19);
            this.timer1.Margin = new System.Windows.Forms.Padding(4);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(254, 37);
            this.timer1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tabela Salas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.btAlterarCinema);
            this.groupBox1.Controls.Add(this.txtMorada);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(609, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 217);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Cinema";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 29);
            this.txtNome.TabIndex = 35;
            // 
            // btAlterarCinema
            // 
            this.btAlterarCinema.BackColor = System.Drawing.Color.Gold;
            this.btAlterarCinema.FlatAppearance.BorderSize = 0;
            this.btAlterarCinema.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarCinema.ForeColor = System.Drawing.Color.White;
            this.btAlterarCinema.Location = new System.Drawing.Point(191, 168);
            this.btAlterarCinema.Name = "btAlterarCinema";
            this.btAlterarCinema.Size = new System.Drawing.Size(133, 33);
            this.btAlterarCinema.TabIndex = 22;
            this.btAlterarCinema.Text = "Alterar";
            this.btAlterarCinema.UseVisualStyleBackColor = false;
            this.btAlterarCinema.Click += new System.EventHandler(this.btAlterarCinema_Click);
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(97, 73);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(297, 29);
            this.txtMorada.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 29);
            this.txtEmail.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 21);
            this.label10.TabIndex = 31;
            this.label10.Text = "Morada:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "Nome:";
            // 
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timer1);
            this.Controls.Add(this.listaSalas);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Cinema";
            this.Size = new System.Drawing.Size(1121, 733);
            this.cliente.ResumeLayout(false);
            this.cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSalas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox cliente;
        private System.Windows.Forms.TextBox txtNumFilas;
        private System.Windows.Forms.TextBox txtNumColunas;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btNovoSala;
        private System.Windows.Forms.Button btRemoverSala;
        private System.Windows.Forms.Button btAlterarSala;
        private System.Windows.Forms.Button btLimparCamposSala;
        private System.Windows.Forms.DataGridView listaSalas;
        private Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAlterarCinema;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
