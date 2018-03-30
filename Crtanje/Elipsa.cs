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
    class Elipsa : Kruznica
    {
        public Elipsa(Point firstCoo, Color color, Point secondCoo) : base(firstCoo, color, secondCoo)
        {
        }

        public override void DrawGraphicsObject(Graphics drawing)
        {
            drawing.DrawEllipse(new Pen(Color, 1), firstCoo.X, firstCoo.Y, secondCoo.X - firstCoo.X,
                secondCoo.Y - firstCoo.Y);
        }
    }

}
