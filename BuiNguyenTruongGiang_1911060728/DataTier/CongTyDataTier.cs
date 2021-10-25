using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuiNguyenTruongGiang_1911060728.Model;

namespace BuiNguyenTruongGiang_1911060728.DataTier
{
    public class CongTyDataTier
    {
        public static List<CONGTY> GetCongTy()
        {
            using (var context = new Context())
            {
                return context.CONGTies.ToList();
            }
        }

        public static string GetMaCtyByTenCty(string TenCty)
        {
            using (var context = new Context())
            {
                return context.CONGTies.FirstOrDefault(p => p.TenCty.Equals(TenCty)).MaCty;
            }
        }

        public static string GetTenCongTyByMaCTy(string MaCty)
        {
            using (var context = new Context())
            {
                return context.CONGTies.FirstOrDefault(p => p.MaCty.Equals(MaCty)).TenCty;
            }
        }

        public static List<string> GetCongTyDuongTinh()
        {
            using (var context = new Context())
            {
                List<NHANVIEN> DSNhanVien = context.NHANVIENs.ToList();
                List<string> DSMaCty = new List<string>();
                foreach (var item in DSNhanVien)
                {
                    if (item.AmTinh == false && !DSMaCty.Contains(item.MaCty))
                    {
                        DSMaCty.Add(item.MaCty);
                    }
                }
                return DSMaCty;
            }
        }
    }
}
