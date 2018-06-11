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
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using DevExpress.XtraGrid.Columns;

namespace QuanLyTBVT.DanhMuc
{
    public partial class frmNhanVien : UserControl
    {
        public frmNhanVien()
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

        private DBQLVT db = new DBQLVT();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            LoadData();
            GridColumn unbColumn = grvData.Columns.AddField("Total");
            unbColumn.VisibleIndex = grvData.Columns.Count;
            unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            unbColumn.ColumnEdit = this.repositoryItemPictureEdit1;
            unbColumn.FieldName = "Total";
            unbColumn.Name = "Total";
            unbColumn.Caption = "Ảnh";
            unbColumn.OptionsColumn.AllowEdit = false;
            unbColumn.Visible = true;
            unbColumn.Width = 110;
        }

        private void LoadData()
        {
            var model = from m in db.NhanViens.AsNoTracking()
                        join n in db.PXTDs.AsNoTracking()
on m.PhongBan equals n.MaPXTD
                        select new NhanVienModel()
                        {
                            MaNV = m.MaNV,
                            GioiTinh = m.GioiTinh == true ? "Nam" : "Nữ",
                            NgaySinh = m.NgaySinh,
                            MoTa = m.MoTa,
                            TenNV = m.TenNV,
                            ChucVu = m.ChucVu,
                            Avatar = m.Avatar,
                            DiaChi = m.DiaChi,
                            Email = m.Email,
                            MaPXTD = n.MaPXTD,
                            TenPXTD = n.TenPXTD
                        };
            BindingSource bs = new BindingSource();
            bs.DataSource = model.ToList();
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
        }

        private string GetPath(string strPath)
        {
            return Application.StartupPath + "strPath";
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strMa = txtSearchMa.Text.Trim();
            string strTen = txtSearchName.Text.Trim();
            var model = from m in db.NhanViens.AsNoTracking()
                        join n in db.PXTDs.AsNoTracking()
                              on m.PhongBan equals n.MaPXTD
                        where string.IsNullOrEmpty(strMa) ? true : m.MaNV.Contains(strMa)
                               && string.IsNullOrEmpty(strTen) ? true : m.TenNV.Contains(strTen)
                        select new NhanVienModel()
                        {
                            MaNV = m.MaNV,
                            GioiTinh = m.GioiTinh == true ? "Nam" : "Nữ",
                            NgaySinh = m.NgaySinh,
                            MoTa = m.MoTa,
                            TenNV = m.TenNV,
                            ChucVu = m.ChucVu,
                            Avatar = m.Avatar,
                            DiaChi = m.DiaChi,
                            Email = m.Email,
                            MaPXTD = n.MaPXTD,
                            TenPXTD = n.TenPXTD
                        };

            BindingSource bs = new BindingSource();
            bs.DataSource = model.ToList();
            bdsData.DataSource = bs;
            grdData.DataSource = bs;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNCC = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaNV").ToString();
            if (string.IsNullOrEmpty(maNCC))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này không?", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                var model = db.NhanViens.Find(maNCC); ;
                db.NhanViens.Remove(model);
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
            frmNhanVien_ThemMoi frm = new frmNhanVien_ThemMoi();
            frm.Closed += delegate
            {

                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }


        string ImageDir = @"images\";
        Hashtable Images = new Hashtable();

        private void grvData_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Total" && e.IsGetData)
            {
                GridView view = sender as GridView;
                var str = e.Row as NhanVienModel;
                string colorName = str.Avatar;
                string fileName = colorName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    if (!Images.ContainsKey(fileName))
                    {
                        Image img = null;
                        try
                        {
                            string filePath = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, fileName, false);
                            img = Image.FromFile(filePath);
                            img = img.GetThumbnailImage(100, 140, null, new IntPtr(0));
                        }
                        catch
                        {
                        }
                        Images.Add(fileName, img);
                    }
                    e.Value = Images[fileName];
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = grvData.GetRowCellValue(grvData.FocusedRowHandle, "MaNV").ToString();
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show(string.Format("Vui lòng chọn bản ghi cần sửa!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmNhanVien_ThemMoi frm = new frmNhanVien_ThemMoi(2, maNV);
            frm.Closed += delegate
            {
                LoadData();
                this.Refresh();
            };
            frm.ShowDialog();
        }
    }
}
