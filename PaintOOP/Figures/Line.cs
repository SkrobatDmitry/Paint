using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Figures
{
    public class Line : Figure
    {
        public Line(PointF start, PointF end, Color color, float penWidth)
        {
            startPoint = start;
            endPoint = end;

            pen = new Pen(color, penWidth);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, startPoint, endPoint);
        }
    }
}
