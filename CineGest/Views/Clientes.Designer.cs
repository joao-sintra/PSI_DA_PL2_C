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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btRemoverCliente = new System.Windows.Forms.Button();
            this.btAlterarCliente = new System.Windows.Forms.Button();
            this.btLimparCamposCliente = new System.Windows.Forms.Button();
            this.btNovoCliente = new System.Windows.Forms.Button();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new CineGest.Views.Timer();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListaClientes
            // 
            this.ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaClientes.Location = new System.Drawing.Point(329, 450);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(443, 259);
            this.ListaClientes.TabIndex = 41;
            this.ListaClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListaClientes_CellMouseClick);
            this.ListaClientes.DoubleClick += new System.EventHandler(this.ListaClientes_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtMorada);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btRemoverCliente);
            this.groupBox1.Controls.Add(this.btAlterarCliente);
            this.groupBox1.Controls.Add(this.btLimparCamposCliente);
            this.groupBox1.Controls.Add(this.btNovoCliente);
            this.groupBox1.Controls.Add(this.txtNif);
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 29);
            this.txtNome.TabIndex = 29;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(110, 118);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(297, 29);
            this.txtMorada.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(852, 253);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 44);
            this.textBox1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(651, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Total (Bilhetes):";
            // 
            // btRemoverCliente
            // 
            this.btRemoverCliente.BackColor = System.Drawing.Color.Brown;
            this.btRemoverCliente.FlatAppearance.BorderSize = 0;
            this.btRemoverCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverCliente.ForeColor = System.Drawing.Color.White;
            this.btRemoverCliente.Location = new System.Drawing.Point(330, 250);
            this.btRemoverCliente.Name = "btRemoverCliente";
            this.btRemoverCliente.Size = new System.Drawing.Size(133, 33);
            this.btRemoverCliente.TabIndex = 15;
            this.btRemoverCliente.Text = "Remover";
            this.btRemoverCliente.UseVisualStyleBackColor = false;
            this.btRemoverCliente.Click += new System.EventHandler(this.btRemoverCliente_Click);
            // 
            // btAlterarCliente
            // 
            this.btAlterarCliente.BackColor = System.Drawing.Color.Gold;
            this.btAlterarCliente.FlatAppearance.BorderSize = 0;
            this.btAlterarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarCliente.ForeColor = System.Drawing.Color.White;
            this.btAlterarCliente.Location = new System.Drawing.Point(179, 250);
            this.btAlterarCliente.Name = "btAlterarCliente";
            this.btAlterarCliente.Size = new System.Drawing.Size(133, 33);
            this.btAlterarCliente.TabIndex = 22;
            this.btAlterarCliente.Text = "Alterar";
            this.btAlterarCliente.UseVisualStyleBackColor = false;
            this.btAlterarCliente.Click += new System.EventHandler(this.btAlterarCliente_Click);
            // 
            // btLimparCamposCliente
            // 
            this.btLimparCamposCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btLimparCamposCliente.FlatAppearance.BorderSize = 0;
            this.btLimparCamposCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparCamposCliente.ForeColor = System.Drawing.Color.White;
            this.btLimparCamposCliente.Location = new System.Drawing.Point(30, 250);
            this.btLimparCamposCliente.Name = "btLimparCamposCliente";
            this.btLimparCamposCliente.Size = new System.Drawing.Size(133, 33);
            this.btLimparCamposCliente.TabIndex = 21;
            this.btLimparCamposCliente.Text = "Limpar campos";
            this.btLimparCamposCliente.UseVisualStyleBackColor = false;
            this.btLimparCamposCliente.Click += new System.EventHandler(this.btLimparCamposCliente_Click);
            // 
            // btNovoCliente
            // 
            this.btNovoCliente.BackColor = System.Drawing.Color.ForestGreen;
            this.btNovoCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoCliente.ForeColor = System.Drawing.Color.White;
            this.btNovoCliente.Location = new System.Drawing.Point(483, 250);
            this.btNovoCliente.Name = "btNovoCliente";
            this.btNovoCliente.Size = new System.Drawing.Size(120, 33);
            this.btNovoCliente.TabIndex = 10;
            this.btNovoCliente.Text = "Novo";
            this.btNovoCliente.UseVisualStyleBackColor = false;
            this.btNovoCliente.Click += new System.EventHandler(this.btNovoCliente_Click);
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(110, 156);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(297, 29);
            this.txtNif.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "NIF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Morada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 83);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tabela Clientes";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timer1);
            this.Controls.Add(this.label3);
            this.Name = "Clientes";
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
        private System.Windows.Forms.Button btRemoverCliente;
        private System.Windows.Forms.Button btAlterarCliente;
        private System.Windows.Forms.Button btLimparCamposCliente;
        private System.Windows.Forms.Button btNovoCliente;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Label label1;
    }
}
