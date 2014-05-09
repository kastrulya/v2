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
        Node startNode, endNode;
        public int weightEdge;

        public Edge(ref Node node1, ref Node node2, int weight) 
        {
            this.startNode = node1;
            this.endNode = node2;
            this.weightEdge = weight;
            this.label = new Label();
            this.label.Text = Convert.ToString(weight);
            this.label.Size = new Size(15, 15);
            this.label.Location = new Point((int)((startNode.location.X + endNode.location.X) / 2), (int)((startNode.location.Y + endNode.location.Y) / 2));
            colorEdge = Color.Coral;
        }

        public void drawEdge(PictureBox panel)
        {
            Graphics graphics = panel.CreateGraphics();
            Pen pen = new Pen(colorEdge);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;
            graphics.DrawLine(pen, startNode.location.X + Node.size/2, startNode.location.Y + Node.size/2, endNode.location.X + Node.size/2, endNode.location.Y + Node.size/2);
            panel.Controls.Add(label);
        }

        public static Edge findEdge(Edge[] edges, Node node1, Node node2)
        {
            for (int i = 0; i < edges.Length; i++)
                if (edges[i].startNode.label.Text == node1.label.Text && edges[i].endNode.label.Text == node2.label.Text)
                    return edges[i];
            return null;
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
