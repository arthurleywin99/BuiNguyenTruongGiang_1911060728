using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuiNguyenTruongGiang_1911060728.Model;
using BuiNguyenTruongGiang_1911060728.DataTier;

namespace BuiNguyenTruongGiang_1911060728.BusinessTier
{
    public class NhanVienBusinessTier
    {
        public static List<NHANVIEN> GetNhanVien()
        {
            return NhanVienDataTier.GetNhanVien();
        }

        public static bool AddNhanVien(NHANVIEN NhanVien, out string error)
        {
            return NhanVienDataTier.AddNhanVien(NhanVien, out error);
        }

        public static bool UpdateNhanVien(string CMND, NHANVIEN NewNhanVien, out string error)
        {
            return NhanVienDataTier.UpdateNhanVien(CMND, NewNhanVien, out error);
        }
    }
}
