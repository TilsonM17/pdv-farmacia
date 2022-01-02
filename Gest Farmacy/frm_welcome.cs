using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M17
{
    public partial class frm_welcome : Form
    {
        public frm_welcome()
        {
            InitializeComponent();
        }

        private void frm_welcome_Load(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.Date.ToString();

            lblFecha.Text = DateTime.Now.ToShortDateString();
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
           
            
            
        }
    }
}
