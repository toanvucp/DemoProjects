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
using DevExpress.XtraGrid.Views.Grid;
using QuanLyTBVT.Common;

namespace QuanLyTBVT.DanhMuc
{
    
    public partial class frmLoaiVatTu : UserControl
    {
        public frmLoaiVatTu()
        {
            InitializeComponent();
            grvData.CustomDrawRowIndicator += grvData_customDrawRow;
        }

        private DBQLVT db = new DBQLVT();


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
            grvData.Columns[0].Caption = "Mã Loại vật tư";
            grvData.Columns[1].Caption = "Tên Loại vật tư";
            grvData.Columns[2].Caption = "Mô tả";
        }

        private void LoadData()
        {
            var model = db.LoaiVatTus.AsNoTracking().OrderBy(m => m.MaLoaiVT).ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = model;
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strMa = txtSearchMa.Text.Trim();
            string strTen = txtSearchName.Text.Trim();
            var model = (from m in db.LoaiVatTus
                         where
(string.IsNullOrEmpty(strMa) ? true : m.MaLoaiVT.Contains(strMa))
&& (string.IsNullOrEmpty(strTen) ? true : m.TenLoaiVT.Contains(strTen))
                         select m).OrderBy(m => m.MaLoaiVT).ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = model;
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
        }

        private void grvData_DataSourceChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNCC = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaLoaiVT").ToString();
            if (string.IsNullOrEmpty(maNCC))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                var model = db.LoaiVatTus.Find(maNCC); ;
                db.LoaiVatTus.Remove(model);
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmLoaiVatTu_ThemMoi frm = new frmLoaiVatTu_ThemMoi();
            frm.Closed += delegate
            {

                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLoaiVT = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaLoaiVT").ToString();
            if (string.IsNullOrEmpty(maLoaiVT))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmLoaiVatTu_ThemMoi frm = new frmLoaiVatTu_ThemMoi(2, maLoaiVT);
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void frmLoaiVatTu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
