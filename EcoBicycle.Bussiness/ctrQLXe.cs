using EcoBicycle.DataAccess;
using EcoBicycle.DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBicycle.Bussiness
{
    public class ctrQLXe
    {
        ChiNhanhDL chinhanh = new ChiNhanhDL();
        XeDL xedl = new XeDL();
        LoaiXeDL LoaiXe = new LoaiXeDL();
        TheXeDL x = new TheXeDL();
        public DataTable chitiet(string mathe)
        {


            return xedl.chitiet(mathe);
        }
        public bool TraXe(string maxe, string maThe, string thoigianbatdau)
        {
           return xedl.TraXe(maxe,maThe,thoigianbatdau);


        }
        public DataTable laydsxe()
        {
            return xedl.laydsXe();
        }
        public DataTable laydsxe(string macn)
        {
            return xedl.laydsXe( macn);
        }
        public bool PhanBoXe(int soluong, string macn1, string macn2)
        {
            return xedl.PhanBoXe(soluong, macn1, macn2);    
        }
        public bool PhanBoXe(string maxe, string macn1, string macn2)
        {
            return xedl.PhanBoXe(maxe, macn1, macn2);
        }
        public bool PhanThe(int soluong, string macn1, string macn2)
        {
            return x.PhanThe(soluong, macn1, macn2);
        }
        public DataTable laydsCN()
        {

            return chinhanh.LayChiNhanh();
        }
        public DataTable laydsLoadXe()
        {

            return LoaiXe.getLoaiXe();
        }
        public DataTable laydstt()
        {

            return xedl.laytranthai();
        }
        public Boolean ThemXe(int maloai)
        {

            return xedl.ThemXe( maloai);
        }
        public Boolean Xoaxe(int maloai)
        {

            return xedl.xoaXe(maloai);
        }
        public bool SuaXe(int maxe, int Maloai, int matrangthai, string macn)
        {
            return xedl.SuaXe( maxe,  Maloai,  matrangthai,  macn);
        }
        public bool MuonXe(string maxe, string maThe)
        {
            return xedl.MuonXe(maxe,maThe);
        }



    }
}
