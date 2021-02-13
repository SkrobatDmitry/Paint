using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Figures
{
    public class RegularPolygon : Polygon
    {
        public RegularPolygon(PointF center, float radius, int num, Color color, Color fillColor, float penWidth): base(color, fillColor, penWidth)
        {
            double angle = Math.PI * 2 / num;
            vertices = Enumerable.Range(0, num).Select(i => PointF.Add(center, new SizeF((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius))).ToArray();
        }
    }
}
