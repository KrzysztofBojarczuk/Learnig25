using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        enum Spectrum
        {
            czerwony, pomarańczowy, żółty, zielony, niebieski, indygo, fioletowy
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void DisplayColor(Spectrum color)
        {
            colorLabel.Text = color.ToString();
        }

        private void redLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.czerwony);
        }

        private void orangeLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.pomarańczowy);
        }

        private void yellowLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.żółty);
        }

        private void greenLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.zielony);
        }

        private void blueLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.niebieski);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void indigoLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.indygo);
        }

        private void violetLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.fioletowy);
        }
    }
}
