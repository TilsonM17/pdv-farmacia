using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using M17.GestFarmacy.helpers;
using M17.GestFarmacy.Usuario;
using M17.GestFarmacy.DataBase;

namespace M17
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_nome.Focus();

           /* Database db = new Database("db_farmacia");
            //db.EXE_NON_QUERY("ALTER TABLE tb_farmaco ALTER COLUMN cod_barra INT");
            db.EXE_READER("SELECT * FROM tb_farmaco");*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

   

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            #region Fazer Login e guardar os dados do usuario

            #region Analisar se os imputs foram preenchidos
            if (txt_nome.Text == "" || txt_senha.Text == "") {

                helpers.CriarMensagem("Preencha os dados", 2);
                txt_nome.Focus();
                return;
                
            }
            #endregion


            List<Database.SQLParametro> dados = new List<Database.SQLParametro>();
             dados.Add(new Database.SQLParametro("@nome",txt_nome.Text));
             dados.Add(new Database.SQLParametro("@senha", txt_senha.Text));


            Database db = new Database("db_farmacia");
            DataTable resultado = db.EXE_READER("SELECT * FROM tb_usuario where nome_usuario = @nome AND senha = @senha;", dados);


            if (resultado.Rows.Count == 1)
            {

            
                txt_nome.Text = "";
                txt_senha.Text = "";

                cl_usuario.buscarUsuario(resultado.Rows[0]);
                frm_Home h = new frm_Home(resultado.Rows[0]);
                h.Show();
                this.Visible = false;




            }
            else {
                helpers.CriarMensagem("A senha ou o Seu nome esta errado!", 2);
                txt_nome.Text = "";
                txt_senha.Text = "";
                txt_nome.Focus();
            
            }

 #endregion

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_senha_KeyDown(object sender, KeyEventArgs e)
        {
            //quando apertar esc vai limpar tudo
            if (e.KeyCode == Keys.Escape)
                txt_senha.Text = "";

            //---------------------------------------
            //quando apertar enter vai executar
            if (e.KeyCode == Keys.Enter)
                btn_entrar_Click(btn_entrar, EventArgs.Empty);
        } 
    }
}
