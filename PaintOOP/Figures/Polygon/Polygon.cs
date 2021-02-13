using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Figures
{
    public abstract class Polygon : Figure
    {
        public PointF[] vertices { get; set; }
        public Brush brush { get; set; }

        public Polygon(Color color, Color fillColor, float penWidth)
        {
            pen = new Pen(color, penWidth);
            brush = new SolidBrush(fillColor);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen, vertices);
            graphics.FillPolygon(brush, vertices);
        }
    }
}
