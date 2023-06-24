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
            this.components = new System.ComponentModel.Container();
            this.btEmitirBilhete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listaLugaresMarcados = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelInformacoesSessao = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.cliente = new System.Windows.Forms.GroupBox();
            this.btLimparCamposCliente = new System.Windows.Forms.Button();
            this.txtMoradaCliente = new System.Windows.Forms.TextBox();
            this.txtNumFiscalCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.checkBoxAnonimoCliente = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListaClientes = new System.Windows.Forms.DataGridView();
            this.txtPesquisaClientes = new System.Windows.Forms.TextBox();
            this.btAnularBilhete = new System.Windows.Forms.Button();
            this.lugares = new System.Windows.Forms.TableLayoutPanel();
            this.listaBilhetes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clienteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SessaoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilheteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new CineGest.Views.Timer();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilheteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cliente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBilhetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilheteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilheteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btEmitirBilhete
            // 
            this.btEmitirBilhete.BackColor = System.Drawing.Color.ForestGreen;
            this.btEmitirBilhete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmitirBilhete.ForeColor = System.Drawing.Color.White;
            this.btEmitirBilhete.Location = new System.Drawing.Point(519, 686);
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
            this.label1.Location = new System.Drawing.Point(355, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tela";
            // 
            // listaLugaresMarcados
            // 
            this.listaLugaresMarcados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaLugaresMarcados.FormattingEnabled = true;
            this.listaLugaresMarcados.ItemHeight = 21;
            this.listaLugaresMarcados.Location = new System.Drawing.Point(740, 102);
            this.listaLugaresMarcados.Name = "listaLugaresMarcados";
            this.listaLugaresMarcados.Size = new System.Drawing.Size(44, 277);
            this.listaLugaresMarcados.TabIndex = 6;
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
            // LabelInformacoesSessao
            // 
            this.LabelInformacoesSessao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInformacoesSessao.Location = new System.Drawing.Point(198, 3);
            this.LabelInformacoesSessao.Name = "LabelInformacoesSessao";
            this.LabelInformacoesSessao.Size = new System.Drawing.Size(690, 60);
            this.LabelInformacoesSessao.TabIndex = 13;
            this.LabelInformacoesSessao.Text = "Sessão 01- Sala 01 Filme";
            this.LabelInformacoesSessao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Brown;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(385, 687);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(133, 30);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // cliente
            // 
            this.cliente.Controls.Add(this.btLimparCamposCliente);
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
            this.cliente.Size = new System.Drawing.Size(297, 277);
            this.cliente.TabIndex = 18;
            this.cliente.TabStop = false;
            this.cliente.Text = "Cliente";
            // 
            // btLimparCamposCliente
            // 
            this.btLimparCamposCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btLimparCamposCliente.FlatAppearance.BorderSize = 0;
            this.btLimparCamposCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparCamposCliente.ForeColor = System.Drawing.Color.White;
            this.btLimparCamposCliente.Location = new System.Drawing.Point(10, 230);
            this.btLimparCamposCliente.Name = "btLimparCamposCliente";
            this.btLimparCamposCliente.Size = new System.Drawing.Size(133, 33);
            this.btLimparCamposCliente.TabIndex = 22;
            this.btLimparCamposCliente.Text = "Limpar campos";
            this.btLimparCamposCliente.UseVisualStyleBackColor = false;
            this.btLimparCamposCliente.Click += new System.EventHandler(this.btLimparCamposCliente_Click);
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
            this.checkBoxAnonimoCliente.Location = new System.Drawing.Point(188, 235);
            this.checkBoxAnonimoCliente.Name = "checkBoxAnonimoCliente";
            this.checkBoxAnonimoCliente.Size = new System.Drawing.Size(93, 25);
            this.checkBoxAnonimoCliente.TabIndex = 4;
            this.checkBoxAnonimoCliente.Text = "Anônimo";
            this.checkBoxAnonimoCliente.UseVisualStyleBackColor = true;
            this.checkBoxAnonimoCliente.CheckedChanged += new System.EventHandler(this.checkBoxAnonimoCliente_CheckedChanged);
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
            this.groupBox2.Controls.Add(this.ListaClientes);
            this.groupBox2.Controls.Add(this.txtPesquisaClientes);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(704, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 308);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Clientes";
            // 
            // ListaClientes
            // 
            this.ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaClientes.Location = new System.Drawing.Point(20, 87);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(355, 227);
            this.ListaClientes.TabIndex = 42;
            this.ListaClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListaClientes_CellMouseClick);
            // 
            // txtPesquisaClientes
            // 
            this.txtPesquisaClientes.Location = new System.Drawing.Point(29, 42);
            this.txtPesquisaClientes.Name = "txtPesquisaClientes";
            this.txtPesquisaClientes.Size = new System.Drawing.Size(346, 29);
            this.txtPesquisaClientes.TabIndex = 0;
            this.txtPesquisaClientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisaClientes_KeyDown);
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
            this.btAnularBilhete.Click += new System.EventHandler(this.btAnularBilhete_Click);
            // 
            // lugares
            // 
            this.lugares.ColumnCount = 1;
            this.lugares.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.lugares.Location = new System.Drawing.Point(23, 102);
            this.lugares.Name = "lugares";
            this.lugares.RowCount = 1;
            this.lugares.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lugares.Size = new System.Drawing.Size(711, 277);
            this.lugares.TabIndex = 22;
            // 
            // listaBilhetes
            // 
            this.listaBilhetes.AutoGenerateColumns = false;
            this.listaBilhetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaBilhetes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lugarDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.clienteIDDataGridViewTextBoxColumn,
            this.funcionarioIDDataGridViewTextBoxColumn,
            this.SessaoID});
            this.listaBilhetes.DataSource = this.bilheteBindingSource1;
            this.listaBilhetes.Location = new System.Drawing.Point(23, 443);
            this.listaBilhetes.Name = "listaBilhetes";
            this.listaBilhetes.Size = new System.Drawing.Size(645, 191);
            this.listaBilhetes.TabIndex = 24;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // lugarDataGridViewTextBoxColumn
            // 
            this.lugarDataGridViewTextBoxColumn.DataPropertyName = "Lugar";
            this.lugarDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarDataGridViewTextBoxColumn.Name = "lugarDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clienteIDDataGridViewTextBoxColumn
            // 
            this.clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            // 
            // funcionarioIDDataGridViewTextBoxColumn
            // 
            this.funcionarioIDDataGridViewTextBoxColumn.DataPropertyName = "FuncionarioID";
            this.funcionarioIDDataGridViewTextBoxColumn.HeaderText = "Funcionario";
            this.funcionarioIDDataGridViewTextBoxColumn.Name = "funcionarioIDDataGridViewTextBoxColumn";
            // 
            // SessaoID
            // 
            this.SessaoID.DataPropertyName = "SessaoID";
            this.SessaoID.HeaderText = "Sessao";
            this.SessaoID.Name = "SessaoID";
            // 
            // bilheteBindingSource1
            // 
            this.bilheteBindingSource1.DataSource = typeof(CineGest.Bilhete);
            // 
            // timer1
            // 
            this.timer1.Location = new System.Drawing.Point(877, 19);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(224, 38);
            this.timer1.TabIndex = 11;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SessaoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sessao";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // bilheteBindingSource
            // 
            this.bilheteBindingSource.DataSource = typeof(CineGest.Bilhete);
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listaBilhetes);
            this.Controls.Add(this.lugares);
            this.Controls.Add(this.btAnularBilhete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.LabelInformacoesSessao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timer1);
            this.Controls.Add(this.btEmitirBilhete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaLugaresMarcados);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Atendimento";
            this.Size = new System.Drawing.Size(1121, 733);
            this.cliente.ResumeLayout(false);
            this.cliente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBilhetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilheteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilheteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEmitirBilhete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaLugaresMarcados;
        private Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelInformacoesSessao;
        private System.Windows.Forms.Button btCancelar;
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
        private System.Windows.Forms.TableLayoutPanel lugares;
        private System.Windows.Forms.DataGridView ListaClientes;
        private System.Windows.Forms.Button btLimparCamposCliente;
        private System.Windows.Forms.DataGridView listaBilhetes;
        private System.Windows.Forms.BindingSource bilheteBindingSource;
        private System.Windows.Forms.BindingSource bilheteBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessaoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
