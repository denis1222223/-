using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOP_1_2_new
{
    class Line : Rectangle
    {
        public override sealed void Draw(Graphics g)
        {
            g.DrawLine(pen, listPoint[0].X, listPoint[0].Y, listPoint[1].X, listPoint[1].Y);
        }
    }
}







/*
public Line()
        {
            requiredCountOfPoints = 2;
        }
*/