using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuiNguyenTruongGiang_1911060728.DataTier;
using BuiNguyenTruongGiang_1911060728.Model;

namespace BuiNguyenTruongGiang_1911060728.BusinessTier
{
    public class CongTyBusinessTier
    {
        public static List<CONGTY> GetCongTy()
        {
            return CongTyDataTier.GetCongTy();
        }

        public static string GetMaCtyByTenCty(string TenCty)
        {
            return CongTyDataTier.GetMaCtyByTenCty(TenCty);
        }

        public static List<string> GetCongTyDuongTinh()
        {
            return CongTyDataTier.GetCongTyDuongTinh();
        }

        public static string GetTenCongTyByMaCTy(string MaCty)
        {
            return CongTyDataTier.GetTenCongTyByMaCTy(MaCty);
        }
    }
}
