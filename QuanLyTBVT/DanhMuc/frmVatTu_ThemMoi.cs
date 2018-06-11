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
    public partial class frmVatTu_ThemMoi : Form
    {
        private DBQLVT db = new DBQLVT();
        public frmVatTu_ThemMoi()
        {
            InitializeComponent();
            LoadComboBox();
        }
        private bool flag = false;
        public frmVatTu_ThemMoi(int isSave, string IdNhaCC)
        {
            InitializeComponent();
            this.cbxDVT.SelectedIndex = 0;
            LoadComboBox();
            this.Text = "Thêm mới vật tư";
            btnSave.Text = "Thêm mới";
            if (isSave == 2)//sua
            {
               
                BindingData(IdNhaCC);
                flag = true;
            }

        }

        private void BindingData(string IDMaVT)
        {
            var model = db.VatTus.Find(IDMaVT);
            if (model != null)
            {
                txtDonGia.Text = model.DonGia.ToString();
                txtMaVT.Text = model.MaVT;
                txtMoTa.Text = model.MoTa;
                txtTenVT.Text = model.TenVT;
                cbxDVT.SelectedText = model.DVT;
                cbxLoaiVT.SelectedValue = model.MaLoaiVT;
                cbxNhaCC.SelectedValue = model.MaNCC;
                btnSave.Text = "Lưu";

                this.Text = "Chỉnh sửa thông tin vật tư";
                this.Refresh();
            }
        }

        private void frmVatTu_ThemMoi_Load(object sender, EventArgs e)
        {
          
        }

        private void LoadComboBox()
        {
            SelectedCbx sel = new SelectedCbx();
            cbxLoaiVT.DataSource = sel.GetCbxLoaiVT();
            cbxLoaiVT.DisplayMember = "DisplayMember";
            cbxLoaiVT.ValueMember = "ValueMember";


            cbxNhaCC.DataSource = sel.GetCbxNCC();
            cbxNhaCC.DisplayMember = "DisplayMember";
            cbxNhaCC.ValueMember = "ValueMember";
        }


        private void Save()
        {
            if (string.IsNullOrEmpty(txtTenVT.Text.Trim()))
            {
                MessageBox.Show("Tên vật tư không được để trống.", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string info = "";
            if (flag)//sua ban ghi
            {
                var model = db.VatTus.Find(txtMaVT.Text);
                model.TenVT = txtTenVT.Text;
                model.DonGia = decimal.Parse(txtDonGia.Text);
                model.DVT = cbxDVT.Text;
                model.MoTa = txtMoTa.Text;
                model.MaLoaiVT = cbxLoaiVT.SelectedValue.ToString();
                model.MaNCC = cbxNhaCC.SelectedValue.ToString();
                info = "Sửa thông tin vật tư";
            }
            else
            {
                VatTu model = new VatTu();
                model.MaNCC = GenerateID();
                model.TenVT = txtTenVT.Text;
                model.DonGia = decimal.Parse(txtDonGia.Text);
                model.DVT = cbxDVT.Text;
                model.MoTa = txtMoTa.Text;
                model.MaLoaiVT = cbxLoaiVT.SelectedValue.ToString();
                model.MaNCC = cbxNhaCC.SelectedValue.ToString();
                info = "Thêm mới Vật tư";
                db.VatTus.Add(model);
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
            var model = db.VatTus.OrderByDescending(m => m.MaVT.Replace("VAT", "")).Select(m => m.MaVT.Replace("VAT", "")).FirstOrDefault();
            if (model != null)
            {
                result = "VAT" + (int.Parse(model) + 1).ToString("D5");
            }
            else
            {
                result = "VAT" + 1.ToString("D5");
            }
            return result;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
