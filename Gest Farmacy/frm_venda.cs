using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

using M17.GestFarmacy.helpers;
using M17.GestFarmacy.cl_venda;
using M17.GestFarmacy.Usuario;
using M17.GestFarmacy.DataBase;

namespace M17
{
    public partial class frm_venda : Form
    {
        public DataView data;
        public int total_pagar = 0;
        public string nome = "CLIENTE";


        //Dados db
        public int id;
        public string nome_farmaco;
        public int total;
        public int preco;
        public int qtd;
        public int estoque;


        public frm_venda(DataView view)
        {
            InitializeComponent();

            this.data = view;

            if (data != null)
            {
                tabela_dados.DataSource = data;
                txt_pagamento.Focus();
               

                int contador = tabela_dados.RowCount;

                label_count.Text = contador.ToString();

                for (int i = 0; i < contador; i++)
                {
                    total_pagar += int.Parse(tabela_dados.Rows[i].Cells[4].Value.ToString());
                }

                label_total_compra.Text = total_pagar.ToString();

                btn_venda.Enabled = true; 

            }
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_itemsCompra item = new frm_itemsCompra();
            item.Show();
            
            
        }

        private void frm_venda_Load(object sender, EventArgs e = null)
        {
            Database bd = new Database("db_farmacia");
            int id = bd.ID_DISPONIVEL("tb_compra", "id_compra");

            label_venda.Text = id.ToString();
            txt_pagamento.Focus();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txt_pagamento_TextChanged(object sender, EventArgs e)
        {
            int quantidade;


            try
            {
                if (txt_pagamento.Text == "")
                {
                    quantidade = 1;
                    return;
                }
                else
                {
                    int.TryParse(txt_pagamento.Text, out quantidade);



                    if (quantidade < 0)
                    {
                        helpers.CriarMensagem("Essa quantidade não é valida", 3);
                        return;
                    }

                    int n1 = Convert.ToInt32(txt_pagamento.Text);

                    int resultado = (n1 - total_pagar);
                    label_troco.Text = resultado.ToString();
                }

            }
            catch (Exception)
            {
                
                throw;
            }

           
        }


        private void btn_venda_Click(object sender, EventArgs e)
        {
          

            if (txt_pagamento.Text == "" || Convert.ToInt32(txt_pagamento.Text) < total_pagar)
            {
                helpers.CriarMensagem("Digite um valor valido", 3);
                return;
            }
             



            #region Preparar as Variaveis
              //Metodo de pagamento
            string forma = "Dinheiro";
            if (rbC.Checked == true)
                forma = "Cartão";
            
            //Nome do Cliente
            
            if (txt_nome.Text != "") { nome = txt_nome.Text; }

            //valor
              /**/

            #endregion

            #region 1-PASSO : Inserir Venda

            Database db = new Database("db_farmacia");

            //criar a lista de parâmetros
            List<Database.SQLParametro> parametros = new List<Database.SQLParametro>();
            parametros.Add(new Database.SQLParametro("@id", cl_usuario.id_usuario));
            parametros.Add(new Database.SQLParametro("@nome", nome));
            parametros.Add(new Database.SQLParametro("@valor", Convert.ToInt32(label_total_compra.Text)));
            parametros.Add(new Database.SQLParametro("@forma", forma));
            parametros.Add(new Database.SQLParametro("@data", DateTime.Now.ToShortDateString()));

            db.EXE_NON_QUERY("INSERT INTO tb_compra(id_usuario,nome_cliente,valor_entregue,forma_pagamento,data_pagamento)"+
                " VALUES(@id,@nome,@valor,@forma,@data)",parametros);

            #endregion

            #region 2-PASSO : Inserir Items da Venda

            int contador = tabela_dados.RowCount;

            for (int i = 0; i < contador; i++)
            {
               
                Database db2 = new Database("db_farmacia");
                int id_compra = db2.LAST_ID("tb_compra", "id_compra");

                //criar a lista de parâmetros
                List<Database.SQLParametro> parametros2 = new List<Database.SQLParametro>();

                //criar a lista de parâmetros
                parametros2.Add(new Database.SQLParametro("@id", tabela_dados.Rows[i].Cells[0].Value));
                parametros2.Add(new Database.SQLParametro("@valor", tabela_dados.Rows[i].Cells[3].Value));
                parametros2.Add(new Database.SQLParametro("@qtd", tabela_dados.Rows[i].Cells[2].Value));
                parametros2.Add(new Database.SQLParametro("@total", tabela_dados.Rows[i].Cells[4].Value));
                parametros2.Add(new Database.SQLParametro("@nome", tabela_dados.Rows[i].Cells[1].Value));
                parametros2.Add(new Database.SQLParametro("@compra", id_compra));
                parametros2.Add(new Database.SQLParametro("@numero", tabela_dados.Rows[i].Cells[2].Value));


                

                #region Descontar  na quantidade dos produtos

                //Primero Tirar no field Estoque
                db2.EXE_NON_QUERY("UPDATE tb_farmaco SET quantidade_estoque = quantidade_estoque - @numero WHERE id_farmaco = @id", parametros2);
                //Depois Vericar se ficou 0
                DataTable tb_tmp = new DataTable();
                tb_tmp = db2.PREPARAR_DATATABLE("SELECT quantidade_estoque FROM tb_farmaco where id_farmaco = " + tabela_dados.Rows[i].Cells[0].Value);
                //Se ficou 0 de produto deixar o ativo = Desativado||(0)

                if (Convert.ToInt32(tb_tmp.Rows[0]["quantidade_estoque"]) == 0)
                    db2.EXE_NON_QUERY("UPDATE tb_farmaco SET quantidade_estoque = 0 ,ativo = 0 WHERE id_farmaco = @id", parametros2);


                #endregion


                //Inserir na base de dados da Tabela ITEMS
                db2.EXE_NON_QUERY("INSERT INTO tb_itemCompra(id_produto,valor,quantidade,total,nome_produto,id_compra)" +
                    " VALUES(@id,@valor,@qtd,@total,@nome,@compra)", parametros2);

                
               

            }
            helpers.CriarMensagem("A venda foi efectuada com sucesso!", 1);
           

              Database bd = new Database("db_farmacia");
            int id_tmp = bd.ID_DISPONIVEL("tb_compra", "id_compra");

            label_venda.Text = id_tmp.ToString();


            //Limpar a tabela de dados
           
            #endregion

            #region 3-PASSO : Criar Factura
            documento = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            documento.PrinterSettings = ps;
            documento.PrintPage += Imprimir;

            documento.Print();

            label_total_compra.Text = "000";
            label_troco.Text = "0";
            label_count.Text = "0";
            txt_nome.Text = "";
            txt_pagamento.Text = "";
            #endregion


        }


        private void tabela_dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }


        private void tabela_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //sair da app
            if (MessageBox.Show("Deseja eliminar o Produto nesta Venda?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //int id_venda = Convert.ToInt16(tabela_dados.Rows[e.RowIndex].Cells["id_compra"].Value);
            tabela_dados.Rows.RemoveAt(e.RowIndex);
        

            int contador = tabela_dados.RowCount;
            for (int i = 0; i < contador; i++)
            {
                total_pagar += int.Parse(tabela_dados.Rows[i].Cells[4].Value.ToString());
            }

            label_total_compra.Text = total_pagar.ToString();
        }


        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            //Criar Fontes dos Titulos
            Font font = new Font("Arial", 14);
            Font titulo = new Font("Arial", 16,FontStyle.Bold);
            Font font2 = new Font("Arial", 14, FontStyle.Italic);
            Font font3 = new Font("Arial", 14, FontStyle.Underline,GraphicsUnit.Point);

            int ancho = 700;
            int y = 70;

            e.Graphics.DrawString("*- FARMACIA XXX -*", titulo, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("------------------ ", titulo, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString(" Venda de Produtos Farmacêuticos.", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("NIF nª: xxxxxxxxx.", font3, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Luanda,Viana, KM30.", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


            e.Graphics.DrawString(" Factura Nº "+label_venda.Text , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Nome do Cliente : Sr(A)"+ nome , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Data : " + DateTime.Now, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("=======================",font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));
            e.Graphics.DrawString("***** - Produtos - *****", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));
          
            e.Graphics.DrawString("NOME  -  QTD  - PREÇO -  SUBTOTAL", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));
            e.Graphics.DrawString("======================= ", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));
            
            //Area dos Produtos
            int contador = tabela_dados.RowCount;

            for (int i = 0; i < contador; i++)
            {
                e.Graphics.DrawString(tabela_dados.Rows[i].Cells[1].Value.ToString() + " -  " +
                  tabela_dados.Rows[i].Cells[2].Value.ToString() + "  - " +
                  tabela_dados.Rows[i].Cells[3].Value.ToString() + "  - " + tabela_dados.Rows[i].Cells[4].Value.ToString() + " "
                  , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

               
            }

            e.Graphics.DrawString("======================= ", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));
            e.Graphics.DrawString("Valor Entrege : " + txt_pagamento.Text + " AKZ", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));
            e.Graphics.DrawString("Troco  : " + label_troco.Text + " AKZ", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));

            e.Graphics.DrawString("======================= ", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));

            e.Graphics.DrawString("Total Compra  : "+label_total_compra.Text +" AKZ", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));
            e.Graphics.DrawString("Atendido por : " + cl_usuario.Nome, font3, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));

            e.Graphics.DrawString("======================= ", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));

            e.Graphics.DrawString("VOLTE SEMPRE!" , font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));
            e.Graphics.DrawString("***********************", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));
            e.Graphics.DrawString("Processado por Programa : GEST FARMACY", font2, Brushes.Gray, new RectangleF(0, y += 40, ancho, 20));
            e.Graphics.DrawString("TilsonM17", font2, Brushes.Gray, new RectangleF(0, y += 40, ancho, 20));

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}

