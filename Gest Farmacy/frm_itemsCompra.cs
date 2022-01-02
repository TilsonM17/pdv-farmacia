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
    public partial class frm_itemsCompra : Form
    {
        
        public List<string> tabela;
        public DataTable table;
        public DataColumn column;
        public DataView view;

        public int index = 1;
       

        //Dados db
        public int id;
        public string nome_farmaco;
        public int total;
        public int preco;
        public int qtd;
        public int estoque;




        public frm_itemsCompra()
        {
            InitializeComponent();
        }

        private void frm_itemsCompra_Load(object sender, EventArgs e)
        {
            btn_continuar.Enabled = false;

            
            txt_pesquisar.Focus();
            // Cria Novo DataTable
            table = new DataTable();
           

            #region Criar Colunas para compor a DataTable

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Id";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "nome";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "quantidade";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "preco";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "sub_total";
            table.Columns.Add(column);

            #endregion

        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tabela_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
          

             

            //btn_excluir.Enabled = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txt_qtd_TextChanged(object sender, EventArgs e)
        {
            
                int quantidade;



                if (txt_qtd.Text == "")
                {
                    quantidade = 1;
                    return;
                }
                else
                {
                    int.TryParse(txt_qtd.Text, out quantidade);



                    if (quantidade < 0)
                    {
                        helpers.CriarMensagem("Essa quantidade não é valida", 3);
                        return;
                    }

                    int n1 = Convert.ToInt32(txt_qtd.Text);

                    int resultado = preco * n1;
                    label_total.Text = resultado.ToString();
                }


         
          
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            this.Close();
            
            frm_venda c = new frm_venda(view);

            c.Show();
            
            

        }

        private void tabela_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_pesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_pesquisar.Text == "")
                     return;
               
                    Database db = new Database("db_farmacia");
                    List<Database.SQLParametro> dados = new List<Database.SQLParametro>();

                    dados.Add(new Database.SQLParametro("@parametro", txt_pesquisar.Text));

                    DataTable tmp = new DataTable();

                    tmp = db.EXE_READER("select * from tb_farmaco WHERE ativo = 1 AND cod_barra = @parametro;", dados);

                    if (tmp.Rows.Count == 0)
                    {
                        helpers.CriarMensagem("Este codigo não corresponde a nenhum Produto Inserido!", 3);
                        return;
                    }

                    tabela_dados.DataSource = tmp;

                    tabela_dados.Columns["data_entrada"].Visible = false;
                    tabela_dados.Columns["quantidade_recebida"].Visible = false;
                    //tabela_dados.Columns["quantidade_estoque"].Visible = false;
                    tabela_dados.Columns["descricao"].Visible = false;

                    tabela_dados.Columns["data_actualisao"].Visible = false;
                    tabela_dados.Columns["ativo"].Visible = false;


                    id = Convert.ToInt16(tabela_dados.Rows[0].Cells["id_farmaco"].Value);
                    nome_farmaco = Convert.ToString(tabela_dados.Rows[0].Cells["nome_farmaco"].Value);
                    preco = Convert.ToInt16(tabela_dados.Rows[0].Cells["preco"].Value);
                    estoque = Convert.ToInt16(tabela_dados.Rows[0].Cells["quantidade_estoque"].Value);

                    txt_qtd.Focus();

                    label_total.Text = preco.ToString();
                    preco_unitario.Text = preco.ToString();
                    label_nome.Text = nome_farmaco.ToString();
                    label_stock.Text = estoque.ToString();
                
            }

        }

        private void txt_qtd_KeyDown(object sender, KeyEventArgs e)
        {



            //quando apertar enter vai executar
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(txt_qtd.Text) > estoque)
                {
                    helpers.CriarMensagem("Restou apenas " + estoque + " unidades de " + label_nome.Text + " no estoque", 3);
                    txt_qtd.Focus();
                    return;
                }
                if (Convert.ToInt32(txt_qtd.Text) < 0)
                {
                    helpers.CriarMensagem("Insira uma Quantidade Valida", 3);
                    return;
                }
                 qtd = Convert.ToInt32(txt_qtd.Text);

                 float sub_total = float.Parse(txt_qtd.Text) * float.Parse(preco_unitario.Text);

                string[,] ListaCompra = new string[200, 8];
                int Fila = 0;//lista de filas

                //DataTable tmp = new DataTable();


                ListaCompra[Fila, 0] = id.ToString();
                ListaCompra[Fila, 1] = label_nome.Text;
                ListaCompra[Fila, 2] = txt_qtd.Text;
                ListaCompra[Fila, 3] = preco.ToString();
                ListaCompra[Fila, 4] = sub_total.ToString();


                tabela = new List<string>()
                    {
                   ListaCompra[Fila, 0],
                   ListaCompra[Fila, 1],
                   ListaCompra[Fila, 2],
                   ListaCompra[Fila, 3],
                   ListaCompra[Fila, 4]
                    };

                Fila++;




                DataRow row;


                row = table.NewRow();

                row["Id"] = tabela[0];
                row["nome"] = tabela[1].ToString();
                row["quantidade"] = tabela[2].ToString();
                row["preco"] = tabela[3].ToString(); 
                row["sub_total"] = tabela[4].ToString();
       

                table.Rows.Add(row);



                view = new DataView(table);


                //tabela_dados.DataSource = table;
                label_count.Text = Convert.ToString(table.Rows.Count);
                label_nome.Text = preco_unitario.Text = "**";
                label_total.Text = "0";
                txt_qtd.Text = "1";
                btn_continuar.Enabled = true;
                label_stock.Text = "0";

                
                txt_pesquisar.Focus();
                txt_pesquisar.Text = "";
            }
              
        }
    }
}
