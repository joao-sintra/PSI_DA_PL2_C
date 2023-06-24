namespace CineGest.Views {
    partial class Inicio {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ListaSessoes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btMudarFuncionario = new System.Windows.Forms.Button();
            this.cbFuncionarios = new System.Windows.Forms.ComboBox();
            this.timer1 = new CineGest.Views.Timer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelQuantBilhetesMes = new System.Windows.Forms.Label();
            this.atendimento1 = new CineGest.Views.Atendimento();
            ((System.ComponentModel.ISupportInitialize)(this.ListaSessoes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sessões";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estatísticas";
            // 
            // ListaSessoes
            // 
            this.ListaSessoes.AllowUserToAddRows = false;
            this.ListaSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaSessoes.Location = new System.Drawing.Point(42, 77);
            this.ListaSessoes.Name = "ListaSessoes";
            this.ListaSessoes.RowHeadersWidth = 62;
            this.ListaSessoes.Size = new System.Drawing.Size(596, 136);
            this.ListaSessoes.TabIndex = 38;
            this.ListaSessoes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListaSessoes_CellMouseClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btMudarFuncionario);
            this.groupBox1.Controls.Add(this.cbFuncionarios);
            this.groupBox1.Controls.Add(this.timer1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.ListaSessoes);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, -13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 725);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // btMudarFuncionario
            // 
            this.btMudarFuncionario.Location = new System.Drawing.Point(266, 21);
            this.btMudarFuncionario.Name = "btMudarFuncionario";
            this.btMudarFuncionario.Size = new System.Drawing.Size(129, 23);
            this.btMudarFuncionario.TabIndex = 42;
            this.btMudarFuncionario.Text = "Mudar Funcionário";
            this.btMudarFuncionario.UseVisualStyleBackColor = true;
            this.btMudarFuncionario.Click += new System.EventHandler(this.btMudarFuncionario_Click);
            // 
            // cbFuncionarios
            // 
            this.cbFuncionarios.FormattingEnabled = true;
            this.cbFuncionarios.Location = new System.Drawing.Point(48, 21);
            this.cbFuncionarios.Name = "cbFuncionarios";
            this.cbFuncionarios.Size = new System.Drawing.Size(214, 21);
            this.cbFuncionarios.TabIndex = 41;
            // 
            // timer1
            // 
            this.timer1.Location = new System.Drawing.Point(877, 19);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(224, 38);
            this.timer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelQuantBilhetesMes);
            this.panel1.Location = new System.Drawing.Point(42, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 362);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 83);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantidade Bilhetes Vendidos este Mês";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuantBilhetesMes
            // 
            this.labelQuantBilhetesMes.AutoSize = true;
            this.labelQuantBilhetesMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantBilhetesMes.Location = new System.Drawing.Point(100, 138);
            this.labelQuantBilhetesMes.Name = "labelQuantBilhetesMes";
            this.labelQuantBilhetesMes.Size = new System.Drawing.Size(19, 21);
            this.labelQuantBilhetesMes.TabIndex = 3;
            this.labelQuantBilhetesMes.Text = "0";
            // 
            // atendimento1
            // 
            this.atendimento1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atendimento1.Location = new System.Drawing.Point(0, 0);
            this.atendimento1.Name = "atendimento1";
            this.atendimento1.Size = new System.Drawing.Size(1121, 733);
            this.atendimento1.TabIndex = 39;
            this.atendimento1.Visible = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.atendimento1);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(1121, 733);
            ((System.ComponentModel.ISupportInitialize)(this.ListaSessoes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ListaSessoes;
        private Atendimento atendimento1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFuncionarios;
        private System.Windows.Forms.Button btMudarFuncionario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelQuantBilhetesMes;
    }
}
