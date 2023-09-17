using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.BLL;
using Z.Common;
using Z.Models.DModels;
using Z.Models.VModels;

namespace Z.WMS.Product
{
    public partial class FormProductInStore : Form
    {
        ProductBLL proBLL = new ProductBLL();
        StoreRegionBLL regionBLL = new StoreRegionBLL();

        public FormProductInStore()
        {
            InitializeComponent();
        }

        List<ViewProductStoreInfo> records = new List<ViewProductStoreInfo>();
        Color selColor = Color.FromArgb(50, 100, 255); //选择按钮的背景色
        Color unSelColor = Color.FromArgb(50, 122, 200); //未选择按钮的背景色

        private void FrmProductInStore_Load(object sender, EventArgs e)
        {
            LoadCboProducts();
            FormUtility.LoadCboStores(cboStores);//加载仓库列表
            dgvProductInstores.AutoGenerateColumns = false;
            dgvProductInstores.DataSource = records;
            txtProductCount.Value = 0;
        }

        /// <summary>
        /// 加载产品下拉框
        /// </summary>
        private void LoadCboProducts()
        {
            List<ProductInfo> list = proBLL.GetAllProducts();
            list.Insert(0, new ProductInfo() { ProductId = 0, ProductName = "----请选择产品----" });
            cboProductList.DisplayMember = "ProductName";
            cboProductList.ValueMember = "ProductId";
            cboProductList.DataSource = list;
            cboProductList.SelectedIndex = 0;
        }

        private void cboStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //加载指定仓库的分区列表
            int storeId = cboStores.SelectedValue.GetInt();
            if (storeId > 0)
            {
                List<StoreRegionInfo> regionList = regionBLL.GetRegionListByStoreId(storeId);
                regionList.Insert(0, new StoreRegionInfo() { SRegionId = 0, SRegionName = "----请选择分区----" });
                cboSRegionList.DisplayMember = "SRegionName";
                cboSRegionList.ValueMember = "SRegionId";
                cboSRegionList.DataSource = regionList;
                cboSRegionList.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// 显示所有产品库存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProductList_Click(object sender, EventArgs e)
        {
            btnProductList.BackColor = selColor;
            btnInstoreRecords.BackColor = unSelColor;
            lblTypeName.Text = "产品库存数据：";
            List<ViewProductStoreInfo> storeData = proBLL.GetAllProductStoreList();
            dgvProductInstores.DataSource = storeData;
        }

        /// <summary>
        /// 显示产品入库记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInstoreRecords_Click(object sender, EventArgs e)
        {
            ShowInStoreRecords();
        }

        private void ShowInStoreRecords()
        {
            btnProductList.BackColor = unSelColor;
            btnInstoreRecords.BackColor = selColor;
            lblTypeName.Text = "入库记录：";
            dgvProductInstores.DataSource = records;
        }

        private void ResetInStoreInfo()
        {
            cboProductList.SelectedIndex = 0;
            cboStores.SelectedIndex = 0;
            cboSRegionList.DataSource = null;
            txtProductCount.Value = 0;
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetInStoreInfo();
            ShowInStoreRecords();
        }


        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetInStoreInfo();
        }

        /// <summary>
        /// 入库提交功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInstore_Click(object sender, EventArgs e)
        {
            string msgTitle = "产品入库";
            //获取入库信息设置
            int productId = cboProductList.SelectedValue.GetInt();
            int storeId = cboStores.SelectedValue.GetInt();
            int regionId = cboSRegionList.SelectedValue.GetInt();
            int productCount = txtProductCount.Value.GetInt();
            //检查  
            bool blCheck = CheckInstoreInfo(msgTitle, productId, storeId, regionId, productCount);
            if (blCheck == false) return;
            //封装信息
            ProductStoreInfo psInfo = new ProductStoreInfo()
            {
                ProductId = productId,
                StoreId = storeId,
                SRegionId = regionId,
                ProductCount = productCount
            };
            //提交
            bool blInstore = proBLL.InStoreProducts(psInfo);
            if (blInstore)
            {
                MsgBoxHelper.MsgBoxShow(msgTitle, $"产品:{cboProductList.Text} 入库成功！");
                //显示本次入库信息在左边的列表中
                ShowThisInStoreRecord(cboProductList.Text, cboStores.Text, cboSRegionList.Text, productCount);
            }
            else
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, $"产品:{cboProductList.Text} 入库失败！");
                return;
            }
        }

        /// <summary>
        /// 将本次入库记录添加到入库记录列表中
        /// </summary>
        /// <param name="proName"></param>
        /// <param name="storeName"></param>
        /// <param name="regionName"></param>
        /// <param name="productCount"></param>
        private void ShowThisInStoreRecord(string proName, string storeName, string regionName, int productCount)
        {
            //将本次入库操作的信息添加到records中
            records.Add(new ViewProductStoreInfo()
            {
                ProStoreId = records.Count + 1,
                ProductCount = productCount,
                ProductName = proName,
                StoreName = storeName,
                SRegionName = regionName
            });
            dgvProductInstores.DataSource = null;
            ShowInStoreRecords();
        }

        private bool CheckInstoreInfo(string msgTitle, int productId, int storeId, int regionId, int productCount)
        {
            if (productId == 0)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "请选择要入库的产品！");
                return false;
            }
            if (storeId == 0)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "请选择要入库的仓库！");
                return false;
            }
            if (regionId == 0)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "请选择要存储产品的仓库分区！");
                return false;
            }
            if (productCount <= 0)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "请设置有效的产品数量！");
                return false;
            }
            return true;
        }
    }
}
