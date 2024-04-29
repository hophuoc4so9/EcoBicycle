using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBicycle.DataAcess;

namespace EcoBicycle.Bussiness
{
    public class ctrHoanTraThe
    {
        MayBanTheDL may = new MayBanTheDL();
        TheXeDL theXe = new TheXeDL();
        public Boolean hoanTraThe(int MatKhau)
        {
            try
            {
                

                return true;

            }catch(Exception)
            {
                return false;
            }
        }

    }
}
