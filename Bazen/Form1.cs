using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bazen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Args args = new Args();
            args.tim1Naziv = tbTim1.Text;
            args.tim2Naziv = tbTim2.Text;
            args.tim3Naziv = tbTim3.Text;
            args.tim4Naziv = tbTim4.Text;
            args.boja1 = btnBoja1.BackColor;
            args.boja2 = btnBoja2.BackColor;
            args.boja3 = btnBoja3.BackColor;
            args.boja4 = btnBoja4.BackColor;

            Bazen bazen = new Bazen(args);
            bazen.Show();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = ColorDialog.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                if (sender is Button b)
                {
                    b.BackColor = ColorDialog.Color;
                }
            }
        }
    }

    public class Args
    {
        public string tim1Naziv, tim2Naziv, tim3Naziv, tim4Naziv;
        public Color boja1, boja2, boja3, boja4;
    }
}
