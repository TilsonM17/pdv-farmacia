using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using M17.GestFarmacy.Usuario;
using M17.GestFarmacy.DataBase;
using System.Runtime.InteropServices;

namespace M17
{
    public partial class frm_Home : Form
    {
        private DataRow dataRow;
        private DataView data;

        public frm_Home()
        {

            InitializeComponent();
            btnlogoInicio.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img\img_farmacia.png");
        }

        public frm_Home(DataRow dataRow)
        {
            
            InitializeComponent();
            // TODO: Complete member initialization
            this.dataRow = dataRow;
            btnlogoInicio.BackgroundImage = Image.FromFile(Application.StartupPath + @"\img\img_farmacia.png");
        }

        



  
        public void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            AbrirFormEnPanel(new frm_atividade());
           
            
        }

       

        private void frm_Home_Load(object sender, EventArgs e)
        {
            label_cargo.Text = " Cargo : " + dataRow["cargo"].ToString();
            label_usuario.Text = "Nome: " + dataRow["nome_completo"].ToString();
            label_contato.Text = DateTime.Now.ToShortTimeString().ToString();
            btnlogoInicio_Click(null, e);

            if (dataRow["cargo"].Equals("Caixa"))
            {
               
                btn_funcionario.Visible = false;
                btn_produto.Visible = false;
                btn_fornecedor.Visible = false;
              
                btn_funcionario.Enabled = false;
                btn_produto.Enabled = false;
                btn_fornecedor.Enabled = false;
                button2.Enabled = false;
                button2.Visible = false;

                
            }

            Database db = new Database("db_farmacia");

            List<Database.SQLParametro> dados = new List<Database.SQLParametro>();

            dados.Add(new Database.SQLParametro("@id", dataRow["id_usuario"]));
            dados.Add(new Database.SQLParametro("@time",DateTime.Now.ToShortTimeString()));
            dados.Add(new Database.SQLParametro("@data", DateTime.Now.ToShortDateString()));

            db.EXE_NON_QUERY("INSERT INTO tb_atividade (id_usuario,time_inicio,data) VALUES(@id,@time,@data)",dados);
            
            
        }




        #region Estilo da pagina

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


       

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_welcome());

        }

        private void btn_funcionario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_funcionario());

        }

        private void btn_sair6_Click(object sender, EventArgs e)
        {
            //sair da app
            if (MessageBox.Show("Deseja sair da Aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            Application.Exit();

            Database db = new Database("db_farmacia");

            List<Database.SQLParametro> dados = new List<Database.SQLParametro>();

            dados.Add(new Database.SQLParametro("@time", DateTime.Now.ToShortTimeString()));

            db.EXE_NON_QUERY("UPDATE tb_atividade SET time_fim = @time where id_usuario = " + dataRow["id_usuario"],dados);
        }

        private void btn_produto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_produto());


        }

        private void btn_venda_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_venda(data));
        }

        private void btn_fornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_Vendas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_sobre());
        }

        private void label_contato_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_welcome());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_estoque());
        }


    }
}
