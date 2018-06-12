using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTBVT.Model;
using QuanLyTBVT.Common;

namespace QuanLyTBVT.DanhMuc
{
    public partial class frmKhoVT : UserControl
    {
        public frmKhoVT()
        {
            InitializeComponent();
        }

        private DBQLVT db = new DBQLVT();

        private void frmKhoVT_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var index = 0;
            var model = (from m in db.KhoVatTus.AsNoTracking()
                         select new { STT = index + 1, m.MaKhoVT, m.TenKhoVT, m.GhiChu }).ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = model;
            grdData.DataSource = bs;
            bdsData.DataSource = bs;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var strSeachMa = txtSearchMa.Text.Trim();
            var strSearchName = txtSearchName.Text.Trim();
            var index = 0;
            var model = (from m in db.KhoVatTus.AsNoTracking()
                         where (string.IsNullOrEmpty(strSeachMa)? true: m.MaKhoVT.Contains(strSeachMa))
                         && (string.IsNullOrEmpty(strSearchName)? true: m.TenKhoVT.Contains(strSearchName))
                         select new { STT = index + 1, m.MaKhoVT, m.TenKhoVT, m.GhiChu }).ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = model;
            grdData.DataSource = bs;
            bdsData.DataSource = bs;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNCC = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaKhoVT").ToString();
            if (string.IsNullOrEmpty(maNCC))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                var model = db.KhoVatTus.Find(maNCC); ;
                db.KhoVatTus.Remove(model);
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmKhoVT_ThemMoi frm = new frmKhoVT_ThemMoi();
            frm.Closed += delegate
            {

                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLoaiVT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaKhoVT").ToString();
            if (string.IsNullOrEmpty(maLoaiVT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmKhoVT_ThemMoi frm = new frmKhoVT_ThemMoi(2, maLoaiVT);
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }
    }
}
