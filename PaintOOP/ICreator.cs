using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP
{
    public interface ICreator
    {
        bool isManyPoint { get; }
        bool isCanFeel { get; }
        bool isVariableAngles { get; }

        Figure Create(Color color, Color fillColor, float penWidth);
    }

    public class FactoryAttribute : Attribute
    {
        private string toolName;
        public string ToolName { get => toolName; set => toolName = value; }

        public FactoryAttribute() { }

        public FactoryAttribute(string toolName)
        {
            this.toolName = toolName;
        }
    }
}
