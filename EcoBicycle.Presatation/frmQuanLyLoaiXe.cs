using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.Utils.About;
using openLibrary.Presatation;
using EcoBicycle.Bussiness;
namespace QuanLyLoaiXe
{
    public partial class frmQuanLyLoaiXe : Form
    {
        ctrQLLoaiXe ctr= new ctrQLLoaiXe();
        public void hienthi()
        {
            DataTable loaixe = ctr.getLoaiXe();
            listView1.Items.Clear();
            int i = 0;
            foreach (DataRow dr in loaixe.Rows)
            {
                listView1.Items.Add(dr[0].ToString());
                listView1.Items[i].SubItems.Add(dr[1].ToString());
                listView1.Items[i].SubItems.Add(dr[2].ToString());
                listView1.Items[i].SubItems.Add(dr[3].ToString());
                listView1.Items[i].SubItems.Add(dr[4].ToString());
                listView1.Items[i].SubItems.Add(dr[5].ToString());
                listView1.Items[i].SubItems.Add(dr[6].ToString());
                if (dr[7] != DBNull.Value)
                {
                    byte[] bytes = (byte[])dr[7];
                    pictureBox1.Image = Utility_img.ByteArrayToImage(bytes); ;

                }
                i++;
            }
   
            
                
             //    Byte[]bytes =    (Byte[])   docdulieu[7].ToString();
               
               
            
            
        }
        public frmQuanLyLoaiXe()
        {
            InitializeComponent();
        }

        private void frmQuanLyLoaiXe_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            hienthi();
        }
        private void listView1_Click(object sender, EventArgs e)
        {
            txtMaLoai.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtTenXe.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoLuong.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtxGiaTien.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtDGiaMuon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtHangXe.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtXuatSu.Text = listView1.SelectedItems[0].SubItems[6].Text;
            DataTable dt = ctr.getLoaiXe();
            var s = dt.Select("MaLoai = " + txtMaLoai.Text).Length;
          DataRow dr=  dt.Select("MaLoai = "+ txtMaLoai.Text ).First();
            if (dr["hinhanh"] != DBNull.Value) pictureBox1.Image = Utility_img.ByteArrayToImage((Byte[])dr["hinhanh"]);
            else pictureBox1.Image = null;
            //txtHinhAnh.Text = listView1.SelectedItems[0].SubItems[7].Text;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            //btnSua.Enabled = false;
            //btnXoa.Enabled = false;
            listView1.Items.Clear();
            //ketnoi.Open();


            //    Byte[] tam = Utility_img.ImageToByteArray(pictureBox1.Image); ;
                byte[] tam = Utility_img.ImageToByteArray(pictureBox1.Image);



            //sql = "insert into LoaiXe values('"+txtMaLoai.Text+"','"+txtTenXe.Text+ "','"+txtSoLuong.Text+ "','"+txtxGiaTien.Text+"','" + txtDGiaMuon.Text+"','"+txtHangXe.Text+"','"+txtXuatSu.Text+"',"+ToVarbinary(tam)+ ")";
            //thuchien = new SqlCommand(sql, ketnoi);
            //thuchien.ExecuteNonQuery();
            //ketnoi.Close();

            DataRow dr = ctr.getLoaiXe().NewRow();
            dr[0] = txtMaLoai.Text;
            dr[1] = txtTenXe.Text;
            dr[2] = txtSoLuong.Text;
            dr[3] = txtxGiaTien.Text;
            dr[4] = txtDGiaMuon.Text;
            dr[5] = txtHangXe.Text;
            dr[6] = txtXuatSu.Text;
            dr[7] = tam;
            ctr.themThongTin(int.Parse(txtMaLoai.Text), dr);

            hienthi();


        }




       



        private void btnSua_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //ketnoi.Open();
            var tam = Utility_img.ImageToByteArray(pictureBox1.Image); ;
            //sql = "update loaixe  set maloai='" + txtMaLoai.Text + "' ,tenxe=N'" + txtTenXe.Text+ "',hangxe=N'" + txtHangXe.Text + "', soluong='" + txtSoLuong.Text + "' where maloai='" + txtMaLoai.Text + "'";
            //thuchien = new SqlCommand(sql, ketnoi);
            //thuchien.ExecuteNonQuery();
            //ketnoi.Close();
            DataRow dr = ctr.getLoaiXe().NewRow();
            dr[0] = txtMaLoai.Text;
            dr[1] = txtTenXe.Text;
            dr[2]= txtSoLuong.Text;
            dr[3] = txtxGiaTien.Text;
            dr[4] = txtDGiaMuon.Text;
            dr[5] = txtHangXe.Text;
            dr[6] = txtXuatSu.Text;
            dr[7] = tam;
            ctr.thayDoiThongTin(int.Parse(txtMaLoai.Text), dr);
            hienthi();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

            //ketnoi.Open();
            //sql = "delete ChiTietMuonxe from xe inner join ChiTietMuonxe on xe.MaXe=ChiTietMuonxe.MaXe where maloai='"+txtMaLoai.Text+"'";
            //thuchien = new SqlCommand(sql, ketnoi);
            //thuchien.ExecuteNonQuery();
            //sql = "delete xe where Maloai='" + txtMaLoai.Text + "'";
            //thuchien = new SqlCommand(sql, ketnoi);
            //thuchien.ExecuteNonQuery();
            //sql = "delete loaixe where  Maloai='" + txtMaLoai.Text + "'";
            //thuchien = new SqlCommand(sql, ketnoi);
            //thuchien.ExecuteNonQuery();
            //ketnoi.Close();
            listView1.Items.Clear();
            ctr.XoaLoai(int.Parse(txtMaLoai.Text));

            hienthi();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a=MessageBox.Show("Bạn Thật Sự Muốn Thoát","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Close();
                Application.Exit();
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            txtMaLoai.Clear();
            txtTenXe.Clear();
            txtDGiaMuon.Clear();
            txtHangXe.Clear();
            //txtHinhAnh.Clear();
            txtSoLuong.Clear();
            txtxGiaTien.Clear();
            txtXuatSu.Clear();
            hienthi();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {

                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.jdg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif)";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                    //   srcimg = dlg.FileName;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

        }
    }
}
