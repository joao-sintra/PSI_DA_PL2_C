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
            this.sidebar1 = new CineGest.Views.Sidebar();
            this.funcionarios1 = new CineGest.Views.Funcionarios();
            this.SuspendLayout();
            // 
            // sidebar1
            // 
            this.sidebar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.sidebar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebar1.Location = new System.Drawing.Point(0, 0);
            this.sidebar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebar1.Name = "sidebar1";
            this.sidebar1.Size = new System.Drawing.Size(255, 733);
            this.sidebar1.TabIndex = 0;
            // 
            // funcionarios1
            // 
            this.funcionarios1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionarios1.Location = new System.Drawing.Point(253, 0);
            this.funcionarios1.Name = "funcionarios1";
            this.funcionarios1.Size = new System.Drawing.Size(1121, 733);
            this.funcionarios1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 729);
            this.Controls.Add(this.funcionarios1);
            this.Controls.Add(this.sidebar1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineGest";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.Sidebar sidebar1;
        private Views.Funcionarios funcionarios1;
    }
}

