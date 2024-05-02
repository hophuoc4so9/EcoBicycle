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
        public static int trangthai = 0;
        public static int MaMay = 0;
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
            if(trangthai==0)
            {
                this.Text = "Đăng ký";
                labelMathe.Visible = false;
                txtMaThe.Visible = false;
                button1.Text = "Tiếp tục";
            }   
            if(trangthai ==1)
            {   cmbLoaiThe.Enabled = false;
                labelMathe.Visible = true;

                txtMaThe.Visible = true;
                if(infoLoginKH.GioiTinh) radioNam.Checked = true;
               else radioNu.Checked = true;
                button1.Text = "Lưu thay đổi";
                txtMaThe.Text = infoLoginKH.MaThe.ToString();
                txtPass.Text = infoLoginKH.MatKhau.ToString();
                txtSDT.Text=infoLoginKH.SDT.ToString();
                DataRow[] dr = ctr.LayLoaiTheXE().Select("MaloaiThe  = " + infoLoginKH.MaloaiThe);
                cmbLoaiThe.SelectedIndex = cmbLoaiThe.FindString( dr[0]["TenThe"].ToString());
            }    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(validData() && trangthai ==0)
            {
                DataRow dr= ctr.LayTheXE().NewRow();
                dr["MatKhau"] =txtPass.Text;
                if (cmbLoaiThe.Text == "Thẻ trả trườc")
                {
                    dr["SoDu"] = 100000000;
                }
                if (cmbLoaiThe.Text == "Thẻ trả sau")
                {
                    dr["MaNganHang"] = cmbNganHang.Text;
                    dr["TenNganHang"] =txtSTK.Text;
                   
                }
                string dk = "TenThe = '" + cmbLoaiThe.Text +"'";
                DataRow[] tam = ctr.LayLoaiTheXE().Select(dk);
                dr["MaloaiThe"] = tam[0]["MaloaiThe"];
                dr["GioiTinh"] = (radioNam.Checked) ? true : false;
                dr["SDT"] =txtSDT.Text;
                

                if (ctr.DangkyThe(MaMay, dr) == true)
                {
                    
                    MessageBox.Show("Đăng ký thẻ thành công");
                }
                else MessageBox.Show("Đăng ký thẻ thất bại");
                    
            }
            if (validData() && trangthai == 1)
            {
                DataRow dr = ctr.LayTheXE().NewRow();
                dr["Mathe"] = int.Parse(txtMaThe.Text);
                dr["MatKhau"] = txtPass.Text;
                if (cmbLoaiThe.Text == "Thẻ trả trườc")
                {
                    dr["SoDu"]= infoLoginKH.getSoDu() ;
                }
                if (cmbLoaiThe.Text == "Thẻ trả sau")
                {
                    dr["MaNganHang"] = cmbNganHang.Text;
                    dr["TenNganHang"] = txtSTK.Text;

                }
                string dk = "TenThe = '" + cmbLoaiThe.Text + "'";
                DataRow[] tam = ctr.LayLoaiTheXE().Select(dk);
                dr["MaloaiThe"] = tam[0]["MaloaiThe"];
                dr["GioiTinh"] = (radioNam.Checked) ? true : false;
                dr["SDT"] = txtSDT.Text;


                if (ctr.Thaydoithongtin(int.Parse(txtMaThe.Text), dr) == true)
                {
                    ctr.change(dr);


                    MessageBox.Show("Thay đổi thông tin thẻ thành công");
                }
                else MessageBox.Show("Thay đổi thông tin thẻ thất bại");

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
            return (txtPass.Text.Length == 6) && (txtSDT.Text.Length >= 10) && (radioNam.Checked || radioNu.Checked) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainKH f = new frmMainKH();
            f.ShowDialog();
        }

        private void labelMathe_Click(object sender, EventArgs e)
        {

        }
    }
}
