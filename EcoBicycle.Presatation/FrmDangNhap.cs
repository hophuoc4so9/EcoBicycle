﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoBicycle.Bussiness;

namespace EcoBicycle.Presatation
{
    public partial class FrmDangNhap : Form
    {   CtrDangNhap ctr= new CtrDangNhap(); 
        public static int trangthai=0;
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            this.BtnDangNhapdn.Visible = false;
            this.btnThoatDangNhap.Visible= false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            if(trangthai==0)
            {
                var f = new frmMainKH();
                f.ShowDialog();
            }    
            else
            {
                this.Close();
            }    
                
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (validData())
            {
                int t = ctr.login(txtUserName.Text, txtPassword.Text);
                if (t == 0)
                {
                    MessageBox.Show("Bạn đã nhập sai tên đăng nhập hoặc mật khẩu");

                }
                else
                if (t == 1)
                {
                    var f = (frmMain)this.ParentForm;
                    f.loadData();
                    this.Close();
                    


                }
                else
                {
                    if(trangthai!=3)
                    {    
                    this.Close();
                    var f = new frmMainKH();
                    f.Show();
                    }
                    else
                    {
                        this.Close();
                        var f = new frmMuonTraXe();
                        frmMuonTraXe.trangthai = 2;
                        f.Show();
                    } 
                        
                }
            }

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
        
      
        private bool validData()
        {
            errorProvider1.SetError(txtUserName, ((txtUserName.Text == "") ? "Hãy nhập Username" : ""));
            errorProvider2.SetError(txtPassword, ((txtPassword.Text == "") ? "Hãy nhập Password" : ""));
            return (txtUserName.Text != "" && txtPassword.Text != "");
        }
        private void BtnDangNhapdn_Click(object sender, EventArgs e)
        {
           
        }
        private void btnThoatDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
