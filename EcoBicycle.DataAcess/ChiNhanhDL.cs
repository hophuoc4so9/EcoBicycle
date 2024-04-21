using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBicycle.DataAccess
{
    public class ChiNhanhDL
    {
        DataTable cn;
        DataHelper dt = DataHelper.GetInstance();
        public ChiNhanhDL()
        {
            cn = dt.FillDataTable("select * from ChiNhanh");
        }
        public DataTable LayChiNhanh()
        {
            cn = dt.FillDataTable("select * from ChiNhanh");
            return cn;
        }
       
        public bool themMoiThemChiNhanh(string macn,String tencn,string dc)
        {
            try
            {
                dt.InsertRowtable(cn,macn, tencn, dc);
                dt.UpdateFromDataTableToDataBase("ChiNhanh", cn);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;

            }
        }
        public bool xoaChiNhanh(String macn)
        {
            try
            {
                dt.DeleteRowTable(cn, "MaCN = '" + macn+"'");
                dt.UpdateFromDataTableToDataBase("ChiNhanh", cn);
                return true;
            }
            catch (Exception ex1)
            {
                throw ex1;
                return false;

            }
        }
        public bool suaChiNhanh(String macn, String tencn, string dc)
        {
            try
            {
                String dk = "MaCN = '" + macn + "'";

                dt.UpdateRowTable(cn, dk, "TenChiNhanh", tencn, "DiaChi",dc);

                dt.UpdateFromDataTableToDataBase("ChiNhanh", cn);
                return true;
            }
            catch (Exception ex1)
            {
                throw ex1;
                return false;

            }
        }
    }
}
