using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP
{
    public class FigureList
    {
        private List<Figure> figureList;

        public FigureList()
        {
            figureList = new List<Figure>();
        }

        public void Add(Figure figure)
        {
            figureList.Add(figure);
        }

        public void DrawFigures(Graphics graphics)
        {
            foreach (Figure figure in figureList)
            {
                figure.Draw(graphics);
            }    
        }
    }
}