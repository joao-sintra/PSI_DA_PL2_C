namespace CineGest {
    partial class MainForm {
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
            this.inicio1 = new CineGest.Views.Inicio();
            this.atendimento1 = new CineGest.Views.Atendimento();
            this.sidebar1 = new CineGest.Views.Sidebar();
            this.SuspendLayout();
            // 
            // inicio1
            // 
            this.inicio1.Location = new System.Drawing.Point(246, -2);
            this.inicio1.Name = "inicio1";
            this.inicio1.Size = new System.Drawing.Size(1121, 733);
            this.inicio1.TabIndex = 2;
            // 
            // atendimento1
            // 
            this.atendimento1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atendimento1.Location = new System.Drawing.Point(246, -2);
            this.atendimento1.Name = "atendimento1";
            this.atendimento1.Size = new System.Drawing.Size(1121, 733);
            this.atendimento1.TabIndex = 1;
            // 
            // sidebar1
            // 
            this.sidebar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.sidebar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebar1.Location = new System.Drawing.Point(0, 0);
            this.sidebar1.Name = "sidebar1";
            this.sidebar1.Size = new System.Drawing.Size(255, 733);
            this.sidebar1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 729);
            this.Controls.Add(this.atendimento1);
            this.Controls.Add(this.inicio1);
            this.Controls.Add(this.sidebar1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineGest";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.Sidebar sidebar1;
        private Views.Atendimento atendimento1;
        private Views.Inicio inicio1;
    }
}

