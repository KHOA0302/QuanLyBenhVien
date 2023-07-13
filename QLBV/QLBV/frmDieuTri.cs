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
    public partial class frmDieuTri : Form
    {
        int vitri = 0;
        bool Them = false;

        public frmDieuTri()
        {
            InitializeComponent();
        }

        private void dIEUTRIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmDieuTri_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.DieuTriTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DieuTriTableAdapter.Fill(this.DS.DIEUTRI);         

            this.SuChuaTriTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SuChuaTriTableAdapter.Fill(this.DS.SUCHUATRI);

            if (Program.mGroup == "YTA")
            {
                btnThem.Enabled = btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            }

            string strlenh = "SELECT * FROM V_BacSi";
            DataTable dt = Program.ExecSqlDataTable(strlenh);

            BindingSource bdsBS = new BindingSource();
            bdsBS.DataSource = dt;

            cmbBS.DataSource = bdsBS;
            cmbBS.DisplayMember = "TEN";
            cmbBS.ValueMember = "MANV";
            cmbBS.SelectedIndex = 0;


            string strlenh1 = "SELECT * FROM V_BenhNhan";
            DataTable dt1 = Program.ExecSqlDataTable(strlenh1);

            BindingSource bdsBN = new BindingSource();
            bdsBN.DataSource = dt1;

            cmbBN.DataSource = bdsBN;
            cmbBN.DisplayMember = "TEN";
            cmbBN.ValueMember = "MABN";
            cmbBN.SelectedIndex = 0;
        }

        private void cmbSCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbSCT.SelectedValue != null)
                {
                    txtMASCT.Text = cmbSCT.SelectedValue.ToString();
                }
            }
            catch { }
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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDT.Position;
            groupBox1.Enabled = true;
            bdsDT.AddNew();            
            txtMABS.Text = Program.username;
            cmbBN.Enabled = true;
            cmbBS.Enabled = true;
            cmbSCT.Enabled = true;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnLuu.Enabled = true;
            gcDieuTri.Enabled = false;           
            Them = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDT.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnLuu.Enabled = true;
            gcDieuTri.Enabled = false;

            if (Program.username != txtMABS.Text.ToString())
            {
                MessageBox.Show("Bạn không thể sửa vì bệnh nhân không phải do bạn điều trị", "Thông báo", MessageBoxButtons.OK);
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnLuu.Enabled = true;
                gcDieuTri.Enabled = true;
                return;
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMABN.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã bệnh nhân", "Thông báo", MessageBoxButtons.OK);
                txtMABN.Focus();
                return;
            }           

            if (txtMABS.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã bác sĩ", "Thông báo", MessageBoxButtons.OK);
                txtMABS.Focus();
                return;
            }

            if (txtMASCT.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã sự chữa trị", "Thông báo", MessageBoxButtons.OK);
                txtMABS.Focus();
                return;
            }

            if (dtpNgay.Text == "")
            {
                MessageBox.Show("Không bỏ trống ngày điều trị", "Thông báo", MessageBoxButtons.OK);
                dtpNgay.Focus();
                return;
            }

            if (txtThoiGian.Text == "")
            {
                MessageBox.Show("Không bỏ trống thời gian điều trị", "Thông báo", MessageBoxButtons.OK);
                txtThoiGian.Focus();
                return;
            }

            if (txtKetQua.Text == "")
            {
                MessageBox.Show("Không bỏ trống kết quả điều trị", "Thông báo", MessageBoxButtons.OK);
                txtKetQua.Focus();
                return;
            }

            try
            {
                btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;                
                gcDieuTri.Enabled = true;
                groupBox1.Enabled = false;
                Them = false;

                bdsDT.EndEdit();
                //bdsBN.ResetCurrentItem();
                this.DieuTriTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DieuTriTableAdapter.Update(this.DS.DIEUTRI);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                bdsDT.RemoveCurrent();
                MessageBox.Show("Lưu thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.DieuTriTableAdapter.Fill(this.DS.DIEUTRI);               
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDT.Position;
            if (Program.username != txtMABS.Text.ToString())
            {
                MessageBox.Show("Bạn không thể xóa vì bệnh nhân không phải do bạn điều trị", "Thông báo", MessageBoxButtons.OK);              
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa bệnh nhân này không ?", "Xác Nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    vitri = bdsDT.Position;
                    bdsDT.RemoveCurrent();
                    this.DieuTriTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.DieuTriTableAdapter.Update(this.DS.DIEUTRI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa bệnh nhân. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.DieuTriTableAdapter.Fill(this.DS.DIEUTRI);
                    bdsDT.Position = vitri;
                    return;
                }
            }
        }
    }
}
