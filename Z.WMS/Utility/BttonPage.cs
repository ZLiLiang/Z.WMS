using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Z.WMS.Product;
using Z.WMS.Properties;
using Z.WMS.Store;
using Z.WMS.StoreTemper;
using Z.WMS.UControls;

namespace Z.WMS
{
    public class BttonPage
    {
        private ComponentResourceManager resources = new ComponentResourceManager(typeof(FormMain));
        private UPageButton btnStorePage;
        private UPageButton btnSRegionPage;
        private UPageButton btnProductInStorePage;
        private UPageButton btnProductPage;
        private UPageButton btnStoreTemperPage;

        public BttonPage()
        {
            BuildBtnStorePage();
            BuildBtnSRegionPage();
            BuildBtnProductInStorePage();
            BuildBtnProductPage();
            BuildBtnStoreTemperPage();
        }

        public UPageButton BtnStorePage
        {
            get => btnStorePage;
        }
        public UPageButton BtnSRegionPage
        {
            get => btnSRegionPage;
        }
        public UPageButton BtnProductInStorePage
        {
            get => btnProductInStorePage;
        }
        public UPageButton BtnProductPage
        {
            get => btnProductPage;
        }
        public UPageButton BtnStoreTemperPage
        {
            get => btnStoreTemperPage;
        }

        #region 构建按钮

        private void BuildBtnStorePage()
        {
            btnStorePage = new UPageButton();
            btnStorePage.BackColor = System.Drawing.Color.Transparent;
            btnStorePage.BackgroundImage = Resources.btnbg01;
            btnStorePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnStorePage.BtnText = "仓库管理页面";
            btnStorePage.Location = new System.Drawing.Point(3, -1);
            btnStorePage.Name = "btnStorePage";
            btnStorePage.Size = new System.Drawing.Size(165, 40);
            btnStorePage.TabIndex = 0;
            btnStorePage.Tag = typeof(FormStoreList).FullName;
        }

        private void BuildBtnSRegionPage()
        {
            btnSRegionPage = new UPageButton();
            btnSRegionPage.BackColor = System.Drawing.Color.Transparent;
            btnSRegionPage.BackgroundImage = Resources.btnbg02;
            btnSRegionPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSRegionPage.BtnText = "仓库分区页面";
            btnSRegionPage.Location = new System.Drawing.Point(198, -1);
            btnSRegionPage.Name = "btnSRegionPage";
            btnSRegionPage.Size = new System.Drawing.Size(165, 40);
            btnSRegionPage.TabIndex = 1;
            btnSRegionPage.Tag = typeof(FormStoreRegionList).FullName;
        }

        private void BuildBtnProductInStorePage()
        {
            btnProductInStorePage = new UPageButton();
            btnProductInStorePage.BackColor = System.Drawing.Color.Transparent;
            btnProductInStorePage.BackgroundImage = Resources.btnbg04;
            btnProductInStorePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnProductInStorePage.BtnText = "产品入库页面";
            btnProductInStorePage.Location = new System.Drawing.Point(3, -1);
            btnProductInStorePage.Name = "btnProductInStorePage";
            btnProductInStorePage.Size = new System.Drawing.Size(165, 40);
            btnProductInStorePage.TabIndex = 1;
            btnProductInStorePage.Tag = typeof(FormProductInStore).FullName;
        }

        private void BuildBtnProductPage()
        {
            btnProductPage = new UPageButton();
            btnProductPage.BackColor = System.Drawing.Color.Transparent;
            btnProductPage.BackgroundImage = Resources.btnbg03;
            btnProductPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnProductPage.BtnText = "产品管理页面";
            btnProductPage.Location = new System.Drawing.Point(198, -1);
            btnProductPage.Name = "btnProductPage";
            btnProductPage.Size = new System.Drawing.Size(165, 40);
            btnProductPage.TabIndex = 1;
            btnProductPage.Tag = typeof(FormProductList).FullName;
        }

        private void BuildBtnStoreTemperPage()
        {
            btnStoreTemperPage = new UPageButton();
            btnStoreTemperPage.BackColor = System.Drawing.Color.Transparent;
            btnStoreTemperPage.BackgroundImage = Resources.btnbg05;
            btnStoreTemperPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnStoreTemperPage.BtnText = "仓库温控页面";
            btnStoreTemperPage.Location = new System.Drawing.Point(3, -1);
            btnStoreTemperPage.Name = "btnStoreTemperPage";
            btnStoreTemperPage.Size = new System.Drawing.Size(165, 40);
            btnStoreTemperPage.TabIndex = 1;
            btnStoreTemperPage.Tag = typeof(FormStoreRegionTemperatureList).FullName;
        }

        #endregion


    }
}
