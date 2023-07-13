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
    public partial class frmKhuChuaTri_Giuong : Form
    {
        int vitri = 0;
        bool Them = false;

        public frmKhuChuaTri_Giuong()
        {
            InitializeComponent();
        }

        private void kHUCHUATRIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKCT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void fromKhuChuaTri_Giuong_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.KhuChuaTriTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KhuChuaTriTableAdapter.Fill(this.DS.KHUCHUATRI);

            this.GiuongTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GiuongTableAdapter.Fill(this.DS.GIUONG);

            this.LamViecTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LamViecTableAdapter.Fill(this.DS.LAMVIEC);
                             
            if (Program.mGroup != "ADMIN")
            {
                btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = false;
                btnThemG.Enabled = btnXoaG.Enabled = false;
            }

            string strlenh = "EXEC SP_NhanVienKhongLaYTaTruong";
            DataTable dt = Program.ExecSqlDataTable(strlenh);

            BindingSource bdsYT = new BindingSource();
            bdsYT.DataSource = dt;

            cmbYT.DataSource = bdsYT;
            cmbYT.DisplayMember = "TEN";
            cmbYT.ValueMember = "MANV";
            cmbYT.SelectedIndex = -1;

            string strlenh1 = "EXEC SP_BenhNhanChuaNamGiuong";
            DataTable dt1 = Program.ExecSqlDataTable(strlenh1);

            BindingSource bdsBN = new BindingSource();
            bdsBN.DataSource = dt1;

            cmbBN.DataSource = bdsBN;
            cmbBN.DisplayMember = "TEN";
            cmbBN.ValueMember = "MABN";
            cmbBN.SelectedIndex = -1;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKCT.Position;
            groupBox1.Enabled = true;
            bdsKCT.AddNew();
            txtMAKHU.Enabled = true;          

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnLuu.Enabled = true;
            gcKhuChuaTri.Enabled = false;
            gcGiuong.Enabled = false;
            Them = true;           
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKCT.Position;
            groupBox1.Enabled = true;          

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnLuu.Enabled = true;
            gcKhuChuaTri.Enabled = false;
            gcGiuong.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMAKHU.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã khu", "Thông báo", MessageBoxButtons.OK);
                txtMAKHU.Focus();
                return;
            }

            if (Them == true)
            {
                String cauTruyVan =
                    "DECLARE @result int " +
                    "EXEC @result = SP_Kiem_Tra_MAKCT '" +
                    txtMAKHU.Text.ToString() + "' " +
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
                    MessageBox.Show("Mã bệnh nhân này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                    txtMABN.Focus();
                    return;
                }
            }

            if (txtTENKHU.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên khu chữa trị", "Thông báo", MessageBoxButtons.OK);
                txtTENKHU.Focus();
                return;
            }

            if (txtMANV.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã y tá trưởng", "Thông báo", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }

            try
            {
                btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                txtMABN.Enabled = false;
                gcKhuChuaTri.Enabled = true;
                gcGiuong.Enabled = true;
                groupBox1.Enabled = false;
                Them = false;

                bdsKCT.EndEdit();
                //bdsBN.ResetCurrentItem();
                this.KhuChuaTriTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KhuChuaTriTableAdapter.Update(this.DS.KHUCHUATRI);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                bdsKCT.RemoveCurrent();
                MessageBox.Show("Lưu thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLV.Count > 0)
            {
                MessageBox.Show("Không thể xóa khu chữa trị đang có nhân viên làm việc", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bdsG.Count > 0)
            {
                MessageBox.Show("Không thể xóa khu chữa trị đang có giường bệnh", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa bệnh nhân này không ?", "Xác Nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    vitri = bdsKCT.Position;
                    bdsKCT.RemoveCurrent();
                    this.KhuChuaTriTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KhuChuaTriTableAdapter.Update(this.DS.KHUCHUATRI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa bệnh nhân. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.KhuChuaTriTableAdapter.Fill(this.DS.KHUCHUATRI);
                    bdsKCT.Position = vitri;
                    return;
                }
            }

            if (bdsKCT.Count == 0) btnXoa.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.KhuChuaTriTableAdapter.Fill(this.DS.KHUCHUATRI);
                this.GiuongTableAdapter.Fill(this.DS.GIUONG);
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

        private void cmbYT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbYT.SelectedValue != null)
                {
                    txtMANV.Text = cmbYT.SelectedValue.ToString();
                }
            }
            catch { }
        }

        private void cmbBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBN.SelectedValue != null)
                {
                    txtMABN.Text = cmbBN.SelectedValue.ToString();
                }
            }
            catch { }
        }

        private void btnThemG_Click(object sender, EventArgs e)
        {
            vitri = bdsG.Position;
            groupBox2.Enabled = true;
            bdsG.AddNew();
            txtSG.Enabled = true;
            txtMKG.Text = txtMAKHU.Text;
            txtMABN.Text = "0";

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnLuu.Enabled = false;
            btnThemG.Enabled = btnSuaG.Enabled = btnXoaG.Enabled = false;
            gcKhuChuaTri.Enabled = false;           
            Them = true;          
        }

        private void btnSuaG_Click(object sender, EventArgs e)
        {
            vitri = bdsG.Position;
            groupBox2.Enabled = true;
            txtMABN.Enabled = true;
            
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnLuu.Enabled = false;
            btnThemG.Enabled = btnSuaG.Enabled = btnXoaG.Enabled = false;
            gcKhuChuaTri.Enabled = false;
        }

        private void btnLuuG_Click(object sender, EventArgs e)
        {
            if (txtSG.Text == "")
            {
                MessageBox.Show("Không bỏ trống số giường", "Thông báo", MessageBoxButtons.OK);
                txtSG.Focus();
                return;
            }

            if (Them == true)
            {
                String cauTruyVan =
                    "DECLARE @result int " +
                    "EXEC @result = SP_Kiem_Tra_SG '" +
                    txtSG.Text.ToString() + "' " +
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
                    MessageBox.Show("Mã bệnh nhân này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                    txtMABN.Focus();
                    return;
                }
            }           

            try
            {
                btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnThemG.Enabled = btnSuaG.Enabled = btnXoaG.Enabled = btnLuuG.Enabled = true;
                txtSG.Enabled = false;
                txtMABN.Enabled = false;
                gcKhuChuaTri.Enabled = true;
                gcGiuong.Enabled = true;
                groupBox2.Enabled = false;
                Them = false;

                bdsG.EndEdit();
                //bdsBN.ResetCurrentItem();
                this.GiuongTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GiuongTableAdapter.Update(this.DS.GIUONG);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                bdsG.RemoveCurrent();
                MessageBox.Show("Lưu thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaG_Click(object sender, EventArgs e)
        {
            if (txtMABN.Text != "0")
            {
                MessageBox.Show("Không thể xóa giường mà bệnh nhân đang nằm", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa bệnh nhân này không ?", "Xác Nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    vitri = bdsG.Position;
                    bdsG.RemoveCurrent();
                    this.GiuongTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.GiuongTableAdapter.Update(this.DS.GIUONG);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giường. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.GiuongTableAdapter.Fill(this.DS.GIUONG);
                    bdsG.Position = vitri;
                    return;
                }
            }

            if (bdsG.Count == 0) btnXoaG.Enabled = false;
        }

       
    }
}
