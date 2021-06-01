using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using PaintOOP;

namespace TrapezoidDLL
{
    [DataContract]
    public class Trapezoid : Figure
    {
        #region Trapezoid Variable's
        [DataMember]
        private Point[] vertices;

        [DataMember]
        private Brush brush;
        #endregion

        #region Trapezoid Constructor's
        public Trapezoid() { }

        public Trapezoid(Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            brush = new SolidBrush(fillColor);
        }
        #endregion

        public override Figure Clone()
        {
            return (Trapezoid)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {
            int width = Math.Abs(points[1].X - points[0].X) / 3;
            vertices = new Point[4] { new Point(points[0].X + width, points[0].Y), new Point(points[1].X - width, points[0].Y), 
                                      points[1], new Point(points[0].X, points[1].Y) };

            if (pen == null)
            {
                SetPen();
            }

            if (isFeel)
            {
                graphics.FillPolygon(brush, vertices);
            }

            graphics.DrawPolygon(pen, vertices);
        }
    }
}
