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

namespace Z.WMS.Product
{
    public partial class FormProductList : Form
    {

        ProductBLL proBLL = new ProductBLL();

        public FormProductList()
        {
            InitializeComponent();
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {
            txtKeyWords.Clear();
            chkShowDel.Checked = false;
            FindProductList();
        }

        private void FindProductList()
        {
            string keywords = txtKeyWords.Text.Trim();
            bool showDel = chkShowDel.Checked;
            List<ProductInfo> proList = proBLL.GetProductList(keywords, showDel);
            dgvProductList.ShowDgvCols(showDel);
            if (proList.Count > 0)
            {
                dgvProductList.AutoGenerateColumns = false;
                dgvProductList.DataSource = proList;
                btnDelete.Enabled = true;
            }
            else
            {
                dgvProductList.DataSource = null;
                btnDelete.Enabled = false;
            }
        }

        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            FindProductList();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindProductList();
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var curCell = dgvProductList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string curVal = curCell.FormattedValue.ToString();
            ProductInfo proInfo = dgvProductList.Rows[e.RowIndex].DataBoundItem as ProductInfo;
            switch (curVal)
            {
                case "修改":
                    //打开产品信息页
                    ShowProductInfoPage(2, proInfo.ProductId);
                    break;
                case "删除":
                    //执行逻辑删除（假删除）
                    DeleteProduct(proInfo.ProductId, 1);
                    break;
                case "恢复":
                    //恢复（逻辑删除的恢复）
                    DeleteProduct(proInfo.ProductId, 0);
                    break;
                case "移除":
                    //真删除 delete
                    DeleteProduct(proInfo.ProductId, 2);
                    break;
            }
        }

        /// <summary>
        /// 删除/恢复/移除 产品信息
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="isDeleted"></param>
        private void DeleteProduct(int productId, int isDeleted)
        {
            string InfoName = "产品信息";
            string delName = FormUtility.GetDelName(isDeleted);
            string msgTitle = $"{InfoName}{delName}";
            DialogResult dr = MsgBoxHelper.MsgBoxConfirm(msgTitle, $"你确定要{delName}该{InfoName}吗？");
            if (dr == DialogResult.Yes)
            {
                bool bl = false;
                switch (isDeleted)
                {
                    case 1://逻辑删除
                        int reDel = proBLL.LogicDeleteProduct(productId);
                        if (reDel == 1)
                        {
                            bl = true;
                        }
                        else if (reDel == 2)
                        {
                            MsgBoxHelper.MsgErrorShow(msgTitle, $"该产品已有库存，不能删除！");
                            return;
                        }
                        else
                        {
                            bl = false;
                        }
                        break;
                    case 0:
                        bl = proBLL.RecoverProduct(productId);
                        break;
                    case 2:
                        bl = proBLL.DeleteProduct(productId);
                        break;
                }
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, $"{InfoName} {delName} 成功！");
                    FindProductList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, $"{InfoName} {delName} 失败！");
                    return;
                }
            }
        }

        /// <summary>
        /// 打开产品信息页
        /// </summary>
        /// <param name="actType"></param>
        /// <param name="productId"></param>
        private void ShowProductInfoPage(int actType, int productId)
        {
            FormProductInfo fProduct = new FormProductInfo();
            fProduct.Tag = new FInfoData()
            {
                ActType = actType,
                FId = productId
            };
            //刷新列表页数据效果  委托，采用事件
            fProduct.ReloadList += () => FindProductList();
            fProduct.StartPosition = FormStartPosition.CenterScreen;
            fProduct.ShowDialog();
        }

        /// <summary>
        /// 打开产品新增页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowProductInfoPage(1, 0);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtKeyWords.Clear();
            chkShowDel.Checked = false;
            FindProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msgTitle = "产品信息删除";
            List<int> delIds = new List<int>();
            foreach (DataGridViewRow dr in dgvProductList.Rows)
            {
                ProductInfo proInfo = dr.DataBoundItem as ProductInfo;
                DataGridViewCheckBoxCell chkCell = dr.Cells["colChk"] as DataGridViewCheckBoxCell;
                if (chkCell.FormattedValue.ToString() == "True")
                {
                    delIds.Add(proInfo.ProductId);
                }
            }
            if (delIds.Count > 0)
            {
                DialogResult dr = MsgBoxHelper.MsgBoxConfirm(msgTitle, $"你确定要删除选择的产品信息吗？");
                if (dr == DialogResult.Yes)
                {
                    //批量删除方法
                    string reStr = proBLL.LogicDeleteProductList(delIds);
                    if (reStr == "Y")//成功
                    {
                        MsgBoxHelper.MsgBoxShow(msgTitle, "选择的产品信息删除 成功！");
                        FindProductList();
                    }
                    else if (reStr.Length >= 1 && (reStr != "Y" || reStr != "0"))//存在产品库存
                    {
                        MsgBoxHelper.MsgErrorShow(msgTitle, "选择的产品信息中存在已有库存的产品，它们的编号是：" + reStr);
                        return;
                    }
                    else//删除失败
                    {
                        MsgBoxHelper.MsgErrorShow(msgTitle, "选择的产品信息删除失败！");
                        return;
                    }
                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "请选择要删除的产品信息！");
                return;
            }
        }
    }
}
