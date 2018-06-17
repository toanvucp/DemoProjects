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
    public partial class frmChiTietPhieuXuat_ThemMoi : Form
    {
        public frmChiTietPhieuXuat_ThemMoi()
        {
            InitializeComponent();
            LoadComboBox();
        }
        private bool flag = false;
        private DBQLVT db = new DBQLVT();
        private int ID;

        public frmChiTietPhieuXuat_ThemMoi(int isSave, string IdPhieuKT)
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
            var model = db.ChiTietPhieuXuats.Find(ID);
            if (model != null)
            {
                this.txtSerialNumber.Text = model.SerialNumber;
                this.cbxVatTu.SelectedValue = model.MaVT;
                this.txtMoTa.Text = model.MoTa;
                txtSoLuong.Text = model.SoLuong.ToString();
                this.cbxTTVT.SelectedValue = model.TrangThaiVT;
                btnSave.Text = "Lưu";

                this.Text = "Chỉnh sửa thông tin chi tiết phiếu kiểm tra";
                this.Refresh();
            }
        }

        private List<SelectedCbxModel> mlstModel = new List<SelectedCbxModel>();

        private void LoadComboBox()
        {
            SelectedCbx sel = new SelectedCbx();
            mlstModel = sel.GetCbxVatTuInKho(false, StaticValue.MaPhieuXuat);
            this.cbxVatTu.DataSource = mlstModel;
            this.cbxVatTu.DisplayMember = "DisplayMember";
            this.cbxVatTu.ValueMember = "ValueMember";

            this.cbxTTVT.DataSource = sel.GetCbxTTVT(false);
            this.cbxTTVT.DisplayMember = "DisplayMember";
            this.cbxTTVT.ValueMember = "ValueMember";

        }

        private void frmChiTietPhieuXuat_ThemMoi_Load(object sender, EventArgs e)
        {

        }
        


        private void cbxVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoLuongKho.Text = (from m in mlstModel
                                 where m.ValueMember == cbxVatTu.SelectedValue.ToString()
                                 select m.SL).ToString();


        }


        private void Save()
        {
            if (string.IsNullOrEmpty(txtSerialNumber.Text.Trim()))
            {
                MessageBox.Show("Serial Number không được để trống!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var sl = int.Parse(txtSoLuong.Text.Trim());
                var slKho = int.Parse(txtSoLuongKho.Text.Trim());
                if (sl > slKho)
                {
                    MessageBox.Show("Số lượng vượt quá số lượng hiện tại trong kho! Vui lòng kiểm tra lại!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Số lượng không hợp lệ! Vui lòng kiểm tra lại!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            string info = "";
            if (flag)//sua ban ghi
            {
                var model = db.ChiTietPhieuXuats.Find(ID);
                model.SerialNumber = txtSerialNumber.Text.Trim();
                model.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                model.MaVT = cbxVatTu.SelectedValue.ToString();
                model.TrangThaiVT = cbxTTVT.SelectedValue.ToString();
                model.MoTa = txtMoTa.Text;
                info = "Sửa thông tin chi tiết phiếu xuất";
            }
            else
            {
                ChiTietPhieuXuat obj = new ChiTietPhieuXuat();
                obj.SerialNumber = txtSerialNumber.Text.Trim();
                obj.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                obj.MaVT = cbxVatTu.SelectedValue.ToString();
                obj.MaPX = StaticValue.MaPhieuXuat;
                obj.MoTa = txtMoTa.Text;
                obj.TrangThaiVT = cbxTTVT.SelectedValue.ToString();
                info = "Thêm mới chi tiết phiếu xuất";
                db.ChiTietPhieuXuats.Add(obj);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
