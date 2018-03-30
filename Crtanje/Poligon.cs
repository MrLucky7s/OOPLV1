using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crtanje
{
    class Poligon : GraphicObject
    {
        private Point[] Points = new Point[31];
        public Poligon(Point firstCoo, Color color, Point[] points) : base(firstCoo, color)
        {
            Points = points;
        }
        public override void DrawGraphicsObject(Graphics drawing)
        {
            drawing.DrawPolygon(new Pen(Color, 1), Points);
        }
    }

}
