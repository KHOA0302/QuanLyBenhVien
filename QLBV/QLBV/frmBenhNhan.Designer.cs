namespace QLBV
{
    partial class frmBenhNhan
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
            System.Windows.Forms.Label mABNLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label mABSLabel;
            System.Windows.Forms.Label mABNLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label tONGTIENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBenhNhan));
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
            this.bdsBN = new System.Windows.Forms.BindingSource(this.components);
            this.BenhNhanTableAdapter = new QLBV.DSTableAdapters.BENHNHANTableAdapter();
            this.tableAdapterManager = new QLBV.DSTableAdapters.TableAdapterManager();
            this.gcBenhNhan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMABN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMABS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsDT = new System.Windows.Forms.BindingSource(this.components);
            this.DieuTriTableAdapter = new QLBV.DSTableAdapters.DIEUTRITableAdapter();
            this.bdsGiuong = new System.Windows.Forms.BindingSource(this.components);
            this.GiuongTableAdapter = new QLBV.DSTableAdapters.GIUONGTableAdapter();
            this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
            this.VatTuTableAdapter = new QLBV.DSTableAdapters.VATTUTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBS = new System.Windows.Forms.ComboBox();
            this.txtMABS = new DevExpress.XtraEditors.TextEdit();
            this.dtpNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMABN = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbVT = new System.Windows.Forms.ComboBox();
            this.bdsSD = new System.Windows.Forms.BindingSource(this.components);
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.txtSL = new DevExpress.XtraEditors.TextEdit();
            this.txtThoiGian = new DevExpress.XtraEditors.TextEdit();
            this.dtpNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtLan = new DevExpress.XtraEditors.SpinEdit();
            this.txtMAVT = new DevExpress.XtraEditors.TextEdit();
            this.txtMABNSD = new DevExpress.XtraEditors.TextEdit();
            this.SuDungTableAdapter = new QLBV.DSTableAdapters.SUDUNGTableAdapter();
            this.gcSuDung = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemSD = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaSD = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLuuSD = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaSD = new System.Windows.Forms.ToolStripMenuItem();
            mABNLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            mABSLabel = new System.Windows.Forms.Label();
            mABNLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            tONGTIENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBenhNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABN.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABNSD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSuDung)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mABNLabel
            // 
            mABNLabel.AutoSize = true;
            mABNLabel.Location = new System.Drawing.Point(76, 27);
            mABNLabel.Name = "mABNLabel";
            mABNLabel.Size = new System.Drawing.Size(103, 17);
            mABNLabel.TabIndex = 0;
            mABNLabel.Text = "Mã Bệnh Nhân ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(273, 27);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(102, 17);
            tENLabel.TabIndex = 2;
            tENLabel.Text = "Tên Bệnh Nhân";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(548, 27);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(69, 17);
            nGAYSINHLabel.TabIndex = 4;
            nGAYSINHLabel.Text = "Ngày Sinh";
            // 
            // mABSLabel
            // 
            mABSLabel.AutoSize = true;
            mABSLabel.Location = new System.Drawing.Point(766, 27);
            mABSLabel.Name = "mABSLabel";
            mABSLabel.Size = new System.Drawing.Size(123, 17);
            mABSLabel.TabIndex = 6;
            mABSLabel.Text = "Mã Bác Sĩ Điều Trị";
            // 
            // mABNLabel1
            // 
            mABNLabel1.AutoSize = true;
            mABNLabel1.Location = new System.Drawing.Point(63, 53);
            mABNLabel1.Name = "mABNLabel1";
            mABNLabel1.Size = new System.Drawing.Size(99, 17);
            mABNLabel1.TabIndex = 0;
            mABNLabel1.Text = "Mã Bệnh Nhân";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(63, 139);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(75, 17);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "Mã Vật Tư";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(308, 53);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(87, 17);
            lANLabel.TabIndex = 4;
            lANLabel.Text = "Lần Sử Dụng";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(63, 95);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(40, 17);
            nGAYLabel.TabIndex = 6;
            nGAYLabel.Text = "Ngày";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(308, 95);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(66, 17);
            tHOIGIANLabel.TabIndex = 8;
            tHOIGIANLabel.Text = "Thời Gian";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(63, 182);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(66, 17);
            sOLUONGLabel.TabIndex = 10;
            sOLUONGLabel.Text = "Số Lượng";
            // 
            // tONGTIENLabel
            // 
            tONGTIENLabel.AutoSize = true;
            tONGTIENLabel.Location = new System.Drawing.Point(308, 182);
            tONGTIENLabel.Name = "tONGTIENLabel";
            tONGTIENLabel.Size = new System.Drawing.Size(71, 17);
            tONGTIENLabel.TabIndex = 12;
            tONGTIENLabel.Text = "Tổng Tiền ";
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 553);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 529);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 529);
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
            // bdsBN
            // 
            this.bdsBN.DataMember = "BENHNHAN";
            this.bdsBN.DataSource = this.DS;
            // 
            // BenhNhanTableAdapter
            // 
            this.BenhNhanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = this.BenhNhanTableAdapter;
            this.tableAdapterManager.DIEUTRITableAdapter = null;
            this.tableAdapterManager.GIUONGTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.LAMVIECTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SUCHUATRITableAdapter = null;
            this.tableAdapterManager.SUDUNGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLBV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // gcBenhNhan
            // 
            this.gcBenhNhan.DataSource = this.bdsBN;
            this.gcBenhNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBenhNhan.Location = new System.Drawing.Point(0, 24);
            this.gcBenhNhan.MainView = this.gridView1;
            this.gcBenhNhan.MenuManager = this.barManager1;
            this.gcBenhNhan.Name = "gcBenhNhan";
            this.gcBenhNhan.Size = new System.Drawing.Size(1067, 231);
            this.gcBenhNhan.TabIndex = 5;
            this.gcBenhNhan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMABN,
            this.colTEN,
            this.colNGAYSINH,
            this.colMABS});
            this.gridView1.GridControl = this.gcBenhNhan;
            this.gridView1.Name = "gridView1";
            // 
            // colMABN
            // 
            this.colMABN.Caption = "Mã Bệnh Nhân";
            this.colMABN.FieldName = "MABN";
            this.colMABN.Name = "colMABN";
            this.colMABN.Visible = true;
            this.colMABN.VisibleIndex = 0;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên Bệnh Nhân";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 1;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày Sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 2;
            // 
            // colMABS
            // 
            this.colMABS.Caption = "Mã Bác Sĩ";
            this.colMABS.FieldName = "MABS";
            this.colMABS.Name = "colMABS";
            this.colMABS.Visible = true;
            this.colMABS.VisibleIndex = 3;
            // 
            // bdsDT
            // 
            this.bdsDT.DataMember = "FK_DIEUTRI_BENHNHAN";
            this.bdsDT.DataSource = this.bdsBN;
            // 
            // DieuTriTableAdapter
            // 
            this.DieuTriTableAdapter.ClearBeforeFill = true;
            // 
            // bdsGiuong
            // 
            this.bdsGiuong.DataMember = "FK_GIUONG_BENHNHAN";
            this.bdsGiuong.DataSource = this.bdsBN;
            // 
            // GiuongTableAdapter
            // 
            this.GiuongTableAdapter.ClearBeforeFill = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBS);
            this.groupBox1.Controls.Add(mABSLabel);
            this.groupBox1.Controls.Add(this.txtMABS);
            this.groupBox1.Controls.Add(nGAYSINHLabel);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(mABNLabel);
            this.groupBox1.Controls.Add(this.txtMABN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 68);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bệnh Nhân";
            // 
            // cmbBS
            // 
            this.cmbBS.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsBN, "MABS", true));
            this.cmbBS.FormattingEnabled = true;
            this.cmbBS.Location = new System.Drawing.Point(968, 23);
            this.cmbBS.Name = "cmbBS";
            this.cmbBS.Size = new System.Drawing.Size(248, 25);
            this.cmbBS.TabIndex = 8;
            this.cmbBS.SelectedIndexChanged += new System.EventHandler(this.cmbBS_SelectedIndexChanged);
            // 
            // txtMABS
            // 
            this.txtMABS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBN, "MABS", true));
            this.txtMABS.Location = new System.Drawing.Point(895, 24);
            this.txtMABS.MenuManager = this.barManager1;
            this.txtMABS.Name = "txtMABS";
            this.txtMABS.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMABS.Properties.Appearance.Options.UseFont = true;
            this.txtMABS.Size = new System.Drawing.Size(67, 24);
            this.txtMABS.TabIndex = 7;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBN, "NGAYSINH", true));
            this.dtpNgaySinh.EditValue = null;
            this.dtpNgaySinh.Location = new System.Drawing.Point(623, 24);
            this.dtpNgaySinh.MenuManager = this.barManager1;
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.dtpNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySinh.Size = new System.Drawing.Size(117, 24);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBN, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(381, 24);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(154, 24);
            this.txtTen.TabIndex = 3;
            // 
            // txtMABN
            // 
            this.txtMABN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBN, "MABN", true));
            this.txtMABN.Enabled = false;
            this.txtMABN.Location = new System.Drawing.Point(185, 24);
            this.txtMABN.MenuManager = this.barManager1;
            this.txtMABN.Name = "txtMABN";
            this.txtMABN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMABN.Properties.Appearance.Options.UseFont = true;
            this.txtMABN.Size = new System.Drawing.Size(64, 24);
            this.txtMABN.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbVT);
            this.groupBox2.Controls.Add(tONGTIENLabel);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(sOLUONGLabel);
            this.groupBox2.Controls.Add(this.txtSL);
            this.groupBox2.Controls.Add(tHOIGIANLabel);
            this.groupBox2.Controls.Add(this.txtThoiGian);
            this.groupBox2.Controls.Add(nGAYLabel);
            this.groupBox2.Controls.Add(this.dtpNgay);
            this.groupBox2.Controls.Add(lANLabel);
            this.groupBox2.Controls.Add(this.txtLan);
            this.groupBox2.Controls.Add(mAVTLabel);
            this.groupBox2.Controls.Add(this.txtMAVT);
            this.groupBox2.Controls.Add(mABNLabel1);
            this.groupBox2.Controls.Add(this.txtMABNSD);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(0, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 230);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sử Dụng Vật Tư";
            // 
            // cmbVT
            // 
            this.cmbVT.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsSD, "MAVT", true));
            this.cmbVT.DataSource = this.bdsVT;
            this.cmbVT.DisplayMember = "TENVT";
            this.cmbVT.FormattingEnabled = true;
            this.cmbVT.Location = new System.Drawing.Point(311, 136);
            this.cmbVT.Name = "cmbVT";
            this.cmbVT.Size = new System.Drawing.Size(214, 25);
            this.cmbVT.TabIndex = 14;
            this.cmbVT.ValueMember = "MAVT";
            this.cmbVT.SelectedIndexChanged += new System.EventHandler(this.cmbVT_SelectedIndexChanged);
            // 
            // bdsSD
            // 
            this.bdsSD.DataMember = "FK_SUDUNG_BENHNHAN";
            this.bdsSD.DataSource = this.bdsBN;
            // 
            // txtTongTien
            // 
            this.txtTongTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSD, "TONGTIEN", true));
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(401, 179);
            this.txtTongTien.MenuManager = this.barManager1;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Size = new System.Drawing.Size(124, 24);
            this.txtTongTien.TabIndex = 13;
            // 
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSD, "SOLUONG", true));
            this.txtSL.Location = new System.Drawing.Point(168, 179);
            this.txtSL.MenuManager = this.barManager1;
            this.txtSL.Name = "txtSL";
            this.txtSL.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Properties.Appearance.Options.UseFont = true;
            this.txtSL.Size = new System.Drawing.Size(127, 24);
            this.txtSL.TabIndex = 11;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSD, "THOIGIAN", true));
            this.txtThoiGian.Location = new System.Drawing.Point(401, 92);
            this.txtThoiGian.MenuManager = this.barManager1;
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.Properties.Appearance.Options.UseFont = true;
            this.txtThoiGian.Size = new System.Drawing.Size(124, 24);
            this.txtThoiGian.TabIndex = 9;
            // 
            // dtpNgay
            // 
            this.dtpNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSD, "NGAY", true));
            this.dtpNgay.EditValue = null;
            this.dtpNgay.Location = new System.Drawing.Point(168, 92);
            this.dtpNgay.MenuManager = this.barManager1;
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Properties.Appearance.Options.UseFont = true;
            this.dtpNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgay.Size = new System.Drawing.Size(127, 24);
            this.dtpNgay.TabIndex = 7;
            // 
            // txtLan
            // 
            this.txtLan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSD, "LAN", true));
            this.txtLan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtLan.Location = new System.Drawing.Point(401, 50);
            this.txtLan.MenuManager = this.barManager1;
            this.txtLan.Name = "txtLan";
            this.txtLan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLan.Properties.Appearance.Options.UseFont = true;
            this.txtLan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLan.Size = new System.Drawing.Size(124, 24);
            this.txtLan.TabIndex = 5;
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSD, "MAVT", true));
            this.txtMAVT.Enabled = false;
            this.txtMAVT.Location = new System.Drawing.Point(168, 136);
            this.txtMAVT.MenuManager = this.barManager1;
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAVT.Properties.Appearance.Options.UseFont = true;
            this.txtMAVT.Size = new System.Drawing.Size(127, 24);
            this.txtMAVT.TabIndex = 3;
            // 
            // txtMABNSD
            // 
            this.txtMABNSD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSD, "MABN", true));
            this.txtMABNSD.Location = new System.Drawing.Point(168, 50);
            this.txtMABNSD.MenuManager = this.barManager1;
            this.txtMABNSD.Name = "txtMABNSD";
            this.txtMABNSD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMABNSD.Properties.Appearance.Options.UseFont = true;
            this.txtMABNSD.Size = new System.Drawing.Size(127, 24);
            this.txtMABNSD.TabIndex = 1;
            // 
            // SuDungTableAdapter
            // 
            this.SuDungTableAdapter.ClearBeforeFill = true;
            // 
            // gcSuDung
            // 
            this.gcSuDung.AutoGenerateColumns = false;
            this.gcSuDung.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gcSuDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gcSuDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gcSuDung.ContextMenuStrip = this.contextMenuStrip1;
            this.gcSuDung.DataSource = this.bdsSD;
            this.gcSuDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSuDung.Location = new System.Drawing.Point(594, 323);
            this.gcSuDung.Name = "gcSuDung";
            this.gcSuDung.ReadOnly = true;
            this.gcSuDung.Size = new System.Drawing.Size(473, 230);
            this.gcSuDung.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MABN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Bệnh Nhân";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Vật Tư";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LAN";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lần Sử Dụng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NGAY";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "THOIGIAN";
            this.dataGridViewTextBoxColumn5.HeaderText = "Thời Gian";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TONGTIEN";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tổng Tiền";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemSD,
            this.btnSuaSD,
            this.btnLuuSD,
            this.btnXoaSD});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 92);
            // 
            // btnThemSD
            // 
            this.btnThemSD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSD.Name = "btnThemSD";
            this.btnThemSD.Size = new System.Drawing.Size(109, 22);
            this.btnThemSD.Text = "Thêm";
            this.btnThemSD.Click += new System.EventHandler(this.btnThemSD_Click);
            // 
            // btnSuaSD
            // 
            this.btnSuaSD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSD.Name = "btnSuaSD";
            this.btnSuaSD.Size = new System.Drawing.Size(109, 22);
            this.btnSuaSD.Text = "Sửa";
            this.btnSuaSD.Click += new System.EventHandler(this.btnSuaSD_Click);
            // 
            // btnLuuSD
            // 
            this.btnLuuSD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuSD.Name = "btnLuuSD";
            this.btnLuuSD.Size = new System.Drawing.Size(109, 22);
            this.btnLuuSD.Text = "Lưu";
            this.btnLuuSD.Click += new System.EventHandler(this.btnLuuSD_Click);
            // 
            // btnXoaSD
            // 
            this.btnXoaSD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSD.Name = "btnXoaSD";
            this.btnXoaSD.Size = new System.Drawing.Size(109, 22);
            this.btnXoaSD.Text = "Xóa";
            this.btnXoaSD.Click += new System.EventHandler(this.btnXoaSD_Click);
            // 
            // frmBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 553);
            this.Controls.Add(this.gcSuDung);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcBenhNhan);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBenhNhan";
            this.Text = "Bệnh Nhân";
            this.Load += new System.EventHandler(this.frmBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBenhNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABN.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABNSD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSuDung)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnChuyenCN;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsBN;
        private DS DS;
        private DSTableAdapters.BENHNHANTableAdapter BenhNhanTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcBenhNhan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMABN;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colMABS;
        private System.Windows.Forms.BindingSource bdsDT;
        private DSTableAdapters.DIEUTRITableAdapter DieuTriTableAdapter;
        private System.Windows.Forms.BindingSource bdsGiuong;
        private DSTableAdapters.GIUONGTableAdapter GiuongTableAdapter;
        private System.Windows.Forms.BindingSource bdsVT;
        private DSTableAdapters.VATTUTableAdapter VatTuTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bdsSD;
        private DSTableAdapters.SUDUNGTableAdapter SuDungTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMABN;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.TextEdit txtSL;
        private DevExpress.XtraEditors.TextEdit txtThoiGian;
        private DevExpress.XtraEditors.DateEdit dtpNgay;
        private DevExpress.XtraEditors.SpinEdit txtLan;
        private DevExpress.XtraEditors.TextEdit txtMAVT;
        private DevExpress.XtraEditors.TextEdit txtMABNSD;
        private DevExpress.XtraEditors.TextEdit txtMABS;
        private DevExpress.XtraEditors.DateEdit dtpNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private System.Windows.Forms.ComboBox cmbVT;
        private System.Windows.Forms.DataGridView gcSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox cmbBS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemSD;
        private System.Windows.Forms.ToolStripMenuItem btnSuaSD;
        private System.Windows.Forms.ToolStripMenuItem btnLuuSD;
        private System.Windows.Forms.ToolStripMenuItem btnXoaSD;
    }
}