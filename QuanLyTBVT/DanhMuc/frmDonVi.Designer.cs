namespace QuanLyTBVT.DanhMuc
{
    partial class frmDonVi
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
        ///
        private void InitializeComponent()
        {
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.tlstData = new DevExpress.XtraTreeList.TreeList();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.bdsData = new DevExpress.XtraEditors.DataNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.tlstData)).BeginInit();
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
            this.labelControl.Size = new System.Drawing.Size(995, 37);
            this.labelControl.TabIndex = 1;
            this.labelControl.Text = "Thông tin Đơn vị";
            // 
            // tlstData
            // 
            this.tlstData.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlstData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlstData.Location = new System.Drawing.Point(21, 114);
            this.tlstData.Name = "tlstData";
            this.tlstData.Size = new System.Drawing.Size(933, 411);
            this.tlstData.TabIndex = 5;
            this.tlstData.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlstData_FocusedNodeChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(636, 66);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 42);
            this.btnXoa.TabIndex = 22;
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
            this.btnSua.Location = new System.Drawing.Point(514, 66);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 42);
            this.btnSua.TabIndex = 21;
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
            this.btnThemMoi.Location = new System.Drawing.Point(393, 66);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(103, 42);
            this.btnThemMoi.TabIndex = 20;
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
            this.bdsData.Location = new System.Drawing.Point(21, 81);
            this.bdsData.Name = "bdsData";
            this.bdsData.Size = new System.Drawing.Size(349, 27);
            this.bdsData.TabIndex = 19;
            this.bdsData.Text = "dataNavigator1";
            this.bdsData.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.bdsData.TextStringFormat = "Bản ghi {0} / {1}";
            // 
            // frmDonVi
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.bdsData);
            this.Controls.Add(this.tlstData);
            this.Controls.Add(this.labelControl);
            this.Name = "frmDonVi";
            this.Size = new System.Drawing.Size(995, 539);
            this.Load += new System.EventHandler(this.frmDonVi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlstData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraTreeList.TreeList tlstData;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemMoi;
        private DevExpress.XtraEditors.DataNavigator bdsData;
    }
}
