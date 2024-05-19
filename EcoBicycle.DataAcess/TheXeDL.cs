using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EcoBicycle.DataAccess;
using System.CodeDom;

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
        public DataTable LayTheXEdaydu()
        {
            TheXE = dt.FillDataTable("select thexe.*,TenThe from thexe, loaithe where thexe.maloaithe = loaithe.maloaithe");
         
            return TheXE;
        }
        public DataRow[] TimTheXE(string MaThe, string MatKhau)
        {
            string dk = "MaThe = " + MaThe + " And MatKhau = " + MatKhau + " AND MaloaiThe  <> 0";
           
            DataRow[] nv = TheXE.Select(dk);
         
  
            return nv;

        }
        public void capNhatThe(string maThe,string MaMay)
        {
            dt.ExecuteNonQuery("insert into ChiTietTheXeMayBan values(" + maThe + "," + MaMay + ")");
        }
        public Boolean HoanTraTHe(string MaThe, string MatKhau)
        {
            try
            {
                String dk = "MaThe = '" + MaThe + "'";

                dt.UpdateRowTable(TheXE, dk, "MaThe", MaThe, "MaloaiThe ", 0);
                
                dt.ExecuteNonQuery("insert into ChiTietTheXeMayBan values(" + MaThe + "," + MatKhau + ")");

                dt.UpdateFromDataTableToDataBase("TheXE", TheXE);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }
        public int DangkyThe(int MaMay, DataRow dr)
        {
            try
            {
                DataTable ChiTietTheXeMayBan = dt.FillDataTable("select * from ChiTietTheXeMayBan ");
                if(dt.FillDataTable("select top (1) * from ChiTietTheXeMayBan where mamay=" + MaMay).Rows.Count==0) return -2;
                DataRow dr1 = dt.FillDataTable("select top (1) * from ChiTietTheXeMayBan where mamay=" + MaMay).Rows[0];
            
                int mathe = int.Parse(dr1["MaThe"].ToString()) ;
                String dk = "MaThe = '" + mathe + "'";
                dr["MaThe"] = mathe;
                dt.UpdateRowTableDungThuTuCot(TheXE, dk, dr.ItemArray);

                dt.UpdateFromDataTableToDataBase("TheXE", TheXE);

                dt.DeleteRowTable(ChiTietTheXeMayBan, "MaMay = " + MaMay + " and Mathe =" + mathe  );
                dt.UpdateFromDataTableToDataBase("ChiTietTheXeMayBan", ChiTietTheXeMayBan);

                return mathe;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public bool PhanThe(int soluong, string macn1, string macn2)
        {

            try
            {
                DataTable db22 = dt.FillDataTable("select top(" + soluong + ") * from view_2  where MaCN ='" + macn1 + "'");
              
                if (int.Parse( db22.Rows[0]["SoThe"].ToString()) < soluong)
                {
                    return
                 false;
                }
                var t = "select * \r\nfrom MayBanThe,ChiTietTheXeMayBan\r\nwhere ChiTietTheXeMayBan.MaMay =MayBanThe.MaMay and MayBanThe.MaCn='" + macn2 + "' ";
                DataTable drrrr = dt.FillDataTable("select * from MayBanThe where  MayBanThe.MaCn='" + macn2+"' ");
                string mamay = drrrr.Rows[0]["MaMay"].ToString();
                db22 = dt.FillDataTable("select TheXE.* from ChiTietTheXeMayBan,TheXE,MayBanThe\r\nwhere ChiTietTheXeMayBan.MaThe = TheXE.MaThe and ChiTietTheXeMayBan.MaMay=MayBanThe.MaMay and MayBanThe.MaCN='" + macn1 + "'")
              ;  int i = 0;
                    ; foreach (DataRow drr in db22.Rows)
                {
                    i++;
                    var t123 ="update ChiTietTheXeMayBan\r\nset MaCN='" + macn2 + "' \r\nfrom MayBanThe,ChiTietTheXeMayBan\r\nwhere ChiTietTheXeMayBan.MaMay =MayBanThe.MaMay and MayBanThe.MaCN='" + macn1 + "' and mathe=" + drr["MaThe"];

                    dt.ExecuteNonQuery("update ChiTietTheXeMayBan\r\nset ChiTietTheXeMayBan.MaMay='" + mamay+"' \r\nfrom MayBanThe,ChiTietTheXeMayBan\r\nwhere ChiTietTheXeMayBan.MaMay =MayBanThe.MaMay and MayBanThe.MaCN='"+macn1+"' and mathe=" + drr["MaThe"]  );
                    if (i >= soluong) break;
                }

                return true;
            }
            catch (Exception e)
            {
                return
                    false;
            }
        }
        public Boolean thayDoiThongTin(int MaThe, DataRow dr)
        {
            try
            {
               
                String dk = "MaThe = '" + MaThe + "'";
               
                dt.UpdateRowTableDungThuTuCot(TheXE, dk, dr.ItemArray);

                dt.UpdateFromDataTableToDataBase("TheXE", TheXE);

                


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean ThemTheMoi( string mathe)
        {
            try
            {

                dt.ExecuteNonQuery("insert into TheXE values(" + mathe + ",111111,null,null,100000000,1,N'',1,'0349146401')");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean napTien(int MaThe, DataRow dr)
        {
            try
            {

                String dk = "MaThe = '" + MaThe + "'";

                dt.UpdateRowTable(TheXE, dk, "SoDu", dr["SoDu"].ToString());

                dt.UpdateFromDataTableToDataBase("TheXE", TheXE);




                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        
    }
}
