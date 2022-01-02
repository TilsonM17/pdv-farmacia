using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using M17.GestFarmacy.DataBase;
using M17.GestFarmacy.helpers;
using M17.GestFarmacy.cl_venda;

namespace M17
{
    public partial class frm_atividade : Form
    {
        //public Database db;

        public frm_atividade()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string calendar = Convert.ToString(calendario.Text);

            Database db = new Database("db_farmacia");
            List<Database.SQLParametro> dados = new List<Database.SQLParametro>();

            dados.Add(new Database.SQLParametro("@parametro", calendar ));

            tabela_dados.DataSource = db.EXE_READER("select * from tb_atividade WHERE data = @parametro;", dados);
           //tabela_dados.Columns["valor_entregue"].
        }

        private void label_count_Click(object sender, EventArgs e)
        {

        }

        private void tabela_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabela_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_usuario = Convert.ToInt16(tabela_dados.Rows[e.RowIndex].Cells["id_usuario"].Value);
            if (DBNull.Value.Equals(tabela_dados.Rows[e.RowIndex].Cells["time_fim"].Value))
                label_out.Text = "Saida do Sistema não Registrada";
            else
                label_out.Text = Convert.ToString(tabela_dados.Rows[e.RowIndex].Cells["time_fim"].Value);
       
           
            DateTime time_inicio = Convert.ToDateTime(tabela_dados.Rows[e.RowIndex].Cells["time_inicio"].Value);

            Database db = new Database("db_farmacia");
            DataTable tmp = new DataTable();
           
           tmp = db.EXE_READER("select * from tb_usuario WHERE id_usuario ="+ id_usuario);
           string n = tmp.Rows[0]["nome_completo"].ToString();

           label_nome.Text = n;
           label_in.Text = time_inicio.ToString();   

        }

        private void frm_atividade_Load(object sender, EventArgs e)
        {

        }
    }
}
