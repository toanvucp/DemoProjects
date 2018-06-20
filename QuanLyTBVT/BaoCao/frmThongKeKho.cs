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
using System.Data.SqlClient;
using System.Configuration;
using QuanLyTBVT.Common;

namespace QuanLyTBVT.BaoCao
{
    public partial class frmThongKeKho : UserControl
    {
        public frmThongKeKho()
        {
            InitializeComponent();
            //crtTrangThaiThietBiKho cry = new crtTrangThaiThietBiKho();
            LoadComboBox();
        }
        private DBQLVT db = new DBQLVT();

        private void LoadComboBox()
        {
            SelectedCbx sel = new SelectedCbx();
            this.cbxMaKho.DataSource = sel.GetCbxKhoVT(false);
            this.cbxMaKho.DisplayMember = "DisplayMember";
            this.cbxMaKho.ValueMember = "ValueMember";
            this.cbxMaKho.SelectedIndex = 0;
        }

        private void LoadReportSource(string _MaKho)
        {
            crtTrangThaiThietBiKho cry = new crtTrangThaiThietBiKho();
            var model = (from m in db.ChiTietKhoVatTus
                         join n in db.KhoVatTus on
                        m.MaKhoVT equals n.MaKhoVT
                         join vt in db.VatTus on m.MaVT equals vt.MaVT
                         where m.MaKhoVT == _MaKho
                         select new
                         {
                             m.MaKhoVT,
                             m.SerialNumber,
                             m.SoLuong,
                             m.TinhTrangVT,
                             m.TrangThai,
                             n.TenKhoVT,
                             MaVT = vt.TenVT

                         }).ToList();
            var totalsum = db.ChiTietKhoVatTus.Where(m => m.MaKhoVT == _MaKho).GroupBy(a => new { a.MaVT, a.TinhTrangVT }).Select(p => new { MaVT = p.Key.MaVT, p.Key.TinhTrangVT, SoLuong = p.Sum(q => q.SoLuong) });
            var modelSub = (from m in totalsum
                            join n in db.VatTus on m.MaVT equals n.MaVT
                            select (new { MaVT = n.TenVT, m.TinhTrangVT, m.SoLuong })).ToList();
            cry.SetDataSource(model);
            cry.Subreports[0].SetDataSource(modelSub); ;

            cryView1.ReportSource = cry;
            cryView1.RefreshReport();
        }


        private void frmThongKeKho_Load(object sender, EventArgs e)
        {


        }

        private void cbxMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportSource(this.cbxMaKho.SelectedValue.ToString());
        }
    }
}
