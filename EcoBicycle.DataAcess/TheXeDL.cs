﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EcoBicycle.DataAccess;

namespace EcoBicycle.DataAcess
{
    public class TheXeDL
    {
        DataTable TheXE;
        DataHelper dt = DataHelper.GetInstance();
        
        public TheXeDL()
        {
            TheXE = dt.FillDataTable("select * from TheXE");
        }
        public DataTable LayTheXE()
        {
            return TheXE;
        }
        public DataRow[] TimTheXE(string MaThe, string MatKhau)
        {
            string dk = "MaThe = '" + MatKhau + "' And MatKhaus = '" + MatKhau + "'";
            DataRow[] nv = TheXE.Select(dk);
            return nv;

        }
        public Boolean HoanTraTHe(string MaThe, string MatKhau)
        {
            try
            {
                String dk = "MaThe = '" + MaThe + "'";

                dt.UpdateRowTable(TheXE, dk, "MaThe", MaThe, "MaloaiThe ", 0);

                dt.UpdateFromDataTableToDataBase("TheXE", TheXE);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }
    }
}