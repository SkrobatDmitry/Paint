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
        private Graphics graphics;
        private FigureList figureList;

        public MainForm()
        {
            InitializeComponent();

            graphics = CreateGraphics(pictureBox.Width, pictureBox.Height);
            figureList = new FigureList();

            Figures.Rectangle rectangle1 = new Figures.Rectangle(new PointF(0.0F, 0.0F), new PointF(1280.0F, 720.0F), ColorTranslator.FromHtml("#9AD9EA"), ColorTranslator.FromHtml("#9AD9EA"), 0.0F);
            figureList.Add(rectangle1);

            Figures.Rectangle rectangle2 = new Figures.Rectangle(new PointF(0.0F, 450.0F), new PointF(1280.0F, 720.0F), ColorTranslator.FromHtml("#23B14D"), ColorTranslator.FromHtml("#23B14D"), 0.0F);
            figureList.Add(rectangle2);

            Figures.Rectangle rectangle3 = new Figures.Rectangle(new PointF(400.0F, 300.0F), new PointF(880.0F, 500.0F), Color.Black, Color.White, 3.0F);
            figureList.Add(rectangle3);

            Figures.Rectangle rectangle4 = new Figures.Rectangle(new PointF(360.0F, 150.0F), new PointF(920.0F, 300.0F), Color.Black, Color.White, 3.0F);
            figureList.Add(rectangle4);

            Figures.Rectangle rectangle5 = new Figures.Rectangle(new PointF(1050.0F, 200.0F), new PointF(1075.0F, 460.0F), Color.Black, Color.Brown, 3.0F);
            figureList.Add(rectangle5);

            Figures.RegularPolygon polygon1 = new Figures.RegularPolygon(new PointF(490.0F, 225.0F), 50.0F, 4, Color.Black, ColorTranslator.FromHtml("#9AD9EA"), 5.0F);
            figureList.Add(polygon1);

            Figures.RegularPolygon polygon2 = new Figures.RegularPolygon(new PointF(640.0F, 225.0F), 50.0F, 4, Color.Black, ColorTranslator.FromHtml("#9AD9EA"), 5.0F);
            figureList.Add(polygon2);

            Figures.RegularPolygon polygon3 = new Figures.RegularPolygon(new PointF(790.0F, 225.0F), 50.0F, 4, Color.Black, ColorTranslator.FromHtml("#9AD9EA"), 5.0F);
            figureList.Add(polygon3);

            Figures.RegularPolygon polygon4 = new Figures.RegularPolygon(new PointF(1062.5F, 230.0F), 75.0F, 8, Color.Black, ColorTranslator.FromHtml("#23B14D"), 5.0F);
            figureList.Add(polygon4);

            Figures.Ellipse ellipse1 = new Figures.Ellipse(new PointF(450.0F, 350.0F), new PointF(830.0F, 450.0F), Color.Black, ColorTranslator.FromHtml("#9AD9EA"), 5.0F);
            figureList.Add(ellipse1);

            Figures.Ellipse ellipse2 = new Figures.Ellipse(new PointF(150.0F, 450.0F), new PointF(250.0F, 500.0F), Color.Black, ColorTranslator.FromHtml("#23B14D"), 3.0F);
            figureList.Add(ellipse2);

            Figures.Ellipse ellipse3 = new Figures.Ellipse(new PointF(175.0F, 420.0F), new PointF(230.0F, 500.0F), Color.Black, ColorTranslator.FromHtml("#23B14D"), 3.0F);
            figureList.Add(ellipse3);

            Figures.Ellipse ellipse4 = new Figures.Ellipse(new PointF(50.0F, 50.0F), new PointF(250.0F, 250.0F), Color.Black, ColorTranslator.FromHtml("#FEF200"), 3.0F);
            figureList.Add(ellipse4);

            Figures.Line line1 = new Figures.Line(new PointF(450.0F, 400.0F), new PointF(830.0F, 400.0F), Color.Black, 2.5F);
            figureList.Add(line1);

            Figures.Line line2 = new Figures.Line(new PointF(640.0F, 350.0F), new PointF(640.0F, 450.0F), Color.Black, 2.5F);
            figureList.Add(line2);

            figureList.DrawFigures(graphics);
        }

        private Graphics CreateGraphics(int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            pictureBox.Image = bitmap;
            return Graphics.FromImage(bitmap);
        }
    }
}
