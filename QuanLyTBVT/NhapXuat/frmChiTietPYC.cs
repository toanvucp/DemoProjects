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
    public partial class frmChiTietPYC : UserControl
    {
        private DBQLVT db = new DBQLVT();
        public frmChiTietPYC()
        {
            InitializeComponent();
        }

        private void frmChiTietPYC_Load(object sender, EventArgs e)
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
            var model = db.PhieuYCs.Find(StaticValue.MaPhieuYC);
            var boold = model.TrangThai.Equals("Mới");
            this.btnSua.Enabled = boold;
            this.btnXoa.Enabled = boold;
            this.btnThemMoi.Enabled = boold;

        }

        private void LoadData()
        {
            var index = 0;
            var model = from m in db.ChiTietPhieuYCs.AsNoTracking()
                        join vt in db.VatTus
                        on m.MaVT equals vt.MaVT
                        where m.MaPhieuYC.Equals(StaticValue.MaPhieuYC)
                        select new
                        {

                            m.ID,
                            m.MaVT,
                            m.MoTa,
                            m.MaPhieuYC,
                            m.SoLuong,
                            STT = index + 1,
                            vt.TenVT,
                            vt.DVT
                        };
            BindingSource bs = new BindingSource();
            bs.DataSource = model.ToList();
            grdData.DataSource = bs;
            bdsData.DataSource = bs;
        }

        private void cbxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTrangThai.SelectedIndex != 0)
            {
                var index = 0;
                var model = from m in db.ChiTietPhieuYCs.AsNoTracking()
                            join vt in db.VatTus
                            on m.MaVT equals vt.MaVT
                            where m.MaPhieuYC.Equals(StaticValue.MaPhieuYC)
                            && m.MaVT == cbxTrangThai.SelectedValue.ToString()
                            select new
                            {

                                m.ID,
                                m.MaVT,
                                m.MoTa,
                                m.MaPhieuYC,
                                m.SoLuong,
                                STT = index + 1,
                                vt.TenVT,
                                vt.DVT
                            };
                BindingSource bs = new BindingSource();
                bs.DataSource = model.ToList();
                grdData.DataSource = bs;
                bdsData.DataSource = bs;
            }

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmChiTietPYC_ThemMoi frm = new frmChiTietPYC_ThemMoi();
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maCTYC = grvData.GetRowCellValue(grvData.FocusedRowHandle, "ID").ToString();
            if (string.IsNullOrEmpty(maCTYC))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmChiTietPYC_ThemMoi frm = new frmChiTietPYC_ThemMoi(2, maCTYC);
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCTYC = grvData.GetRowCellValue(grvData.FocusedRowHandle, "ID").ToString();
            if (string.IsNullOrEmpty(maCTYC))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần xóa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", CommonConstant.MESSAGE_INFO, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                //Duyet ban ghi
                var model = db.ChiTietPhieuYCs.Find(maCTYC); ;
                db.ChiTietPhieuYCs.Remove(model);
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
