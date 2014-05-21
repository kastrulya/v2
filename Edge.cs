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
        public Node startNode, endNode;
        public int weightEdge;

        public Edge(ref Node node1, ref Node node2, int weight) 
        {
            this.startNode = node1;
            this.endNode = node2;
            this.weightEdge = weight;
            this.label = new Label();
            this.label.AutoSize = true;
            this.label.Text = Convert.ToString(weight);
            this.label.Size = new Size(15, 15);
            this.label.Location = new Point((int)((startNode.location.X + endNode.location.X) / 2), (int)((startNode.location.Y + endNode.location.Y) / 2));
            colorEdge = Color.Coral;
        }

        public void drawEdge(PictureBox panel)
        {
            Graphics graphics = panel.CreateGraphics();
            System.Drawing.Drawing2D.AdjustableArrowCap bigArrow = new System.Drawing.Drawing2D.AdjustableArrowCap(5, 5);
            Pen pen = new Pen(colorEdge, 2.0F);
            pen.CustomEndCap = bigArrow;
            PointF startPoint = new PointF(startNode.location.X + Node.size/2, startNode.location.Y + Node.size/2);
            PointF endPoint = new PointF( endNode.location.X + Node.size/2, endNode.location.Y + Node.size/2);
            double R = Math.Sqrt(Math.Pow(startPoint.X - endPoint.X, 2.0) + Math.Pow(startPoint.Y - endPoint.Y, 2.0));
            double size = Node.size / 2;
            endPoint.X = (float)((startPoint.X + ((R - size) / size) * endPoint.X) / (R / size));
            endPoint.Y = (float)((startPoint.Y + ((R - size) / size) * endPoint.Y) / (R / size));
            graphics.DrawLine(pen, startPoint, endPoint);
            panel.Controls.Add(label);
        }

        public static Edge findEdge(Edge[] edges, Node node1, Node node2)
        {
            for (int i = 0; i < edges.Length; i++)
                if (edges[i].startNode.label.Text == node1.label.Text && edges[i].endNode.label.Text == node2.label.Text)
                    return edges[i];
            return null;
        }

        public static void highlightEdge(PictureBox panel, Edge[] edges, Node node1, Node node2)
        {
            //Edge edge = findEdge(edges, node1, node2);
            Edge edge = new Edge(ref node1, ref node2, findEdge(edges, node1, node2).weightEdge);
            edge.colorEdge = Color.Green;
            edge.drawEdge(panel);
        }

        public static void putWeigth(PictureBox panel, Edge edge, int weigth)
        {
            edge.weightEdge = weigth;
            edge.label.Text = Convert.ToString(weigth);
            panel.Controls.Remove(edge.label);
            panel.Controls.Add(edge.label);
//            edge.drawEdge(panel);
        }
    }
}
