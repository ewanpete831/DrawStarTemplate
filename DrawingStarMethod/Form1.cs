using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingStarMethod
{
    public partial class Form1 : Form
    {
        PointF[] star = new PointF[10];
        SolidBrush blueBrush = new SolidBrush(Color.LightSteelBlue);
        Pen blackPen = new Pen(Color.Black);

        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            CreatePoints();

            g.DrawPolygon(blackPen, star);

            sizeInput.Clear();
            xInput.Clear();
            yInput.Clear();
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            CreatePoints();

            g.FillPolygon(blueBrush, star);

            sizeInput.Clear();
            xInput.Clear();
            yInput.Clear();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.DarkKhaki);
        }

        private void CreatePoints()
        {
            float size;
            float starX;
            float starY;

            try
            {
                size = Convert.ToSingle(sizeInput.Text);
            }
            catch
            {
                size = 130;
            }
            try
            {
                starX = Convert.ToSingle(xInput.Text);
            }
            catch
            {
                starX = 0;
            }
            try
            {
                starY = Convert.ToSingle(yInput.Text);
            }
            catch
            {
                starY = 0;
            }

            float scale = size / 130;

            star[0] = new PointF((65 * scale) + starX, (0 * scale) + starY);
            star[1] = new PointF((80 * scale) + starX, (50 * scale) + starY);
            star[2] = new PointF((130 * scale) + starX, (50 * scale) + starY);
            star[3] = new PointF((90 * scale) + starX, (80 * scale) + starY);
            star[4] = new PointF((105 * scale) + starX, (128 * scale) + starY);
            star[5] = new PointF((65 * scale) + starX, (100 * scale) + starY);
            star[6] = new PointF((25 * scale) + starX, (128 * scale) + starY);
            star[7] = new PointF((40 * scale) + starX, (80 * scale) + starY);
            star[8] = new PointF((0 * scale) + starX, (50 * scale) + starY);
            star[9] = new PointF((50 * scale) + starX, (50 * scale) + starY);
        }   
    }
}
