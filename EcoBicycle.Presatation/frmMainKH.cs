﻿using System;
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

namespace EcoBicycle.Presatation
{
    public partial class frmMainKH : Form
    {
        public frmMainKH()
        {
            InitializeComponent();
        }

        private void frmMainKH_Load(object sender, EventArgs e)
        {
            
           
            panel1.AutoSize = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            var f = new FrmDangNhap();
            f.Show();
           
        }
    }
}
