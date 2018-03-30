using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// program i dalje precrtava prek već nacrtanih oblika, također se pri crtanju oblika koji nisu linija ili poligon znaju na početnim koordinatama pojaviti isti oblici
namespace Crtanje
{
    public partial class Form1 : Form
    {
        //definiranje i inicijaliziranje varijabli
        Point firstCoo, secondCoo;
        Point[] tocke = new Point[31];
        int br = 0, i;
        Color color;
        bool mouseDown;
        Graphics go;
        Pen invisipen;

        public Form1()
        {
            InitializeComponent();
            go = this.CreateGraphics();
            invisipen = new Pen(BackColor, 10);
            rdBtnLn.Checked = true;
            rdBtnBlack.Checked = true;
            label1.Visible = false;
            label2.Visible = false;
        }


        //resetiranje koordinata pri puštanju miša

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            {
                mouseDown = false;
                firstCoo.X = 0;
                firstCoo.Y = 0;
                secondCoo.X = 0;
                secondCoo.Y = 0;
            }
        }


        //aktiviranje labeli pri odabiru opcije crtanja poligona
        private void rdBtnPol_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label1.Text = "Nije postavljena\nni jedna tocka.";
            label2.Text = "Srednjom tipkom misa se\noznacavaju tocke\npoligona, desnim klikom\nse crta definirani poligon.";

        }

        //deaktiviranje labeli za sve ostale opcije

        private void rdBtnLn_CheckedChange(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;

        }

        //deaktiviranje labeli za sve ostale opcije

        private void rdBtnRec_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;

        }
        //deaktiviranje labeli za sve ostale opcije

        private void rdBtnCir_ChekedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;

        }
        //deaktiviranje labeli za sve ostale opcije

        private void rdBtnEll_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;

        }


        //crtanje poligona, prvo s definiraju točke koje se onda povežu linijom željene boje (ideja za rješenje je uzeta sa stackoverflow-a)
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            firstCoo = e.Location;
            mouseDown = true;

            if (rdBtnPol.Checked)
            {

                if (e.Button == MouseButtons.Middle)
                {
                    go.DrawRectangle(new Pen(Color.Red, 2), e.Location.X, e.Location.Y, 1, 1);
                    if (br < 31)
                    {
                        tocke[br] = e.Location;
                        br++;
                        label1.Text = br + ". tocka spremljena";
                    }

                    if (br == 30)
                    {
                        label1.Text = "Max broj tocaka\npostignut (30)";
                        tocke[br] = tocke[0];
                        Poligon poli = new Poligon(firstCoo, color, tocke);
                        poli.DrawGraphicsObject(go);
                        br = 0;
                        tocke = new Point[30];
                        label1.Text = "Poligon nacrtan,\ntocke su obrisane.";
                    }
                }

                if (e.Button == MouseButtons.Right)
                {
                    tocke[br] = tocke[0];
                    for (i = br; i < 30; i++)
                    {
                        tocke[i + 1] = tocke[0];
                    }
                    Poligon poli = new Poligon(firstCoo, color, tocke);
                    poli.DrawGraphicsObject(go);
                    br = 0;
                    i = 0;
                    tocke = new Point[31];
                    label1.Text = "Poligon nacrtan,\ntocke su obrisane.";
                }
            }
        }


        //crtanje linije, pravokutnika, kruga i elipse pomoću klasa
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //odabri boje kojom crtamo
            if (rdBtnBlack.Checked)
            {
                color = Color.Black;
            }
            else
                if (rdBtnRed.Checked)
            {
                color = Color.Red;
            }
            else
                if (rdBtnBlue.Checked)
            {
                color = Color.Blue;
            };
            //odabir oblika kojeg crtamo
            if (mouseDown == true)
            {
                if (rdBtnLn.Checked)
                {
                    go.DrawLine(invisipen, firstCoo, secondCoo);
                    secondCoo = e.Location;
                    Linija l = new Linija(firstCoo, color, secondCoo);
                    l.DrawGraphicsObject(go);
                }

                if (rdBtnRec.Checked)
                {
                    Pravokutnik k = new Pravokutnik(firstCoo, color, secondCoo);
                    go.DrawRectangle(invisipen, firstCoo.X, firstCoo.Y, secondCoo.X - firstCoo.X,
                         secondCoo.Y - firstCoo.Y);
                    secondCoo = e.Location;
                    k.DrawGraphicsObject(go);
                }

                if (rdBtnCir.Checked)
                {
                    go.DrawEllipse(invisipen, firstCoo.X, firstCoo.Y, secondCoo.X - firstCoo.X, secondCoo.X - firstCoo.X);
                    Kruznica krug = new Kruznica(firstCoo, color, secondCoo);
                    secondCoo = e.Location;

                    krug.DrawGraphicsObject(go);
                }
                if (rdBtnEll.Checked)
                {
                    go.DrawEllipse(invisipen, firstCoo.X, firstCoo.Y, secondCoo.X - firstCoo.X, secondCoo.Y - firstCoo.Y);
                    Elipsa elip = new Elipsa(firstCoo, color, secondCoo);
                    secondCoo = e.Location;
                    elip.DrawGraphicsObject(go);
                }
            }
        }

       

        

       







    }
}

