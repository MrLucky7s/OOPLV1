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
    class GraphicObject
    {
        protected Point firstCoo;
        protected Color Color { get; set; }

        public GraphicObject() { }

        public GraphicObject(Point firstCoo, Color color)
        {
            this.firstCoo = firstCoo;
            Color = color;
        }

        virtual public void DrawGraphicsObject(Graphics drawing) { }
    }
}
