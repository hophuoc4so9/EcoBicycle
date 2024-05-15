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
    public partial class frmNapTien : Form
    {
        public frmNapTien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var s = new frmMainKH();
            s.Show();
        }

        private void frmNapTien_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrMainKH ctr =new ctrMainKH();
            ;

            if (ctr.NapTien(infoLoginKH.MaThe, int.Parse(textBox1.Text)) )
            {

                MessageBox.Show("Nạp tiền thành công");
            }
            else MessageBox.Show("Nạp tiền thất bại");
        }
    }
}
