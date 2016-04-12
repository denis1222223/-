using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace OOP_1_2_new
{
    abstract class Figure
    {
        public List<Point> listPoint { get; set; }
        public int RequiredCountOfPoints { get; set; }
        public Pen pen { get; set; }
        public Figure()
        {
            listPoint = new List<Point>();
            pen = new Pen(Color.Black, 3);
        }
        public virtual void Draw(Graphics g){}
    }
}
