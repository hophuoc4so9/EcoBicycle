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
    public partial class frmHoanTraThe : Form
    {

        ctrHoanTraThe ctr = new ctrHoanTraThe();
        public frmHoanTraThe()
        {
            InitializeComponent();
        }
        private bool validdate()
        {
            if (txtPass.Text.Length == 6) return true;
            return false;
        }
        private void btnE_Click(object sender, EventArgs e)
        {   
            if(infoLoginKH.SoDu>infoMayBanThe.SoDu)
            {
                MessageBox.Show("Số dư của máy không đủ để thực hiện hoàn trả thẻ");
                return;
            }    
            if(ctr.hoanTraThe(int.Parse( txtPass.Text)))
            {
                MessageBox.Show("Hoàn trả thẻ thành công");
            }    else
                MessageBox.Show("Hoàn trả thẻ thất bại");
        }

        private void frmHoanTraThe_Load(object sender, EventArgs e)
        {

        }
    }
}
