namespace M17
{
    partial class frm_atividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_atividade));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabela_dados = new System.Windows.Forms.DataGridView();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_registros = new System.Windows.Forms.Label();
            this.label_in = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_out = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calendario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 78);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Actividade";
            // 
            // calendario
            // 
            this.calendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendario.Location = new System.Drawing.Point(233, 32);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(135, 20);
            this.calendario.TabIndex = 42;
            this.calendario.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Escolher data:\r\n\r\n";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(460, 78);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(164, 35);
            this.btn_search.TabIndex = 50;
            this.btn_search.Text = "Pesquisar";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 38);
            this.label1.TabIndex = 52;
            this.label1.Text = "Veja e Reveja as Ultimas Actividades dos Usuarios:\r\n\r\n";
            // 
            // tabela_dados
            // 
            this.tabela_dados.AllowUserToAddRows = false;
            this.tabela_dados.AllowUserToDeleteRows = false;
            this.tabela_dados.AllowUserToOrderColumns = true;
            this.tabela_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabela_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_dados.Location = new System.Drawing.Point(22, 145);
            this.tabela_dados.MultiSelect = false;
            this.tabela_dados.Name = "tabela_dados";
            this.tabela_dados.ReadOnly = true;
            this.tabela_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela_dados.Size = new System.Drawing.Size(661, 269);
            this.tabela_dados.TabIndex = 51;
            this.tabela_dados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_dados_CellClick);
            this.tabela_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_dados_CellContentClick);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_nome.Location = new System.Drawing.Point(148, 444);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(54, 16);
            this.label_nome.TabIndex = 55;
            this.label_nome.Text = "Unknow";
            this.label_nome.Click += new System.EventHandler(this.label_count_Click);
            // 
            // label_registros
            // 
            this.label_registros.AutoSize = true;
            this.label_registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_registros.Location = new System.Drawing.Point(12, 442);
            this.label_registros.Name = "label_registros";
            this.label_registros.Size = new System.Drawing.Size(130, 18);
            this.label_registros.TabIndex = 54;
            this.label_registros.Text = "Nome do Usuario:";
            // 
            // label_in
            // 
            this.label_in.AutoSize = true;
            this.label_in.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_in.Location = new System.Drawing.Point(148, 472);
            this.label_in.Name = "label_in";
            this.label_in.Size = new System.Drawing.Size(40, 16);
            this.label_in.TabIndex = 57;
            this.label_in.Text = "00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Hora de entrada:";
            // 
            // label_out
            // 
            this.label_out.AutoSize = true;
            this.label_out.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_out.Location = new System.Drawing.Point(148, 504);
            this.label_out.Name = "label_out";
            this.label_out.Size = new System.Drawing.Size(40, 16);
            this.label_out.TabIndex = 59;
            this.label_out.Text = "00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Hora de logout:";
            // 
            // frm_atividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 540);
            this.Controls.Add(this.label_out);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.label_registros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabela_dados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_atividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_atividade";
            this.Load += new System.EventHandler(this.frm_atividade_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabela_dados;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_registros;
        private System.Windows.Forms.Label label_in;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_out;
        private System.Windows.Forms.Label label6;
    }
}