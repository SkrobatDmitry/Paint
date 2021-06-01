using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace PaintOOP
{
    public class Plugin
    {
        private Dictionary<string, Type> pluginDict = new Dictionary<string, Type>();

        public string Load()
        {
            string name = "";
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"File dll (*.dll)|*.dll"
            };

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Assembly plugin = Assembly.LoadFrom(openFileDialog.FileName);
                    Type[] types = plugin.GetTypes();
                    foreach (Type current in types)
                    {
                        foreach (Attribute attribute in current.GetCustomAttributes())
                        {
                            FactoryAttribute factoryAttribute = attribute as FactoryAttribute;
                            if (factoryAttribute != null)
                            {
                                pluginDict.Add(factoryAttribute.ToolName, current);
                                name = factoryAttribute.ToolName;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return name;
        }

        public Type GetPluginType(string pluginName)
        {
            return pluginDict[pluginName];
        }
    }
}
