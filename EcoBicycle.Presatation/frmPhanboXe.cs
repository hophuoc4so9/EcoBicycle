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
    public partial class frmPhanboXe : Form
    {
     
        ctrQLXe ctr = new ctrQLXe();
        public void loadData()
        {

            string selected = this.cbbChiNhanh.GetItemText(this.cbbChiNhanh.SelectedItem);
            if ("System.Data.DataRowView" == selected) return;
            dataGridView1.DataSource = ctr.laydsxe(selected);
             selected = this.cbchinhanh2.GetItemText(this.cbchinhanh2.SelectedItem);
            dataGridView2.DataSource = ctr.laydsxe(selected);

        }
        public frmPhanboXe()
        {
            InitializeComponent();
        }

        private void frmPhanboXe_Load(object sender, EventArgs e)
        {
            cbbChiNhanh.DataSource = ctr.laydsCN();
            cbbChiNhanh.DisplayMember = "MaCN";
            cbbChiNhanh.ValueMember = "TenChiNhanh";

            cbchinhanh2.DataSource = ctr.laydsCN();
            cbchinhanh2.DisplayMember = "MaCN";
            cbchinhanh2.ValueMember = "TenChiNhanh";
            dataGridView1.DataSource = ctr.laydsxe();
                dataGridView2.DataSource = ctr.laydsxe();
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtMaXe.Text != null)
            {
                int maloai =int.Parse( dataGridView1.CurrentRow.Cells["maloai"].Value.ToString());


                int matt =int.Parse( dataGridView1.CurrentRow.Cells["matt"].Value.ToString() );
                if (ctr.SuaXe(int.Parse(txtMaXe.Text), maloai, matt, cbchinhanh2.Text))
                {
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");
                loadData();


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow.Index >= dataGridView1.Rows.Count) return;
            var s = dataGridView1.CurrentRow.Cells["MaXe"].Value.ToString();
            txtMaXe.Text = dataGridView1.CurrentRow.Cells["MaXe"].Value.ToString();
          
        }
    }
}
