using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace v2
{
    class CreateGraph
    {
        public int startOrEndOfEdge; // start - 0, end - 1;
        public int numEdges, numNodes;
        public float x1, x2, y1, y2;
        Node[] nodes;
        Edge[] edges;
        public DataGridView matrix;
        public string choose1, choose2;
        public Node[] chooseNodes;

        public CreateGraph(ref DataGridView matrix)
        {
            nodes = new Node[0];
            edges = new Edge[0];
            numNodes = 0;
            numEdges = 0;
            startOrEndOfEdge = 0;
            chooseNodes = new Node[2];
            this.matrix = matrix;
            SystemFunction.tableSettings(matrix);
        }

        public Node[] getNodes()
        { return nodes; }

        public Edge[] getEdges()
        { return edges; }

        public void addNode(Node n)
        {
            Array.Resize(ref nodes, nodes.Length + 1);
            nodes[nodes.Length - 1] = n;
            numNodes++;
            matrix.Columns.Add("c" + n.label.Text, n.label.Text);
            for (int i = 0; i < numNodes; i++)
                matrix.Columns[i].Width = 132 / numNodes;
            matrix.Rows.Add();
            matrix.Rows[numNodes - 1].HeaderCell.Value = n.label.Text;
        }

        public Node createNode(float x, float y, int n)
        {
            if (Node.checkFreePlace(nodes, x , y) == true)
            {
                PointF point = new PointF(x , y);
                Node node = new Node(point, Convert.ToString(n));
                addNode(node);
                return node;
            }
            return null;
        }

        public void addEdge(Edge edge)
        {
            Array.Resize(ref edges, edges.Length + 1);
            edges[edges.Length - 1] = edge;
            numEdges++;
            int row = Convert.ToInt32(choose1);
            int cell = Convert.ToInt32(choose2);
            matrix.Rows[row].Cells[cell].Value = edge.weightEdge;
        }

        public Edge createEdge(Node[] chooseNodes, int weigth)
        {
            PointF point1 = new PointF(x1, y1);
            PointF point2 = new PointF(x2, y2);
            Edge edge = new Edge(ref chooseNodes[0],ref chooseNodes[1], weigth);
            addEdge(edge);
            Node.findNodeWithCoord(nodes, x1, y1).label.Text = choose1;
            Node.findNodeWithCoord(nodes, x2, y2).label.Text = choose2;
            startOrEndOfEdge = 0;
            return edge;
        }
        
        public void chooseNode(PictureBox panel, float x, float y)
        {
            Node node = Node.findNodeWithCoord(getNodes(), x, y);
            if (node != null)
            {
                if (startOrEndOfEdge == 1)
                {
                    if (node.label.Text != "♥")
                    {
                        choose2 = node.label.Text;
                        x2 = x;
                        y2 = y;
                        node.label.Text = "♥";
                        chooseNodes[1] = node;
                        Edge edge = createEdge(chooseNodes, 1);
                        edge.drawEdge(panel);
                    }
                    else
                    {
                        node.label.Text = choose1;
                        startOrEndOfEdge = 0;
                    }
                }
                else if (startOrEndOfEdge == 0)
                {
                    choose1 = node.label.Text;
                    x1 = x;
                    y1 = y;
                    node.label.Text = "♥";
                    chooseNodes[0] = node;
                    startOrEndOfEdge = 1;
                }
            }
        }
    }
}
