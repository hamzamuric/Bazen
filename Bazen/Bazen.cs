using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bazen
{
    public partial class Bazen : Form
    {
        Plivac[] tim1, tim2, tim3, tim4;
        Color boja1, boja2, boja3, boja4;
        int trenutni1 = 0, trenutni2 = 0, trenutni3 = 0, trenutni4 = 0;

        public Bazen(Args args)
        {
            InitializeComponent();

            // Imena timova
            lblTim1.Text = args.tim1Naziv;
            lblTim2.Text = args.tim2Naziv;
            lblTim3.Text = args.tim3Naziv;
            lblTim4.Text = args.tim4Naziv;

            // Timovi
            this.boja1 = args.boja1;
            this.boja2 = args.boja2;
            this.boja3 = args.boja3;
            this.boja4 = args.boja4;

            // Panel DoubleBuffered = true
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null, GamePanel, new object[] { true });
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (trenutni1 < 4)
            {
                tim1[trenutni1].Pomeri();
                if (tim1[trenutni1].Zavrsio)
                    trenutni1++;
            }
            if (trenutni2 < 4)
            {
                tim2[trenutni2].Pomeri();
                if (tim2[trenutni2].Zavrsio)
                    trenutni2++;
            }
            if (trenutni3 < 4)
            {
                tim3[trenutni3].Pomeri();
                if (tim3[trenutni3].Zavrsio)
                    trenutni3++;
            }
            if (trenutni4 < 4)
            {
                tim4[trenutni4].Pomeri();
                if (tim4[trenutni4].Zavrsio)
                    trenutni4++;
            }

            GamePanel.Invalidate();
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Panel p = sender as Panel;

            Point[] points = new Point[4];

            points[0] = new Point(0, 0);
            points[1] = new Point(0, p.Height);
            points[2] = new Point(p.Width, p.Height);
            points[3] = new Point(p.Width, 0);

            Brush brush = new SolidBrush(Color.Red);
            g.FillPolygon(brush, points);

            Brush blueBrush = new SolidBrush(Color.Blue);

            // Traka 1
            points[0] = new Point(5, 5);
            points[1] = new Point(5, 45);
            points[2] = new Point(295, 45);
            points[3] = new Point(295, 5);

            g.FillPolygon(blueBrush, points);

            // Traka 2
            points[0] = new Point(5, 55);
            points[1] = new Point(5, 95);
            points[2] = new Point(295, 95);
            points[3] = new Point(295, 55);

            g.FillPolygon(blueBrush, points);

            // Traka 3
            points[0] = new Point(5, 105);
            points[1] = new Point(5, 145);
            points[2] = new Point(295, 145);
            points[3] = new Point(295, 105);

            g.FillPolygon(blueBrush, points);

            // Traka 4
            points[0] = new Point(5, 155);
            points[1] = new Point(5, 195);
            points[2] = new Point(295, 195);
            points[3] = new Point(295, 155);

            g.FillPolygon(blueBrush, points);

            // Plivaci
            if (trenutni1 < 4)
                tim1?[trenutni1]?.Nacrtaj(g);
            if (trenutni2 < 4)
                tim2?[trenutni2]?.Nacrtaj(g);
            if (trenutni3 < 4)
                tim3?[trenutni3]?.Nacrtaj(g);
            if (trenutni4 < 4)
                tim4?[trenutni4]?.Nacrtaj(g);
        }

        // START
        private void Button1_Click(object sender, EventArgs e)
        {
            // Tim 1
            tim1 = new Plivac[4];
            tim1[0] = new Plivac(Stil.LEDJNO, 4, 1, boja1);
            tim1[1] = new Plivac(Stil.PRSNO, 5, 1, boja1);
            tim1[2] = new Plivac(Stil.DELFIN, 3, 1, boja1);
            tim1[3] = new Plivac(Stil.SLOBODNO, 7, 1, boja1);

            // Tim 2
            tim2 = new Plivac[4];
            tim2[0] = new Plivac(Stil.LEDJNO, 6, 2, boja2);
            tim2[1] = new Plivac(Stil.PRSNO, 3, 2, boja2);
            tim2[2] = new Plivac(Stil.DELFIN, 8, 2, boja2);
            tim2[3] = new Plivac(Stil.SLOBODNO, 2, 2, boja2);

            // Tim 3
            tim3 = new Plivac[4];
            tim3[0] = new Plivac(Stil.LEDJNO, 1, 3, boja3);
            tim3[1] = new Plivac(Stil.PRSNO, 7, 3, boja3);
            tim3[2] = new Plivac(Stil.DELFIN, 4, 3, boja3);
            tim3[3] = new Plivac(Stil.SLOBODNO, 6, 3, boja3);

            // Tim 4
            tim4 = new Plivac[4];
            tim4[0] = new Plivac(Stil.LEDJNO, 9, 4, boja4);
            tim4[1] = new Plivac(Stil.PRSNO, 8, 4, boja4);
            tim4[2] = new Plivac(Stil.DELFIN, 3, 4, boja4);
            tim4[3] = new Plivac(Stil.SLOBODNO, 1, 4, boja4);

            // Plivaci sa desne strane
            tim1[1].Brzina *= -1;
            tim1[1].PozicijaX = 285;
            tim1[3].Brzina *= -1;
            tim1[3].PozicijaX = 285;

            tim2[1].Brzina *= -1;
            tim2[1].PozicijaX = 285;
            tim2[3].Brzina *= -1;
            tim2[3].PozicijaX = 285;

            tim3[1].Brzina *= -1;
            tim3[1].PozicijaX = 285;
            tim3[3].Brzina *= -1;
            tim3[3].PozicijaX = 285;

            tim4[1].Brzina *= -1;
            tim4[1].PozicijaX = 285;
            tim4[3].Brzina *= -1;
            tim4[3].PozicijaX = 285;

            GameTimer.Start();
        }

        // PAUZA
        private void Button2_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
        }

        // NASTAVI
        private void Button3_Click(object sender, EventArgs e)
        {
            GameTimer.Start();
        }
    }
}
