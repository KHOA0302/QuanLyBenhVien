using DevExpress.XtraReports.UI;
using QLBV.Report_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        public void HienThiMenu()
        {
            MANV.Text = "Mã nhân viên : " + Program.username;
            HOTEN.Text = "Họ tên nhân viên : " + Program.mHoten;
            CHUCDANH.Text = "Chức danh : " + Program.mGroup;
            DanhMuc.Visible = ThongKe.Visible = true;   
            btnDangXuat.Enabled = true;
            
            if (Program.mGroup == "ADMIN")
            {
                btnTTK.Enabled = btnSL_PH.Enabled = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnBenhNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBenhNhan));
            if (frm != null) frm.Activate();
            else
            {
                frmBenhNhan f = new frmBenhNhan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnVT_SCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVatTu_SuChuaTri));
            if (frm != null) frm.Activate();
            else
            {
                frmVatTu_SuChuaTri f = new frmVatTu_SuChuaTri();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien_LamViec));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien_LamViec f = new frmNhanVien_LamViec();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDieuTri));
            if (frm != null) frm.Activate();
            else
            {
                frmDieuTri f = new frmDieuTri();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Dispose();
            }

            DanhMuc.Visible = ThongKe.Visible = false;
            btnTTK.Enabled = false;
            btnDangXuat.Enabled = false;
            btnSL_PH.Enabled = false;

            Program.frmChinh.MANV.Text = "MANV";
            Program.frmChinh.HOTEN.Text = "HOTEN";
            Program.frmChinh.CHUCDANH.Text = "CHUCDANH";
        }

        private void btnKCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKhuChuaTri_Giuong));
            if (frm != null) frm.Activate();
            else
            {
                frmKhuChuaTri_Giuong f = new frmKhuChuaTri_Giuong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSGL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xrpt_SoGioLamNhanVien rpt = new Xrpt_SoGioLamNhanVien();

            ReportPrintTool preview = new ReportPrintTool(rpt);
            preview.ShowPreviewDialog();
        }

        private void btnTTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();               
                f.Show();
            }
        }

        private void btnSDVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_SuDungVatTu));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_SuDungVatTu f = new Frpt_SuDungVatTu();
                f.Show();
            }
        }

        private void btnDTBN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_DieuTri));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_DieuTri f = new Frpt_DieuTri();
                f.Show();
            }
        }

        private void btnSL_PH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSaoLuuPhucHoi));
            if (frm != null) frm.Activate();
            else
            {
                frmSaoLuuPhucHoi f = new frmSaoLuuPhucHoi();
                f.Show();
            }
        }
    }
}
