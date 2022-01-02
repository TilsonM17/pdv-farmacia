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

namespace M17
{
    public partial class frm_produto : Form
    {
        public int id_usuario;

        public frm_produto()
        {
            InitializeComponent();
        }

        private void label_ganho_Click(object sender, EventArgs e)
        {

        }

        private void frm_produto_Load(object sender, EventArgs e)
        {
            btn_excluir.Enabled =  btn_altera.Enabled = false;
            txt_barra.Focus();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (txt_produto.Text == "" || txt_qtd.Text == "" || txt_barra.Text == "") {
                  helpers.CriarMensagem("Nenhuma caixa pode estar vazia",2);
                return;
             
            }

            Database db = new Database("db_farmacia");

            //Antes de Inserir Saber se o produto ja existe na base de dados e esta ativo!
            DataTable tmp = new DataTable();

            tmp = db.PREPARAR_DATATABLE("SELECT * FROM tb_farmaco WHERE cod_barra =" + txt_barra.Text);
            if (tmp.Rows.Count > 0)
            {

                //Saber se ele esta ativo || Desativado
                if (Convert.ToInt32(tmp.Rows[0]["ativo"]) != 1)
                {
                    helpers.CriarMensagem("O "+ tmp.Rows[0]["nome_farmaco"]+" esta inserido,mais esta inativo."+Environment.NewLine + " Tens de ativalo!", 2);
                    return;
 
                
                }




                helpers.CriarMensagem("Este codigo ja corresponde a um produto inserido e ativo", 3);
                return;
            }
           


            List<Database.SQLParametro> dados = new List<Database.SQLParametro>();

            dados.Add(new Database.SQLParametro("@nome_produto", txt_produto.Text));
            dados.Add(new Database.SQLParametro("@preco_unitario", txt_preco.Text));
            dados.Add(new Database.SQLParametro("@descricao", txt_descricao.Text));
            dados.Add(new Database.SQLParametro("@quantidade_recebida", Convert.ToInt32(txt_qtd.Text)));
            dados.Add(new Database.SQLParametro("@quantidade_estoque",Convert.ToInt32(txt_qtd.Text)));
            dados.Add(new Database.SQLParametro("@data_entrada", DateTime.Now.ToShortDateString()));
            dados.Add(new Database.SQLParametro("@ativo", 1));
            dados.Add(new Database.SQLParametro("@cod", txt_barra.Text));


            db.EXE_NON_QUERY("INSERT INTO tb_farmaco(nome_farmaco,preco,descricao,quantidade_recebida,quantidade_estoque,data_entrada,ativo,cod_barra) VALUES (@nome_produto,@preco_unitario,@descricao,@quantidade_recebida,@quantidade_estoque,@data_entrada,@ativo,@cod);", dados);
            txt_produto.Text  = txt_qtd.Text = txt_descricao.Text = txt_preco.Text = txt_barra.Text = "";

            tabela_dados.DataSource = helpers.CriarGrelha("tb_farmaco");

            helpers.CriarMensagem("Inserido com sucesso", 1);

        }

        private void txt_preco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_qtd_TextChanged(object sender, EventArgs e)
        {

        }


        private void tabela_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_usuario = Convert.ToInt16(tabela_dados.Rows[e.RowIndex].Cells["id_farmaco"].Value);

            btn_excluir.Enabled = true;
        }


        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Database db = new Database("db_farmacia");
                List<Database.SQLParametro> dados = new List<Database.SQLParametro>();

                dados.Add(new Database.SQLParametro("@parametro", "%" + txt_pesquisar.Text + "%"));

                tabela_dados.DataSource = db.EXE_READER("select * from tb_farmaco WHERE nome_farmaco LIKE @parametro;", dados);

            }
          
        }


        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Database db = new Database("db_farmacia");


            db.EXE_NON_QUERY("DELETE FROM tb_farmaco WHERE id_farmaco = " + id_usuario);

            tabela_dados.DataSource = helpers.CriarGrelha("tb_farmaco");
            btn_excluir.Enabled = false;
        }

        private void tabela_dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dados = new DataTable();
            Database db = new Database("db_farmacia");

            dados = db.EXE_READER("select * from tb_farmaco WHERE id_farmaco =" + id_usuario);

            txt_produto.Text = dados.Rows[0]["nome_farmaco"].ToString();
            txt_qtd.Text = dados.Rows[0]["quantidade_recebida"].ToString();
            txt_preco.Text = dados.Rows[0]["preco"].ToString();
            txt_descricao.Text = dados.Rows[0]["descricao"].ToString();
            txt_barra.Text = dados.Rows[0]["cod_barra"].ToString();

             int n1 = Convert.ToInt32(dados.Rows[0]["quantidade_estoque"]);

             if (n1 == 0 || n1 < 10) {

                label_status.ForeColor = Color.Red;
                label_status.Text = "Estoque esta no termino,Recarregue!";
             }
             else
             {
                 label_status.Text = "Estoque ainda tem o suficiente,Fique Atento!";

                 label_status.ForeColor = Color.Green;
                    
             }
            btn_altera.Enabled = true;
            btn_excluir.Enabled = false;
            btn_gravar.Enabled = false;
        }

        private void btn_altera_Click(object sender, EventArgs e)
        {
           

            Database db = new Database("db_farmacia");

            List<Database.SQLParametro> dados = new List<Database.SQLParametro>();

            dados.Add(new Database.SQLParametro("@nome", txt_produto.Text));
            dados.Add(new Database.SQLParametro("@qtd", txt_qtd.Text));
            dados.Add(new Database.SQLParametro("@preco", txt_preco.Text));
            dados.Add(new Database.SQLParametro("@descricao", txt_descricao.Text));
            dados.Add(new Database.SQLParametro("@data", DateTime.Now));
            dados.Add(new Database.SQLParametro("@code", txt_barra.Text));
            dados.Add(new Database.SQLParametro("@ativo", 1));


            db.EXE_NON_QUERY("UPDATE tb_farmaco SET  nome_farmaco = @nome, quantidade_recebida = @qtd, quantidade_estoque = @qtd , ativo = @ativo ,preco = @preco, cod_barra = @code ,descricao = @descricao, data_actualisao = @data where id_farmaco = " + id_usuario, dados);

            tabela_dados.DataSource = helpers.CriarGrelha("tb_farmaco");

            btn_altera.Enabled = false;
        }

        private void tabela_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_pesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Database db = new Database("db_farmacia");
                List<Database.SQLParametro> dados = new List<Database.SQLParametro>();

                dados.Add(new Database.SQLParametro("@parametro", txt_pesquisar.Text));

                tabela_dados.DataSource = db.EXE_READER("select * from tb_farmaco WHERE cod_barra = @parametro;", dados);

            }
           
        }
    }
}
