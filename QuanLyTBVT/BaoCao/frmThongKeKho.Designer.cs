﻿namespace QuanLyTBVT.BaoCao
{
    partial class frmThongKeKho
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
            this.cbxMaKho = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cryView1
            // 
            this.cryView1.ActiveViewIndex = -1;
            this.cryView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cryView1.Location = new System.Drawing.Point(0, 63);
            this.cryView1.Name = "cryView1";
            this.cryView1.Size = new System.Drawing.Size(1311, 672);
            this.cryView1.TabIndex = 1;
            this.cryView1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cbxMaKho
            // 
            this.cbxMaKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaKho.FormattingEnabled = true;
            this.cbxMaKho.Location = new System.Drawing.Point(639, 14);
            this.cbxMaKho.Name = "cbxMaKho";
            this.cbxMaKho.Size = new System.Drawing.Size(348, 29);
            this.cbxMaKho.TabIndex = 2;
            this.cbxMaKho.SelectedIndexChanged += new System.EventHandler(this.cbxMaKho_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "BÁO CÁO VẬT TƯ THIẾT BỊ TỒN KHO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kho Vật Tư";
            // 
            // frmThongKeKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMaKho);
            this.Controls.Add(this.cryView1);
            this.Name = "frmThongKeKho";
            this.Size = new System.Drawing.Size(1311, 735);
            this.Load += new System.EventHandler(this.frmThongKeKho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryView1;
        private System.Windows.Forms.ComboBox cbxMaKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
