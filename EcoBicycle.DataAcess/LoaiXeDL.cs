using EcoBicycle.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EcoBicycle.DataAcess
{
    public class LoaiXeDL
    {
        DataHelper dt= DataHelper.GetInstance();
        DataTable loaiXe;
        public DataTable getLoaiXe()
        {
            loaiXe = dt.FillDataTable("select * from LoaiXe");
            return loaiXe;
        }
        public Boolean thayDoiThongTin(int MaLoai, DataRow dr)
        {
            try
            {
                String dk = "MaLoai  = '" + MaLoai + "'";

                dt.UpdateRowTableDungThuTuCot(loaiXe, dk, dr.ItemArray);

                dt.UpdateFromDataTableToDataBase("LoaiXe", loaiXe);




                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean ThemThongTin(int MaLoai, DataRow dr)
        {
            try
            {
                
             

                dt.InsertRowtable(loaiXe, dr.ItemArray);

                dt.UpdateFromDataTableToDataBase("LoaiXe", loaiXe);

               

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean XoaLoaiXe(int MaLoai)
        {
            try
            {
                String dk = "MaLoai = '" + MaLoai + "'";

                dt.DeleteRowTable(loaiXe, dk);

                dt.UpdateFromDataTableToDataBase("LoaiXe", loaiXe);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
