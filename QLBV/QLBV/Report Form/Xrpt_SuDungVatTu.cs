using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLBV.Report_Form
{
    public partial class Xrpt_SuDungVatTu : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_SuDungVatTu()
        {
            InitializeComponent();
        }

        public Xrpt_SuDungVatTu(string MABN)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MABN;
            this.sqlDataSource1.Fill();
        }
    }
}
