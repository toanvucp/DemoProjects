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
    public partial class frmCTPKT : UserControl
    {
        private DBQLVT db = new DBQLVT();
        public frmCTPKT()
        {
            InitializeComponent();
        }

        private void frmCTPKT_Load(object sender, EventArgs e)
        {
            LoadComboBoxVT();
            LoadData();
            EnableButton();
        }

        private void LoadComboBoxVT()
        {
            SelectedCbx sel = new SelectedCbx();
            this.cbxTrangThai.DataSource = sel.GetCbxVatTu(true);
            this.cbxTrangThai.DisplayMember = "DisplayMember";
            this.cbxTrangThai.ValueMember = "ValueMember";
        }


        private void EnableButton()
        {
            var model = db.PhieuKTs.Find(StaticValue.MaPhieuKT);
            var boold = model.TrangThai.Equals("Mới");
            this.btnSua.Enabled = boold;
            this.btnXoa.Enabled = boold;
            this.btnThemMoi.Enabled = boold;

        }
        //public string MaPhieuKT { get; set; }


        private void LoadData()
        {
            var index = 0;
            var model = from m in db.ChiTietPhieuKTs.AsNoTracking()
                        join vt in db.VatTus
                        on m.MaVT equals vt.MaVT
                        where m.MaPhieuKT.Equals(StaticValue.MaPhieuKT)
                        select new
                        {
                            m.SerialNumber,
                            m.MaPhieuKT,
                            m.MaVT,
                            m.MoTa,
                            m.PTKT,
                            m.SoLuong,
                            TrangThaiKT = m.TrangThaiKT == 0 ? "Không Đạt" : (m.TrangThaiKT == 1 ? "Đạt" : ""),
                            STT = index + 1,
                            m.MaCTKT,
                            vt.TenVT,
                            m.TrangThaiVT
                        };
            BindingSource bs = new BindingSource();
            bs.DataSource = model.ToList();
            grdData.DataSource = bs;
            bdsData.DataSource = bs;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maPhieu = txtSearchMa.Text.Trim();
            int vintstt = cbxTrangThai.SelectedIndex;
            var index = 0;
            var model = from m in db.ChiTietPhieuKTs.AsNoTracking()
                        join vt in db.VatTus
                        on m.MaVT equals vt.MaVT
                        where m.MaPhieuKT.Equals(StaticValue.MaPhieuKT)
                        && (string.IsNullOrEmpty(maPhieu) ? true : m.SerialNumber.Contains(maPhieu))
                        && (vintstt == 0 ? true : m.MaVT == cbxTrangThai.SelectedValue.ToString())
                        select new
                        {
                            m.SerialNumber,
                            m.MaPhieuKT,
                            m.MaVT,
                            m.MoTa,
                            m.PTKT,
                            m.SoLuong,
                            TrangThaiKT = m.TrangThaiKT == 0 ? "Không Đạt" : (m.TrangThaiKT == 1 ? "Đạt" : ""),
                            STT = index + 1,
                            m.MaCTKT,
                            vt.TenVT,
                            m.TrangThaiVT
                        };
            BindingSource bs = new BindingSource();
            bs.DataSource = model.ToList();
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmCTPKT_ThemMoi frm = new frmCTPKT_ThemMoi();
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maphieuKT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaCTKT").ToString();
            if (string.IsNullOrEmpty(maphieuKT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần xóa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", CommonConstant.MESSAGE_INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //Duyet ban ghi
                var model = db.ChiTietPhieuKTs.Find(maphieuKT); ;
                db.ChiTietPhieuKTs.Remove(model);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhieuKT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaCTKT").ToString();
            if (string.IsNullOrEmpty(maPhieuKT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmCTPKT_ThemMoi frm = new frmCTPKT_ThemMoi(2, maPhieuKT);
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }
    }
}
