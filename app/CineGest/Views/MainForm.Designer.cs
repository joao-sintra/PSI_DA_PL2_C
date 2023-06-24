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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sideBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCinema = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFilmes = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSessoes = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFuncionarios = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.inicio1 = new CineGest.Views.Inicio();
            this.filmes1 = new CineGest.Views.Filmes();
            this.funcionarios1 = new CineGest.Views.Funcionarios();
            this.clientes1 = new CineGest.Views.Clientes();
            this.cinema1 = new CineGest.Views.Cinema();
            this.sessoes1 = new CineGest.Views.Sessoes();
            this.sideBar.SuspendLayout();
            this.panelInicio.SuspendLayout();
            this.panelCinema.SuspendLayout();
            this.panelFilmes.SuspendLayout();
            this.panelSessoes.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panelFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.sideBar.Controls.Add(this.label1);
            this.sideBar.Controls.Add(this.panelInicio);
            this.sideBar.Controls.Add(this.panelCinema);
            this.sideBar.Controls.Add(this.panelFilmes);
            this.sideBar.Controls.Add(this.panelSessoes);
            this.sideBar.Controls.Add(this.panelClientes);
            this.sideBar.Controls.Add(this.panelFuncionarios);
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(255, 733);
            this.sideBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::CineGest.Properties.Resources.icons8_theatre_mask_701;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "CineGest";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInicio.Controls.Add(this.label2);
            this.panelInicio.Location = new System.Drawing.Point(3, 127);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(248, 64);
            this.panelInicio.TabIndex = 5;
            this.panelInicio.Click += new System.EventHandler(this.panelInicio_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::CineGest.Properties.Resources.icons8_página_inicial_48;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Início";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.panelInicio_Click);
            // 
            // panelCinema
            // 
            this.panelCinema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCinema.Controls.Add(this.label3);
            this.panelCinema.Location = new System.Drawing.Point(3, 197);
            this.panelCinema.Name = "panelCinema";
            this.panelCinema.Size = new System.Drawing.Size(248, 64);
            this.panelCinema.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::CineGest.Properties.Resources.icons8_movie_48;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cinema";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.panelCinema_Click);
            // 
            // panelFilmes
            // 
            this.panelFilmes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilmes.Controls.Add(this.label4);
            this.panelFilmes.Location = new System.Drawing.Point(3, 267);
            this.panelFilmes.Name = "panelFilmes";
            this.panelFilmes.Size = new System.Drawing.Size(248, 64);
            this.panelFilmes.TabIndex = 7;
            this.panelFilmes.Click += new System.EventHandler(this.panelFilmes_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = global::CineGest.Properties.Resources.icons8_movie_ticket_48;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "Filmes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.panelFilmes_Click);
            // 
            // panelSessoes
            // 
            this.panelSessoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSessoes.Controls.Add(this.label5);
            this.panelSessoes.Location = new System.Drawing.Point(3, 337);
            this.panelSessoes.Name = "panelSessoes";
            this.panelSessoes.Size = new System.Drawing.Size(248, 64);
            this.panelSessoes.TabIndex = 8;
            this.panelSessoes.Click += new System.EventHandler(this.panelSessoes_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = global::CineGest.Properties.Resources.icons8_movie_theater_48;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sessões";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.panelSessoes_Click);
            // 
            // panelClientes
            // 
            this.panelClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientes.Controls.Add(this.label6);
            this.panelClientes.Location = new System.Drawing.Point(3, 407);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(248, 64);
            this.panelClientes.TabIndex = 9;
            this.panelClientes.Click += new System.EventHandler(this.panelClientes_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = global::CineGest.Properties.Resources.icons8_client_48;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 46);
            this.label6.TabIndex = 0;
            this.label6.Text = "Clientes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.panelClientes_Click);
            // 
            // panelFuncionarios
            // 
            this.panelFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuncionarios.Controls.Add(this.label7);
            this.panelFuncionarios.Location = new System.Drawing.Point(3, 477);
            this.panelFuncionarios.Name = "panelFuncionarios";
            this.panelFuncionarios.Size = new System.Drawing.Size(248, 64);
            this.panelFuncionarios.TabIndex = 10;
            this.panelFuncionarios.Click += new System.EventHandler(this.panelFuncionarios_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = global::CineGest.Properties.Resources.icons8_permanent_job_48;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(8, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "Funcionários";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.panelFuncionarios_Click);
            // 
            // inicio1
            // 
            this.inicio1.Location = new System.Drawing.Point(255, 0);
            this.inicio1.Name = "inicio1";
            this.inicio1.Size = new System.Drawing.Size(1121, 733);
            this.inicio1.TabIndex = 10;
            // 
            // filmes1
            // 
            this.filmes1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmes1.Location = new System.Drawing.Point(255, 0);
            this.filmes1.Name = "filmes1";
            this.filmes1.Size = new System.Drawing.Size(1121, 733);
            this.filmes1.TabIndex = 9;
            // 
            // funcionarios1
            // 
            this.funcionarios1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionarios1.Location = new System.Drawing.Point(255, 0);
            this.funcionarios1.Name = "funcionarios1";
            this.funcionarios1.Size = new System.Drawing.Size(1121, 733);
            this.funcionarios1.TabIndex = 8;
            // 
            // clientes1
            // 
            this.clientes1.Location = new System.Drawing.Point(255, 0);
            this.clientes1.Name = "clientes1";
            this.clientes1.Size = new System.Drawing.Size(1121, 733);
            this.clientes1.TabIndex = 7;
            // 
            // cinema1
            // 
            this.cinema1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinema1.Location = new System.Drawing.Point(257, 0);
            this.cinema1.Name = "cinema1";
            this.cinema1.Size = new System.Drawing.Size(1121, 733);
            this.cinema1.TabIndex = 5;
            // 
            // sessoes1
            // 
            this.sessoes1.Location = new System.Drawing.Point(257, 0);
            this.sessoes1.Name = "sessoes1";
            this.sessoes1.Size = new System.Drawing.Size(1121, 733);
            this.sessoes1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 729);
            this.Controls.Add(this.inicio1);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.filmes1);
            this.Controls.Add(this.funcionarios1);
            this.Controls.Add(this.clientes1);
            this.Controls.Add(this.cinema1);
            this.Controls.Add(this.sessoes1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1378, 768);
            this.MinimumSize = new System.Drawing.Size(1378, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineGest";
            this.sideBar.ResumeLayout(false);
            this.panelInicio.ResumeLayout(false);
            this.panelCinema.ResumeLayout(false);
            this.panelFilmes.ResumeLayout(false);
            this.panelSessoes.ResumeLayout(false);
            this.panelClientes.ResumeLayout(false);
            this.panelFuncionarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCinema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelFilmes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelSessoes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelFuncionarios;
        private System.Windows.Forms.Label label7;
       
        private Views.Sessoes sessoes1;
        private Views.Cinema cinema1;
        private Views.Clientes clientes1;
        private Views.Funcionarios funcionarios1;
        private Views.Filmes filmes1;
        private Views.Inicio inicio1;
    }
}

