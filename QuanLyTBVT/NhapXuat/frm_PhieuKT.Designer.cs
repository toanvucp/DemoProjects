namespace QuanLyTBVT.NhapXuat
{
    partial class frm_PhieuKT
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
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchMa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.bdsData = new DevExpress.XtraEditors.DataNavigator();
            this.grdData = new DevExpress.XtraGrid.GridControl();
            this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhieuKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colNgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTrangThai = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDuyetPhieu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.labelControl.Size = new System.Drawing.Size(960, 37);
            this.labelControl.TabIndex = 24;
            this.labelControl.Text = "Thông tin phiếu kiểm tra";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(426, 70);
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
            this.txtSearchMa.Location = new System.Drawing.Point(153, 33);
            this.txtSearchMa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchMa.Name = "txtSearchMa";
            this.txtSearchMa.PasswordChar = '\0';
            this.txtSearchMa.SelectedText = "";
            this.txtSearchMa.SelectionLength = 0;
            this.txtSearchMa.SelectionStart = 0;
            this.txtSearchMa.Size = new System.Drawing.Size(272, 23);
            this.txtSearchMa.TabIndex = 6;
            this.txtSearchMa.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(10, 37);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(70, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Mã phiếu";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(630, 206);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 42);
            this.btnXoa.TabIndex = 33;
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
            this.btnSua.Location = new System.Drawing.Point(508, 206);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 42);
            this.btnSua.TabIndex = 32;
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
            this.btnThemMoi.Location = new System.Drawing.Point(387, 206);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(103, 42);
            this.btnThemMoi.TabIndex = 31;
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
            this.bdsData.Location = new System.Drawing.Point(15, 221);
            this.bdsData.Name = "bdsData";
            this.bdsData.Size = new System.Drawing.Size(349, 27);
            this.bdsData.TabIndex = 30;
            this.bdsData.Text = "dataNavigator1";
            this.bdsData.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.bdsData.TextStringFormat = "Bản ghi {0} / {1}";
            // 
            // grdData
            // 
            gridLevelNode1.RelationName = "Level1";
            this.grdData.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdData.Location = new System.Drawing.Point(0, 251);
            this.grdData.MainView = this.grvData;
            this.grdData.Name = "grdData";
            this.grdData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.grdData.Size = new System.Drawing.Size(944, 277);
            this.grdData.TabIndex = 29;
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
            this.colMaPhieuKT,
            this.colNgayNhap,
            this.colNguoiLap,
            this.colNguoiTG,
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
            this.grvData.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvData_RowClick);
            // 
            // colMaPhieuKT
            // 
            this.colMaPhieuKT.Caption = "Mã Phiếu KT";
            this.colMaPhieuKT.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colMaPhieuKT.FieldName = "MaPhieuKT";
            this.colMaPhieuKT.Name = "colMaPhieuKT";
            this.colMaPhieuKT.Visible = true;
            this.colMaPhieuKT.VisibleIndex = 0;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.Caption = "Ngày lập";
            this.colNgayNhap.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNgayNhap.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colNgayNhap.FieldName = "NgayLap";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.Visible = true;
            this.colNgayNhap.VisibleIndex = 1;
            // 
            // colNguoiLap
            // 
            this.colNguoiLap.Caption = "Người Lập";
            this.colNguoiLap.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNguoiLap.FieldName = "NguoiLap";
            this.colNguoiLap.Name = "colNguoiLap";
            this.colNguoiLap.Visible = true;
            this.colNguoiLap.VisibleIndex = 2;
            // 
            // colNguoiTG
            // 
            this.colNguoiTG.Caption = "Người tham gia";
            this.colNguoiTG.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNguoiTG.FieldName = "NguoiThamGia";
            this.colNguoiTG.Name = "colNguoiTG";
            this.colNguoiTG.Visible = true;
            this.colNguoiTG.VisibleIndex = 3;
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
            this.colNgayDuyet.VisibleIndex = 4;
            // 
            // colNguoiDuyet
            // 
            this.colNguoiDuyet.Caption = "Người duyệt";
            this.colNguoiDuyet.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNguoiDuyet.FieldName = "NguoiDuyet";
            this.colNguoiDuyet.Name = "colNguoiDuyet";
            this.colNguoiDuyet.Visible = true;
            this.colNguoiDuyet.VisibleIndex = 5;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng thái";
            this.colTrangThai.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxTrangThai);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearchMa);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 137);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
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
            this.cbxTrangThai.Location = new System.Drawing.Point(593, 32);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(273, 29);
            this.cbxTrangThai.TabIndex = 10;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(504, 35);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Trạng thái";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDuyetPhieu
            // 
            this.btnDuyetPhieu.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDuyetPhieu.Enabled = false;
            this.btnDuyetPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyetPhieu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetPhieu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDuyetPhieu.Location = new System.Drawing.Point(752, 206);
            this.btnDuyetPhieu.Name = "btnDuyetPhieu";
            this.btnDuyetPhieu.Size = new System.Drawing.Size(114, 42);
            this.btnDuyetPhieu.TabIndex = 34;
            this.btnDuyetPhieu.Text = "Duyệt Phiếu";
            this.btnDuyetPhieu.UseVisualStyleBackColor = false;
            this.btnDuyetPhieu.Click += new System.EventHandler(this.btnDuyetPhieu_Click);
            // 
            // frm_PhieuKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDuyetPhieu);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.bdsData);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_PhieuKT";
            this.Size = new System.Drawing.Size(960, 542);
            this.Load += new System.EventHandler(this.frm_PhieuKT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl;
        private System.Windows.Forms.Button btnSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchMa;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemMoi;
        private DevExpress.XtraEditors.DataNavigator bdsData;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView grvData;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuKT;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiLap;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiTG;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private System.Windows.Forms.ComboBox cbxTrangThai;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button btnDuyetPhieu;
    }
}
