namespace CineGest {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listViewLugares = new System.Windows.Forms.ListView();
            this.listaLugaresMarcados = new System.Windows.Forms.ListBox();
            this.btRemoverLugar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btEmitirBilhete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewLugares
            // 
            this.listViewLugares.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listViewLugares.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLugares.ForeColor = System.Drawing.Color.White;
            this.listViewLugares.GridLines = true;
            this.listViewLugares.HideSelection = false;
            this.listViewLugares.Location = new System.Drawing.Point(210, 95);
            this.listViewLugares.Name = "listViewLugares";
            this.listViewLugares.Size = new System.Drawing.Size(597, 371);
            this.listViewLugares.TabIndex = 0;
            this.listViewLugares.UseCompatibleStateImageBehavior = false;
            this.listViewLugares.View = System.Windows.Forms.View.Details;
            this.listViewLugares.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listaLugaresMarcados
            // 
            this.listaLugaresMarcados.FormattingEnabled = true;
            this.listaLugaresMarcados.Location = new System.Drawing.Point(839, 95);
            this.listaLugaresMarcados.Name = "listaLugaresMarcados";
            this.listaLugaresMarcados.Size = new System.Drawing.Size(120, 199);
            this.listaLugaresMarcados.TabIndex = 1;
            // 
            // btRemoverLugar
            // 
            this.btRemoverLugar.BackColor = System.Drawing.Color.Brown;
            this.btRemoverLugar.FlatAppearance.BorderSize = 0;
            this.btRemoverLugar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverLugar.ForeColor = System.Drawing.Color.White;
            this.btRemoverLugar.Location = new System.Drawing.Point(860, 316);
            this.btRemoverLugar.Name = "btRemoverLugar";
            this.btRemoverLugar.Size = new System.Drawing.Size(83, 30);
            this.btRemoverLugar.TabIndex = 2;
            this.btRemoverLugar.Text = "Remover";
            this.btRemoverLugar.UseVisualStyleBackColor = false;
            this.btRemoverLugar.Click += new System.EventHandler(this.buttonRemoverLugar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tela";
            // 
            // btEmitirBilhete
            // 
            this.btEmitirBilhete.BackColor = System.Drawing.Color.ForestGreen;
            this.btEmitirBilhete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmitirBilhete.ForeColor = System.Drawing.Color.White;
            this.btEmitirBilhete.Location = new System.Drawing.Point(926, 588);
            this.btEmitirBilhete.Name = "btEmitirBilhete";
            this.btEmitirBilhete.Size = new System.Drawing.Size(179, 32);
            this.btEmitirBilhete.TabIndex = 4;
            this.btEmitirBilhete.Text = "Emitir Bilhete";
            this.btEmitirBilhete.UseVisualStyleBackColor = false;
            this.btEmitirBilhete.Click += new System.EventHandler(this.btEmitirBilhete_Click);
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 729);
            this.Controls.Add(this.btEmitirBilhete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemoverLugar);
            this.Controls.Add(this.listaLugaresMarcados);
            this.Controls.Add(this.listViewLugares);
            this.Name = "Atendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewLugares;
        private System.Windows.Forms.ListBox listaLugaresMarcados;
        private System.Windows.Forms.Button btRemoverLugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEmitirBilhete;
    }
}

