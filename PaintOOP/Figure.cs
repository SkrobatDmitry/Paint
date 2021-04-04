﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP
{
    public abstract class Figure
    {
        #region Variable's
        public Point[] points; 

        public Pen pen { get; set; }

        public Boolean isFeel { get; set; }
        #endregion

        #region Constructor's
        public Figure() { }

        public Figure(Color color, float penWidth)
        {
            pen = new Pen(color, penWidth);
        }
        #endregion

        public abstract Figure Clone();

        public abstract void Draw(Graphics graphics);
    }
}
