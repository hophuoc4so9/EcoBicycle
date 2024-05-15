using EcoBicycle.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBicycle.DataAcess
{
    public class XeDL
    {
        DataHelper dt= DataHelper.GetInstance();
        DataTable xe;
        DataTable xedl;
        DataTable trangthaixe;
        public  XeDL()
        {
            xedl = dt.FillDataTable("select * from viewxe_2");
            xe = dt.FillDataTable("select * from Xe");

        }
        public DataTable laydsXe()
        {
            xedl = dt.FillDataTable("select * from viewxe_2");
            xe = dt.FillDataTable("select * from Xe");
            return xedl;
        }
        public DataTable laytranthai()
        {
            trangthaixe = dt.FillDataTable("select * from TrangThaiXe");
            return trangthaixe;

        }
        public bool ThemXe(int Maloai)
        {

            try
            {
                dt.ExecuteNonQuery("insert into Xe(maloai,matt) values("+Maloai+",0)",null);
                return true;
            }
            catch (Exception e)
            {
                return
                    false;
            }
        }
        public bool SuaXe(int maxe,int Maloai,int matrangthai,string macn)
        {

            try
            {
                string s = "exec usp_suaThongTinXe " + maxe + "," + Maloai + "," + matrangthai + ", N'" + macn + "';";
                dt.ExecuteNonQuery("exec usp_suaThongTinXe "+maxe+","+Maloai+","+matrangthai+", N'"+macn+"';");
                return true;
            }
            catch (Exception e)
            {
                return
                    false;
            }
        }
        public bool PhanBoXe(int soluong, string macn1,string macn2)
        {

            try
            {
                DataTable db22 = dt.FillDataTable("select top(" + soluong + ") * from viewxe_1  where MaCN ='" + macn1 + "'");
                if(db22.Rows.Count < soluong)
                {
                    return
                 false;
                }    
                foreach(DataRow drr in db22.Rows)
                {
                    dt.ExecuteNonQuery("exec usp_suaThongTinXe " + drr["maxe"] + "," + drr["Maloai"]  + "," + drr["matt"]  + ", N'" + macn2 + "';");
                }    
           
                return true;
            }
            catch (Exception e)
            {
                return
                    false;
            }
        }
        public bool xoaXe(int Maxe)
        {
            try
            {
                dt.DeleteRowTable(xe, "Maxe = '" + Maxe + "'");
                dt.UpdateFromDataTableToDataBase("Xe", xe);
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
