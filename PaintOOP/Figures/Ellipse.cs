using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Figures
{
    public class Ellipse : Figure
    {
        #region Ellipse Variable's
        private float width;
        private float height;

        private Brush brush;
        #endregion
        
        #region Ellipse Constructor's
        public Ellipse() { }

        public Ellipse(Color color, Color fillColor, float penWidth): base(color, penWidth) 
        {
            brush = new SolidBrush(fillColor);
        }

        public Ellipse(Point startPoint, Point endPoint, Color color, Color fillColor, float penWidth): base(color, penWidth)
        {
            points[0] = new Point(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y)); 
            points[1] = new Point(Math.Max(startPoint.X, endPoint.X), Math.Max(startPoint.Y, endPoint.Y));

            brush = new SolidBrush(fillColor);
        }
        #endregion

        public override Figure Clone()
        {
            return (Ellipse)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {
            width = points[1].X - points[0].X;
            height = points[1].Y - points[0].Y;

            if (isFeel)
            {
                graphics.FillEllipse(brush, points[0].X, points[0].Y, width, height);
            }

            graphics.DrawEllipse(pen, points[0].X, points[0].Y, width, height);
        }
    }
}