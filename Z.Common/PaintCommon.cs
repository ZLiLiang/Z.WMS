using System.Drawing;
using System.Drawing.Drawing2D;

namespace Z.Common
{
    public class PaintCommon
    {
        /// <summary>
        /// 根据矩形画圆角
        /// </summary>
        /// <param name="rectangle"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static GraphicsPath GetRoundRectangle(Rectangle rectangle, int r)
        {
            int i = 2 * r;
            // 把圆角矩形分成八段直线、弧的组合，依次加到路径中 
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(new Point(rectangle.X + r, rectangle.Y), new Point(rectangle.Right - r, rectangle.Y));
            gp.AddArc(new Rectangle(rectangle.Right - 1, rectangle.Y, i, i), 270F, 90F);

            gp.AddLine(new Point(rectangle.Right, rectangle.Y + r), new Point(rectangle.Right, rectangle.Bottom - r));
            gp.AddArc(new Rectangle(rectangle.Right - 1, rectangle.Bottom - 1, i, i), 0F, 90F);

            gp.AddLine(new Point(rectangle.Right - r, rectangle.Bottom), new Point(rectangle.X + r, rectangle.Bottom));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Bottom - 1, i, i), 90F, 90F);

            gp.AddLine(new Point(rectangle.X, rectangle.Bottom - r), new Point(rectangle.X, rectangle.Y + r));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Y, i, i), 180F, 90F);
            return gp;
        }
    }
}
