using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuiNguyenTruongGiang_1911060728.BusinessTier;
using BuiNguyenTruongGiang_1911060728.Model;

namespace BuiNguyenTruongGiang_1911060728
{
    public partial class THONGKE : Form
    {
        public THONGKE()
        {
            InitializeComponent();
        }

        private void THONGKE_Load(object sender, EventArgs e)
        {
            Context context = new Context();
            var list = (from c in context.CONGTies
                        join d in context.NHANVIENs
                        on c.MaCty equals d.MaCty
                        select c).ToList();

            this.reportViewer1.RefreshReport();

            this.reportViewer1.LocalReport.ReportPath = "../../BaoCao.rdlc";
            var reportDataSource = new ReportDataSource("DataSet", list);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
