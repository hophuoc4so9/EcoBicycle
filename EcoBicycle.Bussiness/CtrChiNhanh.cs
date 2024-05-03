using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBicycle.DataAccess;
namespace EcoBicycle.Bussiness
{
    public class CtrChiNhanh
    {
        ChiNhanhDL cn = new ChiNhanhDL();
        public bool ThemtenChiNhanh (string macn, String tencn, string dc)
        {
            
            try
            {
                 cn.themMoiThemChiNhanh(macn,tencn,dc);
              return true;
            }
            catch (Exception e) { return 
                    false; }
        }
        public DataTable laydsChiNhanh()
        {
            return cn.LayChiNhanh();    
        }
        public DataTable LayChiNhanhDayDu()
        {
            return cn.LayChiNhanhDayDu();
        }    
        public bool suaChiNhanh(String tencn, String macn,string dc)
        {

            try
            {  
                cn.suaChiNhanh(tencn,macn,dc);
                return true;
            }
            catch (Exception e)
            {
                return
                    false;
            }
        }
        public bool xoaChiNhanh(String s)
        {

            try
            {
             bool t =    cn.xoaChiNhanh(s);
                return t;
            }
            catch (Exception e)
            {
                return
                    false;
            }
        }
    }
}
