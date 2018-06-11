namespace QuanLyTBVT
{
    partial class frmDoiMK
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPasswordOld = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAccount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPasswordNew = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPasswordAgain = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(147, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(680, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Công ty Kho vận và Cảng Cẩm Phả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(146, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ VẬT TƯ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.txtPasswordAgain);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.txtPasswordNew);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtPasswordOld);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(167, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 313);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnThoat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThoat.Location = new System.Drawing.Point(398, 243);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 49);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Trở về";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(275, 243);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 49);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đổi mật khẩu";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(34, 94);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(91, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Mật khẩu cũ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(34, 48);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Tên đăng nhập";
            // 
            // txtPasswordOld
            // 
            this.txtPasswordOld.Depth = 0;
            this.txtPasswordOld.Hint = "";
            this.txtPasswordOld.Location = new System.Drawing.Point(211, 90);
            this.txtPasswordOld.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPasswordOld.Name = "txtPasswordOld";
            this.txtPasswordOld.PasswordChar = '*';
            this.txtPasswordOld.SelectedText = "";
            this.txtPasswordOld.SelectionLength = 0;
            this.txtPasswordOld.SelectionStart = 0;
            this.txtPasswordOld.Size = new System.Drawing.Size(304, 23);
            this.txtPasswordOld.TabIndex = 1;
            this.txtPasswordOld.UseSystemPasswordChar = false;
            // 
            // txtAccount
            // 
            this.txtAccount.Depth = 0;
            this.txtAccount.Hint = "";
            this.txtAccount.Location = new System.Drawing.Point(211, 44);
            this.txtAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.SelectedText = "";
            this.txtAccount.SelectionLength = 0;
            this.txtAccount.SelectionStart = 0;
            this.txtAccount.Size = new System.Drawing.Size(304, 23);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(34, 140);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(101, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Mật khẩu mới";
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Depth = 0;
            this.txtPasswordNew.Hint = "";
            this.txtPasswordNew.Location = new System.Drawing.Point(211, 136);
            this.txtPasswordNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.PasswordChar = '*';
            this.txtPasswordNew.SelectedText = "";
            this.txtPasswordNew.SelectionLength = 0;
            this.txtPasswordNew.SelectionStart = 0;
            this.txtPasswordNew.Size = new System.Drawing.Size(304, 23);
            this.txtPasswordNew.TabIndex = 2;
            this.txtPasswordNew.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(34, 186);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(136, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Xác nhận mật khẩu";
            // 
            // txtPasswordAgain
            // 
            this.txtPasswordAgain.Depth = 0;
            this.txtPasswordAgain.Hint = "";
            this.txtPasswordAgain.Location = new System.Drawing.Point(211, 182);
            this.txtPasswordAgain.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPasswordAgain.Name = "txtPasswordAgain";
            this.txtPasswordAgain.PasswordChar = '*';
            this.txtPasswordAgain.SelectedText = "";
            this.txtPasswordAgain.SelectionLength = 0;
            this.txtPasswordAgain.SelectionStart = 0;
            this.txtPasswordAgain.Size = new System.Drawing.Size(304, 23);
            this.txtPasswordAgain.TabIndex = 3;
            this.txtPasswordAgain.UseSystemPasswordChar = false;
            // 
            // frmDoiMK
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPasswordOld;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAccount;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPasswordAgain;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPasswordNew;
    }
}