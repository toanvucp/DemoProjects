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
    public partial class frmDonVi_ThemMoi : Form
    {
        public frmDonVi_ThemMoi()
        {
            InitializeComponent();
            LoadComboBox();
        }
        private DBQLVT db = new DBQLVT();
        private bool flag = false;

        public frmDonVi_ThemMoi(int isSave, string IdNhaCC)
        {
            InitializeComponent();
            this.Text = "Thêm mới đơn vị";
            btnSave.Text = "Thêm mới";
            LoadComboBox();
            if (isSave == 2)//sua
            {
                
                BindingData(IdNhaCC);
                flag = true;
            }
        }

        private void BindingData(string IDMaVT)
        {
            var model = db.PXTDs.Find(IDMaVT);
            if (model != null)
            {
                txtMaDV.Text = model.MaPXTD;
                txtMoTa.Text = model.GhiChu;
                txtTenDV.Text = model.TenPXTD;
                cbxParentID.SelectedValue = model.ParentID;
                btnSave.Text = "Lưu";

                this.Text = "Chỉnh sửa thông tin đơn vị";
                this.Refresh();
            }
        }

        private void LoadComboBox()
        {
            SelectedCbx sel = new SelectedCbx();
            cbxParentID.DataSource = sel.CreateTreeDV(!flag);
            cbxParentID.DisplayMember = "DisplayMember";
            cbxParentID.ValueMember = "ValueMember";
        }

        private void frmDonVi_ThemMoi_Load(object sender, EventArgs e)
        {
            
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(txtTenDV.Text.Trim()))
            {
                MessageBox.Show("Tên đơn vị không được để trống.", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string info = "";
            if (flag)//sua ban ghi
            {
                var model = db.PXTDs.Find(txtMaDV.Text);
                model.TenPXTD = txtTenDV.Text;
              
                model.GhiChu = txtMoTa.Text;
                model.ParentID = cbxParentID.SelectedValue.ToString().Equals("")? null : cbxParentID.SelectedValue.ToString();
                info = "Sửa thông tin đơn vị";
            }
            else
            {
                PXTD model = new PXTD();
                model.MaPXTD = GenerateID();
                model.TenPXTD = txtTenDV.Text;
                model.GhiChu = txtMoTa.Text;
                model.ParentID = cbxParentID.SelectedValue.ToString().Equals("") ? null : cbxParentID.SelectedValue.ToString();
                info = "Thêm mới đơn vị";
                db.PXTDs.Add(model);
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
            var model = db.PXTDs.OrderByDescending(m => m.MaPXTD.Replace("KHVT", "")).Select(m => m.MaPXTD.Replace("KHVT", "")).FirstOrDefault();
            if (model != null)
            {
                result = "KHVT" + (int.Parse(model) + 1).ToString("D4");
            }
            else
            {
                result = "KHVT" + 1.ToString("D4");
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
    }
}
