using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace OOP_1_2_new
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        FigureController figureController = new FigureController();
        Dictionary<string, FigureFactory> availableFigures = new Dictionary<string, FigureFactory>();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Height = this.Height - 80;
            pictureBox1.Width = this.Width - 200;
            pictureBox1.Height = this.Height - 80;
            panelColor.Top = panel1.Top + panel1.Height - 65;
            graphics = pictureBox1.CreateGraphics();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = pictureBox1.CreateGraphics();
            availableFigures.Add("Rectangle", new RectangleFactory());
            availableFigures.Add("Square", new SquareFactory());
            availableFigures.Add("Ellipse", new EllipseFactory());
            availableFigures.Add("Circle", new CircleFactory());
            availableFigures.Add("Line", new LineFactory());
            availableFigures.Add("Triangle", new TriangleFactory());
            availableFigures.Add("Polygon", new PolygonFactory());

            int top = 20;

            foreach (KeyValuePair<string, FigureFactory> f in availableFigures)
            {
                Button button = new Button();
                button.Text = f.Key;
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.White;
                button.Left = 40;
                button.Top = top;
                button.Click += new EventHandler(OnClick); //delegate, event
                panel1.Controls.Add(button);
                top += 29;
            }
        }
        private void OnClick(object sender, System.EventArgs e)
        {
            figureController.CreateBufferedFigure(availableFigures[((Button)sender).Text]);
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "bmp";
            saveFileDialog.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
             /*   Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                graphics = Graphics.FromImage(b);
                pictureBox1.Image = b; 
                pictureBox1.Image.Save(saveFileDialog.FileName);*/
            }
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Графический редактор (Аль-Хелали Д). \n\nДля завершения рисования многоугольника нажмите Пробел.");
        }
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            figureController.ClearDrawnList();
        }
        private void Cancel()
        {
            figureController.DeleteLastFigure();
            graphics.Clear(Color.White);
            figureController.DrawAllDrawnList(graphics);
        }
        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                Cancel();
            }
            else
                if (e.KeyCode == Keys.Space)
                {
                    figureController.FinishPointsSetting();
                    figureController.DrawIfPosible(graphics);
                }

        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            figureController.SetNextPoint(new Point(e.X, e.Y));
            figureController.SetColor(colorDialog1.Color);
            figureController.DrawIfPosible(graphics);
        }
        private void panelColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panelColor.BackColor = colorDialog1.Color;
            }
        }
    }
}
