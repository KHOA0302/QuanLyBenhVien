using DevExpress.XtraReports.UI;
using DevExpress.XtraReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBV.Report_Form
{
    public partial class Frpt_SuDungVatTu : Form
    {
        String MABN;
        String TENBN;

        public Frpt_SuDungVatTu()
        {
            InitializeComponent();
        }

        private void bENHNHANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void Frpt_SuDungVatTu_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.BENHNHAN' table. You can move, or remove it, as needed.
            this.BenhNhanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BenhNhanTableAdapter.Fill(this.DS.BENHNHAN);

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Xrpt_SuDungVatTu rpt = new Xrpt_SuDungVatTu(MABN);
            rpt.lblMABN.Text = MABN;
            rpt.lblTENBN.Text = TENBN;
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            printTool.ShowPreviewDialog();
        }

        private void cmbBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBN.SelectedValue != null)
                {
                    MABN = cmbBN.SelectedValue.ToString();
                    TENBN = cmbBN.Text.ToString();
                }
            }
            catch { }
        }
    }
}
