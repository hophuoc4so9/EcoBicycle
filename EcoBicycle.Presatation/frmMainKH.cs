using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using EcoBicycle.Bussiness;
using DevExpress.Office.Drawing;

namespace EcoBicycle.Presatation
{
    public partial class frmMainKH : Form
    {
        ctrMainKH ctr = new ctrMainKH();
        public static int mamay;
        public frmMainKH()
        {
            InitializeComponent();
        }
        
        private void frmMainKH_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ctr.LayMayBanThe();
            comboBox1.DisplayMember = "MaMay";
           
            panel1.AutoSize = true;
            if(infoLoginKH.MaloaiThe <=0)
            {
                btnHoanTraThe.Visible = false;
                btnNapTien.Visible = false;
                btnXemThongTin.Visible = false;
            }    
            else
            {
                btnHoanTraThe.Visible = true;
                btnXemThongTin.Visible= true;
                btnNapTien.Visible = (infoLoginKH.MaloaiThe == 1) ?true:false;  
            }    

            if(infoLoginKH.MaThe == -1)
            {
                btnDangKy.Text = "Đăng ký thẻ";
                
            }    else btnDangKy.Text = "Đăng xuất";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {   if(btnDangKy.Text == "Đăng ký thẻ")
            {    
            this.Hide();
            var f = new frmDangKy();
            frmDangKy.MaMay = int.Parse( comboBox1.Text);
            f.Show();
            }
        else
            {
                ctr.logout();
                frmMainKH_Load(this, null);
            }    
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            var f = new FrmDangNhap();
            frmDangKy.trangthai = 0;
            f.Show();
           
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new frmDangKy();
            frmDangKy.MaMay = int.Parse(comboBox1.Text);
            frmDangKy.trangthai = 1;
            f.Show();
        }

        private void btnHoanTraThe_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn hoàn trả thẻ", "Hoàn trả thẻ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               
                if (ctr.checksodu(infoLoginKH.SoDu, int.Parse(comboBox1.Text)) ==false  && infoLoginKH.MaloaiThe==1)
                {
                    MessageBox.Show("hiện tại không thể hoàn trả thẻ do máy không có đủ tiền");
                    return;
                }
                if (ctr.Thaydoithongtin(infoLoginKH.MaThe))
                {
                    ctr.capNhatThe(infoLoginKH.MaThe.ToString(), comboBox1.Text);
                    MessageBox.Show("Hoàn trả thẻ thành công");
                    ctr.logout();
                    frmMainKH_Load(this, null);
                }
                else MessageBox.Show("Hoàn trả thẻ thấ bại"); ;
               
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
     
       }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            this.Hide();

            var f = new frmNapTien();
     
            f.Show();
        }
    }
}
