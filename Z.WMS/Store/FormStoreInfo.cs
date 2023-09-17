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
using Z.Models.DModels;
using Z.WMS.Models;

namespace Z.WMS.Store
{
    public partial class FormStoreInfo : Form
    {
        public FormStoreInfo()
        {
            InitializeComponent();
        }

        StoreBLL storeBLL = new StoreBLL();
        public event Action ReLoadList; //刷新列表页数据
        public FInfoData fInfo = null;
        int storeId = 0; //当前修改的仓库编号
        string oldName = ""; //修改前的名称
        string oldNo = ""; //修改前的编码
        int actType = 1; //新增

        private void FormStoreInfo_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                fInfo = this.Tag as FInfoData;
                InitPageInfo();
            }
        }

        private void InitPageInfo()
        {
            if (fInfo != null)
            {
                actType = fInfo.ActType;
                string actName = "";
                if (actType == 1)
                {
                    btnClear.Enabled = true;
                    ClearInfo();
                    actName = "新增";
                }
                else//修改
                {
                    storeId = fInfo.FId;
                    //加载仓库
                    btnClear.Visible = false;
                    GetStore();
                    actName = "修改";
                }
                btnOk.Text = actName;
                this.Text += "----" + actName;
            }
        }

        /// <summary>
        /// 加载仓库信息
        /// </summary>
        private void GetStore()
        {
            StoreInfo storeInfo = storeBLL.GetStore(storeId);
            if (storeInfo != null)
            {
                txtStoreName.Text = storeInfo.StoreName;
                txtStoreNo.Text = storeInfo.StoreNo;
                txtRemark.Text = storeInfo.Remark;
                oldName = storeInfo.StoreName;
                oldNo = storeInfo.StoreNo;
            }
        }

        /// <summary>
        /// 清空处理
        /// </summary>
        private void ClearInfo()
        {
            txtRemark.Clear();
            txtStoreName.Clear();
            txtStoreNo.Clear();
            actType = 1;
            storeId = 0;
            oldName = "";
            oldNo = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 仓库信息的提交 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            string conType = actType == 1 ? "新增" : "修改";
            string msgTitle = $"{conType}仓库信息";
            //信息输入接收
            string storeName = txtStoreName.Text.Trim();
            string storeNo = txtStoreNo.Text.Trim();
            string remark = txtRemark.Text.Trim();
            // 判断：非空、存在性
            if (string.IsNullOrEmpty(storeName))
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "仓库名称不能为空！");
                txtStoreName.Focus();
                return;
            }
            if (storeId == 0 || (storeId > 0 && (oldName != storeName || oldNo != storeNo)))
            {
                int intBl = 0;
                if (storeId > 0)
                {
                    if (oldName == storeName)
                        intBl = storeBLL.ExistsStore("", storeNo);
                    else if (oldNo == storeNo)
                        intBl = storeBLL.ExistsStore(storeName, "");
                    else
                        intBl = storeBLL.ExistsStore(storeName, storeNo);
                }
                else
                {
                    intBl = storeBLL.ExistsStore(storeName, storeNo);
                }
                switch (intBl)
                {
                    case 0://都不存在
                        break;
                    case 1://Name 存在
                        MsgBoxHelper.MsgErrorShow(msgTitle, "该仓库名称已存在！");
                        break;
                    case 2://No 存在
                        MsgBoxHelper.MsgErrorShow(msgTitle, "该仓库编码已存在！");
                        break;
                    case 3://都 存在
                        MsgBoxHelper.MsgErrorShow(msgTitle, "该仓库名称和编码已存在！");
                        break;
                }
                if (intBl > 0)
                    return;
            }
            // 信息封装
            StoreInfo storeInfo = new StoreInfo()
            {
                StoreId = storeId,
                StoreNo = storeNo,
                StoreName = storeName,
                Remark = remark
            };

            // 提交：add update      // 结果：作出相应的响应
            if (actType == 1)
            {
                int storeNewId = storeBLL.AddStoreGetId(storeInfo);
                if (storeNewId > 0)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, $"仓库：{storeName}信息新增成功！");
                    storeId = storeNewId;
                    actType = 2;
                    oldName = storeName;
                    oldNo = storeNo;
                    ReLoadList?.Invoke();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, $"仓库：{storeName}信息新增失败！");
                    return;
                }
            }
            else
            {
                bool bl = storeBLL.UpdateStore(storeInfo);
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, $"仓库：{storeName}信息修改成功！");
                    oldName = storeName;
                    oldNo = storeNo;
                    ReLoadList?.Invoke();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, $"仓库：{storeName}信息修改失败！");
                    return;
                }
            }
        }
    }
}
