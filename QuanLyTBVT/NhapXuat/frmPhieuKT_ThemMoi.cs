using DevExpress.XtraEditors.Controls;
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
    public partial class frmPhieuKT_ThemMoi : Form
    {
        public frmPhieuKT_ThemMoi()
        {
            InitializeComponent();
            LoadComboBox();
        }
        private bool flag = false;
        private DBQLVT db = new DBQLVT();

        public frmPhieuKT_ThemMoi(int isSave, string IdPhieuKT)
        {
            InitializeComponent();
            LoadComboBox();
            if (isSave == 2)//sua
            {
                BindingData(IdPhieuKT);
                flag = true;
            }
        }

        private void BindingData(string IdNhaCC)
        {
            var model = db.PhieuKTs.Find(IdNhaCC);
            if (model != null)
            {

                txtMaPKT.Text = model.MaPhieuKT;
                dtpNgayLap.Value = model.NgayLap != null ? DateTime.Parse(model.NgayLap.ToString()) : DateTime.Now;

                var lstUser = model.NguoiThamGia.Split(',');
                for (int j = 0; j < lstUser.Length; j++)
                {
                    foreach (CheckedListBoxItem item in cbxNguoiTG.Properties.GetItems())
                    {
                        //item.CheckState = CheckState.Checked;
                        if (item.ToString().Equals(lstUser[j]))
                            item.CheckState = CheckState.Checked;
                    }
                }
                btnSave.Text = "Lưu";

                this.Text = "Chỉnh sửa thông tin nhà cung cấp";
                this.Refresh();
            }
        }

        private void LoadComboBox()
        {
            SelectedCbx sel = new SelectedCbx();
            var model = sel.GetCbxNhanVien(true);
            this.cbxNguoiTG.Properties.AllowMultiSelect = true;
            this.cbxNguoiTG.Properties.DataSource = model;
            this.cbxNguoiTG.Properties.DisplayMember = "DisplayMember";
            this.cbxNguoiTG.Properties.ValueMember = "ValueMember";
            this.cbxNguoiTG.Properties.SelectAllItemVisible = false;
        }


        private void Save()
        {
            if (dtpNgayLap.Value.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("Ngày lập không được lớn hơn ngày hiện tại!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string text = cbxNguoiTG.Text;
            string info = "";
            if (flag)//sua ban ghi
            {
                var model = db.PhieuKTs.Find(txtMaPKT.Text);
                model.NgayLap = dtpNgayLap.Value;
                if (!string.IsNullOrEmpty(Text))
                {
                    model.NguoiThamGia = cbxNguoiTG.Text;
                }else
                {
                    model.NguoiThamGia = null;
                }

                info = "Sửa thông tin phiếu kiểm tra";
            }
            else
            {
                   PhieuKT obj = new PhieuKT();
                obj.MaPhieuKT = GenerateID();
                obj.NgayLap = dtpNgayLap.Value;
                if (!string.IsNullOrEmpty(Text))
                {
                    obj.NguoiThamGia = cbxNguoiTG.Text;
                }
                else
                {
                    obj.NguoiThamGia = null;
                }
                obj.TrangThai = CommonConstant.STATUS_MOI;
                obj.NguoiLap = StaticValue.UserLogin.Email.Split('@')[0];
                info = "Thêm mới phiếu kiểm tra";
                db.PhieuKTs.Add(obj);
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
            var model = db.PhieuKTs.OrderByDescending(m => m.MaPhieuKT.Replace("PKT", "")).Select(m => m.MaPhieuKT.Replace("PKT", "")).FirstOrDefault();
            if (model != null)
            {
                result = "PKT" + (int.Parse(model) + 1).ToString("D5");
            }
            else
            {
                result = "PKT" + 1.ToString("D5");
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
