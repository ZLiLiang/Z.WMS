using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Common;

namespace Z.WMS.UControls
{
    public partial class UCircleButton : Button
    {
        public UCircleButton()
        {
            InitializeComponent();
        }
        private const int WM_PAINT = 0xF;

        private Color bgColor = Color.Gray;
        /// <summary>
        /// 背景色（渐变色中，颜色1）
        /// </summary>
        [DefaultValue(typeof(Color), "Gray"), Description("控件背景色")]
        public Color BgColor
        {
            get { return bgColor; }
            set { bgColor = value; Invalidate(); }
        }

        private Color bgColor2 = Color.Transparent;
        [DefaultValue(typeof(Color), "Transparent"), Description("控件背景颜色2")]
        public Color BgColor2
        {
            get { return bgColor2; }
            set { bgColor2 = value; Invalidate(); }
        }

        private Color borderColor = Color.Gray;
        [DefaultValue(typeof(Color), "Gray"), Description("控件边框颜色")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        private int borderWidth = 0;
        [DefaultValue(typeof(int), "0"), Description("控件边框粗细")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }

        private int radius = 5;
        [DefaultValue(typeof(int), "5"), Description("圆角弧度大小")]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();
            }
        }

        private LinearGradientMode gradientMode = LinearGradientMode.Vertical;
        [DefaultValue(typeof(LinearGradientMode), "Vertical"), Description("渐变方式")]
        public LinearGradientMode GradientMode
        {
            get { return gradientMode; }
            set
            {
                gradientMode = value;
                Invalidate();
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                //绘制工作：重绘边框、背景、按钮文本Text
                if (this.Radius > 0)
                {
                    using (Graphics g = Graphics.FromHwnd(this.Handle))
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        Rectangle r = new Rectangle();
                        r.Width = this.Width;
                        r.Height = this.Height;
                        DrawBorder(g, r, this.Radius);//绘制边框和背景还有文本
                    }
                }
            }
        }

        private void DrawBorder(Graphics g, Rectangle rect, int radius)
        {
            rect.Width -= 1;
            rect.Height -= 1;
            if (BorderWidth > 0)//边框粗细>0
            {
                GraphicsPath path = new GraphicsPath();
                path = PaintCommon.GetRoundRectangle(rect, radius);//绘制圆角矩形路径
                using (Pen pen = new Pen(this.BorderColor, BorderWidth))
                {
                    g.DrawPath(pen, path);
                }
            }
            //背景区域的矩形
            Rectangle rect1 = new Rectangle(rect.X + BorderWidth, rect.Y + BorderWidth, rect.Width - 2 * BorderWidth, rect.Height - 2 * BorderWidth);
            DrawBackColor(g, rect1, radius);// 绘制背景
            //绘制按钮文本
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Rectangle rect2 = new Rectangle(5, 5, rect.Width - 10, rect.Height - 10);
            g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), rect1, format);
        }

        /// <summary>
        /// 绘制背景
        /// </summary>
        /// <param name="g"></param>
        /// <param name="rect"></param>
        /// <param name="radius"></param>
        private void DrawBackColor(Graphics g, Rectangle rect, int radius)
        {
            //获取背景区域的圆角矩形
            GraphicsPath path = PaintCommon.GetRoundRectangle(rect, radius);
            if (this.BgColor2 != Color.Transparent)
            {
                //线型渐变画刷
                LinearGradientBrush brush = new LinearGradientBrush(rect, BgColor, BgColor2, gradientMode);
                g.FillPath(brush, path);//填充圆角矩形内部
            }
            else
            {
                Brush brush = new SolidBrush(BgColor);
                g.FillPath(brush, path);//填充圆角矩形内部
            }
        }
    }
}
