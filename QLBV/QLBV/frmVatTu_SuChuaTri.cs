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
    public partial class frmVatTu_SuChuaTri : Form
    {
        int vitri = 0;
        bool Them = false;

        public frmVatTu_SuChuaTri()
        {
            InitializeComponent();
        }

        private void vATTUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {           
            DS.EnforceConstraints = false;

            this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VatTuTableAdapter.Fill(this.DS.VATTU);

            this.SuChuaTriTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SuChuaTriTableAdapter.Fill(this.DS.SUCHUATRI);

            this.SuDungTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SuDungTableAdapter.Fill(this.DS.SUDUNG);
         
            this.DieuTriTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DieuTriTableAdapter.Fill(this.DS.DIEUTRI);

            if (Program.mGroup == "YTA" || Program.mGroup == "BACSI")
            {
                btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = false;                
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnMenu.Links[0].Caption == "Vật Tư")
            {
                vitri = bdsVT.Position;
                groupBox1.Enabled = true;
                bdsVT.AddNew();
                txtMAVT.Enabled = true;
                gcVatTu.Enabled = false;
            }    
            
            if (btnMenu.Links[0].Caption == "Sự Chữa Trị")
            {
                vitri = bdsSCT.Position;
                groupBox2.Enabled = true;
                bdsSCT.AddNew();
                txtMASCT.Enabled = true;
                gcSuChuaTri.Enabled = false;
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnLuu.Enabled = true;
            btnMenu.Enabled = false;
            Them = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnMenu.Links[0].Caption == "Vật Tư")
            {
                vitri = bdsVT.Position;
                groupBox1.Enabled = true;
                gcVatTu.Enabled = false;
            }

            if (btnMenu.Links[0].Caption == "Sự Chữa Trị")
            {
                vitri = bdsSCT.Position;
                groupBox2.Enabled = true;
                gcSuChuaTri.Enabled = false;
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnLuu.Enabled = true;
            
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnMenu.Links[0].Caption == "Vật Tư")
            {
                if (txtMAVT.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã vật tư", "Thông báo", MessageBoxButtons.OK);
                    txtMAVT.Focus();
                    return;
                }

                if (Them == true)
                {
                    String cauTruyVan =
                        "DECLARE @result int " +
                        "EXEC @result = SP_Kiem_Tra_MAVT '" +
                        txtMAVT.Text.ToString() + "' " +
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
                        MessageBox.Show("Mã vật tư này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                        txtMAVT.Focus();
                        return;
                    }
                }

                if (txtTENVT.Text == "")
                {
                    MessageBox.Show("Không bỏ trống tên vật tư", "Thông báo", MessageBoxButtons.OK);
                    txtTENVT.Focus();
                    return;
                }

                if (txtDonGia.Text == "")
                {
                    MessageBox.Show("Không bỏ trống đơn giá", "Thông báo", MessageBoxButtons.OK);
                    txtDonGia.Focus();
                    return;
                }

                if (txtDacTa.Text == "")
                {
                    MessageBox.Show("Không bỏ trống đặc tả vật tư", "Thông báo", MessageBoxButtons.OK);
                    txtDacTa.Focus();
                    return;
                }

                try
                {
                    btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                    txtMAVT.Enabled = false;
                    gcVatTu.Enabled = true;
                    groupBox1.Enabled = false;
                    btnMenu.Enabled = true;
                    Them = false;

                    bdsVT.EndEdit();
                    //bdsBN.ResetCurrentItem();
                    this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.VatTuTableAdapter.Update(this.DS.VATTU);
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    bdsVT.RemoveCurrent();
                    MessageBox.Show("Lưu thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            if (btnMenu.Links[0].Caption == "Sự Chữa Trị")
            {
                if (txtMASCT.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã sự chữa trị", "Thông báo", MessageBoxButtons.OK);
                    txtMAVT.Focus();
                    return;
                }

                if (Them == true)
                {
                    String cauTruyVan =
                        "DECLARE @result int " +
                        "EXEC @result = SP_Kiem_Tra_MASCT '" +
                        txtMASCT.Text.ToString() + "' " +
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
                        MessageBox.Show("Mã sự chữa trị này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                        txtMAVT.Focus();
                        return;
                    }
                }

                if (txtTENSCT.Text == "")
                {
                    MessageBox.Show("Không bỏ trống tên sự chữa trị", "Thông báo", MessageBoxButtons.OK);
                    txtTENVT.Focus();
                    return;
                }

                try
                {
                    btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                    txtMASCT.Enabled = false;
                    gcSuChuaTri.Enabled = true;
                    groupBox2.Enabled = false;
                    btnMenu.Enabled = true;
                    Them = false;

                    bdsSCT.EndEdit();
                    //bdsBN.ResetCurrentItem();
                    this.SuChuaTriTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SuChuaTriTableAdapter.Update(this.DS.SUCHUATRI);
                    MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    bdsSCT.RemoveCurrent();
                    MessageBox.Show("Lưu thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnMenu.Links[0].Caption == "Vật Tư")
            {
                if (bdsSD.Count > 0)
                {
                    MessageBox.Show("Không thể xóa vật tư đang sử dụng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (MessageBox.Show("Bạn có thật sự muốn xóa bệnh nhân này không ?", "Xác Nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        vitri = bdsVT.Position;
                        bdsVT.RemoveCurrent();
                        this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.VatTuTableAdapter.Update(this.DS.VATTU);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa bệnh nhân. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                        this.VatTuTableAdapter.Fill(this.DS.VATTU);
                        bdsVT.Position = vitri;
                        return;
                    }
                }

                if (bdsVT.Count == 0) btnXoa.Enabled = false;
            }

            if (btnMenu.Links[0].Caption == "Sự Chữa Trị")
            {
                if (bdsDT.Count > 0)
                {
                    MessageBox.Show("Không thể xóa sự chữa trị vì đang dùng điều trị bệnh nhân", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (MessageBox.Show("Bạn có thật sự muốn xóa bệnh nhân này không ?", "Xác Nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        vitri = bdsSCT.Position;
                        bdsSCT.RemoveCurrent();
                        this.SuChuaTriTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.SuChuaTriTableAdapter.Update(this.DS.SUCHUATRI);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa bệnh nhân. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                        this.SuChuaTriTableAdapter.Fill(this.DS.SUCHUATRI);
                        bdsSCT.Position = vitri;
                        return;
                    }
                }

                if (bdsVT.Count == 0) btnXoa.Enabled = false;
            }
            
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.VatTuTableAdapter.Fill(this.DS.VATTU);
                this.SuChuaTriTableAdapter.Fill(this.DS.SUCHUATRI);
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

        private void btnVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMenu.Links[0].Caption = "Vật Tư";
            gcVatTu.Enabled = true;
            gcSuChuaTri.Enabled = false;
        }

        private void btnSCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMenu.Links[0].Caption = "Sự Chữa Trị";
            gcSuChuaTri.Enabled = true;
            gcVatTu.Enabled = false;
        }
    }
}
