using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MaterialSkin;
using QuanLyTBVT.Common;

namespace QuanLyTBVT
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Home()
        {
            InitializeComponent();
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navBarControl.ActiveGroup = e.Item.Caption == "Employees" ? employeesNavBarGroup : customersNavBarGroup;
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.lblTitle.Caption = "Xin chào: " + StaticValue.UserLogin.TenNV;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMK frm = new frmDoiMK();
            this.Hide();
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            DanhMuc.frmDonVi frm = new DanhMuc.frmDonVi();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            DanhMuc.frmNhaCungCap frm = new DanhMuc.frmNhaCungCap();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            DanhMuc.frmLoaiVatTu frm = new DanhMuc.frmLoaiVatTu();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void btnShowVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            DanhMuc.frmVatTu frm = new DanhMuc.frmVatTu();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            DanhMuc.frmDonVi frm = new DanhMuc.frmDonVi();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            DanhMuc.frmNhanVien frm = new DanhMuc.frmNhanVien();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void btnShowPhieuKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            NhapXuat.frm_PhieuKT frm = new NhapXuat.frm_PhieuKT();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void btnShowCTPKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            NhapXuat.frmCTPKT frm = new NhapXuat.frmCTPKT();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void ofnavBar_Click(object sender, EventArgs e)
        {

        }
    }
}