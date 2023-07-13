namespace QLBV
{
    partial class frmKhuChuaTri_Giuong
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
            System.Windows.Forms.Label mAKHULabel;
            System.Windows.Forms.Label tENKHULabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label sOGIUONGLabel;
            System.Windows.Forms.Label sOPHONGLabel;
            System.Windows.Forms.Label mAKHULabel1;
            System.Windows.Forms.Label mABNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhuChuaTri_Giuong));
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
            this.bdsKCT = new System.Windows.Forms.BindingSource(this.components);
            this.KhuChuaTriTableAdapter = new QLBV.DSTableAdapters.KHUCHUATRITableAdapter();
            this.tableAdapterManager = new QLBV.DSTableAdapters.TableAdapterManager();
            this.GiuongTableAdapter = new QLBV.DSTableAdapters.GIUONGTableAdapter();
            this.LamViecTableAdapter = new QLBV.DSTableAdapters.LAMVIECTableAdapter();
            this.gcKhuChuaTri = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbYT = new System.Windows.Forms.ComboBox();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.txtTENKHU = new DevExpress.XtraEditors.TextEdit();
            this.txtMAKHU = new DevExpress.XtraEditors.TextEdit();
            this.bdsLV = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBN = new System.Windows.Forms.ComboBox();
            this.txtMABN = new DevExpress.XtraEditors.TextEdit();
            this.bdsG = new System.Windows.Forms.BindingSource(this.components);
            this.txtMKG = new DevExpress.XtraEditors.TextEdit();
            this.txtSP = new DevExpress.XtraEditors.TextEdit();
            this.txtSG = new DevExpress.XtraEditors.TextEdit();
            this.gcGiuong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemG = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaG = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLuuG = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaG = new System.Windows.Forms.ToolStripMenuItem();
            mAKHULabel = new System.Windows.Forms.Label();
            tENKHULabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            sOGIUONGLabel = new System.Windows.Forms.Label();
            sOPHONGLabel = new System.Windows.Forms.Label();
            mAKHULabel1 = new System.Windows.Forms.Label();
            mABNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhuChuaTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENKHU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiuong)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAKHULabel
            // 
            mAKHULabel.AutoSize = true;
            mAKHULabel.Location = new System.Drawing.Point(136, 34);
            mAKHULabel.Name = "mAKHULabel";
            mAKHULabel.Size = new System.Drawing.Size(57, 17);
            mAKHULabel.TabIndex = 0;
            mAKHULabel.Text = "Mã Khu";
            // 
            // tENKHULabel
            // 
            tENKHULabel.AutoSize = true;
            tENKHULabel.Location = new System.Drawing.Point(323, 34);
            tENKHULabel.Name = "tENKHULabel";
            tENKHULabel.Size = new System.Drawing.Size(60, 17);
            tENKHULabel.TabIndex = 2;
            tENKHULabel.Text = "Tên Khu";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(597, 33);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(108, 17);
            mANVLabel.TabIndex = 4;
            mANVLabel.Text = "Mã Y Tá Trưởng";
            // 
            // sOGIUONGLabel
            // 
            sOGIUONGLabel.AutoSize = true;
            sOGIUONGLabel.Location = new System.Drawing.Point(65, 51);
            sOGIUONGLabel.Name = "sOGIUONGLabel";
            sOGIUONGLabel.Size = new System.Drawing.Size(70, 17);
            sOGIUONGLabel.TabIndex = 0;
            sOGIUONGLabel.Text = "Số Giường";
            // 
            // sOPHONGLabel
            // 
            sOPHONGLabel.AutoSize = true;
            sOPHONGLabel.Location = new System.Drawing.Point(301, 51);
            sOPHONGLabel.Name = "sOPHONGLabel";
            sOPHONGLabel.Size = new System.Drawing.Size(64, 17);
            sOPHONGLabel.TabIndex = 2;
            sOPHONGLabel.Text = "Số Phòng";
            // 
            // mAKHULabel1
            // 
            mAKHULabel1.AutoSize = true;
            mAKHULabel1.Location = new System.Drawing.Point(65, 93);
            mAKHULabel1.Name = "mAKHULabel1";
            mAKHULabel1.Size = new System.Drawing.Size(57, 17);
            mAKHULabel1.TabIndex = 4;
            mAKHULabel1.Text = "Mã Khu";
            // 
            // mABNLabel
            // 
            mABNLabel.AutoSize = true;
            mABNLabel.Location = new System.Drawing.Point(65, 134);
            mABNLabel.Name = "mABNLabel";
            mABNLabel.Size = new System.Drawing.Size(99, 17);
            mABNLabel.TabIndex = 6;
            mABNLabel.Text = "Mã Bệnh Nhân";
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 562);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 538);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 538);
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
            // bdsKCT
            // 
            this.bdsKCT.DataMember = "KHUCHUATRI";
            this.bdsKCT.DataSource = this.DS;
            // 
            // KhuChuaTriTableAdapter
            // 
            this.KhuChuaTriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.DIEUTRITableAdapter = null;
            this.tableAdapterManager.GIUONGTableAdapter = this.GiuongTableAdapter;
            this.tableAdapterManager.KHUCHUATRITableAdapter = this.KhuChuaTriTableAdapter;
            this.tableAdapterManager.LAMVIECTableAdapter = this.LamViecTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SUCHUATRITableAdapter = null;
            this.tableAdapterManager.SUDUNGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLBV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // GiuongTableAdapter
            // 
            this.GiuongTableAdapter.ClearBeforeFill = true;
            // 
            // LamViecTableAdapter
            // 
            this.LamViecTableAdapter.ClearBeforeFill = true;
            // 
            // gcKhuChuaTri
            // 
            this.gcKhuChuaTri.DataSource = this.bdsKCT;
            this.gcKhuChuaTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKhuChuaTri.Location = new System.Drawing.Point(0, 24);
            this.gcKhuChuaTri.MainView = this.gridView1;
            this.gcKhuChuaTri.MenuManager = this.barManager1;
            this.gcKhuChuaTri.Name = "gcKhuChuaTri";
            this.gcKhuChuaTri.Size = new System.Drawing.Size(1067, 259);
            this.gcKhuChuaTri.TabIndex = 5;
            this.gcKhuChuaTri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHU,
            this.colTENKHU,
            this.colMANV});
            this.gridView1.GridControl = this.gcKhuChuaTri;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKHU
            // 
            this.colMAKHU.Caption = "Mã Khu";
            this.colMAKHU.FieldName = "MAKHU";
            this.colMAKHU.Name = "colMAKHU";
            this.colMAKHU.Visible = true;
            this.colMAKHU.VisibleIndex = 0;
            // 
            // colTENKHU
            // 
            this.colTENKHU.Caption = "Tên Khu";
            this.colTENKHU.FieldName = "TENKHU";
            this.colTENKHU.Name = "colTENKHU";
            this.colTENKHU.Visible = true;
            this.colTENKHU.VisibleIndex = 1;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã Y Tá Trưởng";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbYT);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(this.txtMANV);
            this.groupBox1.Controls.Add(tENKHULabel);
            this.groupBox1.Controls.Add(this.txtTENKHU);
            this.groupBox1.Controls.Add(mAKHULabel);
            this.groupBox1.Controls.Add(this.txtMAKHU);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khu Chữa Trị";
            // 
            // cmbYT
            // 
            this.cmbYT.FormattingEnabled = true;
            this.cmbYT.Location = new System.Drawing.Point(804, 29);
            this.cmbYT.Name = "cmbYT";
            this.cmbYT.Size = new System.Drawing.Size(257, 25);
            this.cmbYT.TabIndex = 6;
            this.cmbYT.SelectedIndexChanged += new System.EventHandler(this.cmbYT_SelectedIndexChanged);
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKCT, "MANV", true));
            this.txtMANV.Enabled = false;
            this.txtMANV.Location = new System.Drawing.Point(711, 30);
            this.txtMANV.MenuManager = this.barManager1;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Properties.Appearance.Options.UseFont = true;
            this.txtMANV.Size = new System.Drawing.Size(87, 24);
            this.txtMANV.TabIndex = 5;
            // 
            // txtTENKHU
            // 
            this.txtTENKHU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKCT, "TENKHU", true));
            this.txtTENKHU.Location = new System.Drawing.Point(389, 31);
            this.txtTENKHU.MenuManager = this.barManager1;
            this.txtTENKHU.Name = "txtTENKHU";
            this.txtTENKHU.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENKHU.Properties.Appearance.Options.UseFont = true;
            this.txtTENKHU.Size = new System.Drawing.Size(176, 24);
            this.txtTENKHU.TabIndex = 3;
            // 
            // txtMAKHU
            // 
            this.txtMAKHU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKCT, "MAKHU", true));
            this.txtMAKHU.Enabled = false;
            this.txtMAKHU.Location = new System.Drawing.Point(199, 31);
            this.txtMAKHU.MenuManager = this.barManager1;
            this.txtMAKHU.Name = "txtMAKHU";
            this.txtMAKHU.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAKHU.Properties.Appearance.Options.UseFont = true;
            this.txtMAKHU.Size = new System.Drawing.Size(100, 24);
            this.txtMAKHU.TabIndex = 1;
            
            // 
            // bdsLV
            // 
            this.bdsLV.DataMember = "FK_LAMVIEC_KHUCHUATRI";
            this.bdsLV.DataSource = this.bdsKCT;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBN);
            this.groupBox2.Controls.Add(mABNLabel);
            this.groupBox2.Controls.Add(this.txtMABN);
            this.groupBox2.Controls.Add(mAKHULabel1);
            this.groupBox2.Controls.Add(this.txtMKG);
            this.groupBox2.Controls.Add(sOPHONGLabel);
            this.groupBox2.Controls.Add(this.txtSP);
            this.groupBox2.Controls.Add(sOGIUONGLabel);
            this.groupBox2.Controls.Add(this.txtSG);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(0, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 205);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Giường Bệnh";
            // 
            // cmbBN
            // 
            this.cmbBN.FormattingEnabled = true;
            this.cmbBN.Location = new System.Drawing.Point(261, 131);
            this.cmbBN.Name = "cmbBN";
            this.cmbBN.Size = new System.Drawing.Size(210, 25);
            this.cmbBN.TabIndex = 8;
            this.cmbBN.SelectedIndexChanged += new System.EventHandler(this.cmbBN_SelectedIndexChanged);
            // 
            // txtMABN
            // 
            this.txtMABN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsG, "MABN", true));
            this.txtMABN.Enabled = false;
            this.txtMABN.Location = new System.Drawing.Point(170, 131);
            this.txtMABN.MenuManager = this.barManager1;
            this.txtMABN.Name = "txtMABN";
            this.txtMABN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMABN.Properties.Appearance.Options.UseFont = true;
            this.txtMABN.Size = new System.Drawing.Size(85, 24);
            this.txtMABN.TabIndex = 7;
            // 
            // bdsG
            // 
            this.bdsG.DataMember = "FK_GIUONG_KHUCHUATRI";
            this.bdsG.DataSource = this.bdsKCT;
            // 
            // txtMKG
            // 
            this.txtMKG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsG, "MAKHU", true));
            this.txtMKG.Enabled = false;
            this.txtMKG.Location = new System.Drawing.Point(170, 90);
            this.txtMKG.MenuManager = this.barManager1;
            this.txtMKG.Name = "txtMKG";
            this.txtMKG.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKG.Properties.Appearance.Options.UseFont = true;
            this.txtMKG.Size = new System.Drawing.Size(85, 24);
            this.txtMKG.TabIndex = 5;
            // 
            // txtSP
            // 
            this.txtSP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsG, "SOPHONG", true));
            this.txtSP.Location = new System.Drawing.Point(371, 48);
            this.txtSP.MenuManager = this.barManager1;
            this.txtSP.Name = "txtSP";
            this.txtSP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSP.Properties.Appearance.Options.UseFont = true;
            this.txtSP.Size = new System.Drawing.Size(100, 24);
            this.txtSP.TabIndex = 3;
            // 
            // txtSG
            // 
            this.txtSG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsG, "SOGIUONG", true));
            this.txtSG.Enabled = false;
            this.txtSG.Location = new System.Drawing.Point(170, 48);
            this.txtSG.MenuManager = this.barManager1;
            this.txtSG.Name = "txtSG";
            this.txtSG.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSG.Properties.Appearance.Options.UseFont = true;
            this.txtSG.Size = new System.Drawing.Size(85, 24);
            this.txtSG.TabIndex = 1;
            // 
            // gcGiuong
            // 
            this.gcGiuong.AutoGenerateColumns = false;
            this.gcGiuong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gcGiuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcGiuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.gcGiuong.ContextMenuStrip = this.contextMenuStrip1;
            this.gcGiuong.DataSource = this.bdsG;
            this.gcGiuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGiuong.Location = new System.Drawing.Point(545, 357);
            this.gcGiuong.Name = "gcGiuong";
            this.gcGiuong.ReadOnly = true;
            this.gcGiuong.Size = new System.Drawing.Size(522, 205);
            this.gcGiuong.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SOGIUONG";
            this.dataGridViewTextBoxColumn1.HeaderText = "Số Giường";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SOPHONG";
            this.dataGridViewTextBoxColumn2.HeaderText = "Số Phòng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MAKHU";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã Khu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MABN";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã Bệnh Nhân";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemG,
            this.btnSuaG,
            this.btnLuuG,
            this.btnXoaG});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 92);
            // 
            // btnThemG
            // 
            this.btnThemG.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemG.Name = "btnThemG";
            this.btnThemG.Size = new System.Drawing.Size(109, 22);
            this.btnThemG.Text = "Thêm";
            this.btnThemG.Click += new System.EventHandler(this.btnThemG_Click);
            // 
            // btnSuaG
            // 
            this.btnSuaG.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaG.Name = "btnSuaG";
            this.btnSuaG.Size = new System.Drawing.Size(109, 22);
            this.btnSuaG.Text = "Sửa";
            this.btnSuaG.Click += new System.EventHandler(this.btnSuaG_Click);
            // 
            // btnLuuG
            // 
            this.btnLuuG.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuG.Name = "btnLuuG";
            this.btnLuuG.Size = new System.Drawing.Size(109, 22);
            this.btnLuuG.Text = "Lưu";
            this.btnLuuG.Click += new System.EventHandler(this.btnLuuG_Click);
            // 
            // btnXoaG
            // 
            this.btnXoaG.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaG.Name = "btnXoaG";
            this.btnXoaG.Size = new System.Drawing.Size(109, 22);
            this.btnXoaG.Text = "Xóa";
            this.btnXoaG.Click += new System.EventHandler(this.btnXoaG_Click);
            // 
            // frmKhuChuaTri_Giuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.gcGiuong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcKhuChuaTri);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhuChuaTri_Giuong";
            this.Text = "Khu Chữa Trị - Giường";
            this.Load += new System.EventHandler(this.fromKhuChuaTri_Giuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhuChuaTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENKHU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiuong)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnChuyenCN;
        private System.Windows.Forms.BindingSource bdsKCT;
        private DS DS;
        private DSTableAdapters.KHUCHUATRITableAdapter KhuChuaTriTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKhuChuaTri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHU;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHU;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.ComboBox cmbYT;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraEditors.TextEdit txtTENKHU;
        private DevExpress.XtraEditors.TextEdit txtMAKHU;
        private DSTableAdapters.LAMVIECTableAdapter LamViecTableAdapter;
        private System.Windows.Forms.BindingSource bdsLV;
        private System.Windows.Forms.GroupBox groupBox2;
        private DSTableAdapters.GIUONGTableAdapter GiuongTableAdapter;
        private System.Windows.Forms.BindingSource bdsG;
        private System.Windows.Forms.DataGridView gcGiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox cmbBN;
        private DevExpress.XtraEditors.TextEdit txtMABN;
        private DevExpress.XtraEditors.TextEdit txtMKG;
        private DevExpress.XtraEditors.TextEdit txtSP;
        private DevExpress.XtraEditors.TextEdit txtSG;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSuaG;
        private System.Windows.Forms.ToolStripMenuItem btnLuuG;
        private System.Windows.Forms.ToolStripMenuItem btnThemG;
        private System.Windows.Forms.ToolStripMenuItem btnXoaG;
    }
}