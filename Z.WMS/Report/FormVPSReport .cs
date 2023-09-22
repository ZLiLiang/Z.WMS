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
    public partial class FormVPSReport : Form
    {
        public FormVPSReport()
        {
            InitializeComponent();
        }

        ViewProductStoreDAL vpsDAL = new ViewProductStoreDAL();
        List<ViewProductStoreInfo> res = null;

        private void FormVPSReport_Load(object sender, EventArgs e)
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
                var fileName = Path.Combine(dialog.SelectedPath, $"产品仓库_{DateTime.Now.ToString("yyyy-MM-dd")}.xlsx");
                ExcelHelper.ToExcel(fileName, res);
            }
        }

        /// <summary>
        /// 为dgv绑定数据
        /// </summary>
        private void DGVRefresh()
        {
            res = vpsDAL.GetAllProductStoreList();
            dgvVPSList.DataSource = res.Select(e => new
            {
                e.ProductId,
                e.ProStoreId,
                e.ProductName,
                e.StoreId,
                e.StoreName,
                e.SRegionId,
                e.SRegionName,
                e.ProductCount
            }).ToList();
        }
    }
}
