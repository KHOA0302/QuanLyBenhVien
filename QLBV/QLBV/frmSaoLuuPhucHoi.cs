using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBV
{
    public partial class frmSaoLuuPhucHoi : Form
    {
        public frmSaoLuuPhucHoi()
        {
            InitializeComponent();
        }

        private void btnSL_Click(object sender, EventArgs e)
        {
            String str = "SP_BackUp '" + txtFileName.Text.ToString() + "'";
            int n = Program.ExecSqlNonQuery(str);

            if (n == 0)
            {
                MessageBox.Show("Sao lưu thành công.", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Sao lưu thất bại.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPH_Click(object sender, EventArgs e)
        {
            int n = Program.ExecSqlNonQuery("USE [master]\n" +
                "ALTER DATABASE [QLBV] SET OFFLINE WITH ROLLBACK IMMEDIATE\n" +
                $"RESTORE DATABASE [QLBV] FROM DISK = '" + txtFileName.Text.ToString() + "' WITH REPLACE\n" +
                "ALTER DATABASE [QLBV] SET ONLINE");

            if (n == 0)
            {
                MessageBox.Show("Phục hồi thành công.", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Phục hồi thất bại.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFile.FileName;
            }
        }   
    }
}
