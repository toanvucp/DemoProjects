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

namespace QuanLyTBVT.BaoCao
{
    public partial class frmBaoCaoXuat : UserControl
    {
        public frmBaoCaoXuat()
        {
            InitializeComponent();
            LoadComboBox();

        }

        private DBQLVT db = new DBQLVT();

        private void LoadComboBox()
        {
            SelectedCbx sel = new SelectedCbx();
            var model = sel.GetPhieuXuat(false);
            this.cbxPhieuXuat.DataSource = model;
            this.cbxPhieuXuat.DisplayMember = "DisplayMember";
            this.cbxPhieuXuat.ValueMember = "ValueMember";
            if (model != null && model.Count > 0)
            {
                this.cbxPhieuXuat.SelectedIndex = 0;
            }

        }

        private void LoadReportSource(string _MaKho)
        {
            crtPhieuXuat cry = new crtPhieuXuat();
            var model = from m in db.ChiTietPhieuXuats
                        join vt in db.VatTus on m.MaVT equals vt.MaVT
                        join pn in db.PhieuXuats on m.MaPX equals pn.MaPX
                        join ncc in db.NhaCungCaps on vt.MaNCC equals ncc.MaNCC
                        join kho in db.KhoVatTus on pn.MaKhoXuat equals kho.MaKhoVT
                        where m.MaPX.Equals(_MaKho)
                        select new
                        {
                            NgayDuyet = pn.NgayDuyet != null ? pn.NgayDuyet.Value.ToString("dd/MM/yyyy") : DateTime.Now.ToString("dd/MM/yyyy"),
                            TenKhoVT = kho.TenKhoVT,
                            LyDo = pn.NoiDung,
                            SerialNumber = m.SerialNumber,
                            TenVT = vt.TenVT,
                            NhaCC = ncc.TenNCC,
                            TrangThaiVT = m.TrangThaiVT,
                            DVT = vt.DVT,
                            SoLuong = m.SoLuong,
                            DonGia = vt.DonGia != null ? vt.DonGia.Value : 0
                        };
            cry.SetDataSource(model.ToList());
            cryView1.ReportSource = cry;
            cryView1.RefreshReport();
        }

        private void cbxPhieuXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportSource(this.cbxPhieuXuat.SelectedValue.ToString());
        }

        private void frmBaoCaoXuat_Load(object sender, EventArgs e)
        {
            LoadReportSource(this.cbxPhieuXuat.SelectedValue.ToString());
        }
    }
}
