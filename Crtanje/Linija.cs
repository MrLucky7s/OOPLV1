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
    class Linija : GraphicObject
    {
        protected Point secondCoo { get; set; }


        public Linija(Point firstCoo, Color color, Point secondCoo) : base(firstCoo, color)
        {
            this.secondCoo = secondCoo;
        }

        public override void DrawGraphicsObject(Graphics drawing)
        {
            drawing.DrawLine(new Pen(Color, 1), firstCoo, secondCoo);

        }
    }

}
