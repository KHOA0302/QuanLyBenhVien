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
    public partial class frmBenhNhan : Form
    {
        int vitri = 0;
        bool Them = false;

        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void bENHNHANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmBenhNhan_Load(object sender, EventArgs e)
        {          
            DS.EnforceConstraints = false;

            this.BenhNhanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BenhNhanTableAdapter.Fill(this.DS.BENHNHAN);

            this.SuDungTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SuDungTableAdapter.Fill(this.DS.SUDUNG);

            this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;           
            this.VatTuTableAdapter.Fill(this.DS.VATTU);

            this.GiuongTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GiuongTableAdapter.Fill(this.DS.GIUONG);

            this.DieuTriTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DieuTriTableAdapter.Fill(this.DS.DIEUTRI);

            if (Program.mGroup == "BACSI")
            {
                btnThem.Enabled = btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;               
            }

            if (Program.mGroup == "YTA")
            {
                contextMenuStrip1.Enabled = false;
            }

            string strlenh = "SELECT * FROM V_BacSi";
            DataTable dt = Program.ExecSqlDataTable(strlenh);

            BindingSource bdsBS = new BindingSource();
            bdsBS.DataSource = dt;

            cmbBS.DataSource = bdsBS;
            cmbBS.DisplayMember = "TEN";
            cmbBS.ValueMember = "MANV";
            cmbBS.SelectedIndex = 0;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsBN.Position;
            groupBox1.Enabled = true;
            bdsBN.AddNew();           
            txtMABS.Text = Program.username;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnLuu.Enabled = true;
            gcBenhNhan.Enabled = false;
            gcSuDung.Enabled = false;
            Them = true;

            String strLenh = "DECLARE @MA INT = DBO.TangMaBN()" + "SELECT @MA";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            txtMABN.Text = Program.myReader.GetInt32(0).ToString();
            Program.myReader.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsBN.Position;
            groupBox1.Enabled = true;           

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnLuu.Enabled = true;
            gcBenhNhan.Enabled = false;
            gcSuDung.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMABN.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã bệnh nhân", "Thông báo", MessageBoxButtons.OK);
                txtMABN.Focus();
                return;
            }

            if (Them == true)
            {
                String cauTruyVan =
                    "DECLARE @result int " +
                    "EXEC @result = SP_Kiem_Tra_MABN '" +
                    txtMABN.Text.ToString() + "' " +
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

            if (txtTen.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên bệnh nhân", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }

            if (dtpNgaySinh.Text == "")
            {
                MessageBox.Show("Không bỏ trống ngày sinh bệnh nhân", "Thông báo", MessageBoxButtons.OK);
                dtpNgaySinh.Focus();
                return;
            }

            if (txtMABS.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã bác sĩ điều trị", "Thông báo", MessageBoxButtons.OK);
                txtMABS.Focus();
                return;
            }

            try
            {
                btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                txtMABN.Enabled = false;
                gcBenhNhan.Enabled = true;
                gcSuDung.Enabled = true;
                groupBox1.Enabled = false;
                Them = false;

                bdsBN.EndEdit();
                //bdsBN.ResetCurrentItem();
                this.BenhNhanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.BenhNhanTableAdapter.Update(this.DS.BENHNHAN);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                bdsBN.RemoveCurrent();
                MessageBox.Show("Lưu thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDT.Count > 0 || bdsGiuong.Count > 0 || bdsSD.Count > 0)
            {
                MessageBox.Show("Không thể xóa bệnh nhân đang điều trị tại bệnh viên", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa bệnh nhân này không ?" , "Xác Nhận", 
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    vitri = bdsBN.Position;
                    bdsBN.RemoveCurrent();
                    this.BenhNhanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.BenhNhanTableAdapter.Update(this.DS.BENHNHAN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa bệnh nhân. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.BenhNhanTableAdapter.Fill(this.DS.BENHNHAN);
                    bdsBN.Position = vitri;
                    return;
                }
            }

            if(bdsBN.Count == 0) btnXoa.Enabled = false;
        }
        

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.BenhNhanTableAdapter.Fill(this.DS.BENHNHAN);
                this.SuDungTableAdapter.Fill(this.DS.SUDUNG);
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

        private void btnThemSD_Click(object sender, EventArgs e)
        {
            vitri = bdsSD.Position;
            groupBox2.Enabled = true;
            bdsSD.AddNew();           
            txtMABNSD.Text = txtMABN.Text;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnLuu.Enabled = false;
            btnThemSD.Enabled = btnSuaSD.Enabled = btnXoaSD.Enabled = false;
            btnLuuSD.Enabled = true;
            gcBenhNhan.Enabled = false;           
            Them = true;
        }

        private void btnSuaSD_Click(object sender, EventArgs e)
        {
            vitri = bdsSD.Position;
            groupBox2.Enabled = true;          

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnLuu.Enabled = false;
            btnThemSD.Enabled = btnSuaSD.Enabled = btnXoaSD.Enabled = false;
            btnLuuSD.Enabled = true;
            gcBenhNhan.Enabled = false;          
        }

        private void btnLuuSD_Click(object sender, EventArgs e)
        {

            if (txtMAVT.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã vật tư", "Thông báo", MessageBoxButtons.OK);               
                return;
            }           

            if (txtLan.Text == "")
            {
                MessageBox.Show("Không bỏ trống lần sử dụng vật tư", "Thông báo", MessageBoxButtons.OK);
                txtLan.Focus();
                return;
            }

            if (dtpNgay.Text == "")
            {
                MessageBox.Show("Không bỏ trống ngày", "Thông báo", MessageBoxButtons.OK);
                dtpNgay.Focus();
                return;
            }

            if (txtThoiGian.Text == "")
            {
                MessageBox.Show("Không bỏ trống thời gian sử dụng", "Thông báo", MessageBoxButtons.OK);
                txtThoiGian.Focus();
                return;
            }

            if (txtSL.Text == "")
            {
                MessageBox.Show("Không bỏ trống số lượng", "Thông báo", MessageBoxButtons.OK);
                txtSL.Focus();
                return;
            }

            String strLenh = "DECLARE @tien float = DBO.TinhTienSuDungVatTu( '" + txtMAVT.Text.ToString() + "', " + int.Parse(txtSL.Text.ToString()) +")" + "SELECT @tien";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            txtTongTien.Text = Program.myReader.GetDouble(0).ToString();
            Program.myReader.Close();

            if (txtTongTien.Text == "")
            {
                MessageBox.Show("Không bỏ trống tổng tiền", "Thông báo", MessageBoxButtons.OK);
                txtTongTien.Focus();
                return;
            }

            try
            {
                btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnThemSD.Enabled = btnSuaSD.Enabled = btnXoaSD.Enabled = btnLuuSD.Enabled = true;
                gcBenhNhan.Enabled = true;
                gcSuDung.Enabled = true;
                groupBox2.Enabled = false;
                Them = false;

                bdsSD.EndEdit();
                //bdsBN.ResetCurrentItem();
                this.SuDungTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SuDungTableAdapter.Update(this.DS.SUDUNG);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                bdsSD.RemoveCurrent();
                MessageBox.Show("Lưu thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaSD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa không ?", "Xác Nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    vitri = bdsSD.Position;
                    bdsSD.RemoveCurrent();
                    this.SuDungTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SuDungTableAdapter.Update(this.DS.SUDUNG);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa bệnh nhân. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.SuDungTableAdapter.Fill(this.DS.SUDUNG);
                    bdsSD.Position = vitri;
                    return;
                }
            }

            if (bdsSD.Count == 0) btnXoa.Enabled = false;
        }

        private void cmbVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbVT.SelectedValue != null) 
                { 
                    txtMAVT.Text = cmbVT.SelectedValue.ToString();
                }
            }
            catch(Exception) { }
        }

        private void cmbBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBS.SelectedValue != null)
                {
                    txtMABS.Text = cmbBS.SelectedValue.ToString();
                }
            }
            catch (Exception) { }
        }
    }
}
