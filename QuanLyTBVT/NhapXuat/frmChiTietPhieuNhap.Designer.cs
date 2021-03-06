﻿namespace QuanLyTBVT.NhapXuat
{
    partial class frmChiTietPhieuNhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTrangThai = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchMa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bdsData = new DevExpress.XtraEditors.DataNavigator();
            this.grdData = new DevExpress.XtraGrid.GridControl();
            this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCTKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTTVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
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
            this.labelControl.Size = new System.Drawing.Size(1311, 37);
            this.labelControl.TabIndex = 29;
            this.labelControl.Text = "Chi tiết Phiếu nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxTrangThai);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearchMa);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1212, 137);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Location = new System.Drawing.Point(765, 28);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(273, 29);
            this.cbxTrangThai.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(598, 66);
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
            this.txtSearchMa.Location = new System.Drawing.Point(325, 29);
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
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(676, 31);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Vật tư";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(182, 33);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(104, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Serial Number";
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
            this.bdsData.Location = new System.Drawing.Point(64, 205);
            this.bdsData.Name = "bdsData";
            this.bdsData.Size = new System.Drawing.Size(323, 27);
            this.bdsData.TabIndex = 41;
            this.bdsData.Text = "dataNavigator1";
            this.bdsData.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.bdsData.TextStringFormat = "Bản ghi {0} / {1}";
            // 
            // grdData
            // 
            gridLevelNode1.RelationName = "Level1";
            this.grdData.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdData.Location = new System.Drawing.Point(63, 238);
            this.grdData.MainView = this.grvData;
            this.grdData.Name = "grdData";
            this.grdData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit2});
            this.grdData.Size = new System.Drawing.Size(1213, 441);
            this.grdData.TabIndex = 40;
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
            this.colMaCTKT,
            this.colMaVT,
            this.colSTT,
            this.colSN,
            this.colPTKT,
            this.colSoLuong,
            this.colTenVT,
            this.colTTVT,
            this.colMoTa});
            this.grvData.GridControl = this.grdData;
            this.grvData.Name = "grvData";
            this.grvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvData.OptionsBehavior.Editable = false;
            this.grvData.OptionsBehavior.ReadOnly = true;
            this.grvData.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grvData.OptionsView.EnableAppearanceEvenRow = true;
            this.grvData.OptionsView.EnableAppearanceOddRow = true;
            // 
            // colMaCTKT
            // 
            this.colMaCTKT.Caption = "Mã chi tiết PN";
            this.colMaCTKT.FieldName = "MaCTPN";
            this.colMaCTKT.Name = "colMaCTKT";
            // 
            // colMaVT
            // 
            this.colMaVT.Caption = "Mã Vật tư";
            this.colMaVT.FieldName = "MaVT";
            this.colMaVT.Name = "colMaVT";
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 66;
            // 
            // colSN
            // 
            this.colSN.Caption = "Serial Number";
            this.colSN.FieldName = "SerialNumber";
            this.colSN.Name = "colSN";
            this.colSN.Visible = true;
            this.colSN.VisibleIndex = 1;
            this.colSN.Width = 207;
            // 
            // colPTKT
            // 
            this.colPTKT.Caption = "PTKT";
            this.colPTKT.FieldName = "PTKT";
            this.colPTKT.Name = "colPTKT";
            this.colPTKT.Width = 188;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
            this.colSoLuong.Width = 207;
            // 
            // colTenVT
            // 
            this.colTenVT.Caption = "Vật tư";
            this.colTenVT.FieldName = "TenVT";
            this.colTenVT.Name = "colTenVT";
            this.colTenVT.Visible = true;
            this.colTenVT.VisibleIndex = 2;
            this.colTenVT.Width = 218;
            // 
            // colTTVT
            // 
            this.colTTVT.Caption = "Trạng thái vật tư";
            this.colTTVT.ColumnEdit = this.repositoryItemMemoEdit2;
            this.colTTVT.FieldName = "TrangThaiVT";
            this.colTTVT.Name = "colTTVT";
            this.colTTVT.Visible = true;
            this.colTTVT.VisibleIndex = 4;
            this.colTTVT.Width = 180;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // colMoTa
            // 
            this.colMoTa.Caption = "Mô tả";
            this.colMoTa.FieldName = "MoTa";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 5;
            this.colMoTa.Width = 159;
            // 
            // frmChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bdsData);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChiTietPhieuNhap";
            this.Size = new System.Drawing.Size(1311, 730);
            this.Load += new System.EventHandler(this.frmChiTietPhieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxTrangThai;
        private System.Windows.Forms.Button btnSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchMa;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DevExpress.XtraEditors.DataNavigator bdsData;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView grvData;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCTKT;
        private DevExpress.XtraGrid.Columns.GridColumn colMaVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colSN;
        private DevExpress.XtraGrid.Columns.GridColumn colPTKT;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTTVT;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
    }
}
