namespace M17
{
    partial class frm_itemsCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_itemsCompra));
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabela_dados = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.preco_unitario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_estoque = new System.Windows.Forms.GroupBox();
            this.label_stock = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dados)).BeginInit();
            this.label_estoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(237, 94);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(294, 20);
            this.txt_pesquisar.TabIndex = 0;
            this.txt_pesquisar.TextChanged += new System.EventHandler(this.txt_pesquisar_TextChanged);
            this.txt_pesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pesquisar_KeyUp);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Codigo de Barra:";
            // 
            // tabela_dados
            // 
            this.tabela_dados.AllowUserToAddRows = false;
            this.tabela_dados.AllowUserToDeleteRows = false;
            this.tabela_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabela_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_dados.Location = new System.Drawing.Point(12, 126);
            this.tabela_dados.MultiSelect = false;
            this.tabela_dados.Name = "tabela_dados";
            this.tabela_dados.ReadOnly = true;
            this.tabela_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela_dados.Size = new System.Drawing.Size(548, 352);
            this.tabela_dados.TabIndex = 36;
            this.tabela_dados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_dados_CellClick);
            this.tabela_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_dados_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Adicionar Items";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(109, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(451, 18);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nesta sessão adicione farmacos ao carrinho para finalizar a venda.";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 25);
            this.label11.TabIndex = 49;
            this.label11.Text = "Preco Unitario:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Quantidade:";
            // 
            // preco_unitario
            // 
            this.preco_unitario.AutoSize = true;
            this.preco_unitario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preco_unitario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.preco_unitario.Location = new System.Drawing.Point(172, 32);
            this.preco_unitario.Name = "preco_unitario";
            this.preco_unitario.Size = new System.Drawing.Size(47, 16);
            this.preco_unitario.TabIndex = 50;
            this.preco_unitario.Text = "00,000";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nome:";
            // 
            // txt_qtd
            // 
            this.txt_qtd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtd.ForeColor = System.Drawing.Color.Red;
            this.txt_qtd.Location = new System.Drawing.Point(175, 77);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(59, 22);
            this.txt_qtd.TabIndex = 1;
            this.txt_qtd.Text = "1";
            this.txt_qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qtd.TextChanged += new System.EventHandler(this.txt_qtd_TextChanged);
            this.txt_qtd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qtd_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Total:";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_total.Location = new System.Drawing.Point(114, 162);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(47, 16);
            this.label_total.TabIndex = 48;
            this.label_total.Text = "00,000";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_nome.Location = new System.Drawing.Point(105, 124);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(0, 16);
            this.label_nome.TabIndex = 47;
            // 
            // label_estoque
            // 
            this.label_estoque.Controls.Add(this.label_stock);
            this.label_estoque.Controls.Add(this.label8);
            this.label_estoque.Controls.Add(this.label_count);
            this.label_estoque.Controls.Add(this.label7);
            this.label_estoque.Controls.Add(this.label5);
            this.label_estoque.Controls.Add(this.label11);
            this.label_estoque.Controls.Add(this.label_nome);
            this.label_estoque.Controls.Add(this.label_total);
            this.label_estoque.Controls.Add(this.preco_unitario);
            this.label_estoque.Controls.Add(this.label1);
            this.label_estoque.Controls.Add(this.label3);
            this.label_estoque.Controls.Add(this.txt_qtd);
            this.label_estoque.Location = new System.Drawing.Point(566, 126);
            this.label_estoque.Name = "label_estoque";
            this.label_estoque.Size = new System.Drawing.Size(276, 322);
            this.label_estoque.TabIndex = 1;
            this.label_estoque.TabStop = false;
            this.label_estoque.Text = "Dados do Farmaco";
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_stock.Location = new System.Drawing.Point(136, 206);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(15, 16);
            this.label_stock.TabIndex = 57;
            this.label_stock.Text = "0";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "Estoque:";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_count.Location = new System.Drawing.Point(172, 280);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(15, 16);
            this.label_count.TabIndex = 55;
            this.label_count.Text = "0";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Selecionados:";
            // 
            // btn_continuar
            // 
            this.btn_continuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_continuar.FlatAppearance.BorderSize = 0;
            this.btn_continuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar.ForeColor = System.Drawing.Color.White;
            this.btn_continuar.Image = ((System.Drawing.Image)(resources.GetObject("btn_continuar.Image")));
            this.btn_continuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_continuar.Location = new System.Drawing.Point(31, 501);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(234, 35);
            this.btn_continuar.TabIndex = 3;
            this.btn_continuar.Text = "FECHAR COMPRA";
            this.btn_continuar.UseVisualStyleBackColor = false;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(349, 501);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(223, 35);
            this.btn_cancelar.TabIndex = 53;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_itemsCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(868, 634);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.label_estoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabela_dados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_itemsCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Items";
            this.Load += new System.EventHandler(this.frm_itemsCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dados)).EndInit();
            this.label_estoque.ResumeLayout(false);
            this.label_estoque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tabela_dados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label preco_unitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.GroupBox label_estoque;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.Label label8;
    }
}