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
    public partial class frm_funcionario : Form
    {
        public int id_usuario;

        public frm_funcionario()
        {
            InitializeComponent();
        }

        private void frm_funcionario_Load(object sender, EventArgs e)
        {
            btn_alterar.Enabled = btn_excluir.Enabled = false;
            txt_completo.Focus();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (txt_completo.Text == "" || txt_nome.Text == "" || txt_senha.Text == "" || combo_cargo.Text == "")
            {
                helpers.CriarMensagem("Os Campos não podem estar Vazios", 3);
                return;
                
            }

            string sexo = "Unknow";
            if (rbM.Checked == true)
            {
                sexo = "M";

            }
            else {
                sexo = "F";
            }

            Database db = new Database("db_farmacia");
            List<Database.SQLParametro> dados = new List<Database.SQLParametro>();

            dados.Add(new Database.SQLParametro("@nome_completo",txt_completo.Text));
            dados.Add(new Database.SQLParametro("@nome_usuario", txt_nome.Text));
            dados.Add(new Database.SQLParametro("@senha", txt_senha.Text));
            dados.Add(new Database.SQLParametro("@data", DateTime.Now));
            dados.Add(new Database.SQLParametro("@cargo", combo_cargo.Text));
            dados.Add(new Database.SQLParametro("@sexo", sexo));

            db.EXE_NON_QUERY("INSERT INTO tb_usuario(nome_completo,nome_usuario,senha,data_cadastro,cargo,sexo) VALUES(@nome_completo,@nome_usuario,@senha,@data,@cargo,@sexo)",dados);

            //Limpar campos
            txt_completo.Text = txt_nome.Text = txt_senha.Text =  combo_cargo.Text = "";
            txt_completo.Focus();

            tabela_dados.DataSource = helpers.CriarGrelha("tb_usuario");
            


        }

        private void tabela_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_usuario = Convert.ToInt16(tabela_dados.Rows[e.RowIndex].Cells["id_usuario"].Value);
                string nome = Convert.ToString(tabela_dados.Rows[e.RowIndex].Cells["nome_completo"].Value);
                
                btn_excluir.Enabled = true;

            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        private void combo_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            Database db = new Database("db_farmacia");
            List<Database.SQLParametro> dados = new List<Database.SQLParametro>();

            dados.Add(new Database.SQLParametro("@parametro", "%" + txt_pesquisar.Text + "%"));

            tabela_dados.DataSource =  db.EXE_READER("select * from tb_usuario WHERE nome_usuario LIKE @parametro;", dados);
            
            tabela_dados.Columns["senha"].Visible = false;
            //tabela_dados.Columns["quantidade_recebida"].Visible = false;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Database db = new Database("db_farmacia");

            db.EXE_NON_QUERY("DELETE FROM tb_usuario WHERE id_usuario = " + id_usuario);

            tabela_dados.DataSource = helpers.CriarGrelha("tb_usuario");
           
            btn_excluir.Enabled = false;

        }

        private void tabela_dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dados = new DataTable();
            Database db = new Database("db_farmacia");
            dados = db.EXE_READER("select * from tb_usuario WHERE id_usuario ="+ id_usuario);

            txt_completo.Text = dados.Rows[0]["nome_completo"].ToString();
            txt_nome.Text = dados.Rows[0]["nome_usuario"].ToString();
            combo_cargo.Text = dados.Rows[0]["cargo"].ToString();
            btn_alterar.Enabled = true;
            btn_excluir.Enabled = false;


        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Database db = new Database("db_farmacia");

            List<Database.SQLParametro> dados = new List<Database.SQLParametro>();

            dados.Add(new Database.SQLParametro("@nome", txt_completo.Text));
            dados.Add(new Database.SQLParametro("@usuario", txt_nome.Text));
            dados.Add(new Database.SQLParametro("@cargo", combo_cargo.Text));


            db.EXE_NON_QUERY("UPDATE tb_usuario SET  nome_completo = @nome,nome_usuario = @usuario, cargo = @cargo where id_usuario = " + id_usuario, dados);

            tabela_dados.DataSource = helpers.CriarGrelha("tb_usuario");

            btn_alterar.Enabled = false;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_completo.Text = txt_nome.Text = txt_senha.Text = combo_cargo.Text = "";
            txt_completo.Focus();
            btn_alterar.Enabled = btn_excluir.Enabled = false;
            txt_completo.Focus();

        }

        private void tabela_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
