using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using EcoBicycle.DataAccess;

namespace EcoBicycle.Bussiness
 {  
    public  class CtrDangNhap
        {

        NhanvienDL nv = new NhanvienDL();
            public bool login(string userName, string password)
            {
                DataRow[] user = nv.TimNhanVien(userName, password); 
            if (user.Length > 0)
                {
                    
                    return true;
                }
                return false;
            }
        }

}

