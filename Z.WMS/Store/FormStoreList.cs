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
    public partial class FormStoreList : Form
    {
        public FormStoreList()
        {
            InitializeComponent();
        }

        StoreBLL storeBLL = new StoreBLL();

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormStoreList_Load(object sender, EventArgs e)
        {
            chkShowDel.Checked = false;
            txtKeyWords.Clear();
            LoadStoreList();
        }

        /// <summary>
        /// 查询仓库信息列表 
        /// </summary>
        private void LoadStoreList()
        {
            bool isDel = chkShowDel.Checked;
            string keywords = txtKeyWords.Text.Trim();
            dgvStoreList.ShowDgvCols(isDel);//显示操作列
            dgvStoreList.Columns["colAddRegion"].Visible = !isDel;

            //加载仓库数据  到数据库读取数据
            List<StoreInfo> storeList = storeBLL.GetStoreInfos(keywords, isDel);
            if (storeList.Count > 0)
            {
                dgvStoreList.AutoGenerateColumns = false;
                dgvStoreList.DataSource = storeList;
                SetEnableBtns(true);
            }
            else
            {
                dgvStoreList.DataSource = null;
                SetEnableBtns(false);
            }

        }

        private void SetEnableBtns(bool blShow)
        {
            btnFind.Enabled = blShow;
            btnDelete.Enabled = blShow;
        }

        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            LoadStoreList();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadStoreList();
        }

        /// <summary>
        /// 新增仓库信息--打开信息页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowStoreInfoPage(1, 0);
        }

        /// <summary>
        /// 打开仓库信息页   新增、修改页面
        /// </summary>
        /// <param name="actTpye"></param>
        /// <param name="storeId"></param>
        private void ShowStoreInfoPage(int actTpye, int storeId)
        {
            FormStoreInfo fStore = new FormStoreInfo();
            fStore.Tag = new FInfoData()
            {
                ActType = actTpye,
                FId = storeId
            };
            //刷新列表页数据效果  委托，采用事件
            fStore.ReLoadList += () => LoadStoreList();
            fStore.StartPosition = FormStartPosition.CenterScreen;
            fStore.ShowDialog();
        }

        /// <summary>
        /// 打开仓库分区信息页   添加分区
        /// </summary>
        /// <param name="storeId"></param>
        private void ShowStoreRegionInfoPage(int storeId)
        {
            FormStoreRegionInfo fRegion = new FormStoreRegionInfo();
            fRegion.Tag = new FInfoData()
            {
                ActType = 3,
                FId = storeId
            };
            //刷新列表页数据效果  委托，采用事件
            fRegion.ReLoadStoreList += () => LoadStoreList();
            fRegion.StartPosition = FormStartPosition.CenterScreen;
            fRegion.ShowDialog();
        }

        private void dgvStoreList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dgvStoreList.Rows[e.RowIndex].Cells[e.ColumnIndex];//当前点击的单元格
            string headText = cell.FormattedValue.ToString();
            StoreInfo store = dgvStoreList.Rows[e.RowIndex].DataBoundItem as StoreInfo;
            switch (headText)
            {
                case "添加分区":
                    //打开添加仓库分区信息页
                    ShowStoreRegionInfoPage(store.StoreId);
                    break;
                case "修改":
                    //打开仓库信息页
                    ShowStoreInfoPage(2, store.StoreId);
                    break;
                case "删除":
                    //执行逻辑删除（假删除）
                    DeleteStore(store, 1);
                    break;
                case "恢复":
                    //恢复（逻辑删除的恢复）
                    DeleteStore(store, 0);
                    break;
                case "移除":
                    //真删除 delete
                    DeleteStore(store, 2);
                    break;
            }
        }

        /// <summary>
        /// 删除/恢复/移除仓库信息
        /// </summary>
        /// <param name="storeInfo"></param>
        /// <param name="delCode"></param>
        private void DeleteStore(StoreInfo storeInfo, int delCode)
        {
            string InfoName = "仓库信息";
            string delName = FormUtility.GetDelName(delCode);
            string msgTitle = $"{InfoName}{delName}";
            DialogResult dr = MsgBoxHelper.MsgBoxConfirm(msgTitle, $"你确定要{delName}该{InfoName}吗？");
            if (dr == DialogResult.Yes)
            {
                bool bl = false;
                switch (delCode)
                {
                    case 1://逻辑删除
                        int reDel = storeBLL.LogicDeleteStore(storeInfo.StoreId);
                        if (reDel == 1)
                        {
                            bl = true;
                        }
                        else if (reDel == 2)
                        {
                            MsgBoxHelper.MsgErrorShow(msgTitle, $"该仓库已添加了分区，不能删除！");
                            return;
                        }
                        else
                        {
                            bl = false;
                        }
                        break;
                    case 0:
                        bl = storeBLL.RecoverStore(storeInfo.StoreId);
                        break;
                    case 2:
                        bl = storeBLL.DeleteStore(storeInfo.StoreId);
                        break;
                }
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, $"{InfoName} {delName} 成功！");
                    LoadStoreList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, $"{InfoName} {delName} 失败！");
                    return;
                }
            }
        }

        /// <summary>
        /// 刷新   恢复最初状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            chkShowDel.Checked = false;
            txtKeyWords.Clear();
            LoadStoreList();
        }

        /// <summary>
        /// 批量删除仓库信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msgTitle = "仓库信息删除";
            List<int> delIds = new List<int>();
            foreach (DataGridViewRow dr in dgvStoreList.Rows)
            {
                StoreInfo store = dr.DataBoundItem as StoreInfo;
                DataGridViewCheckBoxCell chkCell = dr.Cells["colChk"] as DataGridViewCheckBoxCell;
                if (chkCell.FormattedValue.ToString() == "True")
                {
                    delIds.Add(store.StoreId);
                }
            }
            if (delIds.Count > 0)
            {
                DialogResult dr = MsgBoxHelper.MsgBoxConfirm(msgTitle, $"你确定要删除选择的仓库信息吗？");
                if (dr == DialogResult.Yes)
                {
                    string reStr = storeBLL.LogicDeleteStore(delIds);
                    if (reStr == "Y")//成功
                    {
                        MsgBoxHelper.MsgBoxShow(msgTitle, "选择的仓库信息删除 成功！");
                        LoadStoreList();
                    }
                    else if (reStr.Length >= 1 && (reStr != "Y" || reStr != "0"))//存在分区的仓库
                    {
                        MsgBoxHelper.MsgErrorShow(msgTitle, "选择的仓库信息中存在有已添加分区的仓库，它们的编号是：" + reStr);
                        return;
                    }
                    else//删除失败
                    {
                        MsgBoxHelper.MsgErrorShow(msgTitle, "选择的仓库信息删除失败！");
                        return;
                    }
                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "请选择要删除的仓库信息！");
                return;
            }
        }
    }
}
