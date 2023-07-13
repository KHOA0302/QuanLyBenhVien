using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBV
{
    public partial class frmTaoTaiKhoan : Form
    {
        private string taiKhoan = "";
        private string matKhau = "";
        private string maNhanVien = "";
        private string vaiTro = "";

        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            string strlenh = "EXEC SP_NhanVienChuaTaoTaiKhoan";
            DataTable dt = Program.ExecSqlDataTable(strlenh);

            BindingSource bdsNV = new BindingSource();
            bdsNV.DataSource = dt;

            cmbNV.DataSource = bdsNV;
            cmbNV.DisplayMember = "HOTEN";
            cmbNV.ValueMember = "MANV";
            cmbNV.SelectedIndex = -1;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "")
            {
                MessageBox.Show("Thiếu tài khoản", "Thông báo", MessageBoxButtons.OK);
                txtTaikhoan.Focus();
                return;
            }

            if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu", "Thông báo", MessageBoxButtons.OK);
                txtMatkhau.Focus();
                return;
            }

            if (txtXacnhanmatkhau.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                txtXacnhanmatkhau.Focus();
                return;
            }

            if (txtMatkhau.Text != txtXacnhanmatkhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp với mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                txtMatkhau.Focus();
                return;
            }

            taiKhoan = txtTaikhoan.Text;
            matKhau = txtMatkhau.Text;
            vaiTro = (rbBS.Checked == true) ? "BACSI" : "YTA";

            String cauTruyVan =
                    "EXEC SP_Tao_Tai_Khoan '" + taiKhoan + "' , '" + matKhau + "', '"
                    + maNhanVien + "', '" + vaiTro + "'";

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                if (Program.myReader == null)
                {
                    return;
                }

                MessageBox.Show("Đăng kí tài khoản thành công\n\nTài khoản: " + taiKhoan + "\nMật khẩu: " + matKhau + "\nMã Nhân Viên: " + maNhanVien + "\nVai Trò: " + vaiTro, "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cmbNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbNV.SelectedValue != null)
                {
                    maNhanVien = cmbNV.SelectedValue.ToString();
                }
            }
            catch { }
        }
    }
}
