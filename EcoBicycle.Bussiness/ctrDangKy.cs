using EcoBicycle.DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EcoBicycle.Bussiness
{
    public class ctrDangKy
    {
        LoaiTheDL LoaiThe= new LoaiTheDL();
        TheXeDL TheXe = new TheXeDL();  
        public DataTable LayLoaiTheXE()
        {
            return LoaiThe.LayLoaiTheXE();
        }
        public DataTable LayTheXE()
        {
            return TheXe.LayTheXE();
        }
        public int DangkyThe(int MaMay, DataRow dr)
        {
            try
            {
               

                return TheXe.DangkyThe(MaMay, dr);
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public Boolean Thaydoithongtin(int mathe,DataRow dr)
        {
            try
            {


                return TheXe.thayDoiThongTin(mathe, dr);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public void change(DataRow user)
        {
            infoLoginKH.MaloaiThe = (int)user["MaloaiThe"];
            if (user["HoTen"] != DBNull.Value) infoLoginKH.HoTen = user["HoTen"].ToString();
            infoLoginKH.SDT = user["SDT"].ToString();
            infoLoginKH.GioiTinh = (Boolean)user["GioiTinh"];
            if (user["TenNganHang"] != DBNull.Value) infoLoginKH.TenNganHang = user["TenNganHang"].ToString();
            if (user["MaNganHang"] != DBNull.Value) infoLoginKH.MaNganHang = user["MaNganHang"].ToString();

            if (user["SoDu"] != DBNull.Value) infoLoginKH.SoDu = double.Parse(user["SoDu"].ToString());
            //        infoLoginKH.NgaySinh = (DateTime)user[0]["NgaySinh"];
            infoLoginKH.MaThe = (int)user["MaThe"];
            infoLoginKH.MatKhau = (int)user["MatKhau"];
        }


    }
}
