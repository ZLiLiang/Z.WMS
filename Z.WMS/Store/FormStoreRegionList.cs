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
using Z.WMS.Models;

namespace Z.WMS.Store
{
    public partial class FormStoreRegionList : Form
    {
        public FormStoreRegionList()
        {
            InitializeComponent();
        }

        StoreRegionBLL srBLL = new StoreRegionBLL();
        private void FormStoreRegionList_Load(object sender, EventArgs e)
        {
            txtKeyWords.Clear();
            chkShowDel.Checked = false;
            //加载仓库下拉框
            FormUtility.LoadCboStores(cboStores);
            //加载状态下拉框
            LoadCboStates();
            FindStoreRegionList();//加载所有的分区信息
        }

        private void LoadCboStates()
        {
            List<RegionStateModel> stateList = FormUtility.RegionStateList();
            cboStates.DisplayMember = "StateText";
            cboStates.ValueMember = "RegionState";
            cboStates.DataSource = stateList;
            cboStates.SelectedIndex = 0;
        }

        /// <summary>
        /// 查询仓库分区列表
        /// </summary>
        private void FindStoreRegionList()
        {
            int storeId = cboStores.SelectedValue.GetInt();
            int stateId = cboStates.SelectedValue.GetInt();
            string keywords = txtKeyWords.Text.Trim();
            bool showDel = chkShowDel.Checked;
            dgvSRegionList.ShowDgvCols(showDel);//显示操作列
            List<ViewStoreRegionInfo> regionList = srBLL.FindStoreRegionList(storeId, stateId, keywords, showDel);
            if (regionList.Count > 0)
            {
                dgvSRegionList.AutoGenerateColumns = false;
                dgvSRegionList.DataSource = regionList;
                SetEnableBtns(true);
            }
            else
            {
                dgvSRegionList.DataSource = null;
                SetEnableBtns(false);
            }
        }

        private void SetEnableBtns(bool blShow)
        {
            btnDelete.Enabled = blShow;
            // btnFind.Enabled = blShow;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindStoreRegionList();
        }

        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            FindStoreRegionList();
        }

        private void dgvSRegionList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dgvSRegionList.Rows[e.RowIndex].Cells[e.ColumnIndex];//当前点击的单元格
            string headText = cell.FormattedValue.ToString();
            //分区数据对象
            ViewStoreRegionInfo region = dgvSRegionList.Rows[e.RowIndex].DataBoundItem as ViewStoreRegionInfo;
            switch (headText)
            {
                case "修改":
                    //打开仓库分区信息页
                    ShowStoreRegionInfoPage(2, region.SRegionId);
                    break;
                case "删除":
                    //执行逻辑删除（假删除）
                    DeleteStoreRegion(region, 1);
                    break;
                case "恢复":
                    //恢复（逻辑删除的恢复）
                    DeleteStoreRegion(region, 0);
                    break;
                case "移除":
                    //真删除 delete
                    DeleteStoreRegion(region, 2);
                    break;
            }
        }

        /// <summary>
        /// 仓库分区删除、恢复、移除处理
        /// </summary>
        /// <param name="region"></param>
        /// <param name="isDeleted"></param>
        private void DeleteStoreRegion(ViewStoreRegionInfo region, int isDeleted)
        {
            string InfoName = "仓库分区信息";
            string delName = FormUtility.GetDelName(isDeleted);
            string msgTitle = $"{InfoName}{delName}";
            DialogResult dr = MsgBoxHelper.MsgBoxConfirm(msgTitle, $"你确定要{delName}该{InfoName}吗？");
            if (dr == DialogResult.Yes)
            {
                bool bl = false;
                switch (isDeleted)
                {
                    case 1://逻辑删除
                        int reDel = srBLL.LogicDeleteStoreRegion(region.SRegionId, region.StoreId);
                        if (reDel == 1)
                        {
                            bl = true;
                        }
                        else if (reDel == 2)
                        {
                            MsgBoxHelper.MsgErrorShow(msgTitle, $"该仓库分区已添加了产品，不能删除！");
                            return;
                        }
                        else
                        {
                            bl = false;
                        }
                        break;
                    case 0:
                        bl = srBLL.RecoverStoreRegion(region.SRegionId, region.StoreId);
                        break;
                    case 2:
                        bl = srBLL.DeleteStoreRegion(region.SRegionId, region.StoreId);
                        break;
                }
                if (bl)
                {
                    MsgBoxHelper.MsgBoxShow(msgTitle, $"{InfoName} {delName} 成功！");
                    FindStoreRegionList();
                }
                else
                {
                    MsgBoxHelper.MsgErrorShow(msgTitle, $"{InfoName} {delName} 失败！");
                    return;
                }
            }
        }

        /// <summary>
        /// 打开仓库分区信息页面
        /// </summary>
        /// <param name="actType"></param>
        /// <param name="sRegionId"></param>
        private void ShowStoreRegionInfoPage(int actType, int sRegionId)
        {
            FormStoreRegionInfo fStoreRegion = new FormStoreRegionInfo();
            fStoreRegion.Tag = new FInfoData()
            {
                ActType = actType,
                FId = sRegionId
            };
            //刷新列表页数据效果,采用事件
            fStoreRegion.ReloadList += () => FindStoreRegionList();
            fStoreRegion.StartPosition = FormStartPosition.CenterScreen;
            fStoreRegion.ShowDialog();
        }

        /// <summary>
        /// 新增仓库分区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowStoreRegionInfoPage(1, 0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msgTitle = "仓库分区信息删除";
            List<StoreRegionInfo> delRegions = new List<StoreRegionInfo>();
            foreach (DataGridViewRow dr in dgvSRegionList.Rows)
            {
                ViewStoreRegionInfo region = dr.DataBoundItem as ViewStoreRegionInfo;
                DataGridViewCheckBoxCell chkCell = dr.Cells["colChk"] as DataGridViewCheckBoxCell;
                if (chkCell.FormattedValue.ToString() == "True")
                {
                    delRegions.Add(new StoreRegionInfo() { SRegionId = region.SRegionId, StoreId = region.StoreId });
                }
            }
            if (delRegions.Count > 0)
            {
                DialogResult dr = MsgBoxHelper.MsgBoxConfirm(msgTitle, $"你确定要删除选择的仓库分区信息吗？");
                if (dr == DialogResult.Yes)
                {
                    string reStr = srBLL.LogicDeleteStoreRegion(delRegions);
                    if (reStr == "Y")//成功
                    {
                        MsgBoxHelper.MsgBoxShow(msgTitle, "选择的仓库分区信息删除 成功！");
                        FindStoreRegionList();
                    }
                    else if (reStr.Length >= 1 && (reStr != "Y" || reStr != "0"))//存在分区的仓库
                    {
                        MsgBoxHelper.MsgErrorShow(msgTitle, "选择的仓库分区信息中存在有已添加产品的仓库分区，它们的编号是：" + reStr);
                        return;
                    }
                    else//删除失败
                    {
                        MsgBoxHelper.MsgErrorShow(msgTitle, "选择的仓库分区信息删除失败！");
                        return;
                    }
                }
            }
            else
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "请选择要删除的仓库分区信息！");
                return;
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboStores.SelectedIndex = 0;
            cboStates.SelectedIndex = 0;
            txtKeyWords.Clear();
            chkShowDel.Checked = false;
            FindStoreRegionList();
        }

    }
}
