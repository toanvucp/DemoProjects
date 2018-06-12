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

namespace QuanLyTBVT
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TrangChu()
        {
            InitializeComponent();

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

        }
    }
}