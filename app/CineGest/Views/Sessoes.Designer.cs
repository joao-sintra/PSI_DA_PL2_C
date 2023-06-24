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
            this.label3 = new System.Windows.Forms.Label();
            this.ListaSessoes = new System.Windows.Forms.DataGridView();
            this.cliente = new System.Windows.Forms.GroupBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSalaS = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.cbFilmeS = new System.Windows.Forms.ComboBox();
            this.btRemoverSessao = new System.Windows.Forms.Button();
            this.btAlterarSessao = new System.Windows.Forms.Button();
            this.btLimparCamposSessao = new System.Windows.Forms.Button();
            this.btNovoSessao = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new CineGest.Views.Timer();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListaSessoes)).BeginInit();
            this.cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "Gestão de Sessões";
            // 
            // ListaSessoes
            // 
            this.ListaSessoes.AllowUserToAddRows = false;
            this.ListaSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaSessoes.Location = new System.Drawing.Point(292, 416);
            this.ListaSessoes.Name = "ListaSessoes";
            this.ListaSessoes.RowHeadersWidth = 62;
            this.ListaSessoes.Size = new System.Drawing.Size(565, 303);
            this.ListaSessoes.TabIndex = 37;
            this.ListaSessoes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListaSessoes_CellMouseClick_1);
            // 
            // cliente
            // 
            this.cliente.Controls.Add(this.txtPreco);
            this.cliente.Controls.Add(this.label2);
            this.cliente.Controls.Add(this.cbSalaS);
            this.cliente.Controls.Add(this.datePicker);
            this.cliente.Controls.Add(this.cbFilmeS);
            this.cliente.Controls.Add(this.btRemoverSessao);
            this.cliente.Controls.Add(this.btAlterarSessao);
            this.cliente.Controls.Add(this.btLimparCamposSessao);
            this.cliente.Controls.Add(this.btNovoSessao);
            this.cliente.Controls.Add(this.label7);
            this.cliente.Controls.Add(this.label6);
            this.cliente.Controls.Add(this.label5);
            this.cliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(25, 77);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(1055, 305);
            this.cliente.TabIndex = 36;
            this.cliente.TabStop = false;
            this.cliente.Text = "Adicionar Sessão";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(111, 158);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(227, 29);
            this.txtPreco.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Preço:";
            // 
            // cbSalaS
            // 
            this.cbSalaS.FormattingEnabled = true;
            this.cbSalaS.Location = new System.Drawing.Point(111, 68);
            this.cbSalaS.Name = "cbSalaS";
            this.cbSalaS.Size = new System.Drawing.Size(297, 29);
            this.cbSalaS.TabIndex = 27;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(561, 68);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(271, 29);
            this.datePicker.TabIndex = 41;
            this.datePicker.Value = new System.DateTime(2023, 6, 8, 5, 12, 0, 0);
            // 
            // cbFilmeS
            // 
            this.cbFilmeS.FormattingEnabled = true;
            this.cbFilmeS.Location = new System.Drawing.Point(111, 115);
            this.cbFilmeS.Name = "cbFilmeS";
            this.cbFilmeS.Size = new System.Drawing.Size(297, 29);
            this.cbFilmeS.TabIndex = 26;
            // 
            // btRemoverSessao
            // 
            this.btRemoverSessao.BackColor = System.Drawing.Color.Brown;
            this.btRemoverSessao.FlatAppearance.BorderSize = 0;
            this.btRemoverSessao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverSessao.ForeColor = System.Drawing.Color.White;
            this.btRemoverSessao.Location = new System.Drawing.Point(330, 250);
            this.btRemoverSessao.Name = "btRemoverSessao";
            this.btRemoverSessao.Size = new System.Drawing.Size(133, 33);
            this.btRemoverSessao.TabIndex = 15;
            this.btRemoverSessao.Text = "Remover";
            this.btRemoverSessao.UseVisualStyleBackColor = false;
            this.btRemoverSessao.Click += new System.EventHandler(this.btRemoverSessao_Click);
            // 
            // btAlterarSessao
            // 
            this.btAlterarSessao.BackColor = System.Drawing.Color.Gold;
            this.btAlterarSessao.FlatAppearance.BorderSize = 0;
            this.btAlterarSessao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarSessao.ForeColor = System.Drawing.Color.White;
            this.btAlterarSessao.Location = new System.Drawing.Point(179, 250);
            this.btAlterarSessao.Name = "btAlterarSessao";
            this.btAlterarSessao.Size = new System.Drawing.Size(133, 33);
            this.btAlterarSessao.TabIndex = 22;
            this.btAlterarSessao.Text = "Alterar";
            this.btAlterarSessao.UseVisualStyleBackColor = false;
            this.btAlterarSessao.Click += new System.EventHandler(this.btAlterarSessao_Click);
            // 
            // btLimparCamposSessao
            // 
            this.btLimparCamposSessao.BackColor = System.Drawing.Color.RoyalBlue;
            this.btLimparCamposSessao.FlatAppearance.BorderSize = 0;
            this.btLimparCamposSessao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparCamposSessao.ForeColor = System.Drawing.Color.White;
            this.btLimparCamposSessao.Location = new System.Drawing.Point(30, 250);
            this.btLimparCamposSessao.Name = "btLimparCamposSessao";
            this.btLimparCamposSessao.Size = new System.Drawing.Size(133, 33);
            this.btLimparCamposSessao.TabIndex = 21;
            this.btLimparCamposSessao.Text = "Limpar campos";
            this.btLimparCamposSessao.UseVisualStyleBackColor = false;
            this.btLimparCamposSessao.Click += new System.EventHandler(this.btLimparCamposSessao_Click);
            // 
            // btNovoSessao
            // 
            this.btNovoSessao.BackColor = System.Drawing.Color.ForestGreen;
            this.btNovoSessao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoSessao.ForeColor = System.Drawing.Color.White;
            this.btNovoSessao.Location = new System.Drawing.Point(498, 250);
            this.btNovoSessao.Name = "btNovoSessao";
            this.btNovoSessao.Size = new System.Drawing.Size(120, 33);
            this.btNovoSessao.TabIndex = 10;
            this.btNovoSessao.Text = "Nova";
            this.btNovoSessao.UseVisualStyleBackColor = false;
            this.btNovoSessao.Click += new System.EventHandler(this.btNovoSessao_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Filme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sala:";
            // 
            // timer1
            // 
            this.timer1.Location = new System.Drawing.Point(877, 19);
            this.timer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(224, 35);
            this.timer1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 30);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tabela Sessões";
            // 
            // Sessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListaSessoes);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.timer1);
            this.Name = "Sessoes";
            this.Size = new System.Drawing.Size(1121, 733);
            ((System.ComponentModel.ISupportInitialize)(this.ListaSessoes)).EndInit();
            this.cliente.ResumeLayout(false);
            this.cliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ListaSessoes;
        private System.Windows.Forms.GroupBox cliente;
        private System.Windows.Forms.Button btRemoverSessao;
        private System.Windows.Forms.Button btAlterarSessao;
        private System.Windows.Forms.Button btLimparCamposSessao;
        private System.Windows.Forms.Button btNovoSessao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Timer timer1;
        private System.Windows.Forms.ComboBox cbFilmeS;
        private System.Windows.Forms.ComboBox cbSalaS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label1;
    }
}
