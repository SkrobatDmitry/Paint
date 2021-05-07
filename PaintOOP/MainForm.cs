using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintOOP
{
    public partial class MainForm : Form
    {
        #region Variable Declaration
        private FigureStorage figureStorage;

        private Serializer serializer;

        private Bitmap bitmap;

        private Figure currentFigure;
        private ICreator currentCreator;

        private Point startPoint;
        private Point endPoint;

        private Color color;
        private Color fillColor;

        private float penWidth;
        private int cornersNum;

        private Boolean isDrawing;
        private Boolean isFeel;

        private List<Point> points;        
        #endregion

        public MainForm()
        {
            InitializeComponent();

            figureStorage = new FigureStorage();

            serializer = new Serializer();

            color = Color.Black;
            fillColor = Color.White;

            penWidth = 3;
            cornersNum = 3;

            isDrawing = false;
            isFeel = false;

            points = new List<Point>();

            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            PictureBox.Image = bitmap;
        }

        #region Figure Button's Click
        private void LineButton_Click(object sender, EventArgs e)
        {
            currentCreator = new Figures.LineCreator();
            currentFigure = currentCreator.Create(color, fillColor, penWidth);

            StateChange(currentCreator);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            currentCreator = new Figures.RectangleCreator();
            currentFigure = currentCreator.Create(color, fillColor, penWidth);

            StateChange(currentCreator);
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            currentCreator = new Figures.EllipseCreator();
            currentFigure = currentCreator.Create(color, fillColor, penWidth);

            StateChange(currentCreator);
        }

        private void PolygonButton_Click(object sender, EventArgs e)
        {
            currentCreator = new Figures.PolygonCreator();
            currentFigure = currentCreator.Create(color, fillColor, penWidth);

            StateChange(currentCreator);
        }

        private void RegularPolygonButton_Click(object sender, EventArgs e)
        {
            currentCreator = new Figures.RegularPolygonCreator();
            currentFigure = currentCreator.Create(color, fillColor, penWidth);

            (currentFigure as Figures.RegularPolygon).numOfCorners = cornersNum;
            StateChange(currentCreator);
        }

        private void BrokenLineButton_Click(object sender, EventArgs e)
        {
            currentCreator = new Figures.BrokenLineCreator();
            currentFigure = currentCreator.Create(color, fillColor, penWidth);

            StateChange(currentCreator);
        }
        #endregion

        #region Pen and Color Button's Click
        private void FirstColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                FirstColorButton.BackColor = ColorDialog.Color;
                color = ColorDialog.Color;
                
                if (currentFigure != null)
                {
                    currentFigure.color = color;
                    currentFigure.SetPen();
                }
            }
        }

        private void SecondColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                SecondColorButton.BackColor = ColorDialog.Color;
                fillColor = ColorDialog.Color;
            }

            if ((currentFigure != null) && IsFeelCheck.Enabled)
            {
                if (currentCreator.isVariableAngles)
                {
                    object[] args = new object[4] { cornersNum, color, fillColor, penWidth };
                    currentFigure = (Figure)Activator.CreateInstance(currentFigure.GetType(), args);
                }
                else
                {
                    object[] args = new object[3] { color, fillColor, penWidth };
                    currentFigure = (Figure)Activator.CreateInstance(currentFigure.GetType(), args);
                }
            }
        }

        private void PenWidthTrackBar_Scroll(object sender, EventArgs e)
        {
            penWidth = (float)PenWidthTrackBar.Value;

            if (currentFigure != null)
            {
                currentFigure.penWidth = penWidth;
                currentFigure.SetPen();
            }

            PenWidthLabel.Text = "Pen Width: " + penWidth.ToString();
        }


        private void CornersTrackBar_Scroll(object sender, EventArgs e)
        {
            cornersNum = (int)CornersTrackBar.Value;
            CornersNumLabel.Text = "Corners Num: " + cornersNum.ToString();

            (currentFigure as Figures.RegularPolygon).numOfCorners = cornersNum;
        }
        #endregion

        #region Mouse Action
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentFigure != null && !currentCreator.isManyPoint)
            {
                if (e.Button == MouseButtons.Left)
                {
                    startPoint.X = e.X;
                    startPoint.Y = e.Y;

                    points.Clear();
                    points.Add(startPoint);
                    points.Add(startPoint);

                    isDrawing = !isDrawing;
                    currentFigure.isFeel = isFeel;
                }
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing && !currentCreator.isManyPoint)
            {
                endPoint.X = e.X;
                endPoint.Y = e.Y;

                isDrawing = !isDrawing;

                if (startPoint != endPoint)
                { 
                    points[1] = endPoint;
                    figureStorage.undoList.Add(currentFigure);

                    if (!figureStorage.redoStack.IsEmpty())
                    {
                        figureStorage.redoStack.ClearStack();
                        RedoButton.Enabled = false;
                    }

                    UndoButton.Enabled = true;
                }

                currentFigure = currentFigure.Clone();
            }
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentCreator != null && currentCreator.isManyPoint)
            {
                if (e.Button == MouseButtons.Left)
                {
                    startPoint.X = e.X;
                    startPoint.Y = e.Y;

                    if (!isDrawing)
                    {
                        points.Clear();
                        points.Add(startPoint);
                        points.Add(startPoint);

                        isDrawing = !isDrawing;

                        currentFigure.isFeel = isFeel;
                    }
                    else
                    {
                        points.Add(startPoint);
                    }
                }
                else if (e.Button == MouseButtons.Right && isDrawing)
                {
                    isDrawing = !isDrawing;

                    UndoButton.Enabled = true;
                    figureStorage.undoList.Add(currentFigure);
                    currentFigure = currentFigure.Clone();

                    if (!figureStorage.redoStack.IsEmpty())
                    {
                        figureStorage.redoStack.ClearStack();
                        RedoButton.Enabled = false;
                    }
                }
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint.X = e.X;
                endPoint.Y = e.Y;

                points[points.Count - 1] = endPoint;

                currentFigure.points = points.ToArray();
                PictureBox.Refresh();
            }
        }
        #endregion

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            figureStorage.DrawFigures(e.Graphics);
            if (isDrawing)
            {
                currentFigure.Draw(e.Graphics);
            }
        }

        #region Button's Action
        private void IsFeelCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (IsFeelCheck.Checked)
            {
                isFeel = true;
            }
            else
            {
                isFeel = false;
            }
        }

        private void StateChange(ICreator creator)
        {
            if (creator.isCanFeel)
            {
                IsFeelCheck.Enabled = true;
            }
            else
            {
                IsFeelCheck.Enabled = false;
            }

            if (creator.isVariableAngles)
            {
                CornersTrackBar.Visible = true;
                CornersNumLabel.Visible = true;
            }
            else
            {
                CornersTrackBar.Visible = false;
                CornersNumLabel.Visible = false;
            }
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            figureStorage.Undo();
            PictureBox.Refresh();

            RedoButton.Enabled = true;
            if (figureStorage.undoList.IsEmpty())
            {
                UndoButton.Enabled = false;
            }
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            figureStorage.Redo();
            PictureBox.Refresh();

            UndoButton.Enabled = true;
            if (figureStorage.redoStack.IsEmpty())
            {
                RedoButton.Enabled = false;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            figureStorage.Clear();
            PictureBox.Refresh();

            UndoButton.Enabled = false;
            RedoButton.Enabled = false;
        }

        private void MainForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Многоугольник | Ломанная :\nЛКМ - поставить новую точку\nПКМ - поставить последнюю точку\n\nОстальные фигуры :\nЛКМ - начать рисование\nОтпустить ЛКМ - закончить рисование", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region De|Serialize Button's Action
        private void SerializerButton_Click(object sender, EventArgs e)
        {
            serializer.Serialize(figureStorage);
        }

        private void DeserializerButton_Click(object sender, EventArgs e)
        {
            figureStorage = serializer.Deserialize(figureStorage);
            PictureBox.Refresh();

            if (!figureStorage.undoList.IsEmpty())
            {
                UndoButton.Enabled = true;
            }
            if (!figureStorage.redoStack.IsEmpty())
            {
                RedoButton.Enabled = true;
            }
        }
        #endregion
    }
}