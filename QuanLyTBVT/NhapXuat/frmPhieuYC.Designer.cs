namespace QuanLyTBVT.NhapXuat
{
    partial class frmPhieuYC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnDuyetPhieu = new System.Windows.Forms.Button();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.bdsData = new DevExpress.XtraEditors.DataNavigator();
            this.grdData = new DevExpress.XtraGrid.GridControl();
            this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhieuYC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colKhoXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoYC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSearchKhoYC = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxSearchKho = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxTrangThai = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchMa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDetails.Location = new System.Drawing.Point(1137, 199);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(103, 42);
            this.btnDetails.TabIndex = 49;
            this.btnDetails.Text = "Chi tiết";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnDuyetPhieu
            // 
            this.btnDuyetPhieu.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDuyetPhieu.Enabled = false;
            this.btnDuyetPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyetPhieu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetPhieu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDuyetPhieu.Location = new System.Drawing.Point(1006, 199);
            this.btnDuyetPhieu.Name = "btnDuyetPhieu";
            this.btnDuyetPhieu.Size = new System.Drawing.Size(114, 42);
            this.btnDuyetPhieu.TabIndex = 52;
            this.btnDuyetPhieu.Text = "Duyệt Phiếu";
            this.btnDuyetPhieu.UseVisualStyleBackColor = false;
            this.btnDuyetPhieu.Click += new System.EventHandler(this.btnDuyetPhieu_Click);
            // 
            // labelControl
            // 
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Location = new System.Drawing.Point(0, 0);
            this.labelControl.Name = "labelControl";
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.labelControl.Size = new System.Drawing.Size(1297, 37);
            this.labelControl.TabIndex = 44;
            this.labelControl.Text = "Thông tin phiếu nhập";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(884, 199);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 42);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(762, 199);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 42);
            this.btnSua.TabIndex = 50;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThemMoi.Location = new System.Drawing.Point(641, 199);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(103, 42);
            this.btnThemMoi.TabIndex = 48;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // bdsData
            // 
            this.bdsData.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdsData.Appearance.Options.UseFont = true;
            this.bdsData.Buttons.Append.Visible = false;
            this.bdsData.Buttons.CancelEdit.Visible = false;
            this.bdsData.Buttons.EndEdit.Visible = false;
            this.bdsData.Buttons.NextPage.Visible = false;
            this.bdsData.Buttons.PrevPage.Visible = false;
            this.bdsData.Buttons.Remove.Visible = false;
            this.bdsData.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.bdsData.Location = new System.Drawing.Point(59, 214);
            this.bdsData.Name = "bdsData";
            this.bdsData.Size = new System.Drawing.Size(349, 27);
            this.bdsData.TabIndex = 47;
            this.bdsData.Text = "dataNavigator1";
            this.bdsData.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.bdsData.TextStringFormat = "Bản ghi {0} / {1}";
            // 
            // grdData
            // 
            gridLevelNode1.RelationName = "Level1";
            this.grdData.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdData.Location = new System.Drawing.Point(58, 247);
            this.grdData.MainView = this.grvData;
            this.grdData.Name = "grdData";
            this.grdData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.grdData.Size = new System.Drawing.Size(1217, 441);
            this.grdData.TabIndex = 46;
            this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
            // 
            // grvData
            // 
            this.grvData.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvData.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvData.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grvData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grvData.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.grvData.Appearance.OddRow.Options.UseBackColor = true;
            this.grvData.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvData.Appearance.Row.Options.UseFont = true;
            this.grvData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.grvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMaPhieuYC,
            this.colKhoXuat,
            this.colKhoYC,
            this.colNgayLap,
            this.colNguoiLap,
            this.colNgayDuyet,
            this.colNguoiDuyet,
            this.colTrangThai});
            this.grvData.GridControl = this.grdData;
            this.grvData.Name = "grvData";
            this.grvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvData.OptionsBehavior.Editable = false;
            this.grvData.OptionsBehavior.ReadOnly = true;
            this.grvData.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grvData.OptionsView.EnableAppearanceEvenRow = true;
            this.grvData.OptionsView.EnableAppearanceOddRow = true;
            this.grvData.Click += new System.EventHandler(this.grvData_Click);
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 71;
            // 
            // colMaPhieuYC
            // 
            this.colMaPhieuYC.Caption = "Mã Phiếu Yêu cầu";
            this.colMaPhieuYC.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colMaPhieuYC.FieldName = "MaPhieuYC";
            this.colMaPhieuYC.Name = "colMaPhieuYC";
            this.colMaPhieuYC.Visible = true;
            this.colMaPhieuYC.VisibleIndex = 1;
            this.colMaPhieuYC.Width = 193;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colKhoXuat
            // 
            this.colKhoXuat.Caption = "Kho Xuất";
            this.colKhoXuat.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colKhoXuat.FieldName = "TenKhoXuat";
            this.colKhoXuat.Name = "colKhoXuat";
            this.colKhoXuat.Visible = true;
            this.colKhoXuat.VisibleIndex = 2;
            this.colKhoXuat.Width = 120;
            // 
            // colKhoYC
            // 
            this.colKhoYC.Caption = "Kho yêu cầu";
            this.colKhoYC.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colKhoYC.FieldName = "TenKhoYC";
            this.colKhoYC.Name = "colKhoYC";
            this.colKhoYC.Visible = true;
            this.colKhoYC.VisibleIndex = 3;
            this.colKhoYC.Width = 120;
            // 
            // colNgayLap
            // 
            this.colNgayLap.Caption = "Ngày Lập";
            this.colNgayLap.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNgayLap.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayLap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colNgayLap.FieldName = "NgayLap";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.Visible = true;
            this.colNgayLap.VisibleIndex = 4;
            this.colNgayLap.Width = 178;
            // 
            // colNguoiLap
            // 
            this.colNguoiLap.Caption = "Người Lập";
            this.colNguoiLap.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNguoiLap.FieldName = "NguoiLap";
            this.colNguoiLap.Name = "colNguoiLap";
            this.colNguoiLap.Visible = true;
            this.colNguoiLap.VisibleIndex = 5;
            this.colNguoiLap.Width = 178;
            // 
            // colNgayDuyet
            // 
            this.colNgayDuyet.Caption = "Ngày duyệt";
            this.colNgayDuyet.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNgayDuyet.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayDuyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colNgayDuyet.FieldName = "NgayDuyet";
            this.colNgayDuyet.Name = "colNgayDuyet";
            this.colNgayDuyet.Visible = true;
            this.colNgayDuyet.VisibleIndex = 6;
            this.colNgayDuyet.Width = 178;
            // 
            // colNguoiDuyet
            // 
            this.colNguoiDuyet.Caption = "Người duyệt";
            this.colNguoiDuyet.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNguoiDuyet.FieldName = "NguoiDuyet";
            this.colNguoiDuyet.Name = "colNguoiDuyet";
            this.colNguoiDuyet.Visible = true;
            this.colNguoiDuyet.VisibleIndex = 7;
            this.colNguoiDuyet.Width = 178;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng thái";
            this.colTrangThai.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 8;
            this.colTrangThai.Width = 128;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxSearchKhoYC);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.cbxSearchKho);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.cbxTrangThai);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearchMa);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1201, 137);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbxSearchKhoYC
            // 
            this.cbxSearchKhoYC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchKhoYC.FormattingEnabled = true;
            this.cbxSearchKhoYC.Items.AddRange(new object[] {
            "---Chọn---",
            "Mới",
            "Đã Duyệt",
            "Đã Nhập"});
            this.cbxSearchKhoYC.Location = new System.Drawing.Point(582, 77);
            this.cbxSearchKhoYC.Name = "cbxSearchKhoYC";
            this.cbxSearchKhoYC.Size = new System.Drawing.Size(287, 29);
            this.cbxSearchKhoYC.TabIndex = 14;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(472, 82);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(90, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Kho yêu cầu";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxSearchKho
            // 
            this.cbxSearchKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchKho.FormattingEnabled = true;
            this.cbxSearchKho.Items.AddRange(new object[] {
            "---Chọn---",
            "Mới",
            "Đã Duyệt",
            "Đã Nhập"});
            this.cbxSearchKho.Location = new System.Drawing.Point(582, 30);
            this.cbxSearchKho.Name = "cbxSearchKho";
            this.cbxSearchKho.Size = new System.Drawing.Size(287, 29);
            this.cbxSearchKho.TabIndex = 12;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(472, 35);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(67, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Kho xuất";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Items.AddRange(new object[] {
            "---Chọn---",
            "Mới",
            "Đã Duyệt",
            "Đã Nhập"});
            this.cbxTrangThai.Location = new System.Drawing.Point(127, 77);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(241, 29);
            this.cbxTrangThai.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(930, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 42);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchMa
            // 
            this.txtSearchMa.Depth = 0;
            this.txtSearchMa.Hint = "";
            this.txtSearchMa.Location = new System.Drawing.Point(127, 31);
            this.txtSearchMa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchMa.Name = "txtSearchMa";
            this.txtSearchMa.PasswordChar = '\0';
            this.txtSearchMa.SelectedText = "";
            this.txtSearchMa.SelectionLength = 0;
            this.txtSearchMa.SelectionStart = 0;
            this.txtSearchMa.Size = new System.Drawing.Size(239, 23);
            this.txtSearchMa.TabIndex = 6;
            this.txtSearchMa.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 82);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Trạng thái";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 35);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(70, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Mã phiếu";
            // 
            // frmPhieuYC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnDuyetPhieu);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.bdsData);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhieuYC";
            this.Size = new System.Drawing.Size(1297, 711);
            this.Load += new System.EventHandler(this.frmPhieuYC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnDuyetPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemMoi;
        private DevExpress.XtraEditors.DataNavigator bdsData;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView grvData;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuYC;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiLap;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxSearchKhoYC;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox cbxSearchKho;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox cbxTrangThai;
        private System.Windows.Forms.Button btnSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchMa;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoYC;
    }
}
