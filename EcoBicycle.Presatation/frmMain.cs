using EcoBicycle.Bussiness;
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
        CtrDangNhap c = new CtrDangNhap();
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (infoLoginNV.MaNV == -1)
            {
                FrmDangNhap f = (FrmDangNhap)this.MdiChildren.FirstOrDefault(k => k is FrmDangNhap);
                if (f == null)
                {
                    f = new FrmDangNhap();
                    f.TopLevel = false;
                    this.Controls.Add(f);
                 
                    f.MdiParent = this;
                    f.WindowState = FormWindowState.Maximized;
                    
                    f.Show();
                    
                }
              
                
            }
            else
            {

                c.logouNV();
                loadData();
               
            }

            if (infoLoginNV.MaNV == -1)
            {
                btnDangNhap.Caption = "Đăng nhập";
                ribbonPageGroup3.Visible = false;
                ribbonPageGroup5.Visible = false;
            }
            else
            {
                btnDangNhap.Caption = "Đăng xuất";
                ribbonPageGroup3.Visible = true;
                ribbonPageGroup5.Visible = true;
            }

        }
        public void loadData()
        {
            if (infoLoginNV.MaNV == -1)
            {
                btnDangNhap.Caption = "Đăng nhập";
                ribbonPageGroup3.Visible = false;
                ribbonPageGroup5.Visible = false;
            }
            else
            {
                btnDangNhap.Caption = "Đăng xuất";
                ribbonPageGroup3.Visible = true;
                ribbonPageGroup5.Visible = true;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            if (infoLoginNV.MaNV == -1)
            {
                btnDangNhap.Caption = "Đăng nhập";
                ribbonPageGroup3.Visible = false;
                ribbonPageGroup5.Visible = false;
            }
            else
            {
                btnDangNhap.Caption = "Đăng xuất";
                ribbonPageGroup3.Visible = true;
                ribbonPageGroup5.Visible = true;
            }


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
            frmXemThongTin f = (frmXemThongTin)this.MdiChildren.FirstOrDefault(k => k is frmXemThongTin);
            if (f == null)
            {
                f = new frmXemThongTin();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQLTheXe f = (frmQLTheXe)this.MdiChildren.FirstOrDefault(k => k is frmQLTheXe);
            if (f == null)
            {
                f = new frmQLTheXe();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }
    }
}
