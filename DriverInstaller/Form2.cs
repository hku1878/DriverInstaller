﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverInstaller
{
    public partial class Form2 : Form
    {
        public static ListBox _listBox1 = new ListBox();
        public Form2()
        {
            InitializeComponent();
            panel1.Controls.Add(_listBox1);

        }

        public static void _CreateLabel(string DeviceName, string status)
        {
            Label _Resultlabel = new Label();


        }

        public void RenderRainbowText(string Text, PictureBox pb)
        {
            // PictureBox needs an image to draw on
            pb.Image = new Bitmap(pb.Width, pb.Height);
            using (Graphics g = Graphics.FromImage(pb.Image))
            {
                // create all-white background for drawing
                SolidBrush brush = new SolidBrush(Color.White);
                g.FillRectangle(brush, 0, 0,
                    pb.Image.Width, pb.Image.Height);
                // draw comma-delimited elements in multiple colors
                string[] chunks = Text.Split(',');
                brush = new SolidBrush(Color.Black);
                SolidBrush[] brushes = new SolidBrush[] {
            new SolidBrush(Color.Red),
            new SolidBrush(Color.Green),
            new SolidBrush(Color.Blue),
            new SolidBrush(Color.Purple) };
                float x = 0;
                for (int i = 0; i < chunks.Length; i++)
                {
                    // draw text in whatever color
                    g.DrawString(chunks[i], pb.Font, brushes[i], x, 0);
                    // measure text and advance x
                    x += (g.MeasureString(chunks[i], pb.Font)).Width;
                    // draw the comma back in, in black
                    if (i < (chunks.Length - 1))
                    {
                        g.DrawString(",", pb.Font, brush, x, 0);
                        x += (g.MeasureString(",", pb.Font)).Width;
                    }
                }
            }
        }
    }
}
