using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Common;
using Z.DAL;
using Z.Models.VModels;

namespace Z.WMS.Report
{
    public partial class FormVSRTReport : Form
    {
        public FormVSRTReport()
        {
            InitializeComponent();
        }

        ViewSRegionTemperDAL vsrtDAL = new ViewSRegionTemperDAL();
        List<ViewSRegionTemperInfo> res = null;

        private void FormVSRTReport_Load(object sender, EventArgs e)
        {
            this.DGVRefresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.DGVRefresh();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "选择文件夹";
            if (dialog.ShowDialog() == DialogResult.OK && res != null)
            {
                var fileName = Path.Combine(dialog.SelectedPath, $"仓库分区温度_{DateTime.Now.ToString("yyyy-MM-dd")}.xlsx");
                ExcelHelper.ToExcel(fileName, res);
            }
        }

        /// <summary>
        /// 为dgv绑定数据
        /// </summary>
        private void DGVRefresh()
        {
            res = vsrtDAL.GetAllSRegionTemperList();
            dgvVPSList.DataSource = res.Select(e => new
            {
                e.StoreId,
                e.SRegionId,
                e.TotalCount,
                e.SRegionName,
                e.SRTemperature,
                e.AllowLowTemperature,
                e.AllowHighTemperature,
            }).ToList();
        }
    }
}
