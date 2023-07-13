using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLBV.Report_Form
{
    public partial class Xrpt_SoGioLamNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_SoGioLamNhanVien()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
