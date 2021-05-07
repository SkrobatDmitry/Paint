using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PaintOOP.UndoRedo
{
    [DataContract]
    public class UndoList
    {
        [DataMember]
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