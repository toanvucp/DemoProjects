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
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLyTBVT.DanhMuc
{
    public partial class frmVatTu : UserControl
    {
        private DBQLVT db = new DBQLVT();
        public frmVatTu()
        {
            InitializeComponent();
            grvData.CustomDrawRowIndicator += grvData_customDrawRow;
        }

        private void grvData_customDrawRow(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle < 0)
                {
                    e.Info.ImageIndex = 0;
                    e.Info.DisplayText = string.Empty;
                }
                else
                {
                    e.Info.ImageIndex = -1;
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
                SizeF siz = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font);
                Int32 _width = Convert.ToInt32(siz.Width);
                BeginInvoke(new MethodInvoker(delegate { Cal(20, grvData); }));
            }
        }

        bool Cal(Int32 _Width, GridView view)
        {
            view.IndicatorWidth = view.IndicatorWidth < _Width ? _Width : view.IndicatorWidth;
            return true;
        }


        private void LoadGrid()
        {
            grvData.Columns[0].Caption = "Mã Vật tư";
            grvData.Columns[1].Caption = "Tên Vật tư";
            grvData.Columns[2].Caption = "Đơn vị tính";
            grvData.Columns[3].Caption = "Mã loại vật tư";
            grvData.Columns[4].Caption = "Mã Nhà cung cấp";
            grvData.Columns[5].Caption = "Đơn giá";
            grvData.Columns[6].Caption = "Mô tả";
            grvData.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            LoadDatabox();
            LoadData();
        }


        private void LoadDatabox()
        {
            SelectedCbx sel = new SelectedCbx();
            var model = sel.GetCbxLoaiVT();
            this.cbxLoaiVT.DataSource = model;
            this.cbxLoaiVT.ValueMember = "ValueMember";
            this.cbxLoaiVT.DisplayMember = "DisplayMember";
        }

        private void chkLoadAll_CheckedChanged(object sender, EventArgs e)
        {
            cbxLoaiVT.Enabled = (!chkLoadAll.Checked);
            LoadData();
        }

        private void LoadData()
        {
            var model = new List<VatTu>();
            if (chkLoadAll.Checked)//Load all
            {
                model = (db.VatTus.AsNoTracking().OrderBy(m => m.MaLoaiVT)).ToList();
            }
            else
            {
                model = (db.VatTus.AsNoTracking().Where(m => m.MaLoaiVT == cbxLoaiVT.SelectedValue.ToString())).ToList();
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = model;
            bdsData.DataSource = bs;
            grdData.DataSource = bs;

        }

        private void grvData_DataSourceChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strMa = txtSearchMa.Text.Trim();
            string strTen = txtSearchName.Text.Trim();
            var model = (from m in db.VatTus
                         where
(string.IsNullOrEmpty(strMa) ? true : m.MaVT.Contains(strMa))
&& (string.IsNullOrEmpty(strTen) ? true : m.TenVT.Contains(strTen))
&& (chkLoadAll.Checked ? true : m.MaLoaiVT == cbxLoaiVT.SelectedValue.ToString())
                         select m).OrderBy(m => m.MaNCC).ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = model;
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmVatTu_ThemMoi frm = new frmVatTu_ThemMoi();
            frm.Closed += delegate
            {

                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maVT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaVT").ToString();
            if (string.IsNullOrEmpty(maVT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmVatTu_ThemMoi frm = new frmVatTu_ThemMoi(2, maVT);
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maVT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaVT").ToString();
            if (string.IsNullOrEmpty(maVT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần xóa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               
                var model = db.VatTus.Find(maVT); ;
                db.VatTus.Remove(model);
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

        private void labelControl_Click(object sender, EventArgs e)
        {

        }
    }
}
