using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vatromet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point t;
        Random r=new Random();
        
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            t.X = e.X;
            t.Y = e.Y;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen o = new Pen(Color.White);
            g.DrawLine(o, t.X,t.Y,t.X+(r.Next(-50,50)), t.Y + (r.Next(-50, 50)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 1600;
            Height = 600;
            BackColor = Color.Black;
            Text = "Pahuljice";
        }
    }
}
