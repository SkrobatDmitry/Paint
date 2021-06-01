using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintOOP;

namespace TrapezoidDLL
{
    [Factory("Trapezoid")]
    public class TrapezoidCreator : ICreator
    {
        public bool isManyPoint { get { return false; } }
        public bool isCanFeel { get { return true; } }
        public bool isVariableAngles { get { return false; } }

        public Figure Create(Color color, Color fillColor, float penWidth)
        {
            return new Trapezoid(color, fillColor, penWidth);
        }
    }
}