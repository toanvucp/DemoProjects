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
using System.Data.Entity.Core.Objects;
using QuanLyTBVT.Common;

namespace QuanLyTBVT.DanhMuc
{
    public partial class frmNhaCungCap : UserControl
    {
        public frmNhaCungCap()
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


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelControl_Click(object sender, EventArgs e)
        {

        }

        private DBQLVT db = new DBQLVT();

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            
            LoadData();

        }

        private void LoadGrid()
        {
            grvData.Columns[0].Caption = "Mã NCC";
            grvData.Columns[1].Caption = "Tên NCC";
            grvData.Columns[2].Caption = "SĐT";
            grvData.Columns[3].Caption = "Email";
            grvData.Columns[4].Caption = "Địa chỉ";
            grvData.Columns[5].Caption = "MST";
            grvData.Columns[6].Caption = "Mô tả";
        }

        private void grvData_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }

        private void grvData_DataSourceChanged(object sender, EventArgs e)
        {

            LoadGrid();
        }


        private void LoadData()
        {
            var model = db.NhaCungCaps.AsNoTracking().OrderBy(m => m.MaNCC).ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = model;
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strMa = txtSearchMa.Text.Trim();
            string strTen = txtSearchTen.Text.Trim();
            var model = (from m in db.NhaCungCaps
                         where
(string.IsNullOrEmpty(strMa) ? true : m.MaNCC.Contains(strMa))
&& (string.IsNullOrEmpty(strTen) ? true : m.TenNCC.Contains(strTen))
                         select m).OrderBy(m => m.MaNCC).ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = model;
            bdsData.DataSource = bs;
            grdData.DataSource = bs;

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmNhaCungCap_ThemMoi frm = new frmNhaCungCap_ThemMoi();
            frm.Closed += delegate
            {
               
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNCC = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaNCC").ToString();
            if (string.IsNullOrEmpty(maNCC))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmNhaCungCap_ThemMoi frm = new frmNhaCungCap_ThemMoi(2, maNCC);
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string maNCC = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaNCC").ToString();
                var model = db.NhaCungCaps.Find(maNCC); ;
                db.NhaCungCaps.Remove(model);
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
