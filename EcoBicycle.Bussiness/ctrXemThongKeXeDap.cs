using EcoBicycle.Bussiness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBicycle.DataAccess;
namespace EcoBicycle.Bussiness
{
    public class ctrXemThongKeXeDap
    {
        XemThongKeXeDaoDL   db= new XemThongKeXeDaoDL();
        public DataTable layThongKeXeDap()
        {
            //      db = dt.FillDataTable("select * from View_DoanhThu\r\n");
            return db.layThongKeXeDap();
        }
    }
}
