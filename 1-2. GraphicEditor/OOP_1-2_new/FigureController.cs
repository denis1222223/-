using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_1_2_new
{
    class FigureController
    {
        private List<Figure> drawnList = new List<Figure>();
        private Figure bufferedFigure;
        private FigureFactory currentFactory;

        public void CreateBufferedFigure(FigureFactory factory)
        {
            bufferedFigure = factory.GetFigure();
            currentFactory = factory;
        }
        public void SetNextPoint(Point point)
        {
            if (bufferedFigure != null)
                bufferedFigure.listPoint.Add(point);
        }
        public void DrawIfPosible(Graphics graphics)
        {
            if ((bufferedFigure != null) && (bufferedFigure.listPoint.Count == bufferedFigure.RequiredCountOfPoints))
            {
                try
                {
                    bufferedFigure.Draw(graphics);
                    drawnList.Add(bufferedFigure);
                    bufferedFigure = currentFactory.GetFigure();
                }
                catch
                {
                    MessageBox.Show("Вы указали не все точки", "Предупреждение");
                }
            }
        }
        public void ClearDrawnList()
        {
            drawnList.Clear();
        }
        public void DrawAllDrawnList(Graphics graphics)
        {
            foreach (Figure f in drawnList)
            {
                f.Draw(graphics);
            }
        }
        public void DeleteLastFigure()
        {
            if (drawnList.Count != 0)
                drawnList.RemoveAt(drawnList.Count-1);
        }
        public void FinishPointsSetting()
        {
            if (bufferedFigure != null)
            {
                bufferedFigure.RequiredCountOfPoints = bufferedFigure.listPoint.Count;
            }
        }
        public void SetColor(Color color)
        {
            if (bufferedFigure != null)
                bufferedFigure.pen.Color = color;
        }
    }
}
