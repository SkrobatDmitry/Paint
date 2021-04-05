using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Figures
{
    public class Polygon : Figure
    {
        public Brush brush;

        #region Polygon Constructor's
        public Polygon() { }

        public Polygon(Color color, Color fillColor, float penWidth): base(color, penWidth)
        {
            brush = new SolidBrush(fillColor);
        }
        #endregion

        public override Figure Clone()
        {
            return (Polygon)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {
            if (isFeel)
            {
                graphics.FillPolygon(brush, points);
            }

            graphics.DrawPolygon(pen, points);
        }
    }
}
