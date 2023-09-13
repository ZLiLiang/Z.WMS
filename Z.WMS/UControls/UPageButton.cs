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
    [DefaultEvent("Click")]
    public partial class UPageButton : UserControl
    {
        public UPageButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按钮文本
        /// </summary>
        public string BtnText
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        public override Color ForeColor { get => lblText.ForeColor; set => lblText.ForeColor = value; }

        protected override void OnClick(EventArgs e)
        {
            lblText.ForeColor = Color.FromArgb(45, 50, 116);
            base.OnClick(e);
        }

        private void lblText_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
