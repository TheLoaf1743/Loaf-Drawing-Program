using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loaf_Drawing_Program
{
    public partial class Form1 : Form
    {
        //Code is currently taken from this tutorial: https://www.youtube.com/watch?v=7Rs3TPq6k_s

        //For updating location of the "pen" when drawing
        public Point current = new Point();
        public Point old = new Point();

        public Graphics g;
        public Graphics graph;

        public Pen pen = new Pen(Color.Black, 5);

        Bitmap surface;

        public Form1()
        {
            InitializeComponent();

            g = canvasPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);

            surface = new Bitmap(canvasPanel.Width, canvasPanel.Height);

            graph = Graphics.FromImage(surface);

            canvasPanel.BackgroundImage = surface;
            canvasPanel.BackgroundImageLayout = ImageLayout.None;

            pen.Width = (float)brush_size.Value;
        }
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(pen, old, current);
                graph.DrawLine(pen, old, current);

                old = current;
            }
        }

        private Point mouseOffsetPos;
        private bool isMouseDown = false;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffsetPos = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffsetPos);
                this.Location = mousePos;
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
    }
}
