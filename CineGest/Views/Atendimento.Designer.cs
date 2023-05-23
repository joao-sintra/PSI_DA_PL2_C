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
            this.timer1 = new CineGest.Views.Timer();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.listaBilhetes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.GroupBox();
            this.txtMoradaCliente = new System.Windows.Forms.TextBox();
            this.txtNumFiscalCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.checkBoxAnonimoCliente = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listaClientes = new System.Windows.Forms.ListBox();
            this.txtPesquisaClientes = new System.Windows.Forms.TextBox();
            this.btAnularBilhete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cliente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEmitirBilhete
            // 
            this.btEmitirBilhete.BackColor = System.Drawing.Color.ForestGreen;
            this.btEmitirBilhete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmitirBilhete.ForeColor = System.Drawing.Color.White;
            this.btEmitirBilhete.Location = new System.Drawing.Point(572, 685);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tela";
            // 
            // btRemoverLugar
            // 
            this.btRemoverLugar.BackColor = System.Drawing.Color.Brown;
            this.btRemoverLugar.FlatAppearance.BorderSize = 0;
            this.btRemoverLugar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverLugar.ForeColor = System.Drawing.Color.White;
            this.btRemoverLugar.Location = new System.Drawing.Point(568, 343);
            this.btRemoverLugar.Name = "btRemoverLugar";
            this.btRemoverLugar.Size = new System.Drawing.Size(180, 30);
            this.btRemoverLugar.TabIndex = 7;
            this.btRemoverLugar.Text = "Remover";
            this.btRemoverLugar.UseVisualStyleBackColor = false;
            this.btRemoverLugar.Click += new System.EventHandler(this.btRemoverLugar_Click);
            // 
            // listaLugaresMarcados
            // 
            this.listaLugaresMarcados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaLugaresMarcados.FormattingEnabled = true;
            this.listaLugaresMarcados.ItemHeight = 21;
            this.listaLugaresMarcados.Location = new System.Drawing.Point(568, 123);
            this.listaLugaresMarcados.Name = "listaLugaresMarcados";
            this.listaLugaresMarcados.Size = new System.Drawing.Size(180, 214);
            this.listaLugaresMarcados.TabIndex = 6;
            // 
            // listViewLugares
            // 
            this.listViewLugares.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listViewLugares.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLugares.ForeColor = System.Drawing.Color.White;
            this.listViewLugares.GridLines = true;
            this.listViewLugares.HideSelection = false;
            this.listViewLugares.Location = new System.Drawing.Point(18, 102);
            this.listViewLugares.Name = "listViewLugares";
            this.listViewLugares.Size = new System.Drawing.Size(535, 271);
            this.listViewLugares.TabIndex = 5;
            this.listViewLugares.UseCompatibleStateImageBehavior = false;
            this.listViewLugares.View = System.Windows.Forms.View.Details;
            this.listViewLugares.SelectedIndexChanged += new System.EventHandler(this.listViewLugares_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Location = new System.Drawing.Point(894, 3);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(224, 38);
            this.timer1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Atendimento";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(393, 60);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sessão 01- Sala 01 Filme";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Brown;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(433, 686);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(133, 30);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // listaBilhetes
            // 
            this.listaBilhetes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaBilhetes.FormattingEnabled = true;
            this.listaBilhetes.ItemHeight = 21;
            this.listaBilhetes.Location = new System.Drawing.Point(18, 441);
            this.listaBilhetes.Name = "listaBilhetes";
            this.listaBilhetes.Size = new System.Drawing.Size(730, 193);
            this.listaBilhetes.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bilhetes";
            // 
            // cliente
            // 
            this.cliente.Controls.Add(this.txtMoradaCliente);
            this.cliente.Controls.Add(this.txtNumFiscalCliente);
            this.cliente.Controls.Add(this.txtNomeCliente);
            this.cliente.Controls.Add(this.checkBoxAnonimoCliente);
            this.cliente.Controls.Add(this.label7);
            this.cliente.Controls.Add(this.label6);
            this.cliente.Controls.Add(this.label5);
            this.cliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(798, 102);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(297, 235);
            this.cliente.TabIndex = 18;
            this.cliente.TabStop = false;
            this.cliente.Text = "Cliente";
            // 
            // txtMoradaCliente
            // 
            this.txtMoradaCliente.Location = new System.Drawing.Point(107, 120);
            this.txtMoradaCliente.Name = "txtMoradaCliente";
            this.txtMoradaCliente.Size = new System.Drawing.Size(174, 29);
            this.txtMoradaCliente.TabIndex = 7;
            // 
            // txtNumFiscalCliente
            // 
            this.txtNumFiscalCliente.Location = new System.Drawing.Point(107, 81);
            this.txtNumFiscalCliente.Name = "txtNumFiscalCliente";
            this.txtNumFiscalCliente.Size = new System.Drawing.Size(174, 29);
            this.txtNumFiscalCliente.TabIndex = 6;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(107, 44);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(174, 29);
            this.txtNomeCliente.TabIndex = 5;
            // 
            // checkBoxAnonimoCliente
            // 
            this.checkBoxAnonimoCliente.AutoSize = true;
            this.checkBoxAnonimoCliente.Location = new System.Drawing.Point(188, 194);
            this.checkBoxAnonimoCliente.Name = "checkBoxAnonimoCliente";
            this.checkBoxAnonimoCliente.Size = new System.Drawing.Size(93, 25);
            this.checkBoxAnonimoCliente.TabIndex = 4;
            this.checkBoxAnonimoCliente.Text = "Anônimo";
            this.checkBoxAnonimoCliente.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Morada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Num. Fiscal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listaClientes);
            this.groupBox2.Controls.Add(this.txtPesquisaClientes);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(798, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 360);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Clientes";
            // 
            // listaClientes
            // 
            this.listaClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaClientes.FormattingEnabled = true;
            this.listaClientes.ItemHeight = 21;
            this.listaClientes.Location = new System.Drawing.Point(29, 94);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Size = new System.Drawing.Size(252, 256);
            this.listaClientes.TabIndex = 21;
            // 
            // txtPesquisaClientes
            // 
            this.txtPesquisaClientes.Location = new System.Drawing.Point(29, 42);
            this.txtPesquisaClientes.Name = "txtPesquisaClientes";
            this.txtPesquisaClientes.Size = new System.Drawing.Size(252, 29);
            this.txtPesquisaClientes.TabIndex = 0;
            // 
            // btAnularBilhete
            // 
            this.btAnularBilhete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btAnularBilhete.FlatAppearance.BorderSize = 0;
            this.btAnularBilhete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnularBilhete.ForeColor = System.Drawing.Color.White;
            this.btAnularBilhete.Location = new System.Drawing.Point(23, 640);
            this.btAnularBilhete.Name = "btAnularBilhete";
            this.btAnularBilhete.Size = new System.Drawing.Size(133, 30);
            this.btAnularBilhete.TabIndex = 20;
            this.btAnularBilhete.Text = "Anular Bilhete";
            this.btAnularBilhete.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(567, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 30);
            this.label8.TabIndex = 21;
            this.label8.Text = "Lugares Marcados";
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btAnularBilhete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaBilhetes);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timer1);
            this.Controls.Add(this.btEmitirBilhete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemoverLugar);
            this.Controls.Add(this.listaLugaresMarcados);
            this.Controls.Add(this.listViewLugares);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Atendimento";
            this.Size = new System.Drawing.Size(1121, 733);
            this.cliente.ResumeLayout(false);
            this.cliente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEmitirBilhete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRemoverLugar;
        private System.Windows.Forms.ListBox listaLugaresMarcados;
        private System.Windows.Forms.ListView listViewLugares;
        private Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ListBox listaBilhetes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox cliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAnularBilhete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxAnonimoCliente;
        private System.Windows.Forms.TextBox txtMoradaCliente;
        private System.Windows.Forms.TextBox txtNumFiscalCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtPesquisaClientes;
        private System.Windows.Forms.ListBox listaClientes;
        private System.Windows.Forms.Label label8;
    }
}
