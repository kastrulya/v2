using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace v2
{
    class Edge
    {
        public Color colorEdge { get; set; }
        public Label label { get; set; }
        PointF startPoint;
        PointF endPoint;
        int weightEdge;

        public Edge() { }

        public Edge(PointF startPoint, PointF endPoint, int weight)
        {
            this.startPoint.X = startPoint.X + 15;
            this.startPoint.Y = startPoint.Y + 10;
            this.endPoint.X = endPoint.X + 15;
            this.endPoint.Y = endPoint.Y + 10;
            this.weightEdge = weight;
            this.label = new Label();
            this.label.Text = Convert.ToString(weight);
            this.label.Size = new Size(15, 15);
            this.label.Location = new Point((int)((startPoint.X + endPoint.X) / 2), (int)((startPoint.Y + endPoint.Y) / 2));
            colorEdge = Color.Coral;
        }

        public void drawEdge(PictureBox panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(colorEdge);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;// RoundAnchor;// LineCap.RoundAnchor;
            graphics.DrawLine(pen, startPoint, endPoint);
            panel.Controls.Add(label);
        }

    }
}
