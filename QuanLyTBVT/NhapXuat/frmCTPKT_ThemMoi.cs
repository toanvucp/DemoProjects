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
    public partial class frmCTPKT_ThemMoi : Form
    {
        public frmCTPKT_ThemMoi()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private bool flag = false;
        private DBQLVT db = new DBQLVT();
        private int ID;

        private void frmCTPKT_ThemMoi_Load(object sender, EventArgs e)
        {
        }

        public frmCTPKT_ThemMoi(int isSave, string IdPhieuKT)
        {
            InitializeComponent();
            LoadComboBox();
            if (isSave == 2)//sua
            {
                flag = true;
                ID = int.Parse(IdPhieuKT);
                BindingData();
            }
        }

        private void BindingData()
        {
            var model = db.ChiTietPhieuKTs.Find(ID);
            if (model != null)
            {

                this.txtSerialNumber.Text = model.SerialNumber;
                this.cbxVatTu.SelectedValue = model.MaVT;
                this.cbxTTKT.SelectedValue = model.TrangThaiKT;
                this.txtMoTa.Text = model.MoTa;
                btnSave.Text = "Lưu";

                this.Text = "Chỉnh sửa thông tin chi tiết phiếu kiểm tra";
                this.Refresh();
            }
        }

        private void LoadComboBox()
        {
            SelectedCbx sel = new SelectedCbx();
            this.cbxTTKT.DataSource = sel.GetCbxStatusKTTB(false);
            this.cbxTTKT.DisplayMember = "DisplayMember";
            this.cbxTTKT.ValueMember = "ValueMember";

            this.cbxVatTu.DataSource = sel.GetCbxVatTu(false);
            this.cbxVatTu.DisplayMember = "DisplayMember";
            this.cbxVatTu.ValueMember = "ValueMember";
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(txtSerialNumber.Text.Trim()))
            {
                MessageBox.Show("Serial Number không được để trống!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string info = "";
            if (flag)//sua ban ghi
            {
                var model = db.ChiTietPhieuKTs.Find(ID);
                model.SerialNumber = txtSerialNumber.Text.Trim();
                model.SoLuong = 1;
                model.TrangThaiKT = int.Parse(cbxTTKT.SelectedValue.ToString());
                model.MaVT = cbxVatTu.SelectedValue.ToString();
                model.MoTa = txtMoTa.Text;
                info = "Sửa thông tin phiếu kiểm tra";
            }
            else
            {
                ChiTietPhieuKT obj = new ChiTietPhieuKT();
                obj.SerialNumber = txtSerialNumber.Text.Trim();
                obj.SoLuong = 1;
                obj.TrangThaiKT = int.Parse(cbxTTKT.SelectedValue.ToString());
                obj.MaVT = cbxVatTu.SelectedValue.ToString();
                obj.MaPhieuKT = StaticValue.MaPhieuKT;
                obj.MoTa = txtMoTa.Text;
                info = "Thêm mới chi tiết phiếu kiểm tra";
                db.ChiTietPhieuKTs.Add(obj);
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
