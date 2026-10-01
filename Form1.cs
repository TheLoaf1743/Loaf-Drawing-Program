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
    // I am likely wrong with the version names, but I don't have any idea what else to use that doesn't sound weird
    
    // Current version: Pre-Alpha (?)

    // Completed features for version Alpha (?)
    // - Paint brush tool
    // - Brush resize 
    // - Partial eraser tool (only recolors area as the bg color)
    // - Basic saving

    // Incomplete features for version Alpha (?)
    // - Make eraser transparent (without calling canvasPanel.Invalidate, as it causes flickering)
    // - Add bucket tool
    // - Add background color change
    // - Opening image file
    //      - Maybe adding at the top of the page the file name?
    // - Bucket tool
    // - Proper handling of window resizing (currently, canvas area doesn't update)
    // - Zooming in and out
    //      - Make sure this applies also to window resizing, so that the area visually changes,
    //        but the size of the brushes and the canvas won't actually change
    // - Ctrl + Z and Ctrl + Y
    //      - Add buttons that do the same, and are greyed out if there isn't more to
    //        undo or redo
    public partial class Form1 : Form
    {
        //Code is partially taken from this tutorial: https://www.youtube.com/watch?v=7Rs3TPq6k_s

        //For updating location of the "pen" when drawing
        public Point current = new Point();
        public Point old = new Point();

        public Graphics g;
        public Graphics graph;

        public Pen pen = new Pen(Color.Black, 5);

        public CursorMode cursorMode = CursorMode.Brush; //Keep track of current mode to adapt 


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

                //if (cursorMode == CursorMode.Brush)
                //{


                //}
                //else
                //{


                //    //Below -> code from ai. Commented because it feels too complicated for erasing, and either way layers
                //    //         aren't implemented yet, so I can just draw using the background color.
                //    //         As I am typing this, I realise that changing the bg color will cause issues with this idea.
                //    //         I'll look into solving this issue asap

                //    //using (var gfx = Graphics.FromImage(surface))
                //    //{
                //    //    gfx.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;

                //    //    using (var erasePen = new Pen(BackColor, pen.Width))
                //    //    {
                //    //        erasePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                //    //        erasePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                //    //        gfx.DrawLine(erasePen, old, current);
                //    //    }
                //    //}

                //    //Update the visible canvas
                //    //canvasPanel.Invalidate();
                //}
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

        private void eraser_button_click(object sender, EventArgs e)
        {
            pen.Color = BackColor;
            cursorMode = CursorMode.Eraser;
        }

        private void paintbrush_button_click(object sender, EventArgs e)
        {
            pen.Color = colorbox.BackColor;
            cursorMode = CursorMode.Brush;
        }

        private void colorbox_Click(object sender, EventArgs e)
        {
            if (cursorMode != CursorMode.Eraser)
            {
                ColorDialog cd = new ColorDialog();

                if (cd.ShowDialog() == DialogResult.OK)
                {
                    pen.Color = cd.Color;
                    colorbox.BackColor = cd.Color;
                }
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.Transparent);
            canvasPanel.Invalidate();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Png Files (*png) ! *.png";
            sfd.DefaultExt = "png";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                surface.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void brushsize_change(object sender, EventArgs e)
        {
            pen.Width = (float)brush_size.Value;
        }

        private void bg_color_button_click(object sender, EventArgs e)
        {

        }
    }
    public enum CursorMode
    {
        Brush, //Normal paint brush tool
        Eraser, //Normal eraser tool
    }
}
