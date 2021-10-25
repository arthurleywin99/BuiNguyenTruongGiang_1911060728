using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuiNguyenTruongGiang_1911060728.Model;
using BuiNguyenTruongGiang_1911060728.BusinessTier;
using System.Text.RegularExpressions;

namespace BuiNguyenTruongGiang_1911060728
{
    public partial class ThongTinXetNghiem : Form
    {
        private DataTable data;
        public ThongTinXetNghiem()
        {
            InitializeComponent();
        }

        private void ThongTinXetNghiem_Load(object sender, EventArgs e)
        {
            InitDataTable();
            SetDefault();
        }

        private void SetDefault()
        {
            FillCongTy();
            txtCMND.Text = "";
            grTTXN.Enabled = false;
            txtHoTen.Text = "";
            txtSLXN.Text = "1";
            txtSLXN.ReadOnly = true;
            optAmTinh.Enabled = true;
            cboCongTy.SelectedIndex = 0;
        }

        private void InitDataTable()
        {
            data = new DataTable();
            data.Columns.Add("CMND/CCCD", typeof(string));
            data.Columns.Add("Họ và Tên", typeof(string));
            data.Columns.Add("Số lần XN", typeof(int));
            data.Columns.Add("Kết quả", typeof(string));
            dgvTTXN.DataSource = data;
        }

        private void FillNhanVien()
        {
            List<NHANVIEN> list = NhanVienBusinessTier.GetNhanVien();
            data.Rows.Clear();
            foreach (var item in list)
            {
                DataRow row = data.NewRow();
                row["CMND/CCCD"] = item.ID;
                row["Họ và Tên"] = item.HoTen;
                row["Số lần XN"] = item.SoLanXN;
                if (item.AmTinh == true)
                {
                    row["Kết quả"] = "Âm Tính";
                }
                else
                {
                    row["Kết quả"] = "+";
                }
                data.Rows.Add(row);
            }
            dgvTTXN.DataSource = data;
        }

        private void FillCongTy()
        {
            List<CONGTY> list = CongTyBusinessTier.GetCongTy();
            foreach (var item in list)
            {
                cboCongTy.Items.Add(item.TenCty);
            }
            cboCongTy.SelectedIndex = 0;
        }

        private int TimCMND(string CMND)
        {
            for (int i = 0; i < dgvTTXN.Rows.Count - 1; ++i)
            {
                if (dgvTTXN.Rows[i].Cells[0].Value.ToString().Equals(txtCMND.Text))
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string error = string.Empty;
            if (IsValid(out error))
            {
                if (TimCMND(txtCMND.Text) == -1)
                {
                    grTTXN.Enabled = true;
                    txtHoTen.Text = "";
                    txtSLXN.ReadOnly = false;
                    optAmTinh.Checked = true;
                    cboCongTy.SelectedIndex = 0;
                }
                else
                {
                    int index = TimCMND(txtCMND.Text);
                    grTTXN.Enabled = true;
                    txtSLXN.ReadOnly = true;
                    txtHoTen.Text = dgvTTXN.Rows[index].Cells[1].Value.ToString();
                    txtSLXN.Text = (int.Parse(dgvTTXN.Rows[index].Cells[2].Value.ToString()) + 1).ToString();
                    if (dgvTTXN.Rows[index].Cells[1].Value.ToString().Equals("Âm Tính"))
                    {
                        optDuongTinh.Checked = true;
                    }
                    else
                    {
                        optAmTinh.Checked = true;
                    }
                    cboCongTy.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private bool IsValid(out string Error)
        {
            Error = string.Empty;
            try
            {
                if (!(txtCMND.Text.Length == 12 || txtCMND.Text.Length == 9))
                {
                    throw new Exception("Vui lòng nhập CCCD hoặc CMND");
                }
                if (!Regex.IsMatch(txtCMND.Text, @"^[0-9]+$"))
                {
                    throw new Exception("“ID chỉ là các kí tự số");
                }
            }
            catch (Exception ex)
            {
                Error = ex.ToString();
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (TimCMND(txtCMND.Text) == -1)
            {
                string Error = string.Empty;
                if (NhanVienBusinessTier.AddNhanVien(GetNhanVienTuForm, out Error))
                {
                    MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK);
                    SetDefault();
                    FillNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Lỗi: " + Error, "Lỗi", MessageBoxButtons.OK);
                }
            }
            else
            {
                string Error = string.Empty;
                if (NhanVienBusinessTier.UpdateNhanVien(txtCMND.Text, GetNhanVienTuForm, out Error))
                {
                    MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK);
                    SetDefault();
                    FillNhanVien();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Lỗi: " + Error, "Lỗi", MessageBoxButtons.OK);
                }
            }
        }

        private NHANVIEN GetNhanVienTuForm => new NHANVIEN()
        {
            ID = txtCMND.Text,
            HoTen = txtHoTen.Text,
            SoLanXN = int.Parse(txtSLXN.Text),
            AmTinh = optAmTinh.Checked == true ? true : false,
            MaCty = CongTyBusinessTier.GetMaCtyByTenCty(cboCongTy.Text)
        };

        private void tsSapXep_Click(object sender, EventArgs e)
        {
            DataTable SortData = new DataTable();
            SortData.Columns.Add("CMND/CCCD", typeof(string));
            SortData.Columns.Add("Họ và Tên", typeof(string));
            SortData.Columns.Add("Số lần XN", typeof(int));
            SortData.Columns.Add("Kết quả", typeof(string));

            List<NHANVIEN> sortList = NhanVienBusinessTier.GetNhanVien()
                .OrderByDescending(p => p.SoLanXN).ToList();
            
            foreach (var item in sortList)
            {
                DataRow row = SortData.NewRow();
                row["CMND/CCCD"] = item.ID;
                row["Họ và Tên"] = item.HoTen;
                row["Số lần XN"] = item.SoLanXN;
                row["Kết quả"] = !item.AmTinh ? "+" : "Âm Tính";
                SortData.Rows.Add(row);
            }
            dgvTTXN.DataSource = SortData;
        }

        private void tsDuongTinh_Click(object sender, EventArgs e)
        {
            string Notification = "Danh Sách công ty có ca dương tính:\n";
            List<string> DSCty = CongTyBusinessTier.GetCongTyDuongTinh();
            for (int i = 0; i < DSCty.Count; ++i)
            {
                Notification += (i + 1).ToString() + ". " +  CongTyBusinessTier.GetTenCongTyByMaCTy(DSCty[i]) + "\n";
            }
            MessageBox.Show(Notification, "Thông báo", MessageBoxButtons.OK);
        }

        private void tsThongKe_Click(object sender, EventArgs e)
        {
            new THONGKE().ShowDialog();
        }
    }
}
