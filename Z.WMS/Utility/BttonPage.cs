using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Z.WMS.Product;
using Z.WMS.Properties;
using Z.WMS.Report;
using Z.WMS.Store;
using Z.WMS.StoreTemper;
using Z.WMS.UControls;
using Z.WMS.User;

namespace Z.WMS
{
    public class BttonPage
    {
        /// <summary>
        /// 仓库管理
        /// </summary>
        private UPageButton btnStorePage;
        private UPageButton btnSRegionPage;

        /// <summary>
        /// 产品管理
        /// </summary>
        private UPageButton btnProductInStorePage;
        private UPageButton btnProductPage;

        /// <summary>
        /// 仓库温度管理
        /// </summary>
        private UPageButton btnStoreTemperPage;

        /// <summary>
        /// 报表管理
        /// </summary>
        private UPageButton btnVPSPage;
        private UPageButton btnVSRTPage;
        private UPageButton btnVSRPage;

        /// <summary>
        /// 用户管理
        /// </summary>
        private UPageButton btnUserListPage;


        public BttonPage()
        {
            BuildBtnStorePage();
            BuildBtnSRegionPage();
            BuildBtnProductInStorePage();
            BuildBtnProductPage();
            BuildBtnStoreTemperPage();
            BuildBtnUserListPage();
            BuildBtnVPSPage();
            BuildBtnVSRPage();
            BuildBtnVSRTPage();
        }

        /// <summary>
        /// 仓库管理
        /// </summary>
        public UPageButton BtnStorePage
        {
            get => btnStorePage;
        }
        public UPageButton BtnSRegionPage
        {
            get => btnSRegionPage;
        }

        /// <summary>
        /// 产品管理
        /// </summary>
        public UPageButton BtnProductInStorePage
        {
            get => btnProductInStorePage;
        }
        public UPageButton BtnProductPage
        {
            get => btnProductPage;
        }

        /// <summary>
        /// 仓库温度管理
        /// </summary>
        public UPageButton BtnStoreTemperPage
        {
            get => btnStoreTemperPage;
        }

        /// <summary>
        /// 报表管理
        /// </summary>
        public UPageButton BtnVPSPage
        {
            get => btnVPSPage;
        }
        public UPageButton BtnVSRTPage
        {
            get => btnVSRTPage;
        }
        public UPageButton BtnVSRPage
        {
            get => btnVSRPage;
        }

        /// <summary>
        /// 用户管理
        /// </summary>
        public UPageButton BtnUserListPage
        {
            get => btnUserListPage;
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

        private void BuildBtnUserListPage()
        {
            btnUserListPage = new UPageButton();
            btnUserListPage.BackColor = System.Drawing.Color.Transparent;
            btnUserListPage.BackgroundImage = Resources.btnbg05;
            btnUserListPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnUserListPage.BtnText = "用户管理页面";
            btnUserListPage.Location = new System.Drawing.Point(3, -1);
            btnUserListPage.Name = "btnUserListPage";
            btnUserListPage.Size = new System.Drawing.Size(165, 40);
            btnUserListPage.TabIndex = 0;
            btnUserListPage.Tag = typeof(FormUserList).FullName;
        }

        private void BuildBtnVPSPage()
        {
            btnVPSPage = new UPageButton();
            btnVPSPage.BackColor = System.Drawing.Color.Transparent;
            btnVPSPage.BackgroundImage = Resources.btnbg01;
            btnVPSPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnVPSPage.BtnText = "产品仓库页面";
            btnVPSPage.Location = new System.Drawing.Point(3, -1);
            btnVPSPage.Name = "btnVPSPage";
            btnVPSPage.Size = new System.Drawing.Size(165, 40);
            btnVPSPage.TabIndex = 0;
            btnVPSPage.Tag = typeof(FormVPSReport).FullName;
        }

        private void BuildBtnVSRTPage()
        {
            btnVSRTPage = new UPageButton();
            btnVSRTPage.BackColor = System.Drawing.Color.Transparent;
            btnVSRTPage.BackgroundImage = Resources.btnbg02;
            btnVSRTPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnVSRTPage.BtnText = "仓库分区温度页面";
            btnVSRTPage.Location = new System.Drawing.Point(198, -1);
            btnVSRTPage.Name = "btnVSRTPage";
            btnVSRTPage.Size = new System.Drawing.Size(165, 40);
            btnVSRTPage.TabIndex = 1;
            btnVSRTPage.Tag = typeof(FormVSRTReport).FullName;
        }

        private void BuildBtnVSRPage()
        {
            btnVSRPage = new UPageButton();
            btnVSRPage.BackColor = System.Drawing.Color.Transparent;
            btnVSRPage.BackgroundImage = Resources.btnbg03;
            btnVSRPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnVSRPage.BtnText = "仓库分区页面";
            btnVSRPage.Location = new System.Drawing.Point(393, -1);
            btnVSRPage.Name = "btnVSRPage";
            btnVSRPage.Size = new System.Drawing.Size(165, 40);
            btnVSRPage.TabIndex = 1;
            btnVSRPage.Tag = typeof(FormVSRReport).FullName;
        }

        #endregion


    }
}
