using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuiNguyenTruongGiang_1911060728.Model;

namespace BuiNguyenTruongGiang_1911060728.DataTier
{
    public class NhanVienDataTier
    {
        public static List<NHANVIEN> GetNhanVien()
        {
            using (var context = new Context())
            {
                return context.NHANVIENs.ToList();
            }
        }

        public static bool AddNhanVien(NHANVIEN NhanVien, out string error)
        {
            using (var context = new Context())
            {
                error = string.Empty;
                try
                {
                    context.NHANVIENs.Add(NhanVien);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    error = ex.ToString();
                    return false;
                } 
            }
        }

        public static bool UpdateNhanVien(string CMND, NHANVIEN NewNhanVien, out string error)
        {
            using (var context = new Context())
            {
                error = string.Empty;
                try
                {
                    var NhanVien = context.NHANVIENs.FirstOrDefault(p => p.ID.Equals(CMND));
                    NhanVien.HoTen = NewNhanVien.HoTen;
                    NhanVien.SoLanXN = NewNhanVien.SoLanXN;
                    NhanVien.AmTinh = NewNhanVien.AmTinh;
                    NhanVien.MaCty = NewNhanVien.MaCty;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    error = ex.ToString();
                    return false;
                }
            }
        }
    }
}
