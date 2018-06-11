using QuanLyTBVT.Common;
using QuanLyTBVT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTBVT.DanhMuc
{
    public partial class frmLoaiVatTu_ThemMoi : Form
    {
        public frmLoaiVatTu_ThemMoi()
        {
            InitializeComponent();
        }

        private bool flag = false;
        private DBQLVT db = new DBQLVT();
        public frmLoaiVatTu_ThemMoi(int isSave, string IdNhaCC)
        {
            InitializeComponent();
            this.Text = "Thêm mới loại vật tư";
            btnSave.Text = "Thêm mới";
            if (isSave == 2)//sua
            {
                BindingData(IdNhaCC);
                flag = true;
            }

        }

        private void BindingData(string IdNhaCC)
        {
            var model = db.LoaiVatTus.Find(IdNhaCC);
            if (model != null)
            {
                txtMoTa.Text = model.MoTa;
                txtTenLVT.Text = model.TenLoaiVT;
                txtMaLVT.Text = model.MaLoaiVT;
                btnSave.Text = "Lưu";

                this.Text = "Chỉnh sửa thông tin nhà cung cấp";
                this.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(txtTenLVT.Text.Trim()))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống.", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string info = "";
            if (flag)//sua ban ghi
            {
                var model = db.LoaiVatTus.Find(txtMaLVT.Text);
                model.TenLoaiVT = txtTenLVT.Text;
                model.MaLoaiVT = txtMaLVT.Text;
                model.MoTa = txtMoTa.Text;
                info = "Sửa thông tin loại vật tư";
            }
            else
            {
                LoaiVatTu obj = new LoaiVatTu();
                obj.MaLoaiVT = GenerateID();
                obj.TenLoaiVT = txtTenLVT.Text;
                obj.MoTa = txtMoTa.Text;
                info = "Thêm mới loại vật tư";
                db.LoaiVatTus.Add(obj);
            }

            int record = db.SaveChanges();
            if (record > 0)
            {
                MessageBox.Show(info + " thành công.", CommonConstant.MESSAGE_INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("Xảy ra lỗi, vui lòng kiểm tra lại!"), CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private string GenerateID()
        {
            string result = "";
            var model = db.LoaiVatTus.OrderByDescending(m => m.MaLoaiVT.Replace("MLVT", "")).Select(m => m.MaLoaiVT.Replace("MLVT", "")).FirstOrDefault();
            if (model != null)
            {
                result = "MLVT" + (int.Parse(model) + 1).ToString("D5");
            }else
            {
                result = "MLVT" + 1.ToString("D5");
            }
            
            return result;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
