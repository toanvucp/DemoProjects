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

namespace QuanLyTBVT
{
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private DBQLVT db = new DBQLVT();
        private void ChangePassword()
        {
            string newPass = txtPasswordNew.Text;
            string againPass = txtPasswordAgain.Text;
            //Neu password moi khong trung nhau
            if (!newPass.ToLower().Equals(againPass.ToLower()))
            {
                MessageBox.Show("Mật khẩu mới không trùng nhau! Vui lòng kiểm tra lại", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var model = (from m in db.NhanViens where m.MaNV == txtAccount.Text && m.Password == txtPasswordOld.Text select m).FirstOrDefault();
            if (model == null || string.IsNullOrEmpty(model.TenNV))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác! Vui lòng kiểm tra lại", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // thuc hien edit
            model.Password = txtPasswordNew.Text;
            int record = db.SaveChanges();
            if (record > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công! vui lòng đăng nhập lại để sử dụng hệ thống!", CommonConstant.MESSAGE_INFO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clear cache neu co'
                StaticValue.UserLogin = new NhanVien();
                //
                this.Close();
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thực hiện đổi mật khẩu! Vui lòng kiểm tra lại", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } 

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            if (string.IsNullOrEmpty(StaticValue.UserLogin.TenNV))
            {
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
            }
            else
            {
                Home frm = new Home();
                frm.Show();
            }
        }
    }
}
