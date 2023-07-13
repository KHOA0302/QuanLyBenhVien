namespace QLBV
{
    partial class frmVatTu_SuChuaTri
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dACTALabel;
            System.Windows.Forms.Label sOLabel;
            System.Windows.Forms.Label tENLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatTu_SuChuaTri));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenu = new DevExpress.XtraBars.BarSubItem();
            this.btnVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnSCT = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new QLBV.DS();
            this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
            this.VatTuTableAdapter = new QLBV.DSTableAdapters.VATTUTableAdapter();
            this.tableAdapterManager = new QLBV.DSTableAdapters.TableAdapterManager();
            this.SuDungTableAdapter = new QLBV.DSTableAdapters.SUDUNGTableAdapter();
            this.gcVatTu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDACTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDacTa = new DevExpress.XtraEditors.TextEdit();
            this.txtTENVT = new DevExpress.XtraEditors.TextEdit();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.txtMAVT = new DevExpress.XtraEditors.TextEdit();
            this.bdsSD = new System.Windows.Forms.BindingSource(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bdsSCT = new System.Windows.Forms.BindingSource(this.components);
            this.SuChuaTriTableAdapter = new QLBV.DSTableAdapters.SUCHUATRITableAdapter();
            this.gcSuChuaTri = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsDT = new System.Windows.Forms.BindingSource(this.components);
            this.DieuTriTableAdapter = new QLBV.DSTableAdapters.DIEUTRITableAdapter();
            this.txtMASCT = new DevExpress.XtraEditors.TextEdit();
            this.txtTENSCT = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            mAVTLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dACTALabel = new System.Windows.Forms.Label();
            sOLabel = new System.Windows.Forms.Label();
            tENLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDacTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSuChuaTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENSCT.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(228, 26);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(75, 17);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã Vật Tư";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(817, 23);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(58, 17);
            dONGIALabel.TabIndex = 4;
            dONGIALabel.Text = "Đơn Giá";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(483, 26);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(78, 17);
            tENVTLabel.TabIndex = 6;
            tENVTLabel.Text = "Tên Vật Tư";
            // 
            // dACTALabel
            // 
            dACTALabel.AutoSize = true;
            dACTALabel.Location = new System.Drawing.Point(228, 63);
            dACTALabel.Name = "dACTALabel";
            dACTALabel.Size = new System.Drawing.Size(53, 17);
            dACTALabel.TabIndex = 7;
            dACTALabel.Text = "Đặc Tả";
            // 
            // sOLabel
            // 
            sOLabel.AutoSize = true;
            sOLabel.Location = new System.Drawing.Point(231, 27);
            sOLabel.Name = "sOLabel";
            sOLabel.Size = new System.Drawing.Size(104, 17);
            sOLabel.TabIndex = 0;
            sOLabel.Text = "Mã Sự Chữa Trị";
            // 
            // tENLabel1
            // 
            tENLabel1.AutoSize = true;
            tENLabel1.Location = new System.Drawing.Point(511, 27);
            tENLabel1.Name = "tENLabel1";
            tENLabel1.Size = new System.Drawing.Size(107, 17);
            tENLabel1.TabIndex = 3;
            tENLabel1.Text = "Tên Sự Chữa Trị";
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
            this.btnThoat,
            this.btnMenu,
            this.btnVT,
            this.btnSCT});
            this.barManager1.MainMenu = this.bar7;
            this.barManager1.MaxItemId = 11;
            // 
            // bar7
            // 
            this.bar7.BarName = "Main menu";
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar7.FloatLocation = new System.Drawing.Point(163, 122);
            this.bar7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMenu),
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
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 2;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            // btnMenu
            // 
            this.btnMenu.Caption = "Chọn Chế Độ";
            this.btnMenu.Id = 8;
            this.btnMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenu.ImageOptions.SvgImage")));
            this.btnMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnVT),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSCT)});
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnVT
            // 
            this.btnVT.Caption = "Vật Tư";
            this.btnVT.Id = 9;
            this.btnVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVT.ImageOptions.SvgImage")));
            this.btnVT.Name = "btnVT";
            this.btnVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVT_ItemClick);
            // 
            // btnSCT
            // 
            this.btnSCT.Caption = "Sự Chữa Trị";
            this.btnSCT.Id = 10;
            this.btnSCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSCT.ImageOptions.Image")));
            this.btnSCT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSCT.ImageOptions.LargeImage")));
            this.btnSCT.Name = "btnSCT";
            this.btnSCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSCT_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1084, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 555);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1084, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 531);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1084, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 531);
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
            // bdsVT
            // 
            this.bdsVT.DataMember = "VATTU";
            this.bdsVT.DataSource = this.DS;
            // 
            // VatTuTableAdapter
            // 
            this.VatTuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.DIEUTRITableAdapter = null;
            this.tableAdapterManager.GIUONGTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.LAMVIECTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SUCHUATRITableAdapter = null;
            this.tableAdapterManager.SUDUNGTableAdapter = this.SuDungTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLBV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = this.VatTuTableAdapter;
            // 
            // SuDungTableAdapter
            // 
            this.SuDungTableAdapter.ClearBeforeFill = true;
            // 
            // gcVatTu
            // 
            this.gcVatTu.DataSource = this.bdsVT;
            this.gcVatTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcVatTu.Enabled = false;
            this.gcVatTu.Location = new System.Drawing.Point(0, 24);
            this.gcVatTu.MainView = this.gridView1;
            this.gcVatTu.MenuManager = this.barManager1;
            this.gcVatTu.Name = "gcVatTu";
            this.gcVatTu.Size = new System.Drawing.Size(1084, 173);
            this.gcVatTu.TabIndex = 5;
            this.gcVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDACTA,
            this.colDONGIA});
            this.gridView1.GridControl = this.gcVatTu;
            this.gridView1.Name = "gridView1";
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã Vật Tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên Vật Tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDACTA
            // 
            this.colDACTA.Caption = "Đặc Tả";
            this.colDACTA.FieldName = "DACTA";
            this.colDACTA.Name = "colDACTA";
            this.colDACTA.Visible = true;
            this.colDACTA.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn Giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(dACTALabel);
            this.groupBox1.Controls.Add(this.txtDacTa);
            this.groupBox1.Controls.Add(tENVTLabel);
            this.groupBox1.Controls.Add(this.txtTENVT);
            this.groupBox1.Controls.Add(dONGIALabel);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(mAVTLabel);
            this.groupBox1.Controls.Add(this.txtMAVT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Vật Tư";
            // 
            // txtDacTa
            // 
            this.txtDacTa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "DACTA", true));
            this.txtDacTa.Location = new System.Drawing.Point(309, 60);
            this.txtDacTa.MenuManager = this.barManager1;
            this.txtDacTa.Name = "txtDacTa";
            this.txtDacTa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDacTa.Properties.Appearance.Options.UseFont = true;
            this.txtDacTa.Size = new System.Drawing.Size(729, 24);
            this.txtDacTa.TabIndex = 8;
            // 
            // txtTENVT
            // 
            this.txtTENVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "TENVT", true));
            this.txtTENVT.Location = new System.Drawing.Point(567, 23);
            this.txtTENVT.MenuManager = this.barManager1;
            this.txtTENVT.Name = "txtTENVT";
            this.txtTENVT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENVT.Properties.Appearance.Options.UseFont = true;
            this.txtTENVT.Size = new System.Drawing.Size(157, 24);
            this.txtTENVT.TabIndex = 7;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "DONGIA", true));
            this.txtDonGia.Location = new System.Drawing.Point(881, 20);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Size = new System.Drawing.Size(157, 24);
            this.txtDonGia.TabIndex = 5;
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "MAVT", true));
            this.txtMAVT.Enabled = false;
            this.txtMAVT.Location = new System.Drawing.Point(309, 23);
            this.txtMAVT.MenuManager = this.barManager1;
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAVT.Properties.Appearance.Options.UseFont = true;
            this.txtMAVT.Size = new System.Drawing.Size(97, 24);
            this.txtMAVT.TabIndex = 1;
            // 
            // bdsSD
            // 
            this.bdsSD.DataMember = "FK_SUDUNG_VATTU";
            this.bdsSD.DataSource = this.bdsVT;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu)});
            this.bar1.Text = "Custom 3";
            // 
            // bdsSCT
            // 
            this.bdsSCT.DataMember = "SUCHUATRI";
            this.bdsSCT.DataSource = this.DS;
            // 
            // SuChuaTriTableAdapter
            // 
            this.SuChuaTriTableAdapter.ClearBeforeFill = true;
            // 
            // gcSuChuaTri
            // 
            this.gcSuChuaTri.DataSource = this.bdsSCT;
            this.gcSuChuaTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSuChuaTri.Enabled = false;
            this.gcSuChuaTri.Location = new System.Drawing.Point(0, 297);
            this.gcSuChuaTri.MainView = this.gridView2;
            this.gcSuChuaTri.MenuManager = this.barManager1;
            this.gcSuChuaTri.Name = "gcSuChuaTri";
            this.gcSuChuaTri.Size = new System.Drawing.Size(1084, 190);
            this.gcSuChuaTri.TabIndex = 10;
            this.gcSuChuaTri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSO,
            this.colTEN});
            this.gridView2.GridControl = this.gcSuChuaTri;
            this.gridView2.Name = "gridView2";
            // 
            // colSO
            // 
            this.colSO.Caption = "Mã Sự Chữa Trị";
            this.colSO.FieldName = "SO";
            this.colSO.Name = "colSO";
            this.colSO.Visible = true;
            this.colSO.VisibleIndex = 0;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên Sự Chữa Trị";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 1;
            // 
            // bdsDT
            // 
            this.bdsDT.DataMember = "FK_DIEUTRI_SUCHUATRI";
            this.bdsDT.DataSource = this.bdsSCT;
            // 
            // DieuTriTableAdapter
            // 
            this.DieuTriTableAdapter.ClearBeforeFill = true;
            // 
            // txtMASCT
            // 
            this.txtMASCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSCT, "SO", true));
            this.txtMASCT.Location = new System.Drawing.Point(341, 24);
            this.txtMASCT.MenuManager = this.barManager1;
            this.txtMASCT.Name = "txtMASCT";
            this.txtMASCT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMASCT.Properties.Appearance.Options.UseFont = true;
            this.txtMASCT.Size = new System.Drawing.Size(109, 24);
            this.txtMASCT.TabIndex = 1;
            // 
            // txtTENSCT
            // 
            this.txtTENSCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSCT, "TEN", true));
            this.txtTENSCT.Location = new System.Drawing.Point(624, 24);
            this.txtTENSCT.MenuManager = this.barManager1;
            this.txtTENSCT.Name = "txtTENSCT";
            this.txtTENSCT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENSCT.Properties.Appearance.Options.UseFont = true;
            this.txtTENSCT.Size = new System.Drawing.Size(414, 24);
            this.txtTENSCT.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(tENLabel1);
            this.groupBox2.Controls.Add(this.txtTENSCT);
            this.groupBox2.Controls.Add(sOLabel);
            this.groupBox2.Controls.Add(this.txtMASCT);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(0, 487);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1084, 68);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Sự Chữa Trị";
            // 
            // frmVatTu_SuChuaTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1084, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gcSuChuaTri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcVatTu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVatTu_SuChuaTri";
            this.Text = "Vật Tư - Sự Chữa Trị";
            this.Load += new System.EventHandler(this.frmVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDacTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSuChuaTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENSCT.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.BindingSource bdsVT;
        private DS DS;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnChuyenCN;
        private DSTableAdapters.VATTUTableAdapter VatTuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.SUDUNGTableAdapter SuDungTableAdapter;
        private System.Windows.Forms.BindingSource bdsSD;
        private DevExpress.XtraEditors.TextEdit txtTENVT;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.TextEdit txtMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDACTA;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraEditors.TextEdit txtDacTa;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.BindingSource bdsSCT;
        private DSTableAdapters.SUCHUATRITableAdapter SuChuaTriTableAdapter;
        private DevExpress.XtraGrid.GridControl gcSuChuaTri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private System.Windows.Forms.BindingSource bdsDT;
        private DSTableAdapters.DIEUTRITableAdapter DieuTriTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtTENSCT;
        private DevExpress.XtraEditors.TextEdit txtMASCT;
        private DevExpress.XtraBars.BarSubItem btnMenu;
        private DevExpress.XtraBars.BarButtonItem btnVT;
        private DevExpress.XtraBars.BarButtonItem btnSCT;
    }
}