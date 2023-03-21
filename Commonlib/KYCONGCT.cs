﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data;
namespace Commonlib
{
   public class KYCONGCT
    {

        QL_NSEntities db = new QL_NSEntities();

        public List<KYCONGCHITIET> getList(int makycong)
        {
            return db.KYCONGCHITIET.Where(x => x.MAKYCONG == makycong).ToList();
        }

        public KYCONGCHITIET getid(int makycong, string manv)
        {
            return db.KYCONGCHITIET.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV==manv);
        }
        public KYCONGCHITIET Update(KYCONGCHITIET kcct)
        {
            var kycongchitiet = db.KYCONGCHITIET.FirstOrDefault(x=>x.MAKYCONG== kcct.MAKYCONG && x.MANV== kcct.MANV);
            kycongchitiet.D1 = kcct.D1;
            kycongchitiet.D2 = kcct.D2;
            kycongchitiet.D3 = kcct.D3;
            kycongchitiet.D4 = kcct.D4;
            kycongchitiet.D5 = kcct.D5;
            kycongchitiet.D6 = kcct.D6;
            kycongchitiet.D7 = kcct.D7;
            kycongchitiet.D8 = kcct.D8;
            kycongchitiet.D9 = kcct.D9;
            kycongchitiet.D10 = kcct.D10;
            kycongchitiet.D11 = kcct.D11;
            kycongchitiet.D12 = kcct.D12;
            kycongchitiet.D13 = kcct.D13;
            kycongchitiet.D14 = kcct.D14;
            kycongchitiet.D15 = kcct.D15;
            kycongchitiet.D16 = kcct.D16;
            kycongchitiet.D17 = kcct.D17;
            kycongchitiet.D18 = kcct.D18;
            kycongchitiet.D19 = kcct.D19;
            kycongchitiet.D20 = kcct.D20;
            kycongchitiet.D21 = kcct.D21;
            kycongchitiet.D22 = kcct.D22;
            kycongchitiet.D23 = kcct.D23;
            kycongchitiet.D24 = kcct.D24;
            kycongchitiet.D25 = kcct.D25;
            kycongchitiet.D26 = kcct.D26;
            kycongchitiet.D27 = kcct.D27;
            kycongchitiet.D28 = kcct.D28;
            kycongchitiet.D29 = kcct.D29;
            kycongchitiet.D30 = kcct.D30;
            kycongchitiet.D31 = kcct.D31;
            kycongchitiet.NGAYPHEP = kcct.NGAYPHEP;
            kycongchitiet.CONGNGAYLE = kcct.CONGNGAYLE;
            kycongchitiet.CONGCHUNHAT = kcct.CONGCHUNHAT;
            kycongchitiet.NGHIKHONGPHEP = kcct.NGHIKHONGPHEP;
            kycongchitiet.TONGNGAYCONG = kcct.TONGNGAYCONG;
            db.SaveChanges();
            return kycongchitiet;

        }
        public void phatSinhKyCongChiTiet(int thang, int nam)
        {
            var lstNV = db.NhanVien.Where(x=>x.DangLamViec==null).ToList();
            if (lstNV.Count == 0) return;

            foreach (var item in lstNV)
            {
                List<string> listDay = new List<string>();

                for (int j = 1; j <= GetDayNumber(thang, nam); j++)
                {
                    DateTime newDate = new DateTime(nam, thang, j);

                    switch (newDate.DayOfWeek.ToString())
                    {
                        case "Sunday":
                            listDay.Add("CN");
                            break;
                     /*   case "Saturday":
                            listDay.Add("T7");
                            break;*/
                        default:
                            listDay.Add("X");
                            break;
                    }
                }

                switch (listDay.Count)
                {
                    case 28:
                        listDay.Add("");
                        listDay.Add("");
                        listDay.Add("");
                        break;
                    case 29:
                        listDay.Add("");
                        listDay.Add("");
                        break;
                    case 30:
                        listDay.Add("");
                        break;
                }

                KYCONGCHITIET kycongchitiet = new KYCONGCHITIET();
                kycongchitiet.MAKYCONG = nam * 100 + thang;
                kycongchitiet.MANV = item.MaNV;
                kycongchitiet.HOTEN = item.TenNV;
                kycongchitiet.D1 = listDay[0];
                kycongchitiet.D2 = listDay[1];
                kycongchitiet.D3 = listDay[2];
                kycongchitiet.D4 = listDay[3];
                kycongchitiet.D5 = listDay[4];
                kycongchitiet.D6 = listDay[5];
                kycongchitiet.D7 = listDay[6];
                kycongchitiet.D8 = listDay[7];
                kycongchitiet.D9 = listDay[8];
                kycongchitiet.D10 = listDay[9];
                kycongchitiet.D11 = listDay[10];
                kycongchitiet.D12 = listDay[11];
                kycongchitiet.D13 = listDay[12];
                kycongchitiet.D14 = listDay[13];
                kycongchitiet.D15 = listDay[14];
                kycongchitiet.D16 = listDay[15];
                kycongchitiet.D17 = listDay[16];
                kycongchitiet.D18 = listDay[17];
                kycongchitiet.D19 = listDay[18];
                kycongchitiet.D20 = listDay[19];
                kycongchitiet.D21 = listDay[20];
                kycongchitiet.D22 = listDay[21];
                kycongchitiet.D23 = listDay[22];
                kycongchitiet.D24 = listDay[23];
                kycongchitiet.D25 = listDay[24];
                kycongchitiet.D26 = listDay[25];
                kycongchitiet.D27 = listDay[26];
                kycongchitiet.D28 = listDay[27];
                kycongchitiet.D29 = listDay[28];
                kycongchitiet.D30 = listDay[29];
                kycongchitiet.D31 = listDay[30];
                kycongchitiet.NGAYCONG = ClassApp.demSoNgayLamViecTrongThang(thang,nam);
                kycongchitiet.TONGNGAYCONG = ClassApp.demSoNgayLamViecTrongThang(thang, nam);
                db.KYCONGCHITIET.Add(kycongchitiet);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
              
            }

        }

        private int GetDayNumber(int thang, int nam)
        {
            int dayNumber = 0;
            switch (thang)
            {
                case 2:
                    dayNumber = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    dayNumber = 30;
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dayNumber = 31;
                    break;
            }

            return dayNumber;
        }
    }
}