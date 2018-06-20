namespace QuanLyTBVT.BaoCao
{
    partial class frmBaoCaoNhap
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
            this.cryView1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPhieuNhap = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cryView1
            // 
            this.cryView1.ActiveViewIndex = -1;
            this.cryView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cryView1.Location = new System.Drawing.Point(0, 70);
            this.cryView1.Name = "cryView1";
            this.cryView1.Size = new System.Drawing.Size(1277, 457);
            this.cryView1.TabIndex = 2;
            this.cryView1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(566, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "PHIẾU NHẬP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "BÁO CÁO PHIẾU NHẬP KHO";
            // 
            // cbxPhieuNhap
            // 
            this.cbxPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPhieuNhap.FormattingEnabled = true;
            this.cbxPhieuNhap.Location = new System.Drawing.Point(673, 12);
            this.cbxPhieuNhap.Name = "cbxPhieuNhap";
            this.cbxPhieuNhap.Size = new System.Drawing.Size(348, 29);
            this.cbxPhieuNhap.TabIndex = 5;
            this.cbxPhieuNhap.SelectedIndexChanged += new System.EventHandler(this.cbxPhieuNhap_SelectedIndexChanged);
            // 
            // frmBaoCaoNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPhieuNhap);
            this.Controls.Add(this.cryView1);
            this.Name = "frmBaoCaoNhap";
            this.Size = new System.Drawing.Size(1277, 527);
            this.Load += new System.EventHandler(this.frmBaoCaoNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPhieuNhap;
    }
}
