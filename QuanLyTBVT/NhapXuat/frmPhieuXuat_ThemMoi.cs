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
    public partial class frmPhieuXuat_ThemMoi : Form
    {
        public frmPhieuXuat_ThemMoi()
        {
            InitializeComponent();
            LoadComboBox();
        }
        private bool flag = false;
        private DBQLVT db = new DBQLVT();

        public frmPhieuXuat_ThemMoi(int isSave, string IdPhieuKT)
        {
            InitializeComponent();
            LoadComboBox();
            if (isSave == 2)//sua
            {
                BindingData(IdPhieuKT);
                flag = true;
            }
        }


        private void BindingData(string maPX)
        {
            var model = db.PhieuXuats.Find(maPX);
            if (model != null)
            {

                txtMaPX.Text = model.MaPX;
                dtpNgayLap.Value = model.NgayLap != null ? DateTime.Parse(model.NgayLap.ToString()) : DateTime.Now;
                this.cbxKhoXuat.SelectedValue = model.MaKhoXuat;
                this.cbxKhoYC.SelectedValue = model.MaKhoNhap;
                this.cbxPhieuYC.SelectedValue = model.PhieuYC;
                this.txtMoTa.Text = model.NoiDung;
                btnSave.Text = "Lưu";

                this.Text = "Chỉnh sửa thông tin phiếu xuất";
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

            this.cbxPhieuYC.DataSource = sel.GetcbxPhieuYeuCau(CommonConstant.STATUS_DADUYET, false);
            this.cbxPhieuYC.DisplayMember = "DisplayMember";
            this.cbxPhieuYC.ValueMember = "ValueMember";
        }

        private void cbxPhieuYC_SelectedIndexChanged(object sender, EventArgs e)
        {
            var blnshow = !string.IsNullOrEmpty(cbxPhieuYC.SelectedValue.ToString());
            this.cbxKhoXuat.Enabled = blnshow;
            this.cbxKhoYC.Enabled = blnshow;
            if (blnshow)
            {
                var model = db.PhieuYCs.Find(cbxPhieuYC.SelectedValue.ToString());
                this.cbxKhoXuat.SelectedValue = model.MaKhoXuat;
                this.cbxKhoYC.SelectedValue = model.MaKhoYC;
            }
        }


        private void Save()
        {
            if (dtpNgayLap.Value.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("Ngày lập không được lớn hơn ngày hiện tại!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string info = "";
            if (flag)//sua ban ghi
            {
                var model = db.PhieuXuats.Find(txtMaPX.Text);
                model.NgayLap = dtpNgayLap.Value;
                model.MaKhoNhap = cbxKhoYC.SelectedValue.ToString();
                model.MaKhoXuat = cbxKhoXuat.SelectedValue.ToString();
                model.NoiDung = txtMoTa.Text;
                if (cbxPhieuYC.SelectedValue != null)
                {
                    model.PhieuYC = cbxPhieuYC.SelectedValue.ToString();
                }else
                {
                    model.PhieuYC = null;
                }
                info = "Sửa thông tin phiếu xuất";
            }
            else
            {
                PhieuXuat obj = new PhieuXuat();
                obj.MaPX = GenerateID();
                obj.NgayLap = dtpNgayLap.Value;

                obj.MaKhoNhap = cbxKhoYC.SelectedValue.ToString();
                obj.MaKhoXuat = cbxKhoXuat.SelectedValue.ToString();
                obj.NoiDung = txtMoTa.Text;
                if (cbxPhieuYC.SelectedValue != null )
                {
                    obj.PhieuYC = cbxPhieuYC.SelectedValue.ToString();
                }
                obj.TrangThai = CommonConstant.STATUS_MOI;
                obj.NguoiLap = StaticValue.UserLogin.Email.Split('@')[0];
                info = "Thêm mới phiếu xuất";
                db.PhieuXuats.Add(obj);
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
            var model = db.PhieuXuats.OrderByDescending(m => m.MaPX.Replace("PHX", "")).Select(m => m.MaPX.Replace("PHX", "")).FirstOrDefault();
            if (model != null)
            {
                result = "PHX" + (int.Parse(model) + 1).ToString("D5");
            }
            else
            {
                result = "PHX" + 1.ToString("D5");
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhieuXuat_ThemMoi_Load(object sender, EventArgs e)
        {

        }
    }
}
