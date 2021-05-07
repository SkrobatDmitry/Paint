using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PaintOOP.Figures
{
    [DataContract]
    public class RegularPolygon : Figure
    {
        #region RegularPolygon Variable's
        [DataMember]
        private PointF[] vertices;

        [DataMember]
        public int numOfCorners;

        [DataMember]
        private Brush brush;
        #endregion

        #region RegularPolygon Constructor's
        public RegularPolygon() { }

        public RegularPolygon(Color color, Color fillColor, float penWidth): base(color, penWidth) 
        {
            brush = new SolidBrush(fillColor);
        }

        public RegularPolygon(int numOfCorners, Color color, Color fillColor, float penWidth) : base(color, penWidth) 
        {
            this.numOfCorners = numOfCorners;
            vertices = new PointF[numOfCorners];

            brush = new SolidBrush(fillColor);
        }
        #endregion

        public override Figure Clone()
        {
            return (RegularPolygon)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {
            if (pen == null)
            {
                SetPen();
            }

            vertices = new PointF[numOfCorners];
            vertices[0] = points[1];

            PointF o = points[0];
            PointF polar = new PointF(1 * (float)Math.Cos(Math.Acos(-1.0) * 2 / numOfCorners), 1 * (float)Math.Sin(Math.Acos(-1.0) * 2 / numOfCorners));
            PointF radNext = new PointF(points[1].X - o.X, points[1].Y - o.Y);
            PointF temp = new PointF();

            for (int i = 1; i < numOfCorners; i++)
            {
                temp.X = radNext.X * polar.X - radNext.Y * polar.Y;
                temp.Y = radNext.X * polar.Y + radNext.Y * polar.X;

                radNext.X = temp.X;
                radNext.Y = temp.Y;

                vertices[i].X = o.X + radNext.X;
                vertices[i].Y = o.Y + radNext.Y;
            }

            if (isFeel)
            {
                graphics.FillPolygon(brush, vertices);
            }

            graphics.DrawPolygon(pen, vertices);
        }
    }
}
