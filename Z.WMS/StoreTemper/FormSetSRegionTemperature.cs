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
using Z.WMS.Models;
using Z.WMS.UControls;

namespace Z.WMS.StoreTemper
{
    public partial class FormSetSRegionTemperature : Form
    {
        public FormSetSRegionTemperature()
        {
            InitializeComponent();
        }

        SRegionTemperBLL rtBLL = new SRegionTemperBLL();
        public event Action<object, UStoreRegionArgs> ReloadRegion; //刷新列表页该分区的温度与状态
        RegionTemperData regionData = null; //分区信息
        int isCompleted = -1;

        private void FormSetSRegionTemperature_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                regionData = this.Tag as RegionTemperData; //分区信息
                if (regionData != null)
                {
                    if (regionData.TemperState == 0)
                        lblSetType.Text = "升温";
                    else
                        lblSetType.Text = "降温";
                }
                InitSetWays();
                txtTemperature.Value = 0;
            }
        }

        private void InitSetWays()
        {
            chkWayList.Items.Clear();
            if (regionData.TemperState == 0)
            {
                chkWayList.Items.Add("打开热风");
                chkWayList.Items.Add("打开暖气");
                chkWayList.Items.Add("关闭窗户");
            }
            else
            {
                chkWayList.Items.Add("打开冷风");
                chkWayList.Items.Add("关闭暖气");
                chkWayList.Items.Add("打开窗户");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            isCompleted = 0;//开始调温
            decimal srTemper = txtTemperature.Value;//目标室温
            string msgTitle = "调整分区温度";
            if (regionData.LowTemperature > srTemper)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "目标温度不能低于当前分区的最低温度！");
                return;
            }
            else if (regionData.HighTemperature < srTemper)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "目标温度不能高于当前分区的最高温度！");
                return;
            }
            if (chkWayList.CheckedItems.Count == 0)
            {
                MsgBoxHelper.MsgErrorShow(msgTitle, "请设置调温方式！");
                return;
            }

            //开始调温处理
            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    lbMsg.Items.Add($"开始{lblSetType.Text}处理！");
                }));
                Thread.Sleep(5000);
                //室温已调整到目标温度
                //写入设备中  从站中
                if (rtBLL.SetSRTemperature(regionData.SId, srTemper))
                {
                    this.Invoke(new Action(() =>
                    {
                        lbMsg.Items.Add($"已写入设备中！");
                    }));
                    Thread.Sleep(1000);
                    //更新到仓库分区信息表中
                    bool blUpdate = rtBLL.UpdateSRTemperatureById(regionData.SRegionId, srTemper);
                    if (blUpdate)
                    {
                        isCompleted = 1;//高温成功
                        this.Invoke(new Action(() =>
                        {
                            UStoreRegionArgs args = new UStoreRegionArgs(regionData.SRegionId, 1, srTemper);
                            ReloadRegion?.Invoke(this, args);//刷新列表页该分区的温度信息
                            lbMsg.Items.Add($"{lblSetType.Text}调整已完成！2秒后自动关闭！");
                        }));
                        Thread.Sleep(2000);
                        this.Invoke(new Action(() =>
                        {
                            this.Close();//关闭本页
                        }));
                    }
                }
            });
        }

        /// <summary>
        /// 关闭处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isCompleted == -1 || isCompleted == 1)
                this.Close();
            else
            {
                MsgBoxHelper.MsgErrorShow("调整分区调整", "当前正中调温中，不能关闭页面！");
                return;
            }
        }

        /// <summary>
        /// 关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSetSRegionTemperature_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isCompleted == 0)
            {
                MsgBoxHelper.MsgErrorShow("调整分区调整", "当前正中调温中，不能关闭页面！");
                e.Cancel = true;
                return;
            }
        }
    }
}
