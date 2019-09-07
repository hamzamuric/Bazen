using System.Drawing;

namespace Bazen
{
    public enum Stil
    {
        LEDJNO,
        PRSNO,
        DELFIN,
        SLOBODNO
    }

    public class Plivac
    {
        public Stil Disciplina { get; set; }
        public int Brzina { get; set; }
        public int Traka { get; set; }
        public int PozicijaX { get; set; }
        public int Velicina { get; set; }
        public Color BojaTima { get; set; }
        public bool Zavrsio { get; private set; }

        private string slovo;

        public Plivac(Stil disciplina, int brzina, int traka, Color bojaTima)
        {
            this.Disciplina = disciplina;
            this.Brzina = brzina;
            this.Traka = traka;
            this.PozicijaX = 5;
            this.Velicina = 10;
            this.BojaTima = bojaTima;
            this.Zavrsio = false;

            switch (this.Disciplina)
            {
                case Stil.LEDJNO:
                    slovo = "L";
                    break;
                case Stil.PRSNO:
                    slovo = "P";
                    break;
                case Stil.DELFIN:
                    slovo = "D";
                    break;
                case Stil.SLOBODNO:
                    slovo = "S";
                    break;
            }
        }

        public void Pomeri()
        {
            if (Brzina > 0)
            {
                if (this.PozicijaX <= 285)
                    this.PozicijaX += Brzina;
                else
                    this.Zavrsio = true;
            }
            else
            {
                if (this.PozicijaX > 10)
                    this.PozicijaX += Brzina;
                else
                    this.Zavrsio = true;
            }
        }

        public void Nacrtaj(Graphics g)
        {
            g.FillEllipse(new SolidBrush(BojaTima), new Rectangle(new Point(PozicijaX, Traka * 50 - 5 - 25), new Size(Velicina, Velicina)));
            g.DrawString(slovo, new Font(FontFamily.GenericSansSerif, 6f), Brushes.Black, new Point(PozicijaX + 1, Traka * 50 - 4 - 25));
        }
    }
}
