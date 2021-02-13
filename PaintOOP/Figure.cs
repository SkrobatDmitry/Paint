using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP
{
    public abstract class Figure
    {
        public PointF startPoint { get; set; }
        public PointF endPoint { get; set; }

        public Pen pen { get; set; }
        public abstract void Draw(Graphics graphics);
    }
}
