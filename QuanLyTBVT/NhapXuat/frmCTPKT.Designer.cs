namespace QuanLyTBVT.NhapXuat
{
    partial class frmCTPKT
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
            this.tctrolView = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpageCTPKT = new System.Windows.Forms.TabPage();
            this.btnShow = new System.Windows.Forms.Button();
            this.tctrolView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrolView
            // 
            this.tctrolView.Controls.Add(this.tabPage1);
            this.tctrolView.Controls.Add(this.tpageCTPKT);
            this.tctrolView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrolView.Location = new System.Drawing.Point(1, 1);
            this.tctrolView.Name = "tctrolView";
            this.tctrolView.SelectedIndex = 0;
            this.tctrolView.Size = new System.Drawing.Size(961, 590);
            this.tctrolView.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(953, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phiếu kiểm tra";
            // 
            // tpageCTPKT
            // 
            this.tpageCTPKT.BackColor = System.Drawing.Color.White;
            this.tpageCTPKT.Location = new System.Drawing.Point(4, 22);
            this.tpageCTPKT.Name = "tpageCTPKT";
            this.tpageCTPKT.Padding = new System.Windows.Forms.Padding(3);
            this.tpageCTPKT.Size = new System.Drawing.Size(953, 564);
            this.tpageCTPKT.TabIndex = 1;
            this.tpageCTPKT.Text = "Chi tiết phiếu kiểm tra";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(211, 192);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(184, 58);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmCTPKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShow);
            this.Name = "frmCTPKT";
            this.Size = new System.Drawing.Size(967, 596);
            this.Load += new System.EventHandler(this.frmCTPKT_Load);
            this.tctrolView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tctrolView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpageCTPKT;
        public System.Windows.Forms.Button btnShow;
    }
}
