using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace v2
{
    class Node
    {
        public Color colorNode { get; set; }
        public Label label { get; set; }
        public PointF location;
        public static float size = 40; // size of node

        public Node() { }

        public Node(PointF location, string text)
        {
            this.label = new Label();
            this.label.Text = text;
            this.label.Size = new Size(25, 15);
            this.label.BackColor = Color.Coral;
            this.colorNode = Color.Coral;
            this.location = location;
        }

        public void drawNode(PictureBox panel)
        {
            SolidBrush brush = new SolidBrush(colorNode);
            Graphics graphics = panel.CreateGraphics();
            graphics.FillEllipse(brush, location.X, location.Y, size, size);
            label.Location = new Point((int)(location.X + 3),(int)(location.Y + 3));
            panel.Controls.Add(label);
        }

        public static Node findNodeWithCoord(Node[] nodes, float x, float y)
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                if(x >= nodes[i].location.X && x <= nodes[i].location.X + size &&
                    y <= nodes[i].location.Y + size && y >= nodes[i].location.Y)
                    return nodes[i];
            }
            return null;
        }

        public static bool checkFreePlace(Node[] nodes, float x, float y)
        {
            for (int i = 0; i < nodes.Length; i++)
                if (x >= nodes[i].location.X - size && x <= nodes[i].location.X + size &&
                    y <= nodes[i].location.Y + size && y >= nodes[i].location.Y - size)
                    return false;
            return true;
        }


    }
}
