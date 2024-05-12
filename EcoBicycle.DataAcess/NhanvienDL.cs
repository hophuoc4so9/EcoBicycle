using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Remoting.Messaging;
namespace EcoBicycle.DataAccess
{
    public class NhanvienDL
    {   
        DataTable nhanvien,loaiNV;
        DataHelper dt = DataHelper.GetInstance();
        public NhanvienDL()
        {
            nhanvien = dt.FillDataTable("select * from NhanVien");
        }
        public DataTable LayNhanvien()
        {
            nhanvien = dt.FillDataTable("select * from NhanVien");
            return nhanvien;
        }
        public DataTable LayLaoiNhanvien()
        {
            loaiNV = dt.FillDataTable("select * from LoaiNhanVien");
            return loaiNV;
        }
        public DataRow[] TimNhanVien(string username, string password)
        {
            string dk = "username = '" + username + "' And pass  = '" + password+ "'" ;
            DataRow[] nv = nhanvien.Select(dk );
            return nv;

        }
        public Boolean themnv(DataRow dr)
        {
            try
            {
                nhanvien = LayNhanvien();
                DataRow dr2 = nhanvien.NewRow();
                var tam = dr2[0];
                dr2 = dr;
                dr2[0] = tam;
                dt.InsertRowtable(nhanvien,dr2.ItemArray);
                dt.UpdateFromDataTableToDataBase("NhanVien",nhanvien);
                return true;
            }
            catch (Exception e)
            {
                return
                    false;
            }

        }
        public Boolean thayDoiThongTin(int manv, DataRow dr)
        {
            try
            {

                String dk = "MaNV  = '" + manv + "'";

                dt.UpdateRowTableDungThuTuCot2(nhanvien, dk, dr.ItemArray);

                dt.UpdateFromDataTableToDataBase("NhanVien", nhanvien);




                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean XoaThongTin(int manv, DataRow dr)
        {
            try
            {

                String dk = "MaNV  = '" + manv + "'";

                dt.DeleteRowTable(nhanvien, dk);

                dt.UpdateFromDataTableToDataBase("NhanVien", nhanvien);




                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
