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
    public partial class FormVSRReport : Form
    {
        public FormVSRReport()
        {
            InitializeComponent();
        }

        ViewStoreRegionDAL vsrDAL = new ViewStoreRegionDAL();
        List<ViewStoreRegionInfo> res = null;

        private void FormVSRReport_Load(object sender, EventArgs e)
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
                var fileName = Path.Combine(dialog.SelectedPath, $"仓库分区_{DateTime.Now.ToString("yyyy-MM-dd")}.xlsx");
                ExcelHelper.ToExcel(fileName, res);
            }
        }

        /// <summary>
        /// 为dgv绑定数据
        /// </summary>
        private void DGVRefresh()
        {
            res = vsrDAL.GetAllStoreRegionList();
            dgvVSRList.DataSource = res.Select(e => new
            {
                e.StoreId,
                e.StoreName,
                e.TemperState,
                e.SRegionId,
                e.SRegionName,
                e.SRegionNo,
                e.SRTemperature,
                e.AllowHighTemperature,
                e.AllowLowTemperature,
                e.Remark
            }).ToList();
        }
    }
}
