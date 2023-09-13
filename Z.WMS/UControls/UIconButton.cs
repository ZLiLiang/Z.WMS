using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z.WMS.UControls
{
    public partial class UIconButton : Button
    {
        public UIconButton()
        {
            InitializeComponent();
            //尺寸  字体  字号  FlatStyle FlatAppearance  ForeColor
            this.Size = new Size(30, 30);
            this.Font = new Font("Webdings", 10.8F);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Text = "0";
            this.ForeColor = Color.Silver;
            this.BackColor = Color.Transparent;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.FromArgb(53, 61, 134);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.Transparent;
        }

        /// <summary>
        /// 不显示聚焦框
        /// </summary>
        protected override bool ShowFocusCues => false;
    }
}
