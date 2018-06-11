namespace QuanLyTBVT.DanhMuc
{
    partial class frmLoaiVatTu_ThemMoi
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
            this.txtMaLVT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenLVT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(144, 65);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(101, 19);
            this.materialLabel7.TabIndex = 31;
            this.materialLabel7.Text = "Mã loại vật tư";
            // 
            // txtMaLVT
            // 
            this.txtMaLVT.Depth = 0;
            this.txtMaLVT.Enabled = false;
            this.txtMaLVT.Hint = "";
            this.txtMaLVT.Location = new System.Drawing.Point(289, 61);
            this.txtMaLVT.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaLVT.Name = "txtMaLVT";
            this.txtMaLVT.PasswordChar = '\0';
            this.txtMaLVT.SelectedText = "";
            this.txtMaLVT.SelectionLength = 0;
            this.txtMaLVT.SelectionStart = 0;
            this.txtMaLVT.Size = new System.Drawing.Size(401, 23);
            this.txtMaLVT.TabIndex = 30;
            this.txtMaLVT.UseSystemPasswordChar = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHuy.Location = new System.Drawing.Point(482, 253);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(117, 49);
            this.btnHuy.TabIndex = 26;
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
            this.btnSave.Location = new System.Drawing.Point(329, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 49);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Thêm mới";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(289, 157);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(401, 61);
            this.txtMoTa.TabIndex = 24;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(144, 174);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(48, 19);
            this.materialLabel6.TabIndex = 29;
            this.materialLabel6.Text = "Mô tả";
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
            this.labelControl.Size = new System.Drawing.Size(839, 37);
            this.labelControl.TabIndex = 28;
            this.labelControl.Text = "Thông tin Loại vật tư";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(144, 109);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 19);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "Tên loại vật tư";
            // 
            // txtTenLVT
            // 
            this.txtTenLVT.Depth = 0;
            this.txtTenLVT.Hint = "";
            this.txtTenLVT.Location = new System.Drawing.Point(289, 105);
            this.txtTenLVT.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenLVT.Name = "txtTenLVT";
            this.txtTenLVT.PasswordChar = '\0';
            this.txtTenLVT.SelectedText = "";
            this.txtTenLVT.SelectionLength = 0;
            this.txtTenLVT.SelectionStart = 0;
            this.txtTenLVT.Size = new System.Drawing.Size(401, 23);
            this.txtTenLVT.TabIndex = 23;
            this.txtTenLVT.UseSystemPasswordChar = false;
            // 
            // frmLoaiVatTu_ThemMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 335);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtMaLVT);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtTenLVT);
            this.Name = "frmLoaiVatTu_ThemMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm mới loại vật tư";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaLVT;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMoTa;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenLVT;
    }
}