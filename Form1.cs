using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        bool Optdurum = false;
        double sonuc= 0;
        string opt = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if(tx1.Text == "0" || Optdurum)
              
               tx1.Clear();
            
            Optdurum = false;
            Button btn = (Button)sender;
            tx1.Text += btn.Text;
        }

        private void Optislem(object sender, EventArgs e)
        {
            Optdurum = true;
            Button btn = (Button)sender;
            string yeniopt = btn.Text;
            label1.Text = label1.Text +" " + tx1.Text + " " + yeniopt;
            switch (opt)
            {
                case "+":tx1.Text = (sonuc + double.Parse(tx1.Text)).ToString(); break;
                case "-": tx1.Text = (sonuc - double.Parse(tx1.Text)).ToString(); break;
                case "*": tx1.Text = (sonuc * double.Parse(tx1.Text)).ToString(); break;
                case "/": tx1.Text = (sonuc / double.Parse(tx1.Text)).ToString(); break;
              
            }
            sonuc = double.Parse(tx1.Text);
            tx1.Text = sonuc.ToString();
            opt = yeniopt;
        }

        private void CEsılme(object sender, EventArgs e)
        {
            tx1.Text = "0";

        }

        private void Csilme(object sender, EventArgs e)
        {
            tx1.Text = "0";
            label1.Text = "";
            opt = "";
            sonuc = 0;
            Optdurum = false;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Optdurum = true;
            Optdurum = true;
            Button btn = (Button)sender;
            string yeniopt = btn.Text;
            label1.Text = label1.Text + " " + tx1.Text + " " + yeniopt;
            switch (opt)
            {
                case "+": tx1.Text = (sonuc + double.Parse(tx1.Text)).ToString(); break;
                case "-": tx1.Text = (sonuc - double.Parse(tx1.Text)).ToString(); break;
                case "*": tx1.Text = (sonuc * double.Parse(tx1.Text)).ToString(); break;
                case "/": tx1.Text = (sonuc / double.Parse(tx1.Text)).ToString(); break;

            }
            sonuc = double.Parse(tx1.Text);
            tx1.Text = sonuc.ToString();
            opt = " ";

        }
    }
}
