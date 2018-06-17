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

namespace QuanLyTBVT.NhapXuat
{
    public partial class frmPhieuYC_ThemMoi : Form
    {
        public frmPhieuYC_ThemMoi()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private bool flag = false;
        private DBQLVT db = new DBQLVT();

        public frmPhieuYC_ThemMoi(int isSave, string IdPhieuKT)
        {
            InitializeComponent();
            LoadComboBox();
            if (isSave == 2)//sua
            {
                BindingData(IdPhieuKT);
                flag = true;
            }
        }

        private void BindingData(string idPhieuYC)
        {
            var model = db.PhieuYCs.Find(idPhieuYC);
            if (model != null)
            {

                txtMaPYC.Text = model.MaPhieuYC;
                dtpNgayLap.Value = model.NgayLap != null ? DateTime.Parse(model.NgayLap.ToString()) : DateTime.Now;
                this.cbxKhoYC.SelectedValue = model.MaKhoYC;
                this.cbxKhoXuat.SelectedValue = model.MaKhoXuat;
                btnSave.Text = "Lưu";

                this.Text = "Chỉnh sửa thông tin phiếu yêu cầu";
                this.Refresh();
            }
        }

        private void LoadComboBox()
        {
            SelectedCbx sel = new SelectedCbx();
            this.cbxKhoXuat.DataSource = sel.GetCbxKhoVT(false);
            this.cbxKhoXuat.DisplayMember = "DisplayMember";
            this.cbxKhoXuat.ValueMember = "ValueMember";

            this.cbxKhoYC.DataSource = sel.GetCbxKhoVT(false);
            this.cbxKhoYC.DisplayMember = "DisplayMember";
            this.cbxKhoYC.ValueMember = "ValueMember";
        }

        private void Save()
        {
            if (dtpNgayLap.Value.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("Ngày lập không được lớn hơn ngày hiện tại!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.cbxKhoXuat.SelectedValue.ToString().Equals(this.cbxKhoYC.SelectedValue.ToString()))
            {
                MessageBox.Show("Kho yêu cầu và Kho xuất không được trùng nhau!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string info = "";
            if (flag)//sua ban ghi
            {
                var model = db.PhieuYCs.Find(txtMaPYC.Text);
                model.NgayLap = dtpNgayLap.Value;
                model.MaKhoXuat = this.cbxKhoXuat.SelectedValue.ToString();
                model.MaKhoYC = this.cbxKhoYC.SelectedValue.ToString();

                info = "Sửa thông tin phiếu yêu cầu";
            }
            else
            {
                PhieuYC obj = new PhieuYC();
                obj.MaPhieuYC = GenerateID();
                obj.NgayLap = dtpNgayLap.Value;
                obj.TrangThai = CommonConstant.STATUS_MOI;
                obj.MaKhoYC = this.cbxKhoYC.SelectedValue.ToString();
                obj.MaKhoXuat = this.cbxKhoXuat.SelectedValue.ToString();
                obj.NguoiLap = StaticValue.UserLogin.Email.Split('@')[0];
                info = "Thêm mới phiếu yêu cầu";
                db.PhieuYCs.Add(obj);
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
            var model = db.PhieuYCs.OrderByDescending(m => m.MaPhieuYC.Replace("PYC", "")).Select(m => m.MaPhieuYC.Replace("PYC", "")).FirstOrDefault();
            if (model != null)
            {
                result = "PYC" + (int.Parse(model) + 1).ToString("D5");
            }
            else
            {
                result = "PYC" + 1.ToString("D5");
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
