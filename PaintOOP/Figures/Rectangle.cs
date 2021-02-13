using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Figures
{
    public class Rectangle : Figure
    {
        public Brush brush { get; set; }

        public Rectangle(PointF start, PointF end, Color color, Color fillColor, float penWidth)
        {
            PointF pointStart = new PointF(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y));
            PointF pointEnd = new PointF(Math.Max(start.X, end.X), Math.Max(start.Y, end.Y));

            startPoint = pointStart;
            endPoint = pointEnd;

            pen = new Pen(color, penWidth);
            brush = new SolidBrush(fillColor);
        }

        public override void Draw(Graphics graphics)
        {
            float width = endPoint.X - startPoint.X;
            float height = endPoint.Y - startPoint.Y;

            graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, width, height);
            graphics.FillRectangle(brush, startPoint.X, startPoint.Y, width, height);
        }
    }
}
