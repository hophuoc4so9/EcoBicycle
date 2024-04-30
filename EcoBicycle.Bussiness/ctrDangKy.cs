using EcoBicycle.DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBicycle.Bussiness
{
    public class ctrDangKy
    {
        LoaiTheDL LoaiThe= new LoaiTheDL();
        public DataTable LayLoaiTheXE()
        {
            return LoaiThe.LayLoaiTheXE();
        }

    }
}
