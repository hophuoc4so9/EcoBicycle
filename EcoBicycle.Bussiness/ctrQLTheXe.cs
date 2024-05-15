using EcoBicycle.DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBicycle.Bussiness
{
    public class ctrQLTheXe
    {
        TheXeDL the = new TheXeDL();
        public DataTable getThe()
        {
            return the.LayTheXE();
        }
        public DataTable getThedd()
        {
            return the.LayTheXEdaydu();
        }
        public bool ThemTheMoi(string mathe)
        {
            return the.ThemTheMoi(mathe);
        }
    }
}
