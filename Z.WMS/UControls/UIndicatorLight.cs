using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z.WMS.UControls
{
    public partial class UIndicatorLight : UserControl
    {
        public UIndicatorLight()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 指示灯的颜色
        /// </summary>
        public Color CireCleColor
        {
            get { return this.uCircleLight.ForeColor; }
            set { this.uCircleLight.ForeColor = value; }
        }

        /// <summary>
        /// 温度状态文本
        /// </summary>
        public string LightText
        {
            get { return lblState.Text; }
            set { lblState.Text = value; }
        }
    }
}
