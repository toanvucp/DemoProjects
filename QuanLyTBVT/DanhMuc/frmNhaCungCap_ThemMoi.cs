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
    public partial class frmNhaCungCap_ThemMoi : Form
    {
        public frmNhaCungCap_ThemMoi()
        {
            InitializeComponent();
        }

        private bool flag = false;


        public frmNhaCungCap_ThemMoi(int isSave, string IdNhaCC)
        {
            InitializeComponent();
            this.Text = "Thêm mới thông tin nhà cung cấp";
            btnSave.Text = "Thêm mới";
            if (isSave == 2)//sua
            {
                BindingData(IdNhaCC);
                flag = true;
            }

        }


        private void BindingData(string IdNhaCC)
        {
            var model = db.NhaCungCaps.Find(IdNhaCC);
            if (model != null)
            {
                txtDiaChi.Text = model.DiaChi;
                txtEmail.Text = model.Email;
                txtMoTa.Text = model.MoTa;
                txtMST.Text = model.MST;
                txtSDT.Text = model.SDT;
                txtTenNCC.Text = model.TenNCC;
                txtMaNCC.Text = model.MaNCC;
                btnSave.Text = "Lưu";

                this.Text = "Chỉnh sửa thông tin nhà cung cấp";
                this.Refresh();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmNhaCungCap_ThemMoi_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Save();
        }

        private DBQLVT db = new DBQLVT();

        private void Save()
        {
            if (string.IsNullOrEmpty(txtTenNCC.Text.Trim()))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống.", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CommonConstant.CheckPhoneNumber(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string info = "";
            if (flag)//sua ban ghi
            {
                var model = db.NhaCungCaps.Find(txtMaNCC.Text);
                model.TenNCC = txtTenNCC.Text;
                model.TenNCC = txtTenNCC.Text;
                model.SDT = txtSDT.Text;
                model.MoTa = txtMoTa.Text;
                model.MST = txtMST.Text;
                model.DiaChi = txtDiaChi.Text;
                model.Email = txtEmail.Text;
                info = "Sửa thông tin nhà cung cấp";
            }
            else
            {
                NhaCungCap obj = new NhaCungCap();
                obj.MaNCC = GenerateID();
                obj.TenNCC = txtTenNCC.Text;
                obj.SDT = txtSDT.Text;
                obj.MoTa = txtMoTa.Text;
                obj.MST = txtMST.Text;
                obj.DiaChi = txtDiaChi.Text;
                obj.Email = txtEmail.Text;
                info = "Thêm mới thông tin nhà cung cấp";
                db.NhaCungCaps.Add(obj);
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
            var model = db.NhaCungCaps.OrderByDescending(m => m.MaNCC.Replace("NCC", "")).Select(m => m.MaNCC.Replace("NCC", "")).FirstOrDefault();
            if (model != null)
            {
                result = "NCC" + (int.Parse(model) + 1).ToString("D5");
            }
            else
            {
                result = "NCC" + 1.ToString("D5");
            }
            return result;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
