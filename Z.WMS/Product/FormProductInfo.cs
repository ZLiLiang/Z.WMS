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

namespace Z.WMS.Product
{
    public partial class FormProductInfo : Form
    {
        public FormProductInfo()
        {
            InitializeComponent();
        }

        public event Action ReloadList; //刷新产品列表页数据
        ProductBLL proBLL = new ProductBLL();
        private FInfoData fInfo = null;
        int actType = 1; //页面状态
        int productId = 0; //当前修改的产品编号
        string oldName = ""; //原来的产品名称
        string oldNo = ""; //原来的编码

        private void FormProductInfo_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                fInfo = this.Tag as FInfoData;
            }
            InitPageInfo();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            string conType = actType == 1 ? "新增" : "修改";
            string msgTitle = $"{conType}产品信息";
            //接收
            string proNo = txtProductNo.Text.Trim();
            string proName = txtProductName.Text.Trim();
            decimal? lowTemper = null;
            decimal? highTemper = null;

            if (!string.IsNullOrEmpty(txtLowTemper.Text))
            {
                lowTemper = txtLowTemper.Text.GetDecimal();
            }
            if (!string.IsNullOrEmpty(txtHighTemper.Text))
            {
                highTemper = txtHighTemper.Text.GetDecimal();
            }

            //判断
            if (string.IsNullOrEmpty(proName))
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "产品名称不能为空！");
                txtProductName.Focus();
                return;
            }
            //检查名称和编码的存在性
            if (productId == 0 || productId > 0 && (proName != oldName || proNo != oldNo))
            {
                int intBl = 0;
                if (productId > 0)
                {
                    if (oldName == proName)
                    {
                        intBl = proBLL.ExistsProduct("", proNo);
                    }
                    else if (oldNo == proNo)
                    {
                        intBl = proBLL.ExistsProduct(proName, "");
                    }
                    else
                    {
                        intBl = proBLL.ExistsProduct(proName, proNo);
                    }
                }
                else
                {
                    intBl = proBLL.ExistsProduct(proName, proNo);
                }

                switch (intBl)
                {
                    case 0://都不存在
                        break;
                    case 1://Name 存在
                        MsgBoxHelper.MsgErrorShow(msgTitle, "该产品名称已存在！");
                        break;
                    case 2://No 存在
                        MsgBoxHelper.MsgErrorShow(msgTitle, "该产品编码已存在！");
                        break;
                    case 3://都 存在
                        MsgBoxHelper.MsgErrorShow(msgTitle, "该产品名称和编码已存在！");
                        break;
                }
                if (intBl > 0)
                {
                    return;
                }

                //温度值检查
                if (lowTemper == null)
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, "请设置产品的适合低温值！");
                    txtLowTemper.Focus();
                    return;
                }
                else if (highTemper == null)
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, "请设置产品的适合高温值！");
                    txtHighTemper.Focus();
                    return;
                }
                else if (lowTemper != null && highTemper != null && lowTemper > highTemper)
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, "产品的适合低温值不能高于高温值！");
                    txtLowTemper.Focus();
                    return;
                }
                //封装信息
                ProductInfo proInfo = new ProductInfo()
                {
                    ProductId = productId,
                    ProductName = proName,
                    ProductNo = proNo,
                    FitHighTemper = highTemper,
                    FitLowTemper = lowTemper
                };

                //提交   ---   //做出响应
                if (actType == 1)
                {
                    int productNewId = proBLL.AddProductInfoWithId(proInfo);
                    if (productNewId > 0)
                    {
                        MsgBoxHelper.MsgBoxShow(msgTitle, $"产品：{proName}信息新增成功！");
                        //页面转换到修改状态
                        productId = productNewId;
                        actType = 2;
                        oldName = proName;
                        oldNo = proNo;
                        ReloadList?.Invoke();//刷新列表页
                    }
                    else
                    {
                        MsgBoxHelper.MsgErrorShow(msgTitle, $"产品：{proName}信息新增失败！");
                        return;
                    }
                }
                else
                {
                    bool bl = proBLL.UpdateProductInfo(proInfo);
                    if (bl)
                    {
                        MsgBoxHelper.MsgBoxShow(msgTitle, $"产品：{proName}信息修改成功！");
                        oldName = proName;
                        oldNo = proNo;
                        ReloadList?.Invoke();
                    }
                    else
                    {
                        MsgBoxHelper.MsgErrorShow(msgTitle, $"产品：{proName}信息修改失败！");
                        return;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        /// <summary>
        /// 初始化产品信息
        /// </summary>
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
                else //修改
                {
                    productId = fInfo.FId;
                    //加载产品信息
                    btnClear.Visible = false;
                    GetProductInfo();
                    actName = "修改";
                }
                btnOk.Text = actName;
                this.Text += "----" + actName;
            }
        }

        /// <summary>
        /// 加载指定的产品信息
        /// </summary>
        private void GetProductInfo()
        {
            ProductInfo proInfo = proBLL.GetProductInfo(productId);
            if (proInfo != null)
            {
                txtProductNo.Text = proInfo.ProductNo;
                txtProductName.Text = proInfo.ProductName;
                txtLowTemper.Text = proInfo.FitLowTemper.ToString();
                txtHighTemper.Text = proInfo.FitHighTemper.ToString();
                oldName = proInfo.ProductName;
                oldNo = proInfo.ProductNo;
            }
        }

        /// <summary>
        /// 清空处理
        /// </summary>
        private void ClearInfo()
        {
            txtProductNo.Clear();
            txtProductName.Clear();
            txtLowTemper.Clear();
            txtHighTemper.Clear();
            productId = 0;
            actType = 1;
            oldName = "";
            oldNo = "";
        }
    }
}
