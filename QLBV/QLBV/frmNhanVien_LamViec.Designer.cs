namespace QLBV
{
    partial class frmNhanVien_LamViec
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label cHUCDANHLabel;
            System.Windows.Forms.Label mAKHULabel;
            System.Windows.Forms.Label mANVLabel1;
            System.Windows.Forms.Label sOGIOLAMLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien_LamViec));
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
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVienTableAdapter = new QLBV.DSTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QLBV.DSTableAdapters.TableAdapterManager();
            this.DieuTriTableAdapter = new QLBV.DSTableAdapters.DIEUTRITableAdapter();
            this.LamViecTableAdapter = new QLBV.DSTableAdapters.LAMVIECTableAdapter();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHUCDANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChucDanh = new DevExpress.XtraEditors.TextEdit();
            this.txtTENNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.bdsLV = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDT = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbKhu = new System.Windows.Forms.ComboBox();
            this.bdsKCT = new System.Windows.Forms.BindingSource(this.components);
            this.txtSGL = new DevExpress.XtraEditors.TextEdit();
            this.txtMANVLV = new DevExpress.XtraEditors.TextEdit();
            this.txtMAKHU = new DevExpress.XtraEditors.TextEdit();
            this.gcLamViec = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemLV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaLV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLuuLV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaLV = new System.Windows.Forms.ToolStripMenuItem();
            this.KhuChuaTriTableAdapter = new QLBV.DSTableAdapters.KHUCHUATRITableAdapter();
            mANVLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            cHUCDANHLabel = new System.Windows.Forms.Label();
            mAKHULabel = new System.Windows.Forms.Label();
            mANVLabel1 = new System.Windows.Forms.Label();
            sOGIOLAMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucDanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDT)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANVLV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLamViec)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(183, 27);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(95, 17);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã Nhân Viên";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(395, 27);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(98, 17);
            tENLabel.TabIndex = 2;
            tENLabel.Text = "Tên Nhân Viên";
            // 
            // cHUCDANHLabel
            // 
            cHUCDANHLabel.AutoSize = true;
            cHUCDANHLabel.Location = new System.Drawing.Point(786, 27);
            cHUCDANHLabel.Name = "cHUCDANHLabel";
            cHUCDANHLabel.Size = new System.Drawing.Size(76, 17);
            cHUCDANHLabel.TabIndex = 4;
            cHUCDANHLabel.Text = "Chức Danh";
            // 
            // mAKHULabel
            // 
            mAKHULabel.AutoSize = true;
            mAKHULabel.Location = new System.Drawing.Point(121, 91);
            mAKHULabel.Name = "mAKHULabel";
            mAKHULabel.Size = new System.Drawing.Size(57, 17);
            mAKHULabel.TabIndex = 0;
            mAKHULabel.Text = "Mã Khu";
            // 
            // mANVLabel1
            // 
            mANVLabel1.AutoSize = true;
            mANVLabel1.Location = new System.Drawing.Point(121, 47);
            mANVLabel1.Name = "mANVLabel1";
            mANVLabel1.Size = new System.Drawing.Size(95, 17);
            mANVLabel1.TabIndex = 2;
            mANVLabel1.Text = "Mã Nhân Viên";
            // 
            // sOGIOLAMLabel
            // 
            sOGIOLAMLabel.AutoSize = true;
            sOGIOLAMLabel.Location = new System.Drawing.Point(121, 132);
            sOGIOLAMLabel.Name = "sOGIOLAMLabel";
            sOGIOLAMLabel.Size = new System.Drawing.Size(79, 17);
            sOGIOLAMLabel.TabIndex = 4;
            sOGIOLAMLabel.Text = "Số Giờ Làm";
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 497);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 473);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 473);
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
            // bdsNV
            // 
            this.bdsNV.DataMember = "NHANVIEN";
            this.bdsNV.DataSource = this.DS;
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.DIEUTRITableAdapter = this.DieuTriTableAdapter;
            this.tableAdapterManager.GIUONGTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.LAMVIECTableAdapter = this.LamViecTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = this.NhanVienTableAdapter;
            this.tableAdapterManager.SUCHUATRITableAdapter = null;
            this.tableAdapterManager.SUDUNGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLBV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // DieuTriTableAdapter
            // 
            this.DieuTriTableAdapter.ClearBeforeFill = true;
            // 
            // LamViecTableAdapter
            // 
            this.LamViecTableAdapter.ClearBeforeFill = true;
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.DataSource = this.bdsNV;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhanVien.Location = new System.Drawing.Point(0, 24);
            this.gcNhanVien.MainView = this.gridView1;
            this.gcNhanVien.MenuManager = this.barManager1;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1067, 263);
            this.gcNhanVien.TabIndex = 5;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colTEN,
            this.colCHUCDANH});
            this.gridView1.GridControl = this.gcNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã Nhân Viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên Nhân Viên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 1;
            // 
            // colCHUCDANH
            // 
            this.colCHUCDANH.Caption = "Chức Danh";
            this.colCHUCDANH.FieldName = "CHUCDANH";
            this.colCHUCDANH.Name = "colCHUCDANH";
            this.colCHUCDANH.Visible = true;
            this.colCHUCDANH.VisibleIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(cHUCDANHLabel);
            this.groupBox1.Controls.Add(this.txtChucDanh);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.txtTENNV);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(this.txtMANV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // txtChucDanh
            // 
            this.txtChucDanh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "CHUCDANH", true));
            this.txtChucDanh.Location = new System.Drawing.Point(868, 24);
            this.txtChucDanh.MenuManager = this.barManager1;
            this.txtChucDanh.Name = "txtChucDanh";
            this.txtChucDanh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucDanh.Properties.Appearance.Options.UseFont = true;
            this.txtChucDanh.Size = new System.Drawing.Size(120, 24);
            this.txtChucDanh.TabIndex = 5;
            // 
            // txtTENNV
            // 
            this.txtTENNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TEN", true));
            this.txtTENNV.Location = new System.Drawing.Point(499, 24);
            this.txtTENNV.MenuManager = this.barManager1;
            this.txtTENNV.Name = "txtTENNV";
            this.txtTENNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENNV.Properties.Appearance.Options.UseFont = true;
            this.txtTENNV.Size = new System.Drawing.Size(250, 24);
            this.txtTENNV.TabIndex = 3;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MANV", true));
            this.txtMANV.Enabled = false;
            this.txtMANV.Location = new System.Drawing.Point(284, 24);
            this.txtMANV.MenuManager = this.barManager1;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Properties.Appearance.Options.UseFont = true;
            this.txtMANV.Size = new System.Drawing.Size(69, 24);
            this.txtMANV.TabIndex = 1;
            // 
            // bdsLV
            // 
            this.bdsLV.DataMember = "FK_LAMVIEC_NHANVIEN";
            this.bdsLV.DataSource = this.bdsNV;
            // 
            // bdsDT
            // 
            this.bdsDT.DataMember = "FK_DIEUTRI_NHANVIEN";
            this.bdsDT.DataSource = this.bdsNV;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbKhu);
            this.groupBox2.Controls.Add(sOGIOLAMLabel);
            this.groupBox2.Controls.Add(this.txtSGL);
            this.groupBox2.Controls.Add(mANVLabel1);
            this.groupBox2.Controls.Add(this.txtMANVLV);
            this.groupBox2.Controls.Add(mAKHULabel);
            this.groupBox2.Controls.Add(this.txtMAKHU);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(0, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(639, 140);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Làm Việc Nhân Viên";
            // 
            // cmbKhu
            // 
            this.cmbKhu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsLV, "MAKHU", true));
            this.cmbKhu.DataSource = this.bdsKCT;
            this.cmbKhu.DisplayMember = "TENKHU";
            this.cmbKhu.FormattingEnabled = true;
            this.cmbKhu.Location = new System.Drawing.Point(328, 88);
            this.cmbKhu.Name = "cmbKhu";
            this.cmbKhu.Size = new System.Drawing.Size(190, 25);
            this.cmbKhu.TabIndex = 6;
            this.cmbKhu.ValueMember = "MAKHU";
            this.cmbKhu.SelectedIndexChanged += new System.EventHandler(this.cmbKhu_SelectedIndexChanged);
            // 
            // bdsKCT
            // 
            this.bdsKCT.DataMember = "KHUCHUATRI";
            this.bdsKCT.DataSource = this.DS;
            // 
            // txtSGL
            // 
            this.txtSGL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLV, "SOGIOLAM", true));
            this.txtSGL.Location = new System.Drawing.Point(222, 129);
            this.txtSGL.MenuManager = this.barManager1;
            this.txtSGL.Name = "txtSGL";
            this.txtSGL.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGL.Properties.Appearance.Options.UseFont = true;
            this.txtSGL.Size = new System.Drawing.Size(100, 24);
            this.txtSGL.TabIndex = 5;
            // 
            // txtMANVLV
            // 
            this.txtMANVLV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLV, "MANV", true));
            this.txtMANVLV.Enabled = false;
            this.txtMANVLV.Location = new System.Drawing.Point(222, 44);
            this.txtMANVLV.MenuManager = this.barManager1;
            this.txtMANVLV.Name = "txtMANVLV";
            this.txtMANVLV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANVLV.Properties.Appearance.Options.UseFont = true;
            this.txtMANVLV.Size = new System.Drawing.Size(100, 24);
            this.txtMANVLV.TabIndex = 3;
            // 
            // txtMAKHU
            // 
            this.txtMAKHU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLV, "MAKHU", true));
            this.txtMAKHU.Enabled = false;
            this.txtMAKHU.Location = new System.Drawing.Point(222, 88);
            this.txtMAKHU.MenuManager = this.barManager1;
            this.txtMAKHU.Name = "txtMAKHU";
            this.txtMAKHU.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAKHU.Properties.Appearance.Options.UseFont = true;
            this.txtMAKHU.Size = new System.Drawing.Size(100, 24);
            this.txtMAKHU.TabIndex = 1;
            // 
            // gcLamViec
            // 
            this.gcLamViec.AutoGenerateColumns = false;
            this.gcLamViec.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gcLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcLamViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.gcLamViec.ContextMenuStrip = this.contextMenuStrip1;
            this.gcLamViec.DataSource = this.bdsLV;
            this.gcLamViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLamViec.Location = new System.Drawing.Point(639, 357);
            this.gcLamViec.Name = "gcLamViec";
            this.gcLamViec.ReadOnly = true;
            this.gcLamViec.Size = new System.Drawing.Size(428, 140);
            this.gcLamViec.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Nhân Viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAKHU";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Khu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOGIOLAM";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Giờ Làm";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemLV,
            this.btnSuaLV,
            this.btnLuuLV,
            this.btnXoaLV});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 92);
            // 
            // btnThemLV
            // 
            this.btnThemLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLV.Name = "btnThemLV";
            this.btnThemLV.Size = new System.Drawing.Size(109, 22);
            this.btnThemLV.Text = "Thêm";
            this.btnThemLV.Click += new System.EventHandler(this.btnThemLV_Click);
            // 
            // btnSuaLV
            // 
            this.btnSuaLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLV.Name = "btnSuaLV";
            this.btnSuaLV.Size = new System.Drawing.Size(109, 22);
            this.btnSuaLV.Text = "Sửa";
            this.btnSuaLV.Click += new System.EventHandler(this.btnSuaLV_Click);
            // 
            // btnLuuLV
            // 
            this.btnLuuLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuLV.Name = "btnLuuLV";
            this.btnLuuLV.Size = new System.Drawing.Size(109, 22);
            this.btnLuuLV.Text = "Lưu";
            this.btnLuuLV.Click += new System.EventHandler(this.btnLuuLV_Click);
            // 
            // btnXoaLV
            // 
            this.btnXoaLV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLV.Name = "btnXoaLV";
            this.btnXoaLV.Size = new System.Drawing.Size(109, 22);
            this.btnXoaLV.Text = "Xóa";
            this.btnXoaLV.Click += new System.EventHandler(this.btnXoaLV_Click);
            // 
            // KhuChuaTriTableAdapter
            // 
            this.KhuChuaTriTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhanVien_LamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 497);
            this.Controls.Add(this.gcLamViec);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien_LamViec";
            this.Text = "Nhân Viên - Làm Việc";
            this.Load += new System.EventHandler(this.frmNhanVien_LamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucDanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANVLV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLamViec)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.BindingSource bdsNV;
        private DS DS;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnChuyenCN;
        private DSTableAdapters.NHANVIENTableAdapter NhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtChucDanh;
        private DevExpress.XtraEditors.TextEdit txtTENNV;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCHUCDANH;
        private DSTableAdapters.LAMVIECTableAdapter LamViecTableAdapter;
        private System.Windows.Forms.BindingSource bdsLV;
        private DSTableAdapters.DIEUTRITableAdapter DieuTriTableAdapter;
        private System.Windows.Forms.BindingSource bdsDT;
        private System.Windows.Forms.DataGridView gcLamViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemLV;
        private System.Windows.Forms.ToolStripMenuItem btnSuaLV;
        private System.Windows.Forms.ToolStripMenuItem btnLuuLV;
        private System.Windows.Forms.ToolStripMenuItem btnXoaLV;
        private DevExpress.XtraEditors.TextEdit txtSGL;
        private DevExpress.XtraEditors.TextEdit txtMANVLV;
        private DevExpress.XtraEditors.TextEdit txtMAKHU;
        private System.Windows.Forms.ComboBox cmbKhu;
        private System.Windows.Forms.BindingSource bdsKCT;
        private DSTableAdapters.KHUCHUATRITableAdapter KhuChuaTriTableAdapter;
    }
}