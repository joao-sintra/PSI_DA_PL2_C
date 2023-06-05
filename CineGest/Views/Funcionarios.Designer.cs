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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.adicionarFunc = new System.Windows.Forms.GroupBox();
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaPessoas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new CineGest.Views.Timer();
            this.adicionarFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPessoas)).BeginInit();
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
            // adicionarFunc
            // 
            this.adicionarFunc.Controls.Add(this.btRemoverFun);
            this.adicionarFunc.Controls.Add(this.btAlterarFun);
            this.adicionarFunc.Controls.Add(this.txtFuncaoFun);
            this.adicionarFunc.Controls.Add(this.label1);
            this.adicionarFunc.Controls.Add(this.btLimparCamposFun);
            this.adicionarFunc.Controls.Add(this.btNovoFun);
            this.adicionarFunc.Controls.Add(this.txtSalarioFun);
            this.adicionarFunc.Controls.Add(this.txtMoradaFun);
            this.adicionarFunc.Controls.Add(this.txtNomeFun);
            this.adicionarFunc.Controls.Add(this.label7);
            this.adicionarFunc.Controls.Add(this.label6);
            this.adicionarFunc.Controls.Add(this.label5);
            this.adicionarFunc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarFunc.Location = new System.Drawing.Point(26, 77);
            this.adicionarFunc.Name = "adicionarFunc";
            this.adicionarFunc.Size = new System.Drawing.Size(478, 300);
            this.adicionarFunc.TabIndex = 23;
            this.adicionarFunc.TabStop = false;
            this.adicionarFunc.Text = "Adicionar funcionário";
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
            this.btRemoverFun.Click += new System.EventHandler(this.btRemoverFun_Click);
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
            this.btAlterarFun.Click += new System.EventHandler(this.btAlterarFun_Click);
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
            this.btLimparCamposFun.Click += new System.EventHandler(this.btLimparCamposFun_Click);
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
            this.listaFuncionarios.AutoGenerateColumns = false;
            this.listaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.funcaoDataGridViewTextBoxColumn,
            this.pessoaIdDataGridViewTextBoxColumn});
            this.listaFuncionarios.DataSource = this.funcionarioBindingSource;
            this.listaFuncionarios.Location = new System.Drawing.Point(416, 439);
            this.listaFuncionarios.Name = "listaFuncionarios";
            this.listaFuncionarios.RowHeadersWidth = 51;
            this.listaFuncionarios.Size = new System.Drawing.Size(453, 261);
            this.listaFuncionarios.TabIndex = 25;
            this.listaFuncionarios.DoubleClick += new System.EventHandler(this.listaFuncionarios_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            // 
            // funcaoDataGridViewTextBoxColumn
            // 
            this.funcaoDataGridViewTextBoxColumn.DataPropertyName = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.HeaderText = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.Name = "funcaoDataGridViewTextBoxColumn";
            // 
            // pessoaIdDataGridViewTextBoxColumn
            // 
            this.pessoaIdDataGridViewTextBoxColumn.DataPropertyName = "PessoaId";
            this.pessoaIdDataGridViewTextBoxColumn.HeaderText = "PessoaId";
            this.pessoaIdDataGridViewTextBoxColumn.Name = "pessoaIdDataGridViewTextBoxColumn";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(CineGest.Funcionario);
            // 
            // listaPessoas
            // 
            this.listaPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPessoas.Location = new System.Drawing.Point(26, 439);
            this.listaPessoas.Name = "listaPessoas";
            this.listaPessoas.RowHeadersWidth = 51;
            this.listaPessoas.Size = new System.Drawing.Size(355, 261);
            this.listaPessoas.TabIndex = 26;
            this.listaPessoas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listaPessoas_CellMouseClick);
            this.listaPessoas.DoubleClick += new System.EventHandler(this.listaPessoas_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tabela Pessoas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tabela Funcionários";
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaPessoas);
            this.Controls.Add(this.listaFuncionarios);
            this.Controls.Add(this.adicionarFunc);
            this.Controls.Add(this.timer1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Funcionarios";
            this.Size = new System.Drawing.Size(1121, 733);
            this.adicionarFunc.ResumeLayout(false);
            this.adicionarFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Timer timer1;
        private System.Windows.Forms.GroupBox adicionarFunc;
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
        private System.Windows.Forms.DataGridView listaPessoas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
    }
}
