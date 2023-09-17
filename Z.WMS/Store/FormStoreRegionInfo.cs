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
using Z.WMS.Models;

namespace Z.WMS.Store
{
    public partial class FormStoreRegionInfo : Form
    {
        public FormStoreRegionInfo()
        {
            InitializeComponent();
        }

        private StoreRegionBLL srBLL = new StoreRegionBLL();
        public event Action ReLoadStoreList;//刷新仓库管理列表页数据
        public event Action ReloadList;//刷新仓库分区管理列表页数据
        private FInfoData fInfo = null;
        int actType = 1;//当前页面状态标识
        int regionId = 0;//当前修改的仓库编号
        string oldName = "";//修改前的分区名称
        string oldNo = "";//修改前的分区编码
        int oldStoreId = 0;//修改前的仓库编号

        private void FormStoreRegionInfo_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                fInfo = this.Tag as FInfoData;
                InitStoreRegionInfo();
            }
        }

        /// <summary>
        /// 初始化页面信息
        /// </summary>
        private void InitStoreRegionInfo()
        {
            if (fInfo != null)
            {
                actType = fInfo.ActType;
                FormUtility.LoadCboStores(cboStores);
                string actName = "";
                switch (actType)
                {
                    case 1:
                        btnClear.Enabled = true;
                        ClearInfo();
                        actName = "新增";
                        panelTemper.Visible = false;
                        break;
                    case 2:
                        regionId = fInfo.FId;
                        //加载仓库
                        btnClear.Visible = false;
                        GetRegionInfo();
                        panelTemper.Visible = true;
                        actName = "修改";
                        break;
                    case 3:
                        btnClear.Enabled = true;
                        ClearInfo();
                        cboStores.SelectedValue = fInfo.FId;//StoreId
                        cboStores.Enabled = false;
                        panelTemper.Visible = false;
                        actName = "新增";
                        break;
                }

                btnOk.Text = actName;
                this.Text += "----" + actName;
            }
        }

        /// <summary>
        /// 加载指定的分区信息
        /// </summary>
        private void GetRegionInfo()
        {
            StoreRegionInfo srInfo = srBLL.GetSRegionInfo(regionId);
            if (srInfo != null)
            {
                txtRegionName.Text = srInfo.SRegionName;
                txtRegionNo.Text = srInfo.SRegionNo;
                cboStores.SelectedValue = srInfo.StoreId;
                txtCurTemperature.Text = srInfo.SRTemperature == null ? "" : srInfo.SRTemperature.Value.ToString();
                txtLowTemperature.Text = srInfo.AllowLowTemperature == null ? "" : srInfo.AllowLowTemperature.Value.ToString();
                txtHighTemperature.Text = srInfo.AllowHighTemperature == null ? "" : srInfo.AllowHighTemperature.Value.ToString();
                txtRemark.Text = srInfo.Remark;
                oldName = srInfo.SRegionName;
                oldNo = srInfo.SRegionNo;
                oldStoreId = srInfo.StoreId;
            }
        }

        /// <summary>
        /// 页面清空
        /// </summary>
        private void ClearInfo()
        {
            txtRegionName.Clear();
            txtRegionNo.Clear();
            cboStores.SelectedIndex = 0;
            if (actType == 3)
                cboStores.SelectedValue = fInfo.FId;
            txtCurTemperature.Clear();
            txtRemark.Clear();
            oldName = "";
            oldNo = "";
            oldStoreId = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //信息接收
            string regionName = txtRegionName.Text.Trim();
            string regionNo = txtRegionNo.Text.Trim();
            int storeId = cboStores.SelectedValue.GetInt();
            decimal? curTemperature = null;
            if (!string.IsNullOrEmpty(txtCurTemperature.Text))
                curTemperature = txtCurTemperature.Text.GetDecimal();
            decimal? lowTemperature = null, highTemperature = null;
            int regionState = 1;
            if (actType == 2)
            {
                if (!string.IsNullOrEmpty(txtLowTemperature.Text))
                    lowTemperature = txtLowTemperature.Text.GetDecimal();
                if (!string.IsNullOrEmpty(txtHighTemperature.Text))
                    highTemperature = txtHighTemperature.Text.GetDecimal();
            }
            string remark = txtRemark.Text.Trim();
            string msgTitle = "分区信息提交";
            if (string.IsNullOrEmpty(regionName))
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "分区名称不能为空！");
                txtRegionName.Focus();
                return;
            }
            if (regionId == 0 || (regionId > 0 && (oldName != regionName || oldNo != regionNo)))
            {
                int intBl = 0;
                if (regionId > 0)
                {
                    if (oldName == regionName)
                        intBl = srBLL.ExistsStoreRegion("", regionNo);
                    else if (oldNo == regionNo)
                        intBl = srBLL.ExistsStoreRegion(regionName, "");
                    else
                        intBl = srBLL.ExistsStoreRegion(regionName, regionNo);
                }
                else
                {
                    intBl = srBLL.ExistsStoreRegion(regionName, regionNo);
                }
                switch (intBl)
                {
                    case 0://都不存在
                        break;
                    case 1://Name 存在
                        MsgBoxHelper.MsgErrorShow(msgTitle, "该分区名称已存在！");
                        break;
                    case 2://No 存在
                        MsgBoxHelper.MsgErrorShow(msgTitle, "该分区编码已存在！");
                        break;
                    case 3://都 存在
                        MsgBoxHelper.MsgErrorShow(msgTitle, "该分区名称和编码已存在！");
                        break;
                }
                if (intBl > 0)
                    return;
            }
            if (storeId == 0)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "请选择所属仓库！");
                cboStores.Focus();
                return;
            }
            if (actType == 2)
            {
                if (lowTemperature != null && highTemperature != null && lowTemperature > highTemperature)
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, "低温不能高于高温！");
                    txtLowTemperature.Focus();
                    return;
                }
                else if (lowTemperature != null && curTemperature != null && lowTemperature > curTemperature)
                {
                    regionState = 0;//低温
                }
                else if (highTemperature != null && curTemperature != null && highTemperature < curTemperature)
                {
                    regionState = 2;//高温
                }
            }

            //分区信息封装
            StoreRegionInfo srInfo = new StoreRegionInfo()
            {
                SRegionId = regionId,
                SRegionName = regionName,
                SRegionNo = regionNo,
                SRTemperature = curTemperature,
                StoreId = storeId,
                TemperState = regionState,
                Remark = remark
            };
            if (actType == 2)
            {
                if (lowTemperature != null)
                    srInfo.AllowLowTemperature = lowTemperature;
                if (highTemperature != null)
                    srInfo.AllowHighTemperature = highTemperature;
            }

            //提交   下节课
            bool bl = false;//提交状态
            if (actType == 1 || actType == 3)
            {
                int regionNewId = srBLL.AddStoreRegionWithId(srInfo);//返回新分区编号
                if (regionNewId > 0)
                {
                    bl = true;
                    regionId = regionNewId;
                    //actType = 2;
                }
            }
            else //修改
            {
                if (storeId != oldStoreId)
                    bl = srBLL.UpdateStoreRegion(srInfo, oldStoreId);
                else
                    bl = srBLL.UpdateStoreRegion(srInfo);
            }
            string actName = actType != 2 ? "新增" : "修改";
            string successType = bl ? "成功" : "失败";
            if (bl)
            {
                MsgBoxHelper.MsgBoxShow(msgTitle, $"分区：{regionName}{actName}{successType}!");
                if (actType == 1)
                {
                    actType = 2;
                    btnOk.Text = "修改";
                    oldName = regionName;
                    oldNo = regionNo;
                }
                if (actType == 3)
                    ReLoadStoreList?.Invoke();
                else
                    ReloadList?.Invoke();
            }
            else
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, $"分区：{regionName}{actName}{successType}!");
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
