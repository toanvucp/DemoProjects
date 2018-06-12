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
            NhapXuat.frmCTPKT frm = new NhapXuat.frmCTPKT();
            frm.btnShow.Click += delegate
            {
                Cursor.Current = Cursors.WaitCursor;
                customersNavigationPage.Controls.Clear();
                NhapXuat.frm_PhieuKT frm1 = new NhapXuat.frm_PhieuKT();
                customersNavigationPage.Controls.Add(frm1);
                navigationFrame.SelectedPageIndex = 1;
                navBarControl.ActiveGroup = customersNavBarGroup;
                Cursor.Current = Cursors.Default;
            };
            employeesNavigationPage.Controls.Add(frm);
        }
    }
}