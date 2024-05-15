using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using EcoBicycle.DataAccess;
using EcoBicycle.DataAcess;
using System.Data.SqlTypes;

namespace EcoBicycle.Bussiness
 {  
    public  class CtrDangNhap
        {

        NhanvienDL nv = new NhanvienDL();
        TheXeDL theXe = new TheXeDL();
            public int login(string userName, string password)
            {
                DataRow[] user = nv.TimNhanVien(userName, password); 
            if (user.Length > 0)
                {
                infoLoginNV.MaNV= (int)user[0]["MaNV"];
                infoLoginNV.HoTen = user[0]["HoTen"].ToString();
                infoLoginNV.SDT = user[0]["SDT"].ToString();
                infoLoginNV.DiaChi = user[0]["DiaChi"].ToString();
                infoLoginNV.LoaiNV = user[0]["LoaiNV"].ToString();
                infoLoginNV.Luong = double.Parse (user[0]["Luong"].ToString());
            if(user[0]["NgaySinh"]!= DBNull.Value)     infoLoginNV.NgaySinh = DateTime.Parse( user[0]["NgaySinh"].ToString());
                infoLoginNV.username = user[0]["username"].ToString();
                infoLoginNV.pass = user[0]["pass"].ToString();
                return 1;
                }
            user= theXe.TimTheXE(userName, password);
            if (user.Length > 0)
            {
                infoLoginKH.MaloaiThe = (int)user[0]["MaloaiThe"];
                if (user[0]["HoTen"] != DBNull.Value) infoLoginKH.HoTen = user[0]["HoTen"].ToString();
                infoLoginKH.SDT = user[0]["SDT"].ToString();
                infoLoginKH.GioiTinh =(Boolean) user[0]["GioiTinh"];
             if(user[0]["TenNganHang"]!= DBNull.Value) infoLoginKH.TenNganHang = user[0]["TenNganHang"].ToString();
                if (user[0]["MaNganHang"] != DBNull.Value)  infoLoginKH.MaNganHang = user[0]["MaNganHang"].ToString();

                if (user[0]["SoDu"] != DBNull.Value) infoLoginKH.SoDu =double.Parse(user[0]["SoDu"].ToString());
        //        infoLoginKH.NgaySinh = (DateTime)user[0]["NgaySinh"];
                infoLoginKH.MaThe = (int) user[0]["MaThe"];
                infoLoginKH.MatKhau = (int) user[0]["MatKhau"];
                return 2;
            }

            return 0;
            }
        public void logouNV()
        {

            infoLoginNV.MaNV = -1;
                infoLoginNV.HoTen = "";
                infoLoginNV.SDT = "";
            infoLoginNV.DiaChi = "";
            infoLoginNV.LoaiNV = "";
            infoLoginNV.Luong = 0;
           
                infoLoginNV.username = "";
            infoLoginNV.pass = "";


        }
        }

}

