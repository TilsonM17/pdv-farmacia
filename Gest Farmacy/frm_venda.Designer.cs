namespace M17
{
    partial class frm_venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_venda));
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_total_compra = new System.Windows.Forms.Label();
            this.txt_pagamento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_troco = new System.Windows.Forms.Label();
            this.preco_unitario = new System.Windows.Forms.GroupBox();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.label_venda = new System.Windows.Forms.Label();
            this.btn_venda = new System.Windows.Forms.Button();
            this.tabela_dados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_count = new System.Windows.Forms.Label();
            this.label_registros = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.preco_unitario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(182, 315);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(180, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nome do Cliente:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "Total:";
            // 
            // label_total_compra
            // 
            this.label_total_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_compra.ForeColor = System.Drawing.Color.Red;
            this.label_total_compra.Location = new System.Drawing.Point(41, 517);
            this.label_total_compra.Name = "label_total_compra";
            this.label_total_compra.Size = new System.Drawing.Size(149, 46);
            this.label_total_compra.TabIndex = 42;
            this.label_total_compra.Text = "000,000";
            this.label_total_compra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pagamento
            // 
            this.txt_pagamento.Location = new System.Drawing.Point(182, 354);
            this.txt_pagamento.Name = "txt_pagamento";
            this.txt_pagamento.Size = new System.Drawing.Size(180, 20);
            this.txt_pagamento.TabIndex = 2;
            this.txt_pagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pagamento.TextChanged += new System.EventHandler(this.txt_pagamento_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "Troco:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Pagamento:";
            // 
            // label_troco
            // 
            this.label_troco.AutoSize = true;
            this.label_troco.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_troco.ForeColor = System.Drawing.Color.Red;
            this.label_troco.Location = new System.Drawing.Point(281, 532);
            this.label_troco.Name = "label_troco";
            this.label_troco.Size = new System.Drawing.Size(76, 24);
            this.label_troco.TabIndex = 53;
            this.label_troco.Text = "000,00";
            // 
            // preco_unitario
            // 
            this.preco_unitario.Controls.Add(this.rbD);
            this.preco_unitario.Controls.Add(this.rbC);
            this.preco_unitario.Location = new System.Drawing.Point(385, 315);
            this.preco_unitario.Name = "preco_unitario";
            this.preco_unitario.Size = new System.Drawing.Size(141, 81);
            this.preco_unitario.TabIndex = 3;
            this.preco_unitario.TabStop = false;
            this.preco_unitario.Text = "Metodo de Pagamento:";
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Checked = true;
            this.rbD.Location = new System.Drawing.Point(25, 58);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(64, 17);
            this.rbD.TabIndex = 1;
            this.rbD.TabStop = true;
            this.rbD.Text = "Dinheiro";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(25, 19);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(56, 17);
            this.rbC.TabIndex = 0;
            this.rbC.Text = "Cartão";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // label_venda
            // 
            this.label_venda.AutoSize = true;
            this.label_venda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_venda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_venda.Location = new System.Drawing.Point(206, 28);
            this.label_venda.Name = "label_venda";
            this.label_venda.Size = new System.Drawing.Size(22, 16);
            this.label_venda.TabIndex = 52;
            this.label_venda.Text = "xx";
            // 
            // btn_venda
            // 
            this.btn_venda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_venda.Enabled = false;
            this.btn_venda.FlatAppearance.BorderSize = 0;
            this.btn_venda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venda.ForeColor = System.Drawing.Color.White;
            this.btn_venda.Image = ((System.Drawing.Image)(resources.GetObject("btn_venda.Image")));
            this.btn_venda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_venda.Location = new System.Drawing.Point(604, 315);
            this.btn_venda.Name = "btn_venda";
            this.btn_venda.Size = new System.Drawing.Size(194, 64);
            this.btn_venda.TabIndex = 4;
            this.btn_venda.Text = "Efectuar Venda";
            this.btn_venda.UseVisualStyleBackColor = false;
            this.btn_venda.Click += new System.EventHandler(this.btn_venda_Click);
            // 
            // tabela_dados
            // 
            this.tabela_dados.AllowUserToAddRows = false;
            this.tabela_dados.AllowUserToDeleteRows = false;
            this.tabela_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabela_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_dados.Location = new System.Drawing.Point(252, 28);
            this.tabela_dados.MultiSelect = false;
            this.tabela_dados.Name = "tabela_dados";
            this.tabela_dados.ReadOnly = true;
            this.tabela_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela_dados.Size = new System.Drawing.Size(495, 265);
            this.tabela_dados.TabIndex = 51;
            this.tabela_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_dados_CellContentClick);
            this.tabela_dados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_dados_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_count);
            this.groupBox1.Controls.Add(this.label_registros);
            this.groupBox1.Controls.Add(this.btn_inserir);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_count.Location = new System.Drawing.Point(127, 126);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(15, 16);
            this.label_count.TabIndex = 53;
            this.label_count.Text = "0";
            // 
            // label_registros
            // 
            this.label_registros.AutoSize = true;
            this.label_registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_registros.Location = new System.Drawing.Point(6, 124);
            this.label_registros.Name = "label_registros";
            this.label_registros.Size = new System.Drawing.Size(102, 18);
            this.label_registros.TabIndex = 29;
            this.label_registros.Text = "Selecionados:";
            // 
            // btn_inserir
            // 
            this.btn_inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inserir.FlatAppearance.BorderSize = 0;
            this.btn_inserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.ForeColor = System.Drawing.Color.White;
            this.btn_inserir.Image = ((System.Drawing.Image)(resources.GetObject("btn_inserir.Image")));
            this.btn_inserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inserir.Location = new System.Drawing.Point(14, 49);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(202, 35);
            this.btn_inserir.TabIndex = 1;
            this.btn_inserir.Text = "Inserir Farmaco";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(33, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 25);
            this.label15.TabIndex = 50;
            this.label15.Text = "Venda Numero::";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Black;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(604, 513);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(163, 64);
            this.btn_cancelar.TabIndex = 56;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // documento
            // 
            this.documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 638);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_total_compra);
            this.Controls.Add(this.txt_pagamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_troco);
            this.Controls.Add(this.preco_unitario);
            this.Controls.Add(this.label_venda);
            this.Controls.Add(this.btn_venda);
            this.Controls.Add(this.tabela_dados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Efectuar Venda";
            this.Load += new System.EventHandler(this.frm_venda_Load);
            this.preco_unitario.ResumeLayout(false);
            this.preco_unitario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_total_compra;
        private System.Windows.Forms.TextBox txt_pagamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_troco;
        private System.Windows.Forms.GroupBox preco_unitario;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.Label label_venda;
        private System.Windows.Forms.Button btn_venda;
        private System.Windows.Forms.DataGridView tabela_dados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label_registros;
        private System.Windows.Forms.Button btn_inserir;
    }
}