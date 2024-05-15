using EcoBicycle.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoBicycle.Presatation
{
    public partial class frmXemThongTin : Form
    {
        CtrQLNhanVien ctr = new CtrQLNhanVien();
        DataRow dr;
        int manhanvien;
        public frmXemThongTin()
        {
            InitializeComponent();
        }

        private void frmXemThongTin_Load(object sender, EventArgs e)
        {
            comboboxTenLoaiNV.DataSource = ctr.LayLaoiNhanvien();
            var tam = ctr.LayLaoiNhanvien();
            comboboxTenLoaiNV.DisplayMember = "tenLoaiNV";
            comboboxTenLoaiNV.ValueMember = "LoaiNV";
            txtMaNV.Text = infoLoginNV.MaNV.ToString();
            txtHovaTen.Text = infoLoginNV.HoTen;
            txtDiaChi.Text=infoLoginNV.DiaChi;
            txtLuong.Text = infoLoginNV.Luong.ToString();
            txtDiaChi.Text = infoLoginNV.DiaChi;
            txtUserName.Text = infoLoginNV.username;
            TxtPassword.Text=infoLoginNV.pass;
            txtSDT.Text = infoLoginNV.SDT;
            comboboxTenLoaiNV.SelectedValue = infoLoginNV.LoaiNV;
        }
    }
}
