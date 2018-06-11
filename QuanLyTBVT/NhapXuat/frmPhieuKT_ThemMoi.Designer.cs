namespace QuanLyTBVT.NhapXuat
{
    partial class frmPhieuKT_ThemMoi
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
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaPKT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxNguoiTG = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNguoiTG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(169, 66);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(129, 19);
            this.materialLabel7.TabIndex = 39;
            this.materialLabel7.Text = "Mã phiếu kiểm tra";
            // 
            // txtMaPKT
            // 
            this.txtMaPKT.Depth = 0;
            this.txtMaPKT.Enabled = false;
            this.txtMaPKT.Hint = "";
            this.txtMaPKT.Location = new System.Drawing.Point(314, 62);
            this.txtMaPKT.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaPKT.Name = "txtMaPKT";
            this.txtMaPKT.PasswordChar = '\0';
            this.txtMaPKT.SelectedText = "";
            this.txtMaPKT.SelectionLength = 0;
            this.txtMaPKT.SelectionStart = 0;
            this.txtMaPKT.Size = new System.Drawing.Size(401, 23);
            this.txtMaPKT.TabIndex = 0;
            this.txtMaPKT.UseSystemPasswordChar = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHuy.Location = new System.Drawing.Point(459, 211);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(117, 49);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(282, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 49);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Thêm mới";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(169, 162);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 19);
            this.materialLabel2.TabIndex = 33;
            this.materialLabel2.Text = "Ngày lập";
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
            this.labelControl.Size = new System.Drawing.Size(846, 37);
            this.labelControl.TabIndex = 32;
            this.labelControl.Text = "Thông tin Phiếu kiểm tra";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(169, 110);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 19);
            this.materialLabel1.TabIndex = 31;
            this.materialLabel1.Text = "Người tham gia";
            // 
            // cbxNguoiTG
            // 
            this.cbxNguoiTG.Location = new System.Drawing.Point(314, 105);
            this.cbxNguoiTG.Name = "cbxNguoiTG";
            this.cbxNguoiTG.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNguoiTG.Properties.Appearance.Options.UseFont = true;
            this.cbxNguoiTG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNguoiTG.Size = new System.Drawing.Size(401, 28);
            this.cbxNguoiTG.TabIndex = 40;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(314, 154);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(401, 29);
            this.dtpNgayLap.TabIndex = 41;
            // 
            // frmPhieuKT_ThemMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 312);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.cbxNguoiTG);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtMaPKT);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmPhieuKT_ThemMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới phiếu kiểm tra";
            ((System.ComponentModel.ISupportInitialize)(this.cbxNguoiTG.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaPKT;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbxNguoiTG;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
    }
}