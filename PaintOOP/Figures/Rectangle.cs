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
        #region Rectangle Variable's
        private float width;
        private float height;

        public Brush brush;
        #endregion

        #region Rectangle Constructor's
        public Rectangle() { }

        public Rectangle(Color color, Color fillColor, float penWidth): base(color, penWidth) 
        {
            brush = new SolidBrush(fillColor);
        }

        public Rectangle(Point startPoint, Point endPoint, Color color, Color fillColor, float penWidth): base(color, penWidth)
        {
            points[0] = new Point(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y));
            points[1] = new Point(Math.Max(startPoint.X, endPoint.X), Math.Max(startPoint.Y, endPoint.Y));

            brush = new SolidBrush(fillColor);
        }
        #endregion

        public override Figure Clone()
        {
            return (Rectangle)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {
            Point leftCorner = new Point(Math.Min(points[0].X, points[1].X), Math.Min(points[0].Y, points[1].Y));
            Point rightCorner = new Point(Math.Max(points[0].X, points[1].X), Math.Max(points[0].Y, points[1].Y));

            width = rightCorner.X - leftCorner.X;
            height = rightCorner.Y - leftCorner.Y;

            if (isFeel)
            {
                graphics.FillRectangle(brush, leftCorner.X, leftCorner.Y, width, height);
            }

            graphics.DrawRectangle(pen, leftCorner.X, leftCorner.Y, width, height);
        }
    }
}
