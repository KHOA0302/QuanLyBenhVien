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
    public partial class frmNhanVien_LamViec : Form
    {
        int vitri = 0;
        bool Them = false;

        public frmNhanVien_LamViec()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNhanVien_LamViec_Load(object sender, EventArgs e)
        {                   
            DS.EnforceConstraints = false;
            this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NhanVienTableAdapter.Fill(this.DS.NHANVIEN);

            this.LamViecTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LamViecTableAdapter.Fill(this.DS.LAMVIEC);

            this.DieuTriTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DieuTriTableAdapter.Fill(this.DS.DIEUTRI);

            this.KhuChuaTriTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KhuChuaTriTableAdapter.Fill(this.DS.KHUCHUATRI);

            if (Program.mGroup == "YTA" ||  Program.mGroup == "BACSI")
            {
                btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = false;
                contextMenuStrip1.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            groupBox1.Enabled = true;
            bdsNV.AddNew();                     

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnLuu.Enabled = true;
            gcNhanVien.Enabled = false;
            gcLamViec.Enabled = false;
            Them = true;

            String strLenh = "DECLARE @MA INT = DBO.TangMaNV()" + "SELECT @MA";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            txtMANV.Text = Program.myReader.GetInt32(0).ToString();
            Program.myReader.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            groupBox1.Enabled = true;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnLuu.Enabled = true;
            gcNhanVien.Enabled = false;
            gcLamViec.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMANV.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }

            if (Them == true)
            {
                String cauTruyVan =
                    "DECLARE @result int " +
                    "EXEC @result = SP_Kiem_Tra_MANV '" +
                    txtMANV.Text.ToString() + "' " +
                    "SELECT @result";

                SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);

                try
                {
                    Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                    if (Program.myReader == null)
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thực thi Stored Procedure thất bại!\n" + ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    return;
                }
                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                if (result == 1)
                {
                    MessageBox.Show("Mã nhân viên này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                    txtMANV.Focus();
                    return;
                }
            }

            if (txtTENNV.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên bệnh nhân", "Thông báo", MessageBoxButtons.OK);
                txtTENNV.Focus();
                return;
            }           

            if (txtChucDanh.Text == "")
            {
                MessageBox.Show("Không bỏ trống chức danh", "Thông báo", MessageBoxButtons.OK);
                txtChucDanh.Focus();
                return;
            }

            try
            {
                btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                txtMANV.Enabled = false;
                gcNhanVien.Enabled = true;
                gcLamViec.Enabled = true;
                groupBox1.Enabled = false;
                Them = false;

                bdsNV.EndEdit();
                //bdsBN.ResetCurrentItem();
                this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NhanVienTableAdapter.Update(this.DS.NHANVIEN);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                bdsNV.RemoveCurrent();
                MessageBox.Show("Lưu thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDT.Count > 0 || bdsLV.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên đang làm việc tại bệnh viên", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa bệnh nhân này không ?", "Xác Nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    vitri = bdsNV.Position;
                    bdsNV.RemoveCurrent();
                    this.NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NhanVienTableAdapter.Update(this.DS.NHANVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.NhanVienTableAdapter.Fill(this.DS.NHANVIEN);
                    bdsNV.Position = vitri;
                    return;
                }
            }

            if (bdsNV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.NhanVienTableAdapter.Fill(this.DS.NHANVIEN);
                this.LamViecTableAdapter.Fill(this.DS.LAMVIEC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload." + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dispose();
        }

        private void btnThemLV_Click(object sender, EventArgs e)
        {
            vitri = bdsLV.Position;
            groupBox2.Enabled = true;
            bdsLV.AddNew();
            txtMANVLV.Text = txtMANV.Text;

            btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnThemLV.Enabled = btnSuaLV.Enabled = btnXoaLV.Enabled = false;
            btnLuuLV.Enabled = true;
            gcNhanVien.Enabled = false;           
            Them = true;
        }

        private void btnSuaLV_Click(object sender, EventArgs e)
        {
            vitri = bdsLV.Position;
            groupBox2.Enabled = true;           

            btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnThemLV.Enabled = btnSuaLV.Enabled = btnXoaLV.Enabled = false;
            btnLuuLV.Enabled = true;
            gcNhanVien.Enabled = false;
                     
        }

        private void btnXoaLV_Click(object sender, EventArgs e)
        {           
            if (MessageBox.Show("Bạn có thật sự muốn xóa bệnh nhân này không ?", "Xác Nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    vitri = bdsLV.Position;
                    bdsLV.RemoveCurrent();
                    this.LamViecTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LamViecTableAdapter.Update(this.DS.LAMVIEC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.LamViecTableAdapter.Fill(this.DS.LAMVIEC);
                    bdsLV.Position = vitri;
                    return;
                }
            }

            if (bdsLV.Count == 0) btnXoaLV.Enabled = false;
        }

        private void btnLuuLV_Click(object sender, EventArgs e)
        {          
            if (txtMAKHU.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã khu", "Thông báo", MessageBoxButtons.OK);
                txtMAKHU.Focus();
                return;
            }           

            if (txtSGL.Text == "")
            {
                MessageBox.Show("Không bỏ trống số giờ làm", "Thông báo", MessageBoxButtons.OK);
                txtSGL.Focus();
                return;
            }          

            try
            {
                btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnThemLV.Enabled = btnSuaLV.Enabled = btnXoaLV.Enabled = btnLuuLV.Enabled = true;
                gcNhanVien.Enabled = true;
                gcLamViec.Enabled = true;
                groupBox2.Enabled = false;
                Them = false;

                bdsLV.EndEdit();
                //bdsBN.ResetCurrentItem();
                this.LamViecTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LamViecTableAdapter.Update(this.DS.LAMVIEC);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                bdsLV.RemoveCurrent();
                MessageBox.Show("Lưu thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbKhu.SelectedValue != null)
                {
                    txtMAKHU.Text = cmbKhu.SelectedValue.ToString();
                }
            }
            catch { }
        }
    }
}
