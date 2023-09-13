using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Models.UIModels;

namespace Z.WMS.UControls
{
    public partial class UStoreRegionBox : UserControl
    {
        public UStoreRegionBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 控件的数据对象
        /// </summary>
        private StoreRegionBoxModel uBoxSource;
        public StoreRegionBoxModel UBoxSource
        {
            get { return uBoxSource; }
            set
            {
                uBoxSource = value;
                //赋值
                this.SId = uBoxSource.SId;
                this.ProductCount = uBoxSource.ProductCount;
                this.SRgeionName = uBoxSource.SRegionName;
                this.TemperRange = uBoxSource.TemperRange;
                this.TemperState = uBoxSource.TemperState;
                this.MaxTemper = uBoxSource.MaxTemper;
                this.MinTemper = uBoxSource.MinTemper;
                this.SRTemper = uBoxSource.SRTemper;
                this.SRegionId = uBoxSource.SRgionId;
            }
        }

        /// <summary>
        /// 编号 
        /// </summary>
        public int SId
        {
            get { return uBoxSource.SId; }
            set
            {
                uBoxSource.SId = value;
            }
        }
        /// <summary>
        /// 分区编号
        /// </summary>
        public int SRegionId
        {
            get
            {
                return uBoxSource.SRgionId;
            }
            set
            {
                uBoxSource.SRgionId = value;
            }
        }

        /// <summary>
        /// 分区名称
        /// </summary>
        public string SRgeionName
        {
            get { return uBoxSource.SRegionName; }
            set
            {
                uBoxSource.SRegionName = value;
                lblRegionName.Text = uBoxSource.SRegionName;
            }
        }

        /// <summary>
        /// 设置按钮的显示（升温或降温按钮）
        /// </summary>
        public bool BtnSetVisible
        {
            get { return uBoxSource.BtnSetVisible; }
            set
            {
                uBoxSource.BtnSetVisible = value;
                btnSetTemperature.Visible = uBoxSource.BtnSetVisible;
            }
        }

        /// <summary>
        /// 设置按钮的文本
        /// </summary>
        public string BtnSetText
        {
            get { return uBoxSource.BtnSetText; }
            set
            {
                uBoxSource.BtnSetText = value;
                btnSetTemperature.Text = uBoxSource.BtnSetText;
            }
        }

        /// <summary>
        /// 该仓库分区的温度状态
        /// </summary>
        public int TemperState
        {
            get { return uBoxSource.TemperState; }
            set
            {
                uBoxSource.TemperState = value;
                switch (uBoxSource.TemperState)
                {
                    case 0://低温
                        this.uBoxSource.StateColor = Color.FromArgb(137, 201, 151);
                        this.uBoxSource.BtnSetVisible = true;
                        this.uBoxSource.BtnSetText = "升温";
                        break;
                    case 1://正常
                        this.uBoxSource.StateColor = Color.FromArgb(126, 206, 244);
                        this.uBoxSource.BtnSetVisible = false;
                        this.uBoxSource.BtnSetText = "";
                        break;
                    case 2://高温
                        this.uBoxSource.StateColor = Color.FromArgb(155, 61, 76);
                        this.uBoxSource.BtnSetVisible = true;
                        this.uBoxSource.BtnSetText = "降温";
                        break;
                }
                SRTemperLight.ForeColor = this.uBoxSource.StateColor;
                btnSetTemperature.Visible = this.uBoxSource.BtnSetVisible;
                btnSetTemperature.Text = this.uBoxSource.BtnSetText;
            }
        }

        /// <summary>
        /// 指示灯颜色
        /// </summary>
        public Color StateColor
        {
            get { return uBoxSource.StateColor; }
            set
            {
                uBoxSource.StateColor = value;
                SRTemperLight.ForeColor = uBoxSource.StateColor;
            }
        }

        /// <summary>
        /// 产品数量
        /// </summary>
        public int ProductCount
        {
            get { return uBoxSource.ProductCount; }
            set
            {
                uBoxSource.ProductCount = value;
                lblProductCount.Text = uBoxSource.ProductCount.ToString();
            }
        }

        /// <summary>
        /// 室内温度
        /// </summary>
        public decimal SRTemper
        {
            get { return uBoxSource.SRTemper; }
            set
            {
                uBoxSource.SRTemper = value;
                lblSRTemperature.Text = uBoxSource.SRTemper.ToString();
                uTemperValue.Value = uBoxSource.SRTemper;
            }
        }

        public decimal MaxTemper
        {
            get { return uBoxSource.MaxTemper; }
            set
            {
                uBoxSource.MaxTemper = value;
                uTemperValue.BMaxValue = uBoxSource.MaxTemper;
            }
        }

        public decimal MinTemper
        {
            get { return uBoxSource.MinTemper; }
            set
            {
                uBoxSource.MinTemper = value;
                uTemperValue.BMinValue = uBoxSource.MinTemper;
            }
        }

        /// <summary>
        /// 室内温度范围
        /// </summary>
        public string TemperRange
        {
            get { return uBoxSource.TemperRange; }
            set
            {
                uBoxSource.TemperRange = value;
                lblTemperRange.Text = uBoxSource.TemperRange.ToString() + "℃";
            }
        }

        public event Action<object, UStoreRegionArgs> SetTemperature;//设置分区温度事件

        /// <summary>
        /// 升温或降温
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetTemperature_Click(object sender, EventArgs e)
        {
            UStoreRegionArgs args = new UStoreRegionArgs(this.SId, this.SRegionId, this.TemperState, this.MinTemper, this.MaxTemper);
            SetTemperature?.Invoke(sender, args);
        }
    }
}
