namespace CineGest.Views {
    partial class Atendimento {
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
            this.btEmitirBilhete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btRemoverLugar = new System.Windows.Forms.Button();
            this.listaLugaresMarcados = new System.Windows.Forms.ListBox();
            this.listViewLugares = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btEmitirBilhete
            // 
            this.btEmitirBilhete.BackColor = System.Drawing.Color.ForestGreen;
            this.btEmitirBilhete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmitirBilhete.ForeColor = System.Drawing.Color.White;
            this.btEmitirBilhete.Location = new System.Drawing.Point(811, 564);
            this.btEmitirBilhete.Name = "btEmitirBilhete";
            this.btEmitirBilhete.Size = new System.Drawing.Size(179, 32);
            this.btEmitirBilhete.TabIndex = 9;
            this.btEmitirBilhete.Text = "Emitir Bilhete";
            this.btEmitirBilhete.UseVisualStyleBackColor = false;
            this.btEmitirBilhete.Click += new System.EventHandler(this.btEmitirBilhete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tela";
            // 
            // btRemoverLugar
            // 
            this.btRemoverLugar.BackColor = System.Drawing.Color.Brown;
            this.btRemoverLugar.FlatAppearance.BorderSize = 0;
            this.btRemoverLugar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverLugar.ForeColor = System.Drawing.Color.White;
            this.btRemoverLugar.Location = new System.Drawing.Point(745, 292);
            this.btRemoverLugar.Name = "btRemoverLugar";
            this.btRemoverLugar.Size = new System.Drawing.Size(83, 30);
            this.btRemoverLugar.TabIndex = 7;
            this.btRemoverLugar.Text = "Remover";
            this.btRemoverLugar.UseVisualStyleBackColor = false;
            this.btRemoverLugar.Click += new System.EventHandler(this.btRemoverLugar_Click);
            // 
            // listaLugaresMarcados
            // 
            this.listaLugaresMarcados.FormattingEnabled = true;
            this.listaLugaresMarcados.Location = new System.Drawing.Point(724, 71);
            this.listaLugaresMarcados.Name = "listaLugaresMarcados";
            this.listaLugaresMarcados.Size = new System.Drawing.Size(120, 199);
            this.listaLugaresMarcados.TabIndex = 6;
            // 
            // listViewLugares
            // 
            this.listViewLugares.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listViewLugares.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLugares.ForeColor = System.Drawing.Color.White;
            this.listViewLugares.GridLines = true;
            this.listViewLugares.HideSelection = false;
            this.listViewLugares.Location = new System.Drawing.Point(95, 71);
            this.listViewLugares.Name = "listViewLugares";
            this.listViewLugares.Size = new System.Drawing.Size(597, 371);
            this.listViewLugares.TabIndex = 5;
            this.listViewLugares.UseCompatibleStateImageBehavior = false;
            this.listViewLugares.View = System.Windows.Forms.View.Details;
            this.listViewLugares.SelectedIndexChanged += new System.EventHandler(this.listViewLugares_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bouas";
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btEmitirBilhete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemoverLugar);
            this.Controls.Add(this.listaLugaresMarcados);
            this.Controls.Add(this.listViewLugares);
            this.Name = "Atendimento";
            this.Size = new System.Drawing.Size(1066, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEmitirBilhete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRemoverLugar;
        private System.Windows.Forms.ListBox listaLugaresMarcados;
        private System.Windows.Forms.ListView listViewLugares;
        private System.Windows.Forms.Label label2;
    }
}
