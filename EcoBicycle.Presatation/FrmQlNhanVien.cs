using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DirectX.Common.Direct2D;
using DevExpress.Utils.CommonDialogs;
using EcoBicycle.Bussiness;


using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using openLibrary.Presatation;
namespace EcoBicycle.Presatation
{
    public partial class FrmQlNhanVien : Form
    { CtrQLNhanVien ctr = new CtrQLNhanVien();
        DataRow dr;
        int manhanvien;


        public FrmQlNhanVien()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void getData()
        {
            manhanvien =int.Parse( txtMaNV.Text);
            dr["HoTen"] = txtHovaTen.Text;
            dr["GioiTinh"] = (radioButton1.Checked) ? true : false;
            dr["NgaySinh"] = dateTimePicker1.Value;

            dr["SDT"] = txtSDT.Text;
            dr["DiaChi"] = txtDiaChi.Text;
            dr["LoaiNV"] = comboboxTenLoaiNV.SelectedValue;

            dr["Luong"] =  double.Parse(txtLuong.Text);
            dr["username"] = txtUserName.Text;
            dr["pass"] = TxtPassword.Text;
        }
        private void setData()
        {   if (dr == null) return;
             txtMaNV.Text = dr["MaNV"].ToString() ;
             txtHovaTen.Text = dr["HoTen"].ToString();
            if ((Boolean.Parse(dr["GioiTinh"].ToString()))) radioButton1.Checked = true; else radioButton2.Checked = true;
           
            dateTimePicker1.Value = (DateTime)(dr["NgaySinh"]==DBNull.Value? DateTime.Now: dr["NgaySinh"]);
             txtSDT.Text = dr["SDT"].ToString();
             txtDiaChi.Text = dr["DiaChi"].ToString();
           comboboxTenLoaiNV.SelectedValue = dr["LoaiNV"];

            txtLuong.Text = dr["Luong"].ToString();
           txtUserName.Text = dr["username"].ToString();
           TxtPassword.Text = dr["pass"].ToString();
        }
        private void FrmQlNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ctr.laydsNhanVien();
           // comboboxTenLoaiNV.DataSource = ctr.laydsloaiNhanVien();
      
            //    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dr = ctr.laydsNhanVien().NewRow();
            comboboxTenLoaiNV.DataSource = ctr.LayLaoiNhanvien();
            var tam = ctr.LayLaoiNhanvien();
            comboboxTenLoaiNV.DisplayMember = "tenLoaiNV";
            comboboxTenLoaiNV.ValueMember = "LoaiNV";
       


        }
        private bool xacthucthongtin()
        {
            if (txtHovaTen.Text == "") return false;
  
            if (txtSDT.Text == "") return false;
            if (txtDiaChi.Text == "") return false;
            if (txtLuong.Text == "") return false;
            if (txtMaNV.Text == "") return false;
            if (txtUserName.Text == "") return false;
            if (TxtPassword.Text == "") return false;
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(xacthucthongtin())
            { getData();
                if (ctr.themnv(dr))
                {
                    MessageBox.Show("Thành công");
                    dataGridView1.DataSource = ctr.laydsNhanVien();
                }
                else MessageBox.Show("Thất bại");   
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin");
        }

        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //
            if (dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow.Index <dataGridView1.Rows.Count-1)
            {
                DataTable nv = ctr.laydsNhanVien();
                var s = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
                dr = nv.Select("MaNV =" + s).FirstOrDefault();
                setData();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (xacthucthongtin())
            {
                getData();
                if (ctr.XoaThongTin(manhanvien,dr))
                {
                    MessageBox.Show("Thành công");
                    dataGridView1.DataSource = ctr.laydsNhanVien();
                }
                else MessageBox.Show("Thất bại");
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (xacthucthongtin())
            {
                getData();
                if (ctr.thayDoiThongTin(manhanvien,dr))
                {
                    MessageBox.Show("Thành công");
                    dataGridView1.DataSource = ctr.laydsNhanVien();
                }
                else MessageBox.Show("Thất bại");
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    TxtPassword.Text = Membership.GeneratePassword(8,3);
        }

        private void pHinhand_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {

                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.jdg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif)";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                 //   pHinhand.Image = new Bitmap(dlg.FileName);
              
                //    pHinhand.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void comboboxTenLoaiNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           txtMaNV.Text="";
             txtHovaTen.Text="";
       //     dr["GioiTinh"] = (radioButton1.Checked) ? "1" : "0";
            dateTimePicker1.Value = DateTime.Now;
txtSDT.Text = "";
            txtDiaChi.Text = "";
           comboboxTenLoaiNV.SelectedValue = 1;

            txtLuong.Text = null;
         TxtPassword.Text = "";
        }
    }
}
