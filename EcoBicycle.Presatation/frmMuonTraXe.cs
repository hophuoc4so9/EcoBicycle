using EcoBicycle.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoBicycle.Presatation
{
    public partial class frmMuonTraXe : Form
    {
        ctrQLXe ctr= new ctrQLXe();
        public static int trangthai = 1;
        public frmMuonTraXe()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (trangthai == 1)
            {
                this.Hide();
                var f = new FrmDangNhap();
                FrmDangNhap.trangthai = 3;
                f.Show();
            }
            else
            {
                this.BackColor = Color.Green;
                simpleButton2.BackColor = Color.Green;
                simpleButton2.Text = "Mở";
            }

        }
        private void load()
        {

            if( trangthai==1)
            {
                panel1.Visible=false;
                this.BackColor = Color.Red;
                simpleButton2.BackColor = Color.Red;
                simpleButton2.Text = "Khóa";
            }
            else
            {
                panel1.Visible = true;
                this.BackColor = Color.Green;
                simpleButton2.BackColor = Color.Green;
                simpleButton2.Text = "Mở";
            }
            if (Mode.Text == "Mode Mượn")
            {
                dataGridView1.DataSource = ctr.laydsxe();
            }
            else
            {
                dataGridView1.DataSource = ctr.chitiet(infoLoginKH.MaThe.ToString());
            }
        
        }

        private void frmMuonTraXe_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            simpleButton2.BackColor = Color.Green;
            cbbChiNhanh.DataSource = ctr.laydsCN();
            cbbChiNhanh.DisplayMember = "MaCN";
            cbbChiNhanh.ValueMember = "TenChiNhanh";
            dataGridView1.DataSource = ctr.laydsxe();
            load();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            if (Mode.Text == "Mode Mượn")
            {
                if (ctr.MuonXe(txtMaXe.Text, infoLoginKH.MaThe.ToString()))
                {
                    MessageBox.Show("Mượn xe thành công");
                }
                else MessageBox.Show("Mượn xe thất bại");
            }
            else
            {
                string time = dataGridView1.CurrentRow.Cells["ThoigianBatdau"].Value.ToString(); ;
                if (ctr.TraXe(txtMaXe.Text, infoLoginKH.MaThe.ToString(),time))
                {
                    MessageBox.Show("Trả xe thành công");
                }
                else MessageBox.Show("Trả xe thất bại");
            }

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow.Index >= dataGridView1.Rows.Count) return;
            var s = dataGridView1.CurrentRow.Cells["MaXe"].Value.ToString();
            txtMaXe.Text = dataGridView1.CurrentRow.Cells["MaXe"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Mode.Text == "Mode Mượn")
            {
                button1.Text = "Mượn xe";
                Mode.Text = "Mode trả";
            }
            else
            {
                button1.Text = "Trả xe";
                Mode.Text = "Mode Mượn";
            }
            load();
        }
    }
}
