using EcoBicycle.DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBicycle.Bussiness
{
    public class ctrQLLoaiXe
    {
        LoaiXeDL loaiXe = new LoaiXeDL();
        public DataTable getLoaiXe()
        {
           
            return loaiXe.getLoaiXe();
        }
        public Boolean thayDoiThongTin(int MaLoai, DataRow dr)
        {
            try
            {
                return loaiXe.thayDoiThongTin(MaLoai,dr);
            }catch (Exception ex) { return false; }

        }
        public Boolean themThongTin(int MaLoai, DataRow dr)
        {
            try
            {
                return loaiXe.ThemThongTin(MaLoai, dr);
            }
            catch (Exception ex) { return false; }

        }
        public Boolean XoaLoai(int MaLoai)
        {
            try
            {
                return loaiXe.XoaLoaiXe(MaLoai);
            }
            catch (Exception ex) { return false; }

        }
    }
}
