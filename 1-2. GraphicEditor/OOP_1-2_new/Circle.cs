using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOP_1_2_new
{
	// for git
    class Circle : Ellipse
    {
        public override sealed void Draw(Graphics g)
        {
            if ((listPoint[1].X - listPoint[0].X) >= (listPoint[1].Y - listPoint[0].Y))
                g.DrawEllipse(pen, listPoint[0].X, listPoint[0].Y, listPoint[1].Y - listPoint[0].Y, listPoint[1].Y - listPoint[0].Y);
            else
                g.DrawEllipse(pen, listPoint[0].X, listPoint[0].Y, listPoint[1].X - listPoint[0].X, listPoint[1].X - listPoint[0].X);
        }

    }
}
























/*
        public Circle()
        {
            requiredCountOfPoints = 2;
        }
*/