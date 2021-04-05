using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Figures
{
    public class BrokenLineCreator : ICreator
    {
        public bool isManyPoint { get { return true; } }
        public bool isCanFeel { get { return false; } }
        public bool isVariableAngles { get { return false; } }

        public Figure Create(Color color, Color fillColor, float penWidth)
        {
            return new BrokenLine(color, penWidth);
        }
    }
}
