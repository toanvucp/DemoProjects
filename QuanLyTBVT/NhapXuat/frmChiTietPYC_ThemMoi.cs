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
    public partial class frmChiTietPYC_ThemMoi : Form
    {
        public frmChiTietPYC_ThemMoi()
        {
            InitializeComponent();
        }
        private bool flag = false;
        private DBQLVT db = new DBQLVT();
        private int ID;
        public frmChiTietPYC_ThemMoi(int isSave, string idPhieuYC)
        {
            InitializeComponent();
            LoadComboBox();
            if (isSave == 2)//sua
            {
                flag = true;
                ID = int.Parse(idPhieuYC);
                BindingData();
            }
        }

        private void BindingData()
        {
            var model = db.ChiTietPhieuYCs.Find(ID);
            if (model != null)
            {
                this.cbxVatTu.SelectedValue = model.MaVT;
                this.txtMoTa.Text = model.MoTa;
                txtSoLuong.Text = model.SoLuong.ToString();
                btnSave.Text = "Lưu";

                this.Text = "Chỉnh sửa thông tin chi tiết phiếu yêu cầu";
                this.Refresh();
            }
        }

        private void LoadComboBox()
        {
            SelectedCbx sel = new SelectedCbx();

            this.cbxVatTu.DataSource = sel.GetCbxVatTu(false);
            this.cbxVatTu.DisplayMember = "DisplayMember";
            this.cbxVatTu.ValueMember = "ValueMember";

        }

        private void Save()
        {

            try
            {
                int.Parse(txtSoLuong.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Số lượng không hợp lệ! Vui lòng kiểm tra lại!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string info = "";
            if (flag)//sua ban ghi
            {
                var model = db.ChiTietPhieuYCs.Find(ID);
                model.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                model.MaVT = cbxVatTu.SelectedValue.ToString();
                model.MoTa = txtMoTa.Text;
                info = "Sửa thông tin phiếu yêu cầu";
            }
            else
            {
                ChiTietPhieuYC obj = new ChiTietPhieuYC();
                obj.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                obj.MaVT = cbxVatTu.SelectedValue.ToString();
                obj.MoTa = txtMoTa.Text;
                info = "Thêm mới chi tiết phiếu yêu cầu";
                db.ChiTietPhieuYCs.Add(obj);
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

        private void frmChiTietPYC_ThemMoi_Load(object sender, EventArgs e)
        {

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
