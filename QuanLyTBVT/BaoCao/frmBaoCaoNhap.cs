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
using CrystalDecisions.CrystalReports.Engine;

namespace QuanLyTBVT.BaoCao
{
    public partial class frmBaoCaoNhap : UserControl
    {
        public frmBaoCaoNhap()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private DBQLVT db = new DBQLVT();

        private void LoadComboBox()
        {
            SelectedCbx sel = new SelectedCbx();
            var model = sel.GetPhieuNhap(false);
            this.cbxPhieuNhap.DataSource = model;
            this.cbxPhieuNhap.DisplayMember = "DisplayMember";
            this.cbxPhieuNhap.ValueMember = "ValueMember";
            if (model != null && model.Count > 0)
            {
                this.cbxPhieuNhap.SelectedIndex = 0;
            }
        }

        private void LoadReportSource(string _MaKho)
        {
            //crtPhieuNhap cry = new crtPhieuNhap();
            var model = from m in db.ChiTietPhieuNhaps.AsEnumerable()
                        join vt in db.VatTus.AsEnumerable() on m.MaVT equals vt.MaVT
                        join pn in db.PhieuNhaps.AsEnumerable() on m.MaPhieuNhap equals pn.MaPhieuNhap
                        join ncc in db.NhaCungCaps.AsEnumerable() on vt.MaNCC equals ncc.MaNCC
                        join kho in db.KhoVatTus.AsEnumerable() on pn.MaKhoVT equals kho.MaKhoVT
                        where m.MaPhieuNhap.Equals(_MaKho)
                        select new
                        {
                            NgayDuyet = pn.NgayDuyet != null ? pn.NgayDuyet.Value.ToString("dd/MM/yyyy") : DateTime.Now.ToString("dd/MM/yyyy"),
                            TenKhoVT = kho.TenKhoVT,
                            LyDo = pn.NoiDung,
                            SerialNumber = m.SerialNumber,
                            TenVT = vt.TenVT,
                            NhaCC = ncc.TenNCC,
                            TrangThaiVT = m.TrangThai,
                            DVT = vt.DVT,
                            SoLuong = m.SoLuong,
                            DonGia = vt.DonGia != null ? vt.DonGia.Value.ToString("#") : ""
                        };
            ReportDocument StockObjectsReport = new crtPhieuNhap();
            StockObjectsReport.SetDataSource(model.ToList());
            cryView1.ReportSource = StockObjectsReport;
            cryView1.RefreshReport();
        }

        private void cbxPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportSource(this.cbxPhieuNhap.SelectedValue.ToString());
        }

        private void frmBaoCaoNhap_Load(object sender, EventArgs e)
        {
            LoadReportSource(this.cbxPhieuNhap.SelectedValue.ToString());
        }
    }
}
