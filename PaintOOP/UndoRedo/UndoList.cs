using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.UndoRedo
{
    public class UndoList
    {
        private List<Figure> undoList;

        public UndoList()
        {
            undoList = new List<Figure>();
        }

        public void Add(Figure figure)
        {
            undoList.Add(figure);
        }

        public Figure RemoveLast()
        {
            Figure temp = undoList.Last();
            undoList.Remove(undoList.Last());
            return temp;
        }

        public Figure ReturnThis(int ind)
        {
            return undoList.ElementAt(ind);
        }

        public bool IsEmpty()
        {
            if (undoList.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ListCount()
        {
            return undoList.Count();
        }

        public void ClearList()
        {
            undoList.Clear();
        }
    }
}