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
    public partial class frmPhieuNhap_ThemMoi : Form
    {
        public frmPhieuNhap_ThemMoi()
        {
            InitializeComponent();
            LoadComboBox();
        }
        private bool flag = false;
        private DBQLVT db = new DBQLVT();
        private string mstrOLdValueMaKT = "";
        public frmPhieuNhap_ThemMoi(int isSave, string IdPhieuKT)
        {
            InitializeComponent();
            LoadComboBox();
            if (isSave == 2)//sua
            {
                BindingData(IdPhieuKT);
                flag = true;
            }
        }


        private void LoadComboBox()
        {
            SelectedCbx sel = new SelectedCbx();
            this.cbxKhoVT.DataSource = sel.GetCbxKhoVT(false);
            this.cbxKhoVT.DisplayMember = "DisplayMember";
            this.cbxKhoVT.ValueMember = "ValueMember";

            this.cbxNCC.DataSource = sel.GetCbxNCC();
            this.cbxNCC.DisplayMember = "DisplayMember";
            this.cbxNCC.ValueMember = "ValueMember";

            this.cbxPhieuKT.DataSource = sel.GetCbxPhieuKT(CommonConstant.STATUS_DADUYET);
            this.cbxPhieuKT.DisplayMember = "DisplayMember";
            this.cbxPhieuKT.ValueMember = "ValueMember";
        }

        private void BindingData(string IdNhaCC)
        {
            var model = db.PhieuNhaps.Find(IdNhaCC);
            if (model != null)
            {

                txtMaPNhap.Text = model.MaPhieuNhap;
                dtpNgayLap.Value = model.NgayLap != null ? DateTime.Parse(model.NgayLap.ToString()) : DateTime.Now;
                txtMoTa.Text = model.NoiDung;
                cbxKhoVT.SelectedValue = model.MaKhoVT;
                cbxNCC.SelectedValue = model.MaNCC;
                mstrOLdValueMaKT = model.MaPhieuKT;
                btnSave.Text = "Lưu";

                this.Text = "Chỉnh sửa thông tin phiếu nhập";
                this.Refresh();
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
            string strMaPNhap = txtMaPNhap.Text;
            string strMaPhieuKT = cbxPhieuKT.SelectedValue.ToString();
            if (flag)//sua ban ghi
            {
                var model = db.PhieuNhaps.Find(strMaPNhap);
                model.NgayLap = dtpNgayLap.Value;
                model.MaKhoVT = cbxKhoVT.SelectedValue.ToString();
                model.MaPhieuKT = strMaPhieuKT;
                model.MaNCC = cbxNCC.SelectedValue.ToString();
                model.NoiDung = txtMoTa.Text;
                if (string.IsNullOrEmpty(mstrOLdValueMaKT) || !mstrOLdValueMaKT.Equals(cbxPhieuKT.SelectedValue.ToString()))
                {
                    //Clear bang chitiet phieu nhap
                    ClearDataChiTiet(strMaPNhap);
                    //Cap nhat lai chi tiet phieu nhap
                    UpdateChiTiet(strMaPNhap, strMaPhieuKT);
                    //end
                }
                info = "Sửa thông tin phiếu nhập";
            }
            else
            {
                strMaPNhap = GenerateID();
                PhieuNhap obj = new PhieuNhap();
                obj.MaPhieuNhap = strMaPNhap;
                obj.NgayLap = dtpNgayLap.Value;
                obj.TrangThai = CommonConstant.STATUS_MOI;
                obj.NguoiLap = StaticValue.UserLogin.Email.Split('@')[0];
                obj.MaKhoVT = cbxKhoVT.SelectedValue.ToString();
                obj.MaPhieuKT = cbxPhieuKT.SelectedValue.ToString();
                obj.MaNCC = cbxNCC.SelectedValue.ToString();
                obj.NoiDung = txtMoTa.Text;
                //Insert chi tiet phieu nhap
                UpdateChiTiet(strMaPNhap, strMaPhieuKT);
                //end
                info = "Thêm mới phiếu nhập";

                db.PhieuNhaps.Add(obj);
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

        private void ClearDataChiTiet(string maPhieuNhap)
        {
            var model = db.ChiTietPhieuNhaps.Where(m => m.MaPhieuNhap == maPhieuNhap).ToList();
            db.ChiTietPhieuNhaps.RemoveRange(model);
        }

        private void UpdateChiTiet(string maPhieuNhap, string maPhieuKT)
        {
            var model = db.ChiTietPhieuKTs.Where(m => m.MaPhieuKT.Equals(maPhieuKT)).ToList();
            var lstAdd = new List<ChiTietPhieuNhap>();
            foreach (var item in model)
            {
                ChiTietPhieuNhap obj = new ChiTietPhieuNhap();
                obj.MaPhieuNhap = maPhieuNhap;
                obj.SerialNumber = item.SerialNumber;
                obj.SoLuong = int.Parse(item.SoLuong.ToString());
                obj.TrangThai = item.TrangThaiVT;
                obj.MoTa = item.MoTa;
                obj.MaVT = item.MaVT;
                lstAdd.Add(obj);
            }
            db.ChiTietPhieuNhaps.AddRange(lstAdd);
        }

        private string GenerateID()
        {
            string result = "";
            var model = db.PhieuNhaps.OrderByDescending(m => m.MaPhieuNhap.Replace("NHAP", "")).Select(m => m.MaPhieuNhap.Replace("NHAP", "")).FirstOrDefault();
            if (model != null)
            {
                result = "NHAP" + (int.Parse(model) + 1).ToString("D5");
            }
            else
            {
                result = "NHAP" + 1.ToString("D5");
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
