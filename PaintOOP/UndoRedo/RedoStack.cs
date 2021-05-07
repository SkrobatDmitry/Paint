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
    public class RedoStack
    {
        [DataMember]
        private Stack<Figure> redoStack;

        public RedoStack()
        {
            redoStack = new Stack<Figure>();
        }

        public void PushStack(Figure figure)
        {
            redoStack.Push(figure);
        }

        public Figure PopStack()
        {
            return redoStack.Pop();
        }

        public bool IsEmpty()
        {
            if (redoStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearStack()
        {
            redoStack.Clear();
        }
    }
}
