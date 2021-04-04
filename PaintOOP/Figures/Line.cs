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
        #region Line Constructor's
        public Line() { }

        public Line(Color color, float penWidth): base(color, penWidth) { }

        public Line(Point startPoint, Point endPoint, Color color, float penWidth): base(color, penWidth)
        {
            points[0] = startPoint;
            points[1] = endPoint;
        }
        #endregion

        public override Figure Clone()
        {
            return (Line)MemberwiseClone();
        }
        
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, points[0], points[1]);
        }
    }
}
