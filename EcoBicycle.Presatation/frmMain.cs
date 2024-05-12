using QuanLyLoaiXe;
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

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXemThongKeXeDap f = (frmXemThongKeXeDap)this.MdiChildren.FirstOrDefault(k => k is frmXemThongKeXeDap);
            if (f == null)
            {
                f = new frmXemThongKeXeDap();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuanLyLoaiXe f = (frmQuanLyLoaiXe)this.MdiChildren.FirstOrDefault(k => k is frmQuanLyLoaiXe);
            if (f == null)
            {
                f = new frmQuanLyLoaiXe();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQLChiNhanh f = (FrmQLChiNhanh)this.MdiChildren.FirstOrDefault(k => k is FrmQLChiNhanh);
            if (f == null)
            {
                f = new FrmQLChiNhanh();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQLXe f = (frmQLXe)this.MdiChildren.FirstOrDefault(k => k is frmQLXe);
            if (f == null)
            {
                f = new frmQLXe();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
