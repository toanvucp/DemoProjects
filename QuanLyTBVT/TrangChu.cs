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
using QuanLyTBVT.Common;
using QuanLyTBVT.Model;

namespace QuanLyTBVT
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TrangChu()
        {
            InitializeComponent();
            PhanQuyen();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2016 Colorful";
            navigationFrame.TransitionAnimationProperties.FrameInterval = 1000;
            employeesNavigationPage.AutoScroll = true;
            customersNavigationPage.AutoScroll = true;
        }



        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navBarControl.ActiveGroup = e.Item.Caption == "Employees" ? employeesNavBarGroup : customersNavBarGroup;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            DanhMuc.frmKhoVT frm = new DanhMuc.frmKhoVT();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void btnShowPhieuKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            NhapXuat.frm_PhieuKT frm = new NhapXuat.frm_PhieuKT();
            frm.btnDetails.Click += delegate
            {
                Cursor.Current = Cursors.WaitCursor;
                customersNavigationPage.Controls.Clear();
                NhapXuat.frmCTPKT frm1 = new NhapXuat.frmCTPKT();
                customersNavigationPage.Controls.Add(frm1);
                navigationFrame.SelectedPageIndex = 1;
                navBarControl.ActiveGroup = customersNavBarGroup;
                Cursor.Current = Cursors.Default;
            };
            employeesNavigationPage.Controls.Add(frm);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(StaticValue.MaPhieuKT))
            {
                MessageBox.Show("Vui lòng chọn phiếu kiểm tra để có thể thực hiện được chức năng này!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //show 
            Cursor.Current = Cursors.WaitCursor;
            customersNavigationPage.Controls.Clear();
            NhapXuat.frmCTPKT frm1 = new NhapXuat.frmCTPKT();
            customersNavigationPage.Controls.Add(frm1);
            navigationFrame.SelectedPageIndex = 1;
            navBarControl.ActiveGroup = customersNavBarGroup;
            Cursor.Current = Cursors.Default;
        }

        private void TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnShowPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            NhapXuat.frmPhieuNhap frm = new NhapXuat.frmPhieuNhap();
            frm.btnDetails.Click += delegate
            {
                Cursor.Current = Cursors.WaitCursor;
                customersNavigationPage.Controls.Clear();
                NhapXuat.frmChiTietPhieuNhap frm1 = new NhapXuat.frmChiTietPhieuNhap();
                customersNavigationPage.Controls.Add(frm1);
                navigationFrame.SelectedPageIndex = 1;
                navBarControl.ActiveGroup = customersNavBarGroup;
                Cursor.Current = Cursors.Default;
            };
            employeesNavigationPage.Controls.Add(frm);
        }

        private void btnShowCTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(StaticValue.MaPhieuNhap))
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để có thể thực hiện được chức năng này!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //show 
            Cursor.Current = Cursors.WaitCursor;
            customersNavigationPage.Controls.Clear();
            NhapXuat.frmChiTietPhieuNhap frm1 = new NhapXuat.frmChiTietPhieuNhap();
            customersNavigationPage.Controls.Add(frm1);
            navigationFrame.SelectedPageIndex = 1;
            navBarControl.ActiveGroup = customersNavBarGroup;
            Cursor.Current = Cursors.Default;
        }

        private void btnShowMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMK frm = new frmDoiMK();
            frm.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            this.txtBarName.Caption = "Xin chào: " + StaticValue.UserLogin.TenNV;
        }

        private void btnShowLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            StaticValue.UserLogin = new NhanVien();
            this.Hide();
            frm.Show();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnShowPXTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            DanhMuc.frmDonVi frm = new DanhMuc.frmDonVi();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void btnShowNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            DanhMuc.frmNhanVien frm = new DanhMuc.frmNhanVien();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            DanhMuc.frmNhaCungCap frm = new DanhMuc.frmNhaCungCap();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void btnShowLoaiVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            DanhMuc.frmLoaiVatTu frm = new DanhMuc.frmLoaiVatTu();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void btnShowVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            DanhMuc.frmVatTu frm = new DanhMuc.frmVatTu();
            employeesNavigationPage.Controls.Add(frm);
        }

        private void btnShowPhieuYC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            NhapXuat.frmPhieuYC frm = new NhapXuat.frmPhieuYC();
            frm.btnDetails.Click += delegate
            {
                Cursor.Current = Cursors.WaitCursor;
                customersNavigationPage.Controls.Clear();
                NhapXuat.frmChiTietPYC frm1 = new NhapXuat.frmChiTietPYC();
                customersNavigationPage.Controls.Add(frm1);
                navigationFrame.SelectedPageIndex = 1;
                navBarControl.ActiveGroup = customersNavBarGroup;
                Cursor.Current = Cursors.Default;
            };
            employeesNavigationPage.Controls.Add(frm);
        }
    

        private void btnShowCTPYC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(StaticValue.MaPhieuYC))
            {
                MessageBox.Show("Vui lòng chọn phiếu yêu cầu để có thể thực hiện được chức năng này!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //show 
            Cursor.Current = Cursors.WaitCursor;
            customersNavigationPage.Controls.Clear();
            NhapXuat.frmChiTietPYC frm1 = new NhapXuat.frmChiTietPYC();
            customersNavigationPage.Controls.Add(frm1);
            navigationFrame.SelectedPageIndex = 1;
            navBarControl.ActiveGroup = customersNavBarGroup;
            Cursor.Current = Cursors.Default;
        }

        private void btnShowPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeesNavigationPage.Controls.Clear();
            NhapXuat.frmPhieuXuat frm = new NhapXuat.frmPhieuXuat();
            frm.btnDetails.Click += delegate
            {
                Cursor.Current = Cursors.WaitCursor;
                customersNavigationPage.Controls.Clear();
                NhapXuat.frmChiTietPhieuXuat frm1 = new NhapXuat.frmChiTietPhieuXuat();
                customersNavigationPage.Controls.Add(frm1);
                navigationFrame.SelectedPageIndex = 1;
                navBarControl.ActiveGroup = customersNavBarGroup;
                Cursor.Current = Cursors.Default;
            };
            employeesNavigationPage.Controls.Add(frm);
        }

        private void btnShowCTPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(StaticValue.MaPhieuXuat))
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất để có thể thực hiện được chức năng này!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //show 
            Cursor.Current = Cursors.WaitCursor;
            customersNavigationPage.Controls.Clear();
            NhapXuat.frmChiTietPhieuXuat frm1 = new NhapXuat.frmChiTietPhieuXuat();
            customersNavigationPage.Controls.Add(frm1);
            navigationFrame.SelectedPageIndex = 1;
            navBarControl.ActiveGroup = customersNavBarGroup;
            Cursor.Current = Cursors.Default;
        }
//        Administrator
//Nhân viên nhập dữ liệu
//Nhân viên duyệt phiếu
        private void PhanQuyen()
        {
            if (StaticValue.UserLogin != null)
            {
                switch (StaticValue.UserLogin.RoleID)
                {
                    case "Nhân viên nhập dữ liệu":
                        btnShowKhoVT.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btnShowPXTD.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btnShowNV.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                        break;
                    case "Nhân viên duyệt phiếu":
                        btnShowKhoVT.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btnShowPXTD.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btnShowNV.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}