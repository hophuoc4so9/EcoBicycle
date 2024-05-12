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
using EcoBicycle.Presatation;
namespace EcoBicycle.Presatation
{
    public partial class frmQLXe : Form
    {
        ctrQLXe ctr = new ctrQLXe();
        
        public frmQLXe()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            

            dataGridView1.DataSource = ctr.laydsxe();
            comboBox1.DataSource= ctr.laydsLoadXe();
            comboBox1.DisplayMember= "TenXe";
         
            cbbTrangThai.DataSource = ctr.laydstt();
            cbbTrangThai.DisplayMember = "TenTrangThai";

       //     cbbTrangThai.ValueMember = "TenTrangThai";
   

            cbbChiNhanh.DataSource = ctr.laydsCN();
            cbbChiNhanh.DisplayMember = "MaCN";
            cbbChiNhanh.DataSource = ctr.laydsCN();
            cbbChiNhanh.DisplayMember = "MaCN";


        }
        private void frmQLXe_Load(object sender, EventArgs e)
        {
            loadData();
            txtMaXe.ReadOnly = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataTable db= ctr.laydsLoadXe();
            string dk = "TenXe  = '" + comboBox1.Text + "'";
            DataRow dr = db.Select(dk).First();
            if (ctr.ThemXe(int.Parse(dr["MaLoai"].ToString()) ))
            {
                MessageBox.Show("Thành công");
            }
            else MessageBox.Show("Thất bại");
            dataGridView1.DataSource =ctr.laydsxe();
            loadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            if(dataGridView1.CurrentRow.Index >= dataGridView1.Rows.Count) return;
            var s= dataGridView1.CurrentRow.Cells["MaXe"].Value.ToString();
            txtMaXe.Text = dataGridView1.CurrentRow.Cells["MaXe"].Value.ToString();
            cbbChiNhanh.SelectedItem = dataGridView1.CurrentRow.Cells["MaCN"].Value.ToString();
            cbbTrangThai.SelectedItem = dataGridView1.CurrentRow.Cells["TenTrangThai"].Value.ToString();
          comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells["TenXe"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtMaXe.Text!=null)
            {
                if (ctr.Xoaxe(int.Parse(txtMaXe.Text)))
                {
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
                loadData();
                   

            }    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaXe.Text != null)
            {
                DataTable db = ctr.laydsLoadXe();
                string dk = "TenXe  = '" + comboBox1.Text + "'";
                DataRow dr = db.Select(dk).First();
                int maloai= int.Parse(dr["MaLoai"].ToString());

                db = ctr.laydstt();
                dk = "TenTrangThai   = '" + cbbTrangThai.Text + "'";
                dr = db.Select(dk).First();
                int matt = int.Parse(dr["Matt"].ToString());
                if (ctr.SuaXe(int.Parse(txtMaXe.Text),maloai,matt,cbbChiNhanh.Text ))
                {
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
                loadData();


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaXe.Text != null)
            {
                DataTable db = ctr.laydsLoadXe();
                string dk = "TenXe  = '" + comboBox1.Text + "'";
                DataRow dr = db.Select(dk).First();
                int maloai = int.Parse(dr["MaLoai"].ToString());

                db = ctr.laydstt();
                dk = "TenTrangThai   = '" + cbbTrangThai.Text + "'";
                dr = db.Select(dk).First();
                int matt = int.Parse(dr["Matt"].ToString());
                if (ctr.SuaXe(int.Parse(txtMaXe.Text), maloai, matt, cbbChiNhanh.Text))
                {
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
                loadData();


            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
