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
    public partial class frm_Vendas : Form
    {
        public DataTable tmp;

        public frm_Vendas()
        {
            InitializeComponent();
        }

        private void NovoFunc_Click(object sender, EventArgs e)
        {
             tmp = new DataTable();
            string calendar = Convert.ToString(calendario.Text);

            Database db = new Database("db_farmacia");
            List<Database.SQLParametro> dados = new List<Database.SQLParametro>();

            dados.Add(new Database.SQLParametro("@parametro", "%" + calendar + "%"));

            
                tmp = db.EXE_READER("select * from tb_compra WHERE data_pagamento LIKE @parametro;", dados);
                tabela_dados.DataSource = tmp;


            DataTable data = new DataTable();
            DataTable cartao = new DataTable();

            data = db.EXE_READER("SELECT  SUM(valor_entregue) as valor FROM tb_compra where data_pagamento LIKE @parametro AND forma_pagamento = 'Dinheiro';", dados);
            cartao = db.EXE_READER("SELECT  SUM(valor_entregue) as valor FROM tb_compra where data_pagamento LIKE @parametro AND forma_pagamento = 'Cartão';", dados);

            
            int total_dinheiro;
            int total_cartao;

            int.TryParse(data.Rows[0]["valor"].ToString(),out total_dinheiro);
            int.TryParse(cartao.Rows[0]["valor"].ToString(), out total_cartao);


            if (total_dinheiro == 0 &&  total_cartao == 0)
            {
                label_cartao.Text = "0000,000";
                label_caixa.Text = "0000,000";

                helpers.CriarMensagem("Não vendas Registradas neste dia", 3);
                  
                return;
                

            }

            label_cartao.Text = total_cartao.ToString();

            label_caixa.Text = total_dinheiro.ToString();
               

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Vendas_Load(object sender, EventArgs e)
        {

        }

        private void tabela_dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //sair da app
            if (MessageBox.Show("Deseja eliminar esta venda?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                int id = Convert.ToInt16(tabela_dados.Rows[e.RowIndex].Cells["id_compra"].Value);

                Database db = new Database("db_farmacia");


                db.EXE_NON_QUERY("DELETE FROM tb_compra WHERE id_compra = " + id);

                helpers.CriarMensagem("Apagado com sucesso", 2);

                List<Database.SQLParametro> dados = new List<Database.SQLParametro>();

                dados.Add(new Database.SQLParametro("@parametro", "%" + calendario.Text + "%"));

                tabela_dados.DataSource = db.EXE_READER("select * from tb_compra WHERE data_pagamento LIKE @parametro;", dados);

                DataTable data = new DataTable();
                data = db.EXE_READER("SELECT  SUM(valor_entregue) as valor FROM tb_compra where data_pagamento LIKE @parametro", dados);

               /* int.TryParse(data.Rows[0]["valor"].ToString(), out total);

                label_caixa.Text = total.ToString();*/
            }
            catch (Exception)
            {
                
                throw;
            }
          
        }

        private void tabela_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            relatorio.frm_relatorio_venda v = new relatorio.frm_relatorio_venda(tmp);
            v.Show();
        }
    }
}
