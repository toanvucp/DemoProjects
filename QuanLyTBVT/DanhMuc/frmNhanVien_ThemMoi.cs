using QuanLyTBVT.Common;
using QuanLyTBVT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTBVT.DanhMuc
{
    public partial class frmNhanVien_ThemMoi : Form
    {
        public frmNhanVien_ThemMoi()
        {
            InitializeComponent();
            LoadComboBox();
            this.cbxQuyen.SelectedIndex = 1;
            this.rptNam.Checked = true;
        }
        private DBQLVT db = new DBQLVT();
        private bool flag = false;

        public frmNhanVien_ThemMoi(int isSave, string IdNhaCC)
        {
            InitializeComponent();
            this.cbxQuyen.SelectedIndex = 1;
            this.rptNam.Checked = true;
            LoadComboBox();
            this.Text = "Thêm mới nhân viên";
            btnSave.Text = "Thêm mới";
            if (isSave == 2)//sua
            {

                BindingData(IdNhaCC);
                flag = true;
            }

        }

        private void LoadComboBox()
        {
            SelectedCbx sel = new SelectedCbx();
            var model = sel.CreateTreeDV(false);
            this.cbxDonVi.DataSource = model;
            this.cbxDonVi.DisplayMember = "DisplayMember";
            this.cbxDonVi.ValueMember = "ValueMember";
        }

        private void BindingData(string IDMaVT)
        {
            var model = db.NhanViens.Find(IDMaVT);
            if (model != null)
            {
                txtChucVu.Text = model.ChucVu;
                txtDiaChi.Text = model.DiaChi;
                txtMoTa.Text = model.MoTa;
                txtEmail.Text = model.Email;
                txtMaNV.SelectedText = model.MaNV;
                txtTenNV.Text = model.TenNV;

                if (model.GioiTinh == true)
                {
                    rptNam.Checked = true;
                }
                else
                {
                    rptNu.Checked = true;
                }
                cbxDonVi.SelectedValue = model.PhongBan;
                cbxQuyen.SelectedText = model.RoleID;
                if (!string.IsNullOrEmpty(model.Avatar))
                {
                    picAva.Image = Image.FromFile(Application.StartupPath + model.Avatar);
                }
                btnSave.Text = "Lưu";

                this.Text = "Chỉnh sửa thông tin nhân viên";
                this.Refresh();
            }
        }

        private void CopyImage(string path, bool overide)
        {
            string filename = openfile.FileName;
            string filepath = Application.StartupPath + @"\images\" + path; //Địa chỉ cần copy qua
            if (!File.Exists(filename)) return;

            if (File.Exists(filepath))
                File.Delete(filepath);
            else
                try
                {
                    File.Copy(filename, filepath, overide);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã phát sinh lỗi trong việc chọn ảnh upload, vui lòng kiểm tra lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openfile.Title = "Chọn Ảnh đại diện";
            openfile.InitialDirectory = @"c:\Program Files";//Thư mục mặc định khi mở
            openfile.Filter = "All files (*.*)|*.*|exe files (*.exe)|*.exe";// Lọc ra những file cần hiển thị
            openfile.FilterIndex = 1;//chúng ta có All files là 1,exe là 2
            openfile.RestoreDirectory = true;

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                picAva.Image = Image.FromFile(openfile.FileName);
                Path_Image = Path.GetFileName(openfile.FileName);
            }
        }

        private string Path_Image = "";
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //CopyImage(Path_Image);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }


        private void Save()
        {
            if (string.IsNullOrEmpty(txtTenNV.Text.Trim()))
            {
                MessageBox.Show("Tên vật tư không được để trống.", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(Path_Image))
            {
                var model = db.NhanViens.Select(m => m.Avatar == @"\images\" + Path_Image).FirstOrDefault();
                if (model)
                {
                    MessageBox.Show("Tên ảnh đã tồn tại trong hệ thống. Vui lòng kiểm tra lại!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    picAva.Image = null;
                    Path_Image = "";
                    return;
                }
            }


            string info = "";
            if (flag)//sua ban ghi
            {

                var model = db.NhanViens.Find(txtMaNV.Text);
                model.ChucVu = txtChucVu.Text;
                model.DiaChi = txtDiaChi.Text;
                model.Email = txtEmail.Text;
                model.MoTa = txtMoTa.Text;
                //model.MaNV = txtMaNV.Text;
                model.PhongBan = cbxDonVi.SelectedValue.ToString();
                model.RoleID = cbxQuyen.Text;
                model.GioiTinh = rptNam.Checked ? true : rptNu.Checked ? false : false;
                model.NgaySinh = dtpNgaySinh.Value;
                model.TenNV = txtTenNV.Text;
                if (!string.IsNullOrEmpty(Path_Image))
                {
                    CopyImage(Path_Image, true);
                    model.Avatar = @"\images\" + Path_Image;
                }
                info = "Sửa thông tin nhân viên";
            }
            else
            {
                NhanVien model = new NhanVien();

                model.MaNV = GenerateID();
                model.ChucVu = txtChucVu.Text;
                model.DiaChi = txtDiaChi.Text;
                model.Email = txtEmail.Text;
                model.MoTa = txtMoTa.Text;
                model.PhongBan = cbxDonVi.SelectedValue.ToString();
                model.RoleID = cbxQuyen.Text;
                model.GioiTinh = rptNam.Checked ? true : rptNu.Checked ? false : false;
                model.NgaySinh = dtpNgaySinh.Value;
                model.TenNV = txtTenNV.Text;
                if (!string.IsNullOrEmpty(Path_Image))
                {
                    CopyImage(Path_Image, true);
                    //model.Avatar = @"\images\" + Path_Image;
                }
                info = "Thêm mới nhân viên";
                db.NhanViens.Add(model);
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
            var model = db.NhanViens.OrderByDescending(m => m.MaNV.Replace("NV", "")).Select(m => m.MaNV.Replace("NV", "")).FirstOrDefault();
            if (model != null)
            {
                result = "NV" + (int.Parse(model) + 1).ToString("D5");
            }
            else
            {
                result = "NV" + 1.ToString("D5");
            }
            return result;
        }
    }
}
