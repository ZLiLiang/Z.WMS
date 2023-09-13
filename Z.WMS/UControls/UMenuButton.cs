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
    public partial class UMenuButton : UserControl
    {
        public UMenuButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按钮图标
        /// </summary>
        public Image BtnImg
        {
            get { return pbImg.Image; }
            set
            {
                pbImg.Image = value;
            }
        }

        /// <summary>
        /// 按钮文本
        /// </summary>
        public string BtnText
        {
            get { return lblBtnText.Text; }
            set
            {
                lblBtnText.Text = value;
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.FromArgb(88, 116, 216);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.FromArgb(45, 50, 166);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            this.BackColor = Color.FromArgb(88, 116, 216);
        }

        private void lblBtnText_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void pbImg_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblBtnText_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void pbImg_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }
    }
}
