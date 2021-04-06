using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.UndoRedo
{
    public class FigureStorage
    {
        public UndoList undoList;
        public RedoStack redoStack;

        public FigureStorage()
        {
            undoList = new UndoList();
            redoStack = new RedoStack();
        }

        public void Undo()
        {
            if (!undoList.IsEmpty())
            {
                redoStack.PushStack(undoList.RemoveLast());
            }
        }

        public void Redo()
        {
            if (!redoStack.IsEmpty())
            {
                undoList.Add(redoStack.PopStack());
            }
        }

        public void Clear()
        {
            undoList.ClearList();
            redoStack.ClearStack();
        }

        public void DrawFigures(Graphics graphics)
        {
            int count = undoList.ListCount();
            for (int i = 0; i < count; i++)
            {
                undoList.ReturnThis(i).Draw(graphics);
            }
        }
    }
}
