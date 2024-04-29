using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EcoBicycle.DataAccess;
namespace EcoBicycle.DataAcess
{
    public class MayBanTheDL
    {
        DataTable MayBanThe;
        DataHelper dt = DataHelper.GetInstance();

        public MayBanTheDL()
        {
            MayBanThe = dt.FillDataTable("select * from TheXE");
        }
        public DataTable LayMayBanThe()
        {
            return MayBanThe;
        }
        public DataRow TimTheXE(string MaMay)
        {
            string dk = "MaMay  = '" + MaMay + "'";
            DataRow nv = MayBanThe.Select(dk).FirstOrDefault();
            return nv;

        }
        public Boolean hoanTraTHe(double soDuKH,string MaMay)
        {
            try
            {
                DataRow dr = TimTheXE(MaMay);
                if (soDuKH > double.Parse(dr["SoDu"].ToString())) return true;
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
