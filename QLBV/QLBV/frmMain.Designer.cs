namespace QLBV
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnBenhNhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnKCT = new DevExpress.XtraBars.BarButtonItem();
            this.btnNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnVT_SCT = new DevExpress.XtraBars.BarButtonItem();
            this.btnDT = new DevExpress.XtraBars.BarButtonItem();
            this.btnSGL = new DevExpress.XtraBars.BarButtonItem();
            this.btnSDVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnDTBN = new DevExpress.XtraBars.BarButtonItem();
            this.btnSL_PH = new DevExpress.XtraBars.BarButtonItem();
            this.HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.CHUCDANH = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.DimGray;
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40, 39, 40, 39);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangNhap,
            this.btnTTK,
            this.btnDangXuat,
            this.btnBenhNhan,
            this.btnKCT,
            this.btnNV,
            this.btnVT_SCT,
            this.btnDT,
            this.btnSGL,
            this.btnSDVT,
            this.btnDTBN,
            this.btnSL_PH});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 440;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HeThong,
            this.DanhMuc,
            this.ThongKe});
            this.ribbonControl1.Size = new System.Drawing.Size(1011, 158);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnTTK
            // 
            this.btnTTK.Caption = "Tạo Tài Khoản";
            this.btnTTK.Enabled = false;
            this.btnTTK.Id = 2;
            this.btnTTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTTK.ImageOptions.SvgImage")));
            this.btnTTK.Name = "btnTTK";
            this.btnTTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTTK_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 3;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.Caption = "Bệnh Nhân - \r\nSử Dụng Vật Tư";
            this.btnBenhNhan.Id = 4;
            this.btnBenhNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBenhNhan.ImageOptions.Image")));
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBenhNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBenhNhan_ItemClick);
            // 
            // btnKCT
            // 
            this.btnKCT.Caption = "Giường - \r\nKhu Chữa Trị\r\n";
            this.btnKCT.Id = 5;
            this.btnKCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKCT.ImageOptions.Image")));
            this.btnKCT.Name = "btnKCT";
            this.btnKCT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKCT_ItemClick);
            // 
            // btnNV
            // 
            this.btnNV.Caption = "Nhân Viên - \r\nLàm Việc\r\n";
            this.btnNV.Id = 6;
            this.btnNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNV.ImageOptions.Image")));
            this.btnNV.Name = "btnNV";
            this.btnNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNV_ItemClick);
            // 
            // btnVT_SCT
            // 
            this.btnVT_SCT.Caption = "Vật Tư - \r\nSự Chữa Trị";
            this.btnVT_SCT.Id = 8;
            this.btnVT_SCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVT_SCT.ImageOptions.Image")));
            this.btnVT_SCT.Name = "btnVT_SCT";
            this.btnVT_SCT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnVT_SCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVT_SCT_ItemClick);
            // 
            // btnDT
            // 
            this.btnDT.Caption = "Điều Trị";
            this.btnDT.Id = 13;
            this.btnDT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDT.ImageOptions.Image")));
            this.btnDT.Name = "btnDT";
            this.btnDT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDT_ItemClick);
            // 
            // btnSGL
            // 
            this.btnSGL.Caption = "Số Giờ Làm Của Nhân Viên";
            this.btnSGL.Id = 14;
            this.btnSGL.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSGL.ImageOptions.SvgImage")));
            this.btnSGL.Name = "btnSGL";
            this.btnSGL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSGL_ItemClick);
            // 
            // btnSDVT
            // 
            this.btnSDVT.Caption = "Sử Dụng Vật Tư";
            this.btnSDVT.Id = 15;
            this.btnSDVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSDVT.ImageOptions.SvgImage")));
            this.btnSDVT.Name = "btnSDVT";
            this.btnSDVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSDVT_ItemClick);
            // 
            // btnDTBN
            // 
            this.btnDTBN.Caption = "Điều Trị Bệnh Nhân";
            this.btnDTBN.Id = 16;
            this.btnDTBN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDTBN.ImageOptions.SvgImage")));
            this.btnDTBN.Name = "btnDTBN";
            this.btnDTBN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDTBN_ItemClick);
            // 
            // btnSL_PH
            // 
            this.btnSL_PH.Caption = "Sao Lưu - Phục Hồi";
            this.btnSL_PH.Enabled = false;
            this.btnSL_PH.Id = 17;
            this.btnSL_PH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSL_PH.ImageOptions.SvgImage")));
            this.btnSL_PH.Name = "btnSL_PH";
            this.btnSL_PH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSL_PH_ItemClick);
            // 
            // HeThong
            // 
            this.HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.HeThong.Name = "HeThong";
            this.HeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTTK);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSL_PH);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ Thống";
            // 
            // DanhMuc
            // 
            this.DanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.Text = "Danh Mục";
            this.DanhMuc.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBenhNhan);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDT);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKCT);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNV);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnVT_SCT);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh Mục";
            // 
            // ThongKe
            // 
            this.ThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Text = "Thống Kê";
            this.ThongKe.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSGL);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thống Kê";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSDVT);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Thống Kê";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDTBN);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Thống Kê";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.CHUCDANH});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1011, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(42, 17);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(45, 17);
            this.HOTEN.Text = "HOTEN";
            // 
            // CHUCDANH
            // 
            this.CHUCDANH.Name = "CHUCDANH";
            this.CHUCDANH.Size = new System.Drawing.Size(74, 17);
            this.CHUCDANH.Text = "CHUCDANH";
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 471);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản Lý Bệnh Viện";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel CHUCDANH;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnTTK;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage DanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnBenhNhan;
        private DevExpress.XtraBars.BarButtonItem btnKCT;
        private DevExpress.XtraBars.BarButtonItem btnNV;
        private DevExpress.XtraBars.BarButtonItem btnVT_SCT;
        private DevExpress.XtraBars.BarButtonItem btnDT;
        private DevExpress.XtraBars.BarButtonItem btnSGL;
        private DevExpress.XtraBars.BarButtonItem btnSDVT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnDTBN;
        private DevExpress.XtraBars.BarButtonItem btnSL_PH;
    }
}

