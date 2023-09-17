using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.BLL;
using Z.Common;
using Z.Models.UIModels;
using Z.WMS.Models;
using Z.WMS.UControls;

namespace Z.WMS.StoreTemper
{
    public partial class FormStoreRegionTemperatureList : Form
    {
        public FormStoreRegionTemperatureList()
        {
            InitializeComponent();
        }

        SRegionTemperBLL rtBLL = new SRegionTemperBLL();

        private void FormStoreRegionTemperatureList_Load(object sender, EventArgs e)
        {
            FormUtility.LoadCboStores(cboStores); //加载仓库列表
            lblMsg.Text = "";
            LoadSRegionBoxList();
        }

        /// <summary>
        /// 查询分区盒子列表
        /// </summary>
        private void LoadSRegionBoxList()
        {
            int storeId = cboStores.SelectedValue.GetInt();
            List<StoreRegionBoxModel> boxList = rtBLL.FindRegionBoxList(storeId);
            //将boxList 包装成分区盒子，显示在列表中
            ShowSRegionBoxList(boxList);
        }

        /// <summary>
        /// 将boxList 包装成分区盒子，显示在列表中
        /// </summary>
        /// <param name="boxList"></param>
        private void ShowSRegionBoxList(List<StoreRegionBoxModel> boxList)
        {
            flpRegionList.Controls.Clear();
            foreach (var box in boxList)
            {
                UStoreRegionBox rBox = new UStoreRegionBox();
                rBox.UBoxSource = box;
                if (box.TemperState != 1)
                {
                    //就会显示升温或降温按钮-----注册事件---调整温度
                    rBox.SetTemperature += SetTemperature;
                }
                rBox.Margin = new Padding(10, 20, 10, 20);
                flpRegionList.Controls.Add(rBox);
            }
        }

        /// <summary>
        /// 升温或降温事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetTemperature(object sender, UStoreRegionArgs e)
        {
            ShowSetTemperaturePage(e);
        }

        private void ShowSetTemperaturePage(UStoreRegionArgs e)
        {
            FormSetSRegionTemperature fSetTemper = new FormSetSRegionTemperature();
            fSetTemper.Tag = new RegionTemperData
            {
                SRegionId = e.SRegionId,
                TemperState = e.TemperState,
                LowTemperature = e.LowTemperature,
                HighTemperature = e.HighTemperature,
                SId = e.SId
            };
            //订阅刷新事件
            fSetTemper.ReloadRegion += ReloadRegion;
            fSetTemper.Show();
        }

        /// <summary>
        /// 刷新列表页分区的室温与状态
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ReloadRegion(object sender, UStoreRegionArgs e)
        {
            foreach (UStoreRegionBox uBox in flpRegionList.Controls)
            {
                if (uBox.SRegionId == e.SRegionId)
                {
                    uBox.SRTemper = e.SRTemperature;
                    uBox.TemperState = e.TemperState;
                    break;
                }
            }
        }

        /// <summary>
        /// 手动检测 读取温度数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblMsg.ForeColor = Color.White;
            //显示消息  lblMsg的Text
            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    lblMsg.Text = "开始读取，请稍后。。。";
                }));
                Thread.Sleep(2000);
                //读取数据的过程
                this.Invoke(new Action(() =>
                {
                    lblMsg.Text = "读取中，请稍后。。。";
                }));
                Thread.Sleep(2000);
                try
                {
                    this.Invoke(new Action(() =>
                    {
                        List<StoreRegionBoxModel> boxList = rtBLL.ReadRegionTemperData();//读取数据，更新到数据库，并返回更新后的数据
                        if (boxList != null)
                        {
                            ShowSRegionBoxList(boxList);
                            lblMsg.Text = "检测完成！";
                        }
                        else
                        {
                            lblMsg.Text = "检测失败，请检查设备！";
                            lblMsg.ForeColor = Color.Red;
                        }
                    }));
                }
                catch (Exception ex)
                {
                    MsgBoxHelper.MsgErrorShow("手动检测", "检测出现异常！");
                }

            });
        }

        private void cboStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSRegionBoxList();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboStores.SelectedIndex = 0;
            lblMsg.Text = "";
            LoadSRegionBoxList();
        }
    }
}
