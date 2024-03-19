using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            gr.FillRectangle(Brushes.Black, 10, 10, 80, 80);
            Pen p2 = new Pen(Color.Gray, 4); // Ширина 4 пиксела
            gr.DrawRectangle(p2, 10, 10, 80, 80);
            gr.RotateTransform(20);
            gr.TranslateTransform(20, 20);
            Graphics gr2 = Graphics.FromImage(bmp);
            gr2.FillRectangle(Brushes.Black, 30, 30, 100, 100);
            gr2.DrawRectangle(p2, 30, 30, 100, 100);
            Graphics gr3 = Graphics.FromImage(bmp);
            gr3.FillRectangle(Brushes.Black, 50, 50, 120, 120);
            gr3.DrawRectangle(p2, 50, 50, 120, 120);
            Graphics gr4 = Graphics.FromImage(bmp);
            gr4.FillRectangle(Brushes.Black, 70, 70, 140, 140);
            gr4.DrawRectangle(p2, 70, 70, 140, 140);
            Graphics gr5 = Graphics.FromImage(bmp);
            gr5.FillRectangle(Brushes.Black, 90, 90, 160, 160);
            gr5.DrawRectangle(p2, 90, 90, 160, 160);
            Graphics gr6 = Graphics.FromImage(bmp);
            gr6.FillRectangle(Brushes.Black, 110, 110, 180, 180);
            gr6.DrawRectangle(p2, 110, 110, 180, 180);
            pictureBox1.Image = bmp;

        }
    }
}
