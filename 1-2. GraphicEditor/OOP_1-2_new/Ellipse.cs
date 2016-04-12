using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOP_1_2_new
{
    class Ellipse : Figure
    {
        public Ellipse()
        {
            RequiredCountOfPoints = 2;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, listPoint[0].X, listPoint[0].Y, listPoint[1].X - listPoint[0].X, listPoint[1].Y - listPoint[0].Y);
        }
    }
}









/*
        public Ellipse()
        {
            requiredCountOfPoints = 2;
        }
*/