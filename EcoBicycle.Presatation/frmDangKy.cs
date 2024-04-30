using DevExpress.XtraBars.Ribbon;
using EcoBicycle.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoBicycle.Presatation
{
    public partial class frmDangKy : Form
    {
        ctrDangKy ctr = new ctrDangKy();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGreen;
            cmbLoaiThe.DataSource = ctr.LayLoaiTheXE();
            cmbLoaiThe.DisplayMember = "TenThe";
            cmbLoaiThe.ValueMember = "TenThe";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(validData())
            {
                d
            }    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  
            if(cmbLoaiThe.Text == "Thẻ trả trườc")
            { 
                labelThongBao1.Visible= true;
                labelThongBao2.Visible = true;
                labelNganHang.Visible = false;
                labelSTK.Visible = false;
                cmbNganHang.Visible = false;
                txtSTK.Visible = false;
            }
            if (cmbLoaiThe.Text == "Thẻ trả sau")
            {
                labelThongBao1.Visible = false;
                labelThongBao2.Visible = false;
                labelNganHang.Visible = true;
                labelSTK.Visible = true;
                cmbNganHang.Visible = true;
                txtSTK.Visible = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validData()
        {
            errorProvider1.SetError(txtPass, ((txtPass.Text.Length < 6) ? "Hãy nhập Pass gồm 6 số" : ""));
            errorProvider2.SetError(txtSDT, ((txtSDT.Text.Length <10) ? "Hãy nhập đủ số điện thoại" : ""));
            errorProvider3.SetError(radioNu, ((!(radioNam.Checked || radioNu.Checked)) ? "Hãy chọn giới tính" : ""));
            if (cmbLoaiThe.Text == "Thẻ trả trườc")
            {
                
            }
            if (cmbLoaiThe.Text == "Thẻ trả sau" && txtSTK.Text.Length == 0)
            {
                errorProvider2.SetError(txtSTK, ((txtSTK.Text.Length ==0) ? "Hãy nhập đủ số tài khoản" : ""));
                return false;
            }
            return (txtPass.Text.Length == 6) && (txtSDT.Text.Length == 10) && (radioNam.Checked || radioNu.Checked) ;
        }
    }
}
