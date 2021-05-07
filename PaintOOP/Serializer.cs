using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace PaintOOP
{    
    class Serializer
    {
        readonly JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };

        private OpenFileDialog openDialog = new OpenFileDialog();
        private SaveFileDialog saveDialog = new SaveFileDialog();

        public void Serialize(FigureStorage figureStorage)
        {
            JsonSerializer serializer = JsonSerializer.Create(settings);

            try
            {
                saveDialog.DefaultExt = ".json";
                saveDialog.Filter = "JSON files (*.json)|*json|Text files (*.txt)|*txt";

                saveDialog.ShowDialog();
                string fileName = saveDialog.FileName;

                if (fileName != "")
                {
                    using StreamWriter streamWriter = new StreamWriter(fileName);
                    using JsonWriter jsonWriter = new JsonTextWriter(streamWriter);
                    serializer.Serialize(jsonWriter, figureStorage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FigureStorage Deserialize(FigureStorage currentFigureStorage)
        {
            try
            {
                FigureStorage figureStorage = new FigureStorage();

                openDialog.ShowDialog();
                string fileName = openDialog.FileName;

                if (fileName != "")
                {
                    using FileStream fStream = File.OpenRead(fileName);
                    string streamReader = new StreamReader(fStream).ReadToEnd();
                    figureStorage = JsonConvert.DeserializeObject<FigureStorage>(streamReader, settings);

                    return figureStorage;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return currentFigureStorage;
        }
    }
}
