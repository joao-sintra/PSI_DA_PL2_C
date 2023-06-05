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
            this.cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSalas)).BeginInit();
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
            this.listaSalas.DoubleClick += new System.EventHandler(this.listaSalas_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Location = new System.Drawing.Point(851, 18);
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
            // Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
