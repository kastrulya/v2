using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace v2
{
    public partial class Form1 : Form
    {

        CreateGraph createGraph;

        public Form1()
        {
            InitializeComponent();
            createGraph = new CreateGraph();
 //           Graph graph = new Graph();
        }

        private void buttonLoadGraph_Click(object sender, EventArgs e)
        {
 //           SystemFunction.outputGraph(graphData, SystemFunction.readFile());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDeijkstra_Click(object sender, EventArgs e)
        {
            //graph = new Graph(SystemFunction.readFile());
            
//            AlgDeijkstra.algDeijksra(graph, pictureBox1, graphDeijkstra);

            //string[] ans = new string[graph.data.Length];
            //for (int i = 0; i < graph.data.Length; i++)
            //{
            //    Edge[] edge = graph.edges;
            //    Node[] node = graph.nodes;
            //    ans[i] = AlgDeijkstra.deijkstra(i, ref edge, ref node, graph.data);
            //    graphDeijkstra.Items.Add(ans[i]);
            //    SystemFunction.drawGraph(pictureBox1, graph);
            //    Thread.Sleep(1000);
            //}
        }

        private void downloadFromFile_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph(SystemFunction.readFile());
            SystemFunction.drawGraph(pictureBox1, graph);
            this.Controls.Add(graph.inputMatrix);
            pictureBox1.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
        }

        private void drawGraph_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            CreateGraph createGraph = new CreateGraph();
            //createGraph.matrix.
 //           this.Controls.Add(createGraph.matrix);
        }

        private void Deijkstra_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph(SystemFunction.readFile());
            string[] ans = new string[graph.data.Length];
            for (int i = 0; i < graph.data.Length; i++)
            {
                Edge[] edge = graph.edges;
                Node[] node = graph.nodes;
                ans[i] = AlgDeijkstra.deijkstra(i, ref edge, ref node, graph.data);
                graphDeijkstra.Items.Add(ans[i]);
                SystemFunction.drawGraph(pictureBox1, graph);
                Thread.Sleep(1000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void graphDeijkstra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 //           graphData.Items.Clear();
 //           SystemFunction.clearGraph(pictureBox1, graph);
        }//clear

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)//draw node
        {
            float x = e.Location.X;
            float y = e.Location.Y;
            Node node = createGraph.createNode(x, y, createGraph.numNodes);
            if(node != null)   node.drawNode(pictureBox1);
            this.Controls.Add(createGraph.matrix);
        }
       
        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                Node node = Node.findNodeWithCoord(createGraph.getNodes(), e.Location.X, e.Location.Y);
                if (createGraph.startOrEndOfEdge == 1)
                {
                    createGraph.choose2 = node.label.Text;
                    createGraph.x2 = e.Location.X;
                    createGraph.y2 = e.Location.Y;
                    node.label.Text = "♥";
                    createGraph.chooseNodes[1] = node;
                    Edge edge = createGraph.createEdge(createGraph.chooseNodes);
                    edge.drawEdge(pictureBox1);
                }
                else if (createGraph.startOrEndOfEdge == 0)
                {
                    createGraph.choose1 = node.label.Text;
                    createGraph.x1 = e.Location.X;
                    createGraph.y1 = e.Location.Y;
                    node.label.Text = "♥";
                    createGraph.chooseNodes[0] = node;
                    createGraph.startOrEndOfEdge = 1;
                }
          }

    }
}
