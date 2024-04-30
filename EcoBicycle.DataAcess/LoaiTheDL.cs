using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EcoBicycle.DataAccess;

namespace EcoBicycle.DataAcess
{
    public class LoaiTheDL
    {
        DataTable LoaiThe;
        DataHelper dt = DataHelper.GetInstance();
        
        public LoaiTheDL()
        {
            LoaiThe = dt.FillDataTable("select * from LoaiThe ");
        }
        public DataTable LayLoaiTheXE()
        {
            DataRow[] t =LoaiThe.Select("MaloaiThe <> 0");
            return t.CopyToDataTable();
        }
        
       
    }
}
