using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace EcoBicycle.DataAccess
{
    public class NhanvienDL
    {   
        DataTable nhanvien;
        DataHelper dt = DataHelper.GetInstance();
        public NhanvienDL()
        {
            nhanvien = dt.FillDataTable("select * from NhanVien");
        }
        public DataTable LayNhanvien()
        {
            return nhanvien;
        }
        public DataRow[] TimNhanVien(string username, string password)
        {
            string dk = "username = '" + username + "' And pass  = '" + password+ "'" ;
            DataRow[] nv = nhanvien.Select(dk );
            return nv;

        }
       
        }
}
