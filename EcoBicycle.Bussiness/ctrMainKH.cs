using EcoBicycle.DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EcoBicycle.Bussiness
{
    public class ctrMainKH
    {
        MayBanTheDL mayBan = new MayBanTheDL();
        TheXeDL theXe = new TheXeDL();
        public DataTable LayMayBanThe()
        {
            return mayBan.LayMayBanThe();
        }
        public void logout()
        {
            infoLoginKH.clear();
        }
        public Boolean Thaydoithongtin(int mathe)
        {
            try
            {
                DataRow dr = theXe.LayTheXE().NewRow();
                dr["MaThe"] = mathe;
                dr["MatKhau"] = 111111;
                dr["MaloaiThe"] = 0;
                
                return theXe.thayDoiThongTin(mathe, dr);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean NapTien(int mathe,int soDu)
        {
            try
            {
                DataRow dr = theXe.LayTheXE().NewRow();
                dr["MaThe"] = mathe;
          var t = infoLoginKH.SoDu + soDu;
                dr["SoDu"] = t;
                

                return theXe.napTien(mathe, dr);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public void capNhatThe(string mathe, string mamay)
        {
            theXe.capNhatThe(mathe, mamay);
        }
        public Boolean checksodu(double sodu,int mamay)
        {
            try
            {
              

                return mayBan.hoanTraTHe(sodu, mamay);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
