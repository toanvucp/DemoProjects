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
    public partial class frmKhoVT_ThemMoi : Form
    {
        private bool flag = false;
        private DBQLVT db = new DBQLVT();
        public frmKhoVT_ThemMoi()
        {
            InitializeComponent();
        }

        public frmKhoVT_ThemMoi(int isSave, string IdNhaCC)
        {
            InitializeComponent();
            this.Text = "Thêm mới kho vật tư";
            btnSave.Text = "Thêm mới";
            if (isSave == 2)//sua
            {
                BindingData(IdNhaCC);
                flag = true;
            }

        }

        private void BindingData(string IdNhaCC)
        {
            var model = db.KhoVatTus.Find(IdNhaCC);
            if (model != null)
            {
                txtMoTa.Text = model.GhiChu;
                txtTenKhoVT.Text = model.TenKhoVT;
                txtMaKhoVT.Text = model.MaKhoVT;
                btnSave.Text = "Lưu";

                this.Text = "Chỉnh sửa thông tin kho vật tư";
                this.Refresh();
            }
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(txtTenKhoVT.Text.Trim()))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống.", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string info = "";
            if (flag)//sua ban ghi
            {
                var model = db.KhoVatTus.Find(txtMaKhoVT.Text);
                model.TenKhoVT = txtTenKhoVT.Text;
                model.GhiChu = txtMoTa.Text;
                info = "Sửa thông tin kho vật tư";
            }
            else
            {
                KhoVatTu obj = new KhoVatTu();
                obj.MaKhoVT = GenerateID();
                obj.TenKhoVT = txtTenKhoVT.Text;
                obj.GhiChu = txtMoTa.Text;
                info = "Thêm mới kho vật tư";
                db.KhoVatTus.Add(obj);
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
            var model = db.KhoVatTus.OrderByDescending(m => m.MaKhoVT.Replace("KHO", "")).Select(m => m.MaKhoVT.Replace("KHO", "")).FirstOrDefault();
            if (model != null)
            {
                result = "KHO" + (int.Parse(model) + 1).ToString("D2");
            }
            else
            {
                result = "KHO" + 1.ToString("D2");
            }

            return result;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
