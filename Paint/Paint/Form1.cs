using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paint
{
    public partial class Form1 : Form
    {
        bool rys = false;
        bool erase = false;
        Graphics g;
        int x0, y0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            textBox1.Text = hScrollBar1.Value.ToString();
            textBox2.Text = hScrollBar2.Value.ToString();
            textBox3.Text = hScrollBar3.Value.ToString();
            erase = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            panel1.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            textBox1.Text = hScrollBar1.Value.ToString();
            textBox2.Text = hScrollBar2.Value.ToString();
            textBox3.Text = hScrollBar3.Value.ToString();
            erase = false;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            textBox1.Text = hScrollBar1.Value.ToString();
            textBox2.Text = hScrollBar2.Value.ToString();
            textBox3.Text = hScrollBar3.Value.ToString();
            erase = false;
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            textBox1.Text = hScrollBar1.Value.ToString();
            textBox2.Text = hScrollBar2.Value.ToString();
            textBox3.Text = hScrollBar3.Value.ToString();
            erase = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            rys = true;
            x0 = e.X;
            y0 = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            rys = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rys)
            {
                if (erase == true)
                {
                    Pen p = new Pen(Color.FromArgb(255, 255, 255), 25);
                    int x = e.X; int y = e.Y;  
                    g.DrawLine(p, x0, y0, x, y);    
                    x0 = x; y0 = y;
                }
                else
                {
                    Pen p = new Pen(Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value), 7);
                    int x = e.X; int y = e.Y;    
                    g.DrawLine(p, x0, y0, x, y);    
                    x0 = x; y0 = y;
                }
                
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SHine221B");
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SHine221B");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
