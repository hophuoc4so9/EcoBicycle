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
    public partial class FrmQLChiNhanh : Form
    {
        CtrChiNhanh Ctr = new CtrChiNhanh();
        public FrmQLChiNhanh()
        {
            InitializeComponent();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            String s = dgvChuyenNganh.CurrentRow.Cells[0].Value.ToString();
            if (s != null && s != "")
            {
                txtChiNhanh.Text = s;
                DialogResult dialogResult = MessageBox.Show( "Bạn có chắc chắn muốn xóa bản ghi có mã là " + s + " hay không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (txtChiNhanh.Text == "") errorProvider1.SetError(txtChiNhanh, "Hãy nhập mã chi nhánh ");
                    else
                    {
                        if (!Ctr.xoaChiNhanh(txtChiNhanh.Text = dgvChuyenNganh.CurrentRow.Cells[0].Value.ToString())) MessageBox.Show("Xóa Chuyên Ngành thất bại!");

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            }
                

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtChiNhanh.Text == "" || txtTenCN.Text =="")
            {
                if (txtChiNhanh.Text == "" )  errorProvider1.SetError(txtChiNhanh, "Hãy nhập mã chi nhánh ");
                if (txtTenCN.Text == "") errorProvider1.SetError(txtChiNhanh, "Hãy nhập tên chuyên ngành ");
            }
            else
            {
                if (Ctr.ThemtenChiNhanh(txtChiNhanh.Text, txtTenCN.Text, txtDiaChi.Text) == false)
                    MessageBox.Show("Thêm thất bại");
                ;

            }    
        }

        private void FrmQLChuyenNganh_Load(object sender, EventArgs e)
        {
            dgvChuyenNganh.DataSource = Ctr.laydsChiNhanh();
           
            

        }

        private void dgvChuyenNganh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvChuyenNganh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChuyenNganh.CurrentRow == null) return;
            int selectionId = dgvChuyenNganh.CurrentCell.RowIndex;
            if (selectionId >= dgvChuyenNganh.Rows.Count)
            {
                selectionId = dgvChuyenNganh.Rows.Count - 1;
            }
            txtChiNhanh.Text = dgvChuyenNganh.Rows[selectionId].Cells["MaCN"].Value.ToString();
            txtDiaChi.Text = dgvChuyenNganh.Rows[selectionId].Cells["DiaChi"].Value.ToString();
            txtTenCN.Text = dgvChuyenNganh.Rows[selectionId].Cells["TenChiNhanh"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtChiNhanh.Text == "")
                errorProvider1.SetError(txtChiNhanh, "Hãy nhập tên cần sửa chuyên ngành!");
            else
            {
              //  String s = dgvChuyenNganh.CurrentRow.Cells[0].Value.ToString();

                if (Ctr.suaChiNhanh(txtChiNhanh.Text,txtTenCN.Text,txtDiaChi.Text ) == false)
                    MessageBox.Show("Sửa thất bại");
                ;

            }
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
