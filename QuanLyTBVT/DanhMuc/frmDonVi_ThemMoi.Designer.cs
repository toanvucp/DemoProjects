namespace QuanLyTBVT.DanhMuc
{
    partial class frmDonVi_ThemMoi
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
            this.txtMaDV = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenDV = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxParentID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(163, 46);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(75, 19);
            this.materialLabel7.TabIndex = 56;
            this.materialLabel7.Text = "Mã đơn vị";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Depth = 0;
            this.txtMaDV.Enabled = false;
            this.txtMaDV.Hint = "";
            this.txtMaDV.Location = new System.Drawing.Point(308, 42);
            this.txtMaDV.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.PasswordChar = '\0';
            this.txtMaDV.SelectedText = "";
            this.txtMaDV.SelectionLength = 0;
            this.txtMaDV.SelectionStart = 0;
            this.txtMaDV.Size = new System.Drawing.Size(401, 23);
            this.txtMaDV.TabIndex = 55;
            this.txtMaDV.UseSystemPasswordChar = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHuy.Location = new System.Drawing.Point(482, 285);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(117, 49);
            this.btnHuy.TabIndex = 47;
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
            this.btnSave.Location = new System.Drawing.Point(321, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 49);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Thêm mới";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.labelControl.Size = new System.Drawing.Size(856, 37);
            this.labelControl.TabIndex = 49;
            this.labelControl.Text = "Thông tin đơn vị";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(163, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 48;
            this.materialLabel1.Text = "Tên đơn vị";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Depth = 0;
            this.txtTenDV.Hint = "";
            this.txtTenDV.Location = new System.Drawing.Point(308, 90);
            this.txtTenDV.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.PasswordChar = '\0';
            this.txtTenDV.SelectedText = "";
            this.txtTenDV.SelectionLength = 0;
            this.txtTenDV.SelectionStart = 0;
            this.txtTenDV.Size = new System.Drawing.Size(401, 23);
            this.txtTenDV.TabIndex = 43;
            this.txtTenDV.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(163, 221);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(48, 19);
            this.materialLabel6.TabIndex = 54;
            this.materialLabel6.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(308, 192);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(401, 61);
            this.txtMoTa.TabIndex = 45;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(163, 148);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 51;
            this.materialLabel3.Text = "Đơn vị cha";
            // 
            // cbxParentID
            // 
            this.cbxParentID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxParentID.FormattingEnabled = true;
            this.cbxParentID.Location = new System.Drawing.Point(308, 138);
            this.cbxParentID.Name = "cbxParentID";
            this.cbxParentID.Size = new System.Drawing.Size(401, 29);
            this.cbxParentID.TabIndex = 58;
            // 
            // frmDonVi_ThemMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 367);
            this.Controls.Add(this.cbxParentID);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtTenDV);
            this.Name = "frmDonVi_ThemMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm mới đơn vị";
            this.Load += new System.EventHandler(this.frmDonVi_ThemMoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaDV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenDV;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox txtMoTa;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox cbxParentID;
    }
}