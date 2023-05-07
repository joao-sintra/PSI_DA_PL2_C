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
            this.buttonRemoverLugar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewLugares
            // 
            this.listViewLugares.HideSelection = false;
            this.listViewLugares.Location = new System.Drawing.Point(296, 95);
            this.listViewLugares.Name = "listViewLugares";
            this.listViewLugares.Size = new System.Drawing.Size(426, 371);
            this.listViewLugares.TabIndex = 0;
            this.listViewLugares.UseCompatibleStateImageBehavior = false;
            this.listViewLugares.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listaLugaresMarcados
            // 
            this.listaLugaresMarcados.FormattingEnabled = true;
            this.listaLugaresMarcados.Location = new System.Drawing.Point(755, 67);
            this.listaLugaresMarcados.Name = "listaLugaresMarcados";
            this.listaLugaresMarcados.Size = new System.Drawing.Size(120, 199);
            this.listaLugaresMarcados.TabIndex = 1;
            // 
            // buttonRemoverLugar
            // 
            this.buttonRemoverLugar.Location = new System.Drawing.Point(779, 272);
            this.buttonRemoverLugar.Name = "buttonRemoverLugar";
            this.buttonRemoverLugar.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoverLugar.TabIndex = 2;
            this.buttonRemoverLugar.Text = "Remover";
            this.buttonRemoverLugar.UseVisualStyleBackColor = true;
            this.buttonRemoverLugar.Click += new System.EventHandler(this.buttonRemoverLugar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tela";
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoverLugar);
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
        private System.Windows.Forms.Button buttonRemoverLugar;
        private System.Windows.Forms.Label label1;
    }
}

