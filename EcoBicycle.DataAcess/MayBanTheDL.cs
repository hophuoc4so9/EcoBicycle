using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EcoBicycle.DataAccess;
using static System.Net.Mime.MediaTypeNames;
namespace EcoBicycle.DataAcess
{
    public class MayBanTheDL
    {
        DataTable MayBanThe;
        DataHelper dt = DataHelper.GetInstance();

        public MayBanTheDL()
        {
            MayBanThe = dt.FillDataTable("select * from MayBanThe");
        }
        public DataTable LayMayBanThe()
        {
            return MayBanThe;
        }
        public DataRow TimTheXE(int MaMay)
        {
            string dk = "MaMay  = '" + MaMay + "'";
            DataRow nv = MayBanThe.Select(dk).FirstOrDefault();
            return nv;

        }
        public Boolean hoanTraTHe(double soDuKH,int MaMay)
        {
            try
            {
                
                DataRow dr = TimTheXE(MaMay);
       //         var s123 = double.Parse(dr["SoDu"].ToString()) -soDuKH;

                if (soDuKH <= double.Parse(dr["SoDu"].ToString()))
                { 
                    try
                    {
                        String dk = "MaMay = '" + MaMay + "'";
                      
                        dt.UpdateRowTable(MayBanThe, dk, "SoDu", double.Parse(dr["SoDu"].ToString()) - soDuKH);

                        dt.UpdateFromDataTableToDataBase("MayBanThe", MayBanThe);
                    }
                    catch (Exception ex2)
                    {
                        return false;
                    }
                    
                    return true; 
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
