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
    public partial class frmPhieuYC : UserControl
    {
        public frmPhieuYC()
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

        private DBQLVT db = new DBQLVT();

        private void frmPhieuYC_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadData();
        }

        private void LoadCombobox()
        {
            SelectedCbx sel = new SelectedCbx();
            this.cbxSearchKho.DataSource = sel.GetCbxKhoVT(true);
            this.cbxSearchKho.DisplayMember = "DisplayMember";
            this.cbxSearchKho.ValueMember = "ValueMember";

            this.cbxSearchKhoYC.DataSource = sel.GetCbxKhoVT(true);
            this.cbxSearchKhoYC.DisplayMember = "DisplayMember";
            this.cbxSearchKhoYC.ValueMember = "ValueMember";
        }

        private void LoadData()
        {
            var index = 0;
            var model = from m in db.PhieuYCs.AsNoTracking()
                        join kvt in db.KhoVatTus on m.MaKhoXuat equals kvt.MaKhoVT
                        join kvt1 in db.KhoVatTus on m.MaKhoYC equals kvt1.MaKhoVT
                        select new
                        {
                            STT = index +1,
                            m.MaPhieuYC,
                            m.TenPhieu,
                            m.NgayLap,
                            m.NguoiLap,
                            m.NgayDuyet,
                            m.NguoiDuyet,
                            m.TrangThai,
                            m.MaKhoXuat,
                            m.MaKhoYC,
                            TenKhoXuat = kvt.TenKhoVT,
                            TenKhoYC = kvt1.TenKhoVT
                        };

            BindingSource bs = new BindingSource();
            bs.DataSource = model.ToList();
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var indexKhoYC = cbxSearchKhoYC.SelectedIndex;
            var indexKhoXuat = cbxSearchKho.SelectedIndex;
            var strMaKho = txtSearchMa.Text.Trim();
            var indexTT = cbxTrangThai.SelectedIndex;
            var index = 0;
            var model = from m in db.PhieuYCs.AsNoTracking()
                        join kvt in db.KhoVatTus on m.MaKhoXuat equals kvt.MaKhoVT
                        join kvt1 in db.KhoVatTus on m.MaKhoYC equals kvt1.MaKhoVT
                        where ((string.IsNullOrEmpty(strMaKho)? true: m.MaPhieuYC.Contains(strMaKho))
                        && (indexTT == 0 ? true : m.TrangThai == cbxTrangThai.Text)
                        && (indexKhoXuat == 0 ? true : m.MaKhoXuat == cbxSearchKho.SelectedValue.ToString())
                        && (indexKhoYC == 0 ? true : m.MaKhoYC == cbxSearchKhoYC.SelectedValue.ToString()))
                        select new
                        {
                            STT = index + 1,
                            m.MaPhieuYC,
                            m.TenPhieu,
                            m.NgayLap,
                            m.NguoiLap,
                            m.NgayDuyet,
                            m.NguoiDuyet,
                            m.TrangThai,
                            m.MaKhoXuat,
                            m.MaKhoYC,
                            TenKhoXuat = kvt.TenKhoVT,
                            TenKhoYC = kvt1.TenKhoVT
                        };

            BindingSource bs = new BindingSource();
            bs.DataSource = model.ToList();
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmPhieuYC_ThemMoi frm = new frmPhieuYC_ThemMoi();
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maphieuYC = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPhieuYC").ToString();
            if (string.IsNullOrEmpty(maphieuYC))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmPhieuYC_ThemMoi frm = new frmPhieuYC_ThemMoi(2, maphieuYC);
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhieuYC = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPhieuYC").ToString();
            if (string.IsNullOrEmpty(maPhieuYC))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần xóa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", CommonConstant.MESSAGE_INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //Duyet ban ghi
                var model = db.PhieuYCs.Find(maPhieuYC); ;
                db.PhieuYCs.Remove(model);
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

        private void btnDuyetPhieu_Click(object sender, EventArgs e)
        {
            string maPhieuYC = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPhieuYC").ToString();
            if (string.IsNullOrEmpty(maPhieuYC))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn duyệt phiếu kiểm tra này không?", CommonConstant.MESSAGE_INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //Duyet ban ghi
                var model = db.PhieuYCs.Find(maPhieuYC); ;
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

        private void btnDetails_Click(object sender, EventArgs e)
        {
            string maPhieuYC = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaPhieuYC").ToString();
            if (string.IsNullOrEmpty(maPhieuYC))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần xem!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StaticValue.MaPhieuYC = maPhieuYC;
        }
    }
}
