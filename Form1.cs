using System;
using System.Drawing;
using System.Windows.Forms;

namespace DCIT318Assignment4
{
    public partial class Form1 : Form
    {
        private bool drawing;
        private Point previousPoint;

        public Form1()
        {
            InitializeComponent();
            drawing = false;
        }

        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            previousPoint = e.Location;
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                using (Graphics g = drawingPanel.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, previousPoint, e.Location);
                    previousPoint = e.Location;
                }
            }
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }
    }
}
