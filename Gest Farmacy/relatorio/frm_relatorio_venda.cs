using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M17.relatorio
{
    public partial class frm_relatorio_venda : Form
    {
        DataTable tabela = new DataTable();

        public frm_relatorio_venda(DataTable dt)
        {
            InitializeComponent();

            this.tabela = dt;
        }

        private void frm_relatorio_venda_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", tabela));


            this.reportViewer1.RefreshReport();
        }
    }
}
