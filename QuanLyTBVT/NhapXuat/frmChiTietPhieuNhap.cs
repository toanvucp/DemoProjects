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
    public partial class frmChiTietPhieuNhap : UserControl
    {
        private DBQLVT db = new DBQLVT();
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadComboBoxVT();
            LoadData();
        }

        private void LoadComboBoxVT()
        {
            SelectedCbx sel = new SelectedCbx();
            this.cbxTrangThai.DataSource = sel.GetCbxVatTu(true);
            this.cbxTrangThai.DisplayMember = "DisplayMember";
            this.cbxTrangThai.ValueMember = "ValueMember";
        }

        private void LoadData()
        {
            var index = 0;
            var model = from m in db.ChiTietPhieuNhaps.AsNoTracking()
                        join vt in db.VatTus
                        on m.MaVT equals vt.MaVT
                        where m.MaPhieuNhap.Equals(StaticValue.MaPhieuNhap)
                        select new
                        {
                            m.SerialNumber,
                            m.MaVT,
                            m.MoTa,
                            m.TrangThai,
                            m.SoLuong,
                            STT = index + 1,
                            m.MaCTPN,
                            m.MaPhieuNhap,
                            vt.TenVT,
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
            var model = from m in db.ChiTietPhieuNhaps.AsNoTracking()
                        join vt in db.VatTus
                        on m.MaVT equals vt.MaVT
                        where m.MaPhieuNhap.Equals(StaticValue.MaPhieuNhap)
                        && (string.IsNullOrEmpty(maPhieu) ? true : m.SerialNumber.Contains(maPhieu))
                        && (vintstt == 0 ? true : m.MaVT == cbxTrangThai.SelectedValue.ToString())
                        select new
                        {
                            m.SerialNumber,
                            m.MaVT,
                            m.MoTa,
                            m.TrangThai,
                            m.SoLuong,
                            STT = index + 1,
                            m.MaCTPN,
                            m.MaPhieuNhap,
                            vt.TenVT,
                        };
            BindingSource bs = new BindingSource();
            bs.DataSource = model.ToList();
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
        }
    }
}
