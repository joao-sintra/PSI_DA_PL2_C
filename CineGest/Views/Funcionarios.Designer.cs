namespace CineGest.Views {
    partial class Funcionarios {
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
            this.btRemoverFun = new System.Windows.Forms.Button();
            this.btAlterarFun = new System.Windows.Forms.Button();
            this.txtFuncaoFun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btLimparCamposFun = new System.Windows.Forms.Button();
            this.btNovoFun = new System.Windows.Forms.Button();
            this.txtSalarioFun = new System.Windows.Forms.TextBox();
            this.txtMoradaFun = new System.Windows.Forms.TextBox();
            this.txtNomeFun = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listaFuncionarios = new System.Windows.Forms.DataGridView();
            this.timer1 = new CineGest.Views.Timer();
            this.cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gestão de Funcionários";
            // 
            // cliente
            // 
            this.cliente.Controls.Add(this.btRemoverFun);
            this.cliente.Controls.Add(this.btAlterarFun);
            this.cliente.Controls.Add(this.txtFuncaoFun);
            this.cliente.Controls.Add(this.label1);
            this.cliente.Controls.Add(this.btLimparCamposFun);
            this.cliente.Controls.Add(this.btNovoFun);
            this.cliente.Controls.Add(this.txtSalarioFun);
            this.cliente.Controls.Add(this.txtMoradaFun);
            this.cliente.Controls.Add(this.txtNomeFun);
            this.cliente.Controls.Add(this.label7);
            this.cliente.Controls.Add(this.label6);
            this.cliente.Controls.Add(this.label5);
            this.cliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(26, 77);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(478, 300);
            this.cliente.TabIndex = 23;
            this.cliente.TabStop = false;
            this.cliente.Text = "Adicionar funcionario";
            // 
            // btRemoverFun
            // 
            this.btRemoverFun.BackColor = System.Drawing.Color.Brown;
            this.btRemoverFun.FlatAppearance.BorderSize = 0;
            this.btRemoverFun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverFun.ForeColor = System.Drawing.Color.White;
            this.btRemoverFun.Location = new System.Drawing.Point(330, 250);
            this.btRemoverFun.Name = "btRemoverFun";
            this.btRemoverFun.Size = new System.Drawing.Size(133, 33);
            this.btRemoverFun.TabIndex = 15;
            this.btRemoverFun.Text = "Remover";
            this.btRemoverFun.UseVisualStyleBackColor = false;
            // 
            // btAlterarFun
            // 
            this.btAlterarFun.BackColor = System.Drawing.Color.Gold;
            this.btAlterarFun.FlatAppearance.BorderSize = 0;
            this.btAlterarFun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarFun.ForeColor = System.Drawing.Color.White;
            this.btAlterarFun.Location = new System.Drawing.Point(179, 250);
            this.btAlterarFun.Name = "btAlterarFun";
            this.btAlterarFun.Size = new System.Drawing.Size(133, 33);
            this.btAlterarFun.TabIndex = 22;
            this.btAlterarFun.Text = "Alterar";
            this.btAlterarFun.UseVisualStyleBackColor = false;
            // 
            // txtFuncaoFun
            // 
            this.txtFuncaoFun.Location = new System.Drawing.Point(111, 196);
            this.txtFuncaoFun.Name = "txtFuncaoFun";
            this.txtFuncaoFun.Size = new System.Drawing.Size(297, 29);
            this.txtFuncaoFun.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Função:";
            // 
            // btLimparCamposFun
            // 
            this.btLimparCamposFun.BackColor = System.Drawing.Color.RoyalBlue;
            this.btLimparCamposFun.FlatAppearance.BorderSize = 0;
            this.btLimparCamposFun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparCamposFun.ForeColor = System.Drawing.Color.White;
            this.btLimparCamposFun.Location = new System.Drawing.Point(30, 250);
            this.btLimparCamposFun.Name = "btLimparCamposFun";
            this.btLimparCamposFun.Size = new System.Drawing.Size(133, 33);
            this.btLimparCamposFun.TabIndex = 21;
            this.btLimparCamposFun.Text = "Limpar campos";
            this.btLimparCamposFun.UseVisualStyleBackColor = false;
            // 
            // btNovoFun
            // 
            this.btNovoFun.BackColor = System.Drawing.Color.ForestGreen;
            this.btNovoFun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoFun.ForeColor = System.Drawing.Color.White;
            this.btNovoFun.Location = new System.Drawing.Point(343, 28);
            this.btNovoFun.Name = "btNovoFun";
            this.btNovoFun.Size = new System.Drawing.Size(120, 33);
            this.btNovoFun.TabIndex = 10;
            this.btNovoFun.Text = "Novo";
            this.btNovoFun.UseVisualStyleBackColor = false;
            this.btNovoFun.Click += new System.EventHandler(this.btNovoFun_Click);
            // 
            // txtSalarioFun
            // 
            this.txtSalarioFun.Location = new System.Drawing.Point(111, 156);
            this.txtSalarioFun.Name = "txtSalarioFun";
            this.txtSalarioFun.Size = new System.Drawing.Size(297, 29);
            this.txtSalarioFun.TabIndex = 7;
            // 
            // txtMoradaFun
            // 
            this.txtMoradaFun.Location = new System.Drawing.Point(111, 116);
            this.txtMoradaFun.Name = "txtMoradaFun";
            this.txtMoradaFun.Size = new System.Drawing.Size(297, 29);
            this.txtMoradaFun.TabIndex = 6;
            // 
            // txtNomeFun
            // 
            this.txtNomeFun.Location = new System.Drawing.Point(111, 77);
            this.txtNomeFun.Name = "txtNomeFun";
            this.txtNomeFun.Size = new System.Drawing.Size(297, 29);
            this.txtNomeFun.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Salário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Morada:";
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
            // listaFuncionarios
            // 
            this.listaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaFuncionarios.Location = new System.Drawing.Point(26, 402);
            this.listaFuncionarios.Name = "listaFuncionarios";
            this.listaFuncionarios.RowHeadersWidth = 51;
            this.listaFuncionarios.Size = new System.Drawing.Size(555, 261);
            this.listaFuncionarios.TabIndex = 25;
            this.listaFuncionarios.DoubleClick += new System.EventHandler(this.listaFuncionarios_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Location = new System.Drawing.Point(872, 19);
            this.timer1.Margin = new System.Windows.Forms.Padding(4);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(221, 35);
            this.timer1.TabIndex = 22;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listaFuncionarios);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.timer1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Funcionarios";
            this.Size = new System.Drawing.Size(1121, 733);
            this.cliente.ResumeLayout(false);
            this.cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Timer timer1;
        private System.Windows.Forms.GroupBox cliente;
        private System.Windows.Forms.Button btRemoverFun;
        private System.Windows.Forms.Button btAlterarFun;
        private System.Windows.Forms.TextBox txtFuncaoFun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLimparCamposFun;
        private System.Windows.Forms.Button btNovoFun;
        private System.Windows.Forms.TextBox txtSalarioFun;
        private System.Windows.Forms.TextBox txtMoradaFun;
        private System.Windows.Forms.TextBox txtNomeFun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView listaFuncionarios;
    }
}
