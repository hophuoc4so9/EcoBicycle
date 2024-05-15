using System;
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
    public partial class frmPhanBo : Form
    {
        CtrChiNhanh ctr = new CtrChiNhanh();
        ctrQLXe ctr2 = new ctrQLXe();
        public int trangthai = 0;
        public frmPhanBo()
        {
            InitializeComponent();
        }

        private void frmPhanBo_Load(object sender, EventArgs e)
        {
            if(trangthai == 1)
            {
                this.Text = "Phân bổ xe";

            }    
            else
            {
               
                    this.Text = "Phân bổ thẻ xe";

                

            }
            comboBox1.DataSource = ctr.laydsChiNhanh();
            comboBox1.DisplayMember = "TenChiNhanh";
            comboBox1.ValueMember = "MaCN";
            comboBox2.DataSource = ctr.laydsChiNhanh();
            comboBox2.DisplayMember = "TenChiNhanh";
            comboBox2.ValueMember = "MaCN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (trangthai == 1)
            {
                if (ctr2.PhanBoXe(int.Parse(txtMaLoai.Text), comboBox1.SelectedValue.ToString(), comboBox2.SelectedValue.ToString()))
                {
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("thất bại");

            }
            else
            {
                if (int.TryParse(txtMaLoai.Text, out int n)==false) return;
                if (ctr2.PhanThe(int.Parse(txtMaLoai.Text), comboBox1.SelectedValue.ToString(), comboBox2.SelectedValue.ToString()))
                {
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("thất bại");



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
