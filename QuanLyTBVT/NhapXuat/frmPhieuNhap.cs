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
    public partial class frmPhieuNhap : UserControl
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
            this.cbxTrangThai.SelectedIndex = 0;
            SetStatusButton(false);
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

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
        }

        private DBQLVT db = new DBQLVT();

        private void LoadData()
        {
            var index = 0;
            var model = from m in db.PhieuNhaps.AsNoTracking()
                        join ncc in db.NhaCungCaps on m.MaNCC equals ncc.MaNCC
                        join kvt in db.KhoVatTus on m.MaKhoVT equals kvt.MaKhoVT
                        select new
                        {
                            STT = index + 1,
                            m.MaPhieuNhap,
                            m.MaNCC,
                            m.MaKhoVT,
                            m.NgayLap,
                            m.NguoiLap,
                            m.NgayDuyet,
                            m.NguoiDuyet,
                            m.NoiDung,
                            m.TrangThai,
                            ncc.TenNCC,
                            kvt.TenKhoVT
                        };
            BindingSource bs = new BindingSource();
            bs.DataSource = model.ToList();
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
        }

        private void LoadComboBox()
        {
            SelectedCbx sel = new SelectedCbx();
            this.cbxSearchKho.DataSource = sel.GetCbxKhoVT(true);
            this.cbxSearchKho.DisplayMember = "DisplayMember";
            this.cbxSearchKho.ValueMember = "ValueMember";
        }

        private void grvData_Click(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maPhieu = txtSearchMa.Text.Trim();
            int vintstt = cbxTrangThai.SelectedIndex;
            int vintKho = cbxSearchKho.SelectedIndex;
            string strTrangThai = cbxTrangThai.Text;
            var index = 0;
            var model = from m in db.PhieuNhaps.AsNoTracking()
                        join ncc in db.NhaCungCaps on m.MaNCC equals ncc.MaNCC
                        join kvt in db.KhoVatTus on m.MaKhoVT equals kvt.MaKhoVT
                        where (string.IsNullOrEmpty(maPhieu) ? true : m.MaPhieuNhap.Contains(maPhieu))
                && (vintstt == 0 ? true : m.TrangThai == strTrangThai)
                && (vintKho == 0 ? true : m.MaKhoVT == cbxSearchKho.SelectedValue.ToString())
                        select new
                        {
                            STT = index + 1,
                            m.MaPhieuNhap,
                            m.MaNCC,
                            m.MaKhoVT,
                            m.NgayLap,
                            m.NguoiLap,
                            m.NgayDuyet,
                            m.NguoiDuyet,
                            m.NoiDung,
                            m.TrangThai,
                            ncc.TenNCC,
                            kvt.TenKhoVT
                        };
            BindingSource bs = new BindingSource();
            bs.DataSource = model.ToList();
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
            SetStatusButton(false);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            string maPhieuKT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPhieuNhap").ToString();
            if (string.IsNullOrEmpty(maPhieuKT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần xem!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StaticValue.MaPhieuNhap = maPhieuKT;
        }

        private void btnDuyetPhieu_Click(object sender, EventArgs e)
        {
            string maVT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPhieuNhap").ToString();
            if (string.IsNullOrEmpty(maVT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn duyệt phiếu nhập này không?", CommonConstant.MESSAGE_INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //Duyet ban ghi
                var model = db.PhieuNhaps.Find(maVT); ;
                model.TrangThai = CommonConstant.STATUS_DADUYET;
                model.NgayDuyet = DateTime.Now;
                model.NguoiDuyet = StaticValue.UserLogin.Email.Split('@')[0];
                //Chuyen du lieu vao trong ChiTietKho
                InsertVaoKho(maVT, model.MaKhoVT);
                //End
                //update trang thai phieu KT
                UpdateStatusPKT(model.MaPhieuKT);
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

        private void InsertVaoKho(string _MaPhieuNhap, string maKho)
        {
            var model = from m in db.ChiTietPhieuNhaps where m.MaPhieuNhap.Equals(_MaPhieuNhap) select m;

            //var models = from m in db.ChiTietKhoVatTus where m.MaKhoVT == maKho && m.TrangThai == "2" select m;

            var KhoAdd = new List<ChiTietKhoVatTu>();
            if (model != null && model.ToList().Count > 0)
            {
                foreach (var item in model.ToList())
                {
                    ChiTietKhoVatTu kho = new ChiTietKhoVatTu();
                    kho.MaKhoVT = maKho;
                    kho.MaVT = item.MaVT;
                    kho.SoLuong = item.SoLuong;
                    kho.TinhTrangVT = item.TrangThai;
                    kho.TrangThai = CommonConstant.STATUS_CHITIETKHO_MOI;
                    kho.SerialNumber = item.SerialNumber;
                    //kho.
                    KhoAdd.Add(kho);
                }
            }
            db.ChiTietKhoVatTus.AddRange(KhoAdd);
        }

        private void UpdateStatusPKT(string maphieuKT)
        {
            var model = db.PhieuKTs.Find(maphieuKT);
            if (model != null)
            {
                model.TrangThai = CommonConstant.STATUS_DANHAP;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmPhieuNhap_ThemMoi frm = new frmPhieuNhap_ThemMoi();
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhieuKT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPhieuNhap").ToString();
            if (string.IsNullOrEmpty(maPhieuKT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmPhieuNhap_ThemMoi frm = new frmPhieuNhap_ThemMoi(2, maPhieuKT);
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maphieuKT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPhieuNhap").ToString();
            if (string.IsNullOrEmpty(maphieuKT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần xóa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", CommonConstant.MESSAGE_INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //Duyet ban ghi
                var model = db.PhieuNhaps.Find(maphieuKT); ;
                db.PhieuNhaps.Remove(model);
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
