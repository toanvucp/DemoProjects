﻿using QuanLyTBVT.Common;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Login(txtAccount.Text,txtPassword.Text);
            Cursor.Current = Cursors.Default;
        }
        private DBQLVT db = new DBQLVT();

        private void Login(string user, string password)
        {
            try
            {
                var model = (from m in db.NhanViens where m.MaNV == user && m.Password == password select m).FirstOrDefault();
                //Kiem tra nhan vien co ton tai trong he thong khong
                if (model != null && !string.IsNullOrEmpty(model.TenNV))
                {
                    StaticValue.UserLogin = model;
                    //Dang nhap thanh cong:
                    Home frm = new Home();
                    this.Hide();
                    frm.Show();
                    MessageBox.Show(string.Format("Đăng nhập thành công! Xin chào {0}",model.TenNV), CommonConstant.MESSAGE_INFO,MessageBoxButtons.OK,MessageBoxIcon.Information );
                }else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu! Vui lòng thử lại!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu! Vui lòng thử lại!", CommonConstant.MESSAGE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDoiMK frm = new frmDoiMK();
            this.Hide();
            frm.Show();
        }
    }
}
