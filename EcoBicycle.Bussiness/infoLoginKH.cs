﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBicycle.Bussiness
{
    public class infoLoginKH
    {

        public static string HoTen ="";
        public static bool GioiTinh=true;
        public static string SDT ="";
        public static int MaThe = -1;
        public static int MatKhau =-1;
        public static string MaNganHang = "";
        public static string TenNganHang = "";
        public static double SoDu = 0;
        public static int MaloaiThe = -1;

        public static double getSoDu()
        {
            return SoDu;
        }
        public static void clear()
        {
         HoTen = "";
         GioiTinh = true;
         SDT = "";
        MaThe = -1;
         MatKhau = -1;
         MaNganHang = "";
         TenNganHang = "";
        SoDu = 0;
         MaloaiThe = -1;
        }


    }
}
