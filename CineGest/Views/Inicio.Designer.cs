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
            this.timer1 = new CineGest.Views.Timer();
            this.label1 = new System.Windows.Forms.Label();
            this.labelQuantBilhetesHoje = new System.Windows.Forms.Label();
            this.listaSessoesDia = new System.Windows.Forms.ListBox();
            this.listaLotacaoPsessao = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelQuantBilhetesSemana = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Location = new System.Drawing.Point(897, 3);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(224, 38);
            this.timer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sessões";
            // 
            // labelQuantBilhetesHoje
            // 
            this.labelQuantBilhetesHoje.AutoSize = true;
            this.labelQuantBilhetesHoje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantBilhetesHoje.Location = new System.Drawing.Point(102, 104);
            this.labelQuantBilhetesHoje.Name = "labelQuantBilhetesHoje";
            this.labelQuantBilhetesHoje.Size = new System.Drawing.Size(28, 21);
            this.labelQuantBilhetesHoje.TabIndex = 3;
            this.labelQuantBilhetesHoje.Text = "45";
            // 
            // listaSessoesDia
            // 
            this.listaSessoesDia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaSessoesDia.FormattingEnabled = true;
            this.listaSessoesDia.ItemHeight = 21;
            this.listaSessoesDia.Items.AddRange(new object[] {
            ""});
            this.listaSessoesDia.Location = new System.Drawing.Point(31, 74);
            this.listaSessoesDia.Name = "listaSessoesDia";
            this.listaSessoesDia.Size = new System.Drawing.Size(1058, 151);
            this.listaSessoesDia.TabIndex = 5;
            // 
            // listaLotacaoPsessao
            // 
            this.listaLotacaoPsessao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaLotacaoPsessao.FormattingEnabled = true;
            this.listaLotacaoPsessao.ItemHeight = 21;
            this.listaLotacaoPsessao.Location = new System.Drawing.Point(483, 104);
            this.listaLotacaoPsessao.Name = "listaLotacaoPsessao";
            this.listaLotacaoPsessao.Size = new System.Drawing.Size(441, 151);
            this.listaLotacaoPsessao.TabIndex = 6;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelQuantBilhetesSemana);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listaLotacaoPsessao);
            this.panel1.Controls.Add(this.labelQuantBilhetesHoje);
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
            this.label2.Size = new System.Drawing.Size(144, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantidade Bilhetes Vendidos Hoje";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantidade Bilhetes Vendidos Semana";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuantBilhetesSemana
            // 
            this.labelQuantBilhetesSemana.AutoSize = true;
            this.labelQuantBilhetesSemana.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantBilhetesSemana.Location = new System.Drawing.Point(274, 104);
            this.labelQuantBilhetesSemana.Name = "labelQuantBilhetesSemana";
            this.labelQuantBilhetesSemana.Size = new System.Drawing.Size(37, 21);
            this.labelQuantBilhetesSemana.TabIndex = 8;
            this.labelQuantBilhetesSemana.Text = "532";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(610, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 46);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lotação da Sala por Sessão";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listaSessoesDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timer1);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(1121, 733);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelQuantBilhetesHoje;
        private System.Windows.Forms.ListBox listaSessoesDia;
        private System.Windows.Forms.ListBox listaLotacaoPsessao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQuantBilhetesSemana;
        private System.Windows.Forms.Label label6;
    }
}
