using DevExpress.XtraRichEdit.Fields;
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
    public partial class frmQLTheXe : Form
    {

        ctrQLTheXe ct2 = new ctrQLTheXe();
        ctrDangKy ctr = new ctrDangKy();
        public frmQLTheXe()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void frmQLTheXe_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ct2.getThedd();

            cmbLoaiThe.DataSource = ctr.LayLoaiTheXE();
            cmbLoaiThe.DisplayMember = "TenThe";
            cmbLoaiThe.ValueMember = "MaLoaithe";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
        private bool validData()
        {
           
            errorProvider1.SetError(txtPass, ((txtPass.Text.Length < 6) ? "Hãy nhập Pass gồm 6 số" : ""));
            errorProvider2.SetError(txtSDT, ((txtSDT.Text.Length < 10) ? "Hãy nhập đủ số điện thoại" : ""));
            errorProvider3.SetError(radioNu, ((!(radioNam.Checked || radioNu.Checked)) ? "Hãy chọn giới tính" : ""));
            
            return (txtPass.Text.Length == 6) && (txtSDT.Text.Length >= 10) && (radioNam.Checked || radioNu.Checked);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validData())
            {
                DataRow dr = ctr.LayTheXE().NewRow();
                dr["Mathe"] = int.Parse(txtMaThe.Text);
                dr["MatKhau"] = txtPass.Text;
                
                string dk = "TenThe = '" + cmbLoaiThe.Text + "'";
                DataRow[] tam = ctr.LayLoaiTheXE().Select(dk);
                dr["MaloaiThe"] = tam[0]["MaloaiThe"];
                dr["GioiTinh"] = (radioNam.Checked) ? true : false;
                dr["SDT"] = txtSDT.Text;


                if (ctr.Thaydoithongtin(int.Parse(txtMaThe.Text), dr) == true)
                {
                    ctr.change(dr);


                    MessageBox.Show("Thay đổi thông tin thẻ thành công");
                    dataGridView1.DataSource = ct2.getThedd();
                }
                else MessageBox.Show("Thay đổi thông tin thẻ thất bại");

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if(txtMaThe.Text!="")
            {
                if (ct2.ThemTheMoi(txtMaThe.Text))
                {
                    MessageBox.Show("Đăng ký thành công");
                    dataGridView1.DataSource = ct2.getThedd();
                }
                else MessageBox.Show("Mã thẻ đã tồn tại");
            }    
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow.Index >= dataGridView1.Rows.Count) return;
            var s = dataGridView1.CurrentRow.Cells["MaThe"].Value.ToString();
            DataRow dr = ct2.getThedd().Select("MaThe=" + s).FirstOrDefault();
            if (dr == null) return;
            txtMaThe.Text = dr["MaThe"].ToString();
            txtPass.Text = dr["MatKhau"].ToString();
            txtSDT.Text = dr["SDt"].ToString();
            bool s123 = (bool)dr["gioiTinh"];
            if (s123) radioNam.Checked = true;
        else radioNu.Checked=true;
            cmbLoaiThe.SelectedValue = int.Parse(dr["MaLoaithe"].ToString());

        }
    }
}
