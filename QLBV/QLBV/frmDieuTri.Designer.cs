namespace QLBV
{
    partial class frmDieuTri
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
            System.Windows.Forms.Label mASCTLabel;
            System.Windows.Forms.Label mABSLabel;
            System.Windows.Forms.Label mABNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label kETQUALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDieuTri));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new QLBV.DS();
            this.bdsDT = new System.Windows.Forms.BindingSource(this.components);
            this.DieuTriTableAdapter = new QLBV.DSTableAdapters.DIEUTRITableAdapter();
            this.tableAdapterManager = new QLBV.DSTableAdapters.TableAdapterManager();
            this.SuChuaTriTableAdapter = new QLBV.DSTableAdapters.SUCHUATRITableAdapter();
            this.gcDieuTri = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMABS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMABN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKETQUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBS = new System.Windows.Forms.ComboBox();
            this.cmbBN = new System.Windows.Forms.ComboBox();
            this.cmbSCT = new System.Windows.Forms.ComboBox();
            this.bdsSCT = new System.Windows.Forms.BindingSource(this.components);
            this.txtKetQua = new DevExpress.XtraEditors.TextEdit();
            this.txtThoiGian = new DevExpress.XtraEditors.TextEdit();
            this.dtpNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMABN = new DevExpress.XtraEditors.TextEdit();
            this.txtMABS = new DevExpress.XtraEditors.TextEdit();
            this.txtMASCT = new DevExpress.XtraEditors.TextEdit();
            mASCTLabel = new System.Windows.Forms.Label();
            mABSLabel = new System.Windows.Forms.Label();
            mABNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            kETQUALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDieuTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKetQua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASCT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mASCTLabel
            // 
            mASCTLabel.AutoSize = true;
            mASCTLabel.Location = new System.Drawing.Point(246, 62);
            mASCTLabel.Name = "mASCTLabel";
            mASCTLabel.Size = new System.Drawing.Size(104, 17);
            mASCTLabel.TabIndex = 0;
            mASCTLabel.Text = "Mã Sự Chữa Trị";
            // 
            // mABSLabel
            // 
            mABSLabel.AutoSize = true;
            mABSLabel.Location = new System.Drawing.Point(246, 105);
            mABSLabel.Name = "mABSLabel";
            mABSLabel.Size = new System.Drawing.Size(71, 17);
            mABSLabel.TabIndex = 2;
            mABSLabel.Text = "Mã Bác Sĩ";
            // 
            // mABNLabel
            // 
            mABNLabel.AutoSize = true;
            mABNLabel.Location = new System.Drawing.Point(246, 147);
            mABNLabel.Name = "mABNLabel";
            mABNLabel.Size = new System.Drawing.Size(99, 17);
            mABNLabel.TabIndex = 4;
            mABNLabel.Text = "Mã Bệnh Nhân";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(701, 62);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(92, 17);
            nGAYLabel.TabIndex = 6;
            nGAYLabel.Text = "Ngày Điều Trị";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(701, 105);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(66, 17);
            tHOIGIANLabel.TabIndex = 8;
            tHOIGIANLabel.Text = "Thời Gian";
            // 
            // kETQUALabel
            // 
            kETQUALabel.AutoSize = true;
            kETQUALabel.Location = new System.Drawing.Point(701, 147);
            kETQUALabel.Name = "kETQUALabel";
            kETQUALabel.Size = new System.Drawing.Size(59, 17);
            kETQUALabel.TabIndex = 10;
            kETQUALabel.Text = "Kết Quả";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar7});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnLuu,
            this.btnXoa,
            this.btnUndo,
            this.btnReload,
            this.btnChuyenCN,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar7;
            this.barManager1.MaxItemId = 8;
            // 
            // bar7
            // 
            this.bar7.BarName = "Main menu";
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar7.FloatLocation = new System.Drawing.Point(163, 122);
            this.bar7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar7.OptionsBar.MultiLine = true;
            this.bar7.OptionsBar.UseWholeRow = true;
            this.bar7.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 2;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1067, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 588);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 564);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 564);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Hoàn tác";
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            // 
            // btnChuyenCN
            // 
            this.btnChuyenCN.Caption = "Chuyển chi nhánh";
            this.btnChuyenCN.Id = 6;
            this.btnChuyenCN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenCN.ImageOptions.Image")));
            this.btnChuyenCN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChuyenCN.ImageOptions.LargeImage")));
            this.btnChuyenCN.Name = "btnChuyenCN";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDT
            // 
            this.bdsDT.DataMember = "DIEUTRI";
            this.bdsDT.DataSource = this.DS;
            // 
            // DieuTriTableAdapter
            // 
            this.DieuTriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.DIEUTRITableAdapter = this.DieuTriTableAdapter;
            this.tableAdapterManager.GIUONGTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.LAMVIECTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SUCHUATRITableAdapter = this.SuChuaTriTableAdapter;
            this.tableAdapterManager.SUDUNGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLBV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // SuChuaTriTableAdapter
            // 
            this.SuChuaTriTableAdapter.ClearBeforeFill = true;
            // 
            // gcDieuTri
            // 
            this.gcDieuTri.DataSource = this.bdsDT;
            this.gcDieuTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDieuTri.Location = new System.Drawing.Point(0, 24);
            this.gcDieuTri.MainView = this.gridView1;
            this.gcDieuTri.MenuManager = this.barManager1;
            this.gcDieuTri.Name = "gcDieuTri";
            this.gcDieuTri.Size = new System.Drawing.Size(1067, 326);
            this.gcDieuTri.TabIndex = 5;
            this.gcDieuTri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASCT,
            this.colMABS,
            this.colMABN,
            this.colNGAY,
            this.colTHOIGIAN,
            this.colKETQUA});
            this.gridView1.GridControl = this.gcDieuTri;
            this.gridView1.Name = "gridView1";
            // 
            // colMASCT
            // 
            this.colMASCT.Caption = "Mã Sự Chữa Trị";
            this.colMASCT.FieldName = "MASCT";
            this.colMASCT.Name = "colMASCT";
            this.colMASCT.Visible = true;
            this.colMASCT.VisibleIndex = 0;
            // 
            // colMABS
            // 
            this.colMABS.Caption = "Mã Bác Sĩ";
            this.colMABS.FieldName = "MABS";
            this.colMABS.Name = "colMABS";
            this.colMABS.Visible = true;
            this.colMABS.VisibleIndex = 1;
            // 
            // colMABN
            // 
            this.colMABN.Caption = "Mã Bệnh Nhân";
            this.colMABN.FieldName = "MABN";
            this.colMABN.Name = "colMABN";
            this.colMABN.Visible = true;
            this.colMABN.VisibleIndex = 2;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày Điều Trị";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 3;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.Caption = "Thời Gian";
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 4;
            // 
            // colKETQUA
            // 
            this.colKETQUA.Caption = "Kết Quả";
            this.colKETQUA.FieldName = "KETQUA";
            this.colKETQUA.Name = "colKETQUA";
            this.colKETQUA.Visible = true;
            this.colKETQUA.VisibleIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBS);
            this.groupBox1.Controls.Add(this.cmbBN);
            this.groupBox1.Controls.Add(this.cmbSCT);
            this.groupBox1.Controls.Add(kETQUALabel);
            this.groupBox1.Controls.Add(this.txtKetQua);
            this.groupBox1.Controls.Add(tHOIGIANLabel);
            this.groupBox1.Controls.Add(this.txtThoiGian);
            this.groupBox1.Controls.Add(nGAYLabel);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(mABNLabel);
            this.groupBox1.Controls.Add(this.txtMABN);
            this.groupBox1.Controls.Add(mABSLabel);
            this.groupBox1.Controls.Add(this.txtMABS);
            this.groupBox1.Controls.Add(mASCTLabel);
            this.groupBox1.Controls.Add(this.txtMASCT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 238);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết Điều Trị Bệnh Nhân";
            // 
            // cmbBS
            // 
            this.cmbBS.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDT, "MABS", true));
            this.cmbBS.Enabled = false;
            this.cmbBS.FormattingEnabled = true;
            this.cmbBS.Location = new System.Drawing.Point(429, 102);
            this.cmbBS.Name = "cmbBS";
            this.cmbBS.Size = new System.Drawing.Size(195, 25);
            this.cmbBS.TabIndex = 14;
            this.cmbBS.SelectedIndexChanged += new System.EventHandler(this.cmbBS_SelectedIndexChanged);
            // 
            // cmbBN
            // 
            this.cmbBN.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDT, "MABN", true));
            this.cmbBN.Enabled = false;
            this.cmbBN.FormattingEnabled = true;
            this.cmbBN.Location = new System.Drawing.Point(429, 143);
            this.cmbBN.Name = "cmbBN";
            this.cmbBN.Size = new System.Drawing.Size(195, 25);
            this.cmbBN.TabIndex = 13;
            this.cmbBN.SelectedIndexChanged += new System.EventHandler(this.cmbBN_SelectedIndexChanged);
            // 
            // cmbSCT
            // 
            this.cmbSCT.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDT, "MASCT", true));
            this.cmbSCT.DataSource = this.bdsSCT;
            this.cmbSCT.DisplayMember = "TEN";
            this.cmbSCT.Enabled = false;
            this.cmbSCT.FormattingEnabled = true;
            this.cmbSCT.Location = new System.Drawing.Point(429, 58);
            this.cmbSCT.Name = "cmbSCT";
            this.cmbSCT.Size = new System.Drawing.Size(195, 25);
            this.cmbSCT.TabIndex = 12;
            this.cmbSCT.ValueMember = "SO";
            this.cmbSCT.SelectedIndexChanged += new System.EventHandler(this.cmbSCT_SelectedIndexChanged);
            // 
            // bdsSCT
            // 
            this.bdsSCT.DataMember = "SUCHUATRI";
            this.bdsSCT.DataSource = this.DS;
            // 
            // txtKetQua
            // 
            this.txtKetQua.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDT, "KETQUA", true));
            this.txtKetQua.Location = new System.Drawing.Point(799, 144);
            this.txtKetQua.MenuManager = this.barManager1;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Properties.Appearance.Options.UseFont = true;
            this.txtKetQua.Size = new System.Drawing.Size(226, 24);
            this.txtKetQua.TabIndex = 11;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDT, "THOIGIAN", true));
            this.txtThoiGian.Location = new System.Drawing.Point(799, 102);
            this.txtThoiGian.MenuManager = this.barManager1;
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.Properties.Appearance.Options.UseFont = true;
            this.txtThoiGian.Size = new System.Drawing.Size(226, 24);
            this.txtThoiGian.TabIndex = 9;
            // 
            // dtpNgay
            // 
            this.dtpNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDT, "NGAY", true));
            this.dtpNgay.EditValue = null;
            this.dtpNgay.Location = new System.Drawing.Point(799, 59);
            this.dtpNgay.MenuManager = this.barManager1;
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Properties.Appearance.Options.UseFont = true;
            this.dtpNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgay.Size = new System.Drawing.Size(226, 24);
            this.dtpNgay.TabIndex = 7;
            // 
            // txtMABN
            // 
            this.txtMABN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDT, "MABN", true));
            this.txtMABN.Enabled = false;
            this.txtMABN.Location = new System.Drawing.Point(356, 144);
            this.txtMABN.MenuManager = this.barManager1;
            this.txtMABN.Name = "txtMABN";
            this.txtMABN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMABN.Properties.Appearance.Options.UseFont = true;
            this.txtMABN.Size = new System.Drawing.Size(67, 24);
            this.txtMABN.TabIndex = 5;
            // 
            // txtMABS
            // 
            this.txtMABS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDT, "MABS", true));
            this.txtMABS.Enabled = false;
            this.txtMABS.Location = new System.Drawing.Point(356, 102);
            this.txtMABS.MenuManager = this.barManager1;
            this.txtMABS.Name = "txtMABS";
            this.txtMABS.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMABS.Properties.Appearance.Options.UseFont = true;
            this.txtMABS.Size = new System.Drawing.Size(67, 24);
            this.txtMABS.TabIndex = 3;
            // 
            // txtMASCT
            // 
            this.txtMASCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDT, "MASCT", true));
            this.txtMASCT.Enabled = false;
            this.txtMASCT.Location = new System.Drawing.Point(356, 59);
            this.txtMASCT.MenuManager = this.barManager1;
            this.txtMASCT.Name = "txtMASCT";
            this.txtMASCT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMASCT.Properties.Appearance.Options.UseFont = true;
            this.txtMASCT.Size = new System.Drawing.Size(67, 24);
            this.txtMASCT.TabIndex = 1;
            // 
            // frmDieuTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcDieuTri);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDieuTri";
            this.Text = "Điều Trị";
            this.Load += new System.EventHandler(this.frmDieuTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDieuTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKetQua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASCT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDT;
        private DS DS;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnChuyenCN;
        private DSTableAdapters.DIEUTRITableAdapter DieuTriTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcDieuTri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASCT;
        private DevExpress.XtraGrid.Columns.GridColumn colMABS;
        private DevExpress.XtraGrid.Columns.GridColumn colMABN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private DevExpress.XtraGrid.Columns.GridColumn colKETQUA;
        private DSTableAdapters.SUCHUATRITableAdapter SuChuaTriTableAdapter;
        private System.Windows.Forms.BindingSource bdsSCT;
        private System.Windows.Forms.ComboBox cmbBS;
        private System.Windows.Forms.ComboBox cmbBN;
        private System.Windows.Forms.ComboBox cmbSCT;
        private DevExpress.XtraEditors.TextEdit txtKetQua;
        private DevExpress.XtraEditors.TextEdit txtThoiGian;
        private DevExpress.XtraEditors.DateEdit dtpNgay;
        private DevExpress.XtraEditors.TextEdit txtMABN;
        private DevExpress.XtraEditors.TextEdit txtMABS;
        private DevExpress.XtraEditors.TextEdit txtMASCT;
    }
}