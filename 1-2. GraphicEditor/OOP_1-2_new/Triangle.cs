using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1_2_new
{
    class Triangle : Polygon
    {
        public Triangle()
        {
            RequiredCountOfPoints = 3;
        }
    }
}


















/*
        public override sealed void Draw(Graphics g)
        {
            g.DrawPolygon(pen, listPoint.ToArray());
        }
         * */