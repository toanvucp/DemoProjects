using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using QuanLyTBVT.Model;
using DevExpress.XtraTreeList;
using QuanLyTBVT.Common;
using System.Data.SqlClient;

namespace QuanLyTBVT.DanhMuc
{
    public partial class frmDonVi : DevExpress.XtraEditors.XtraUserControl
    {
        public frmDonVi()
        {
            InitializeComponent();
            SelectedCbx sel = new SelectedCbx();
        }

        private void tlstData_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
          
        }

        private DBQLVT db = new DBQLVT();

        private void frmDonVi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var model = db.PXTDs.AsNoTracking().ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = model;
            bdsData.DataSource = bs;
            tlstData.DataSource = bs;
            tlstData.KeyFieldName = "MaPXTD";
            tlstData.ParentFieldName = "ParentID";
            tlstData.RootValue = DBNull.Value;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            TreeListMultiSelection selectedNodes = tlstData.Selection;
            MessageBox.Show(selectedNodes[0].GetValue(tlstData.Columns[0]).ToString());
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmDonVi_ThemMoi frm = new frmDonVi_ThemMoi();
            frm.Closed += delegate
            {

                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            object keyValue = tlstData.FocusedNode[tlstData.KeyFieldName];
            //TreeListMultiSelection selectedNodes = tlstData.Selection;
            //MessageBox.Show(selectedNodes[0].GetValue(tlstData.Columns[0]).ToString(), keyValue.ToString());
            string maLoaiVT = keyValue.ToString();
            if (string.IsNullOrEmpty(maLoaiVT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmDonVi_ThemMoi frm = new frmDonVi_ThemMoi(2, maLoaiVT);
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            object keyValue = tlstData.FocusedNode[tlstData.KeyFieldName];
            string maNCC = keyValue.ToString();
            if (string.IsNullOrEmpty(maNCC))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SelectedCbx sel = new SelectedCbx();
                //kiem tra xem co don vi con khong
                if (sel.CheckChildExist(maNCC))
                {
                    MessageBox.Show("Đơn vị đã tồn tại đơn vị con. Vui lòng xóa các đơn vị con của đơn vị này!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var model = db.PXTDs.Find(maNCC); ;
                db.PXTDs.Remove(model);
                int record = db.SaveChanges();
                if (record > 0)
                {
                    MessageBox.Show("Xóa bản ghi thành công.", CommonConstant.MESSAGE_INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Format("Xảy ra lỗi, vui lòng kiểm tra lại!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
        }

        
    }

}
