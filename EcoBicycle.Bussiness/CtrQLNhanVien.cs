using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBicycle.DataAccess;
namespace EcoBicycle.Bussiness
{
    public class CtrQLNhanVien
    {   NhanvienDL cn=new NhanvienDL();
        ChiNhanhDL cn1 = new ChiNhanhDL();
       
        public DataTable laydsNhanVien()
        {
            return cn.LayNhanvien();
        }

        public DataTable LayLaoiNhanvien()
        {
            
            return cn.LayLaoiNhanvien();
        }
        public DataTable laydsChiNhanh()
        {
            return cn1.LayChiNhanh();
        }
        public Boolean themnv(DataRow dr)
        {
            try
            {
             
                return cn.themnv(dr);
            }
            catch (Exception e)
            {
                return
                    false;
            }

        }
        public Boolean thayDoiThongTin(int manv,DataRow dr)
        {
            try
            {




                return cn.thayDoiThongTin(manv,dr);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean XoaThongTin(int manv, DataRow dr)
        {
            try
            {




                return cn.XoaThongTin(manv,dr);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
