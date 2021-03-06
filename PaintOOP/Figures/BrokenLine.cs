﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PaintOOP.Figures
{
    [DataContract]
    class BrokenLine : Figure
    {
        #region BrokenLine Constructor's
        public BrokenLine() { }

        public BrokenLine(Color color, float penWidth): base(color, penWidth) { }

        public BrokenLine(Point[] points, Color color, float penWidth): base(color, penWidth)
        {
            this.points = points;
        }
        #endregion

        public override Figure Clone()
        {
            return (BrokenLine)MemberwiseClone();
        }

        public override void Draw(Graphics graphics)
        {
            if (pen ==  null)
            {
                SetPen();
            }

            graphics.DrawLines(pen, points);
        }
    }
}
