using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Common;

namespace Z.WMS.UControls
{
    public partial class UPanel : Panel
    {
        private const int WM_PAINT = 0xF;

        public UPanel()
        {
            InitializeComponent();
        }
        private Color bgColor = Color.Gray;

        /// <summary>
        /// 背景色（渐变色中，颜色1）
        /// </summary>
        [DefaultValue(typeof(Color), "Gray"), Description("控件背景色")]
        public Color BgColor
        {
            get { return bgColor; }
            set
            {
                bgColor = value;
                Invalidate();
            }
        }

        private Color borderColor = Color.Red;
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

        [DefaultValue(typeof(Color), "Gray"), Description("控件背景颜色2")]
        private Color bgColor2 = Color.White;
        public Color BgColor2
        {
            get { return bgColor2; }
            set
            {
                bgColor2 = value;
                Invalidate();
            }
        }


        [DefaultValue(typeof(int), "5"), Description("圆角弧度大小")]
        private int radius = 5;
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();
            }
        }

        [DefaultValue(typeof(LinearGradientMode), "Vertical"), Description("渐变方式")]
        private LinearGradientMode gradientMode = LinearGradientMode.Vertical;
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
                if (this.Radius > 0)
                {
                    using (Graphics g = Graphics.FromHwnd(this.Handle))
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        Rectangle r = new Rectangle();
                        r.Width = this.Width;
                        r.Height = this.Height;
                        DrawBorder(g, r, this.Radius);
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
