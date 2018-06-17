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

namespace QuanLyTBVT.NhapXuat
{
    public partial class frmPhieuXuat : UserControl
    {
        private DBQLVT db = new DBQLVT();
        public frmPhieuXuat()
        {
            InitializeComponent();
            SetStatusButton(false);
            this.cbxTrangThai.SelectedIndex = 0;
            btnDuyetPhieu.Visible = CommonConstant.ISSHOWBTNDUYET;
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

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            int index = 0;
            var modelLoad = from m in db.PhieuXuats.AsNoTracking()
                            join kvt in db.KhoVatTus on m.MaKhoXuat equals kvt.MaKhoVT
                            join kvt1 in db.KhoVatTus on m.MaKhoNhap equals kvt1.MaKhoVT
                            select (new
                            {
                                STT = index + 1,
                                m.MaPX,
                                m.MaKhoXuat,
                                m.MaKhoNhap,
                                m.NguoiDuyet,
                                m.NgayDuyet,
                                m.NguoiLap,
                                m.NgayLap,
                                m.TrangThai,
                                m.PhieuYC,
                                m.NoiDung,
                                TenKhoXuat = kvt.TenKhoVT,
                                TenKhoYC = kvt1.TenKhoVT
                            });
            BindingSource bs = new BindingSource();
            bs.DataSource = modelLoad.ToList();
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
            SetStatusButton(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maPhieu = txtSearchMa.Text.Trim();
            var index = 0;
            int vintstt = cbxTrangThai.SelectedIndex;
            string strTrangThai = cbxTrangThai.Text;
            var modelLoad = from m in db.PhieuXuats.AsNoTracking()
                            join kvt in db.KhoVatTus on m.MaKhoXuat equals kvt.MaKhoVT
                            join kvt1 in db.KhoVatTus on m.MaKhoNhap equals kvt1.MaKhoVT
                            where (string.IsNullOrEmpty(maPhieu) ? true : m.MaPX.Contains(maPhieu))
                                && (vintstt == 0 ? true : m.TrangThai == strTrangThai)
                            select (new
                            {
                                STT = index + 1,
                                m.MaPX,
                                m.MaKhoXuat,
                                m.MaKhoNhap,
                                m.NguoiDuyet,
                                m.NgayDuyet,
                                m.NguoiLap,
                                m.NgayLap,
                                m.TrangThai,
                                m.PhieuYC,
                                m.NoiDung,
                                TenKhoXuat = kvt.TenKhoVT,
                                TenKhoYC = kvt1.TenKhoVT
                            });
            BindingSource bs = new BindingSource();
            bs.DataSource = modelLoad.ToList();
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
            SetStatusButton(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhieuXuat = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPX").ToString();
            if (string.IsNullOrEmpty(maPhieuXuat))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần xóa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", CommonConstant.MESSAGE_INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //Duyet ban ghi
                var model = db.PhieuXuats.Find(maPhieuXuat); ;
                db.PhieuXuats.Remove(model);
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

        private void btnDetails_Click(object sender, EventArgs e)
        {
            string maPX = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPX").ToString();
            if (string.IsNullOrEmpty(maPX))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần xem!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StaticValue.MaPhieuXuat = maPX;
        }

        private void btnDuyetPhieu_Click(object sender, EventArgs e)
        {
            string maPX = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPX").ToString();
            if (string.IsNullOrEmpty(maPX))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn duyệt phiếu kiểm tra này không?", CommonConstant.MESSAGE_INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //Duyet ban ghi
                var model = db.PhieuXuats.Find(maPX); ;
                model.TrangThai = CommonConstant.STATUS_DADUYET;
                model.NgayDuyet = DateTime.Now;
                model.NguoiDuyet = StaticValue.UserLogin.Email.Split('@')[0];

                //Chuyen trang thai trong bang kho
                CreatePhieuKT(model);
                //End

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

        /// <summary>
        /// Chuyen trang thai thiet bi trong kho sang trang thai "2"
        /// </summary>
        private void CreatePhieuKT(PhieuXuat px)
        {
            //Get All Chi tiet phieu xuat
            var model = db.ChiTietPhieuXuats.Where(m => m.MaPX == px.MaPX).ToList();
            //Update kho nhung chi tiet phieu xuat
            var models = (from m in db.ChiTietKhoVatTus
                          join n in model
 on m.SerialNumber equals n.SerialNumber
                          where m.MaKhoVT == px.MaKhoXuat
                          select m).ToList();
            models.ForEach(a => { a.TrangThai = CommonConstant.STATUS_CHITIETKHO_DANGXUAT; a.MaKhoVT = px.MaKhoNhap; });
            //db.SaveChanges();

        }

        private string GenerateID()
        {
            string result = "";
            var model = db.PhieuKTs.OrderByDescending(m => m.MaPhieuKT.Replace("PKT", "")).Select(m => m.MaPhieuKT.Replace("PKT", "")).FirstOrDefault();
            if (model != null)
            {
                result = "PKT" + (int.Parse(model) + 1).ToString("D5");
            }
            else
            {
                result = "PKT" + 1.ToString("D5");
            }
            return result;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmPhieuXuat_ThemMoi frm = new frmPhieuXuat_ThemMoi();
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPX = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPX").ToString();
            if (string.IsNullOrEmpty(maPX))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmPhieuXuat_ThemMoi frm = new frmPhieuXuat_ThemMoi(2, maPX);
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }
    }
}
