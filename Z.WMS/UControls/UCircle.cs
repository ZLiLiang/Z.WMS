using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z.WMS.UControls
{
    public partial class UCircle : UserControl
    {
        public UCircle()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = e.ClipRectangle;

            Rectangle rect1 = new Rectangle(rect.X + 1, rect.Y + 1, rect.Width - 2, rect.Height - 2);
            g.DrawEllipse(new Pen(this.ForeColor), rect1);
            g.FillEllipse(new SolidBrush(this.ForeColor), rect1);
        }
    }
}
