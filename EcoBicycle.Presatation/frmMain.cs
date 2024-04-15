﻿using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FrmDangNhap f = (FrmDangNhap)this.MdiChildren.FirstOrDefault(k => k is FrmDangNhap);
            if (f == null)
            {
                f = new FrmDangNhap();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }
    }
}