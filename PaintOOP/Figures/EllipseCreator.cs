using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Figures
{
    public class EllipseCreator : ICreator
    {
        public bool isManyPoint { get { return false; } }
        public bool isCanFeel { get { return true; } }
        public bool isVariableAngles { get { return false; } }

        public Figure Create(Color color, Color fillColor, float penWidth)
        {
            return new Ellipse(color, fillColor, penWidth);
        }
    }
}
