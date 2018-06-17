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
using DevExpress.XtraGrid.Views.Grid;
using QuanLyTBVT.Common;

namespace QuanLyTBVT.NhapXuat
{
    public partial class frm_PhieuKT : UserControl
    {
        private DBQLVT db = new DBQLVT();
        public frm_PhieuKT()
        {
            InitializeComponent();
            SetStatusButton(false);
            this.cbxTrangThai.SelectedIndex = 0;
            btnDuyetPhieu.Visible = CommonConstant.ISSHOWBTNDUYET;
        }

        private void frm_PhieuKT_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            int index = 0;
            var modelLoad = from m in db.PhieuKTs.AsNoTracking()
                            select (new
                            {
                                STT = index + 1,
                                m.MaPhieuKT,
                                m.NgayDuyet,
                                m.NgayLap,
                                m.NguoiDuyet,
                                m.NguoiLap,
                                m.NguoiThamGia,
                                m.TrangThai
                            });
            BindingSource bs = new BindingSource();
            bs.DataSource = modelLoad.ToList();
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
            SetStatusButton(false);
        }

        private void SetStatusButton(bool flag)
        {
            this.btnDuyetPhieu.Enabled = flag;
            this.btnSua.Enabled = flag;
            this.btnXoa.Enabled = flag;
            if (flag)
            {
                this.btnSua.BackColor = Color.FromArgb(92, 184, 92);
                this.btnDuyetPhieu.BackColor = Color.OrangeRed;
                this.btnXoa.BackColor = Color.FromArgb(217, 83, 79);
            }
            else
            {
                this.btnXoa.BackColor = Color.LightGray;
                this.btnSua.BackColor = Color.LightGray;
                this.btnDuyetPhieu.BackColor = Color.LightGray;
            }
        }

        private void grvData_RowClick(object sender, RowClickEventArgs e)
        {
            if (grvData.DataRowCount > 0)
            {
                if (grvData.GetRowCellValue(grvData.FocusedRowHandle, "TrangThai") != null)
                {
                    string status = grvData.GetRowCellValue(grvData.FocusedRowHandle, "TrangThai").ToString();
                    //TrangThai = moi hien thi button
                    SetStatusButton(status.Equals(CommonConstant.STATUS_MOI));
                }
            }
        }

        private void btnDuyetPhieu_Click(object sender, EventArgs e)
        {
            string maVT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPhieuKT").ToString();
            if (string.IsNullOrEmpty(maVT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn duyệt phiếu kiểm tra này không?", CommonConstant.MESSAGE_INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //Duyet ban ghi
                var model = db.PhieuKTs.Find(maVT); ;
                model.TrangThai = CommonConstant.STATUS_DADUYET;
                model.NgayDuyet = DateTime.Now;
                model.NguoiDuyet = StaticValue.UserLogin.Email.Split('@')[0];
                int record = db.SaveChanges();
                if (record > 0)
                {
                    MessageBox.Show("Duyệt phiếu thành công.", CommonConstant.MESSAGE_INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Format("Xảy ra lỗi, vui lòng kiểm tra lại!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maPhieu = txtSearchMa.Text.Trim();
            var index = 0;
            int vintstt = cbxTrangThai.SelectedIndex;
            string strTrangThai = cbxTrangThai.Text;
            var modelLoad = from m in db.PhieuKTs.AsNoTracking()
                            where (string.IsNullOrEmpty(maPhieu) ? true : m.MaPhieuKT.Contains(maPhieu))
                                && (vintstt == 0 ? true : m.TrangThai == strTrangThai)
                            select new
                            {
                                STT = index + 1,
                                m.MaPhieuKT,
                                m.NgayDuyet,
                                m.NgayLap,
                                m.NguoiDuyet,
                                m.NguoiLap,
                                m.NguoiThamGia,
                                m.TrangThai
                            };

            BindingSource bs = new BindingSource();
            bs.DataSource = modelLoad.ToList();
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
            SetStatusButton(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maphieuKT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPhieuKT").ToString();
            if (string.IsNullOrEmpty(maphieuKT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần xóa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", CommonConstant.MESSAGE_INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //Duyet ban ghi
                var model = db.PhieuKTs.Find(maphieuKT); ;
                db.PhieuKTs.Remove(model);
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
            frmPhieuKT_ThemMoi frm = new frmPhieuKT_ThemMoi();
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhieuKT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPhieuKT").ToString();
            if (string.IsNullOrEmpty(maPhieuKT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmPhieuKT_ThemMoi frm = new frmPhieuKT_ThemMoi(2, maPhieuKT);
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            string maPhieuKT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPhieuKT").ToString();
            if (string.IsNullOrEmpty(maPhieuKT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần xem!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StaticValue.MaPhieuKT = maPhieuKT;
        }
    }
}
