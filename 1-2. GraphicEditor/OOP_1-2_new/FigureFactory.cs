using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1_2_new
{
    interface FigureFactory
    {
        Figure GetFigure();
    }

    class RectangleFactory : FigureFactory
    {
        public Figure GetFigure()
        {
            return new Rectangle();
        }
    }

    class SquareFactory : FigureFactory
    {
        public Figure GetFigure()
        {
            return new Square();
        }
    }

    class EllipseFactory : FigureFactory
    {
        public Figure GetFigure()
        {
            return new Ellipse();
        }
    }

    class CircleFactory : FigureFactory
    {
        public Figure GetFigure()
        {
            return new Circle();
        }
    }

    class LineFactory : FigureFactory
    {
        public Figure GetFigure()
        {
            return new Line();
        }
    }

    class TriangleFactory : FigureFactory
    {
        public Figure GetFigure()
        {
            return new Triangle();
        }
    }

    class PolygonFactory : FigureFactory
    {
        public Figure GetFigure()
        {
            return new Polygon();
        }
    }
}
