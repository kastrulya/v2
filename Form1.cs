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
        Graph graph;

        public Form1()
        {
            InitializeComponent();
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
            //buttonClear.PerformClick();
            //buttonClear_Click();
            dgwMatrix.Visible = true;
            graph = new Graph(this.dgwMatrix, SystemFunction.readFile());
            dgwMatrix.CellValueChanged -= new DataGridViewCellEventHandler(this.matrix_CellValueChanged);
            SystemFunction.drawGraph(pictureBox1, graph);
            dgwMatrix.Visible = true;
            pictureBox1.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            pictureBox1.MouseDoubleClick -= new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
        }

        private void drawGraph_Click(object sender, EventArgs e)
        {
            dgwMatrix.Visible = true;
            pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            dgwMatrix.Visible = true;
            createGraph = new CreateGraph(ref this.dgwMatrix);
            dgwMatrix.CellValueChanged += new DataGridViewCellEventHandler(this.matrix_CellValueChanged);
            saveGraph.Visible = true;            
            saveGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSave_Click);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            graph = new Graph(createGraph.getNodes(), createGraph.getEdges());
            pictureBox1.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            dgwMatrix.CellValueChanged -= new DataGridViewCellEventHandler(this.matrix_CellValueChanged);
            dgwMatrix.ReadOnly = true;
            saveGraph.Visible = false;
            graph = new Graph(createGraph.getNodes(), createGraph.getEdges());
        }

        private void Deijkstra_Click(object sender, EventArgs e)
        {
            listOutput.Items.Clear();
            if (graph != null)
            {
                dgwOutput.Visible = true;
                listOutput.Visible = true;
                AlgDeijkstra.algDeijkstra(pictureBox1, graph, dgwOutput, listOutput);
            }
            else 
                listOutput.Items.Add(" Граф не завантажений ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            graph = null;
            createGraph = null;
            dgwMatrix.Rows.Clear();
            dgwMatrix.Columns.Clear();
            dgwMatrix.Visible = false;
            pictureBox1.Controls.Clear();
            pictureBox1.Refresh();
            dgwOutput.Rows.Clear();
            dgwOutput.Visible = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)//draw node
        {
            float x = e.Location.X;
            float y = e.Location.Y;
            Node node = createGraph.createNode(x, y, createGraph.getNodes().Length);// createGraph.numNodes);
            if (node != null) node.drawNode(pictureBox1);
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            createGraph.chooseNode(pictureBox1, e.Location.X, e.Location.Y);
        }

        private void matrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Edge[] edges = createGraph.getEdges();
            if (e.ColumnIndex >= 0)
            {
                Node node1 = createGraph.getNodes()[e.RowIndex];
                Node node2 = createGraph.getNodes()[e.ColumnIndex];
                Edge edge = Edge.findEdge(edges, node1, node2);
                int weigth = Convert.ToInt32(dgwMatrix.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (edge != null)
                    Edge.putWeigth(pictureBox1, edge, weigth);
                else
                {
                    edge = new Edge(ref node1, ref node2, weigth);
                    createGraph.addEdge(edge);
                    edge.drawEdge(pictureBox1);
                }
            }
        }

        private void dgwMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
