﻿namespace CineGest.Views {
    partial class Timer {
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
            this.labelHoraDia = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelHoraDia
            // 
            this.labelHoraDia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraDia.Location = new System.Drawing.Point(3, 0);
            this.labelHoraDia.Name = "labelHoraDia";
            this.labelHoraDia.Size = new System.Drawing.Size(224, 38);
            this.labelHoraDia.TabIndex = 1;
            this.labelHoraDia.Text = "Tempo";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelHoraDia);
            this.Name = "Timer";
            this.Size = new System.Drawing.Size(224, 38);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHoraDia;
        private System.Windows.Forms.Timer timer1;
    }
}
