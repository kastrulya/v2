using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            int[][] data = SystemFunction.readFile(openFileDialog1.FileName);
                            dgwMatrix.Visible = true;
                            graph = new Graph(this.dgwMatrix, data);
                            dgwMatrix.CellValueChanged -= new DataGridViewCellEventHandler(this.matrix_CellValueChanged);
                            SystemFunction.drawGraph(pictureBox1, graph);
                            dgwMatrix.Visible = true;
                            pictureBox1.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
                            pictureBox1.MouseDoubleClick -= new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
                          }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("   Щось пішло не так. Спробуйте ще раз ");
                }
            }
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
            graph = new Graph(createGraph.getNodes(), createGraph.getEdges());
            StreamWriter sw = File.CreateText("j");


            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";


            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "graph";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                
                sb.AppendLine(graph.data.Length.ToString());
                for (int i = 0; i < graph.data.Length; i++)
                {
                    for (int j = 0; j < graph.data.Length; j++)
                    {
                        if (graph.data[i][j] != -1)
                        sb.AppendLine("" + (i+1).ToString() + " " + (j+1).ToString() + " " + graph.data[i][j]);
                    }
                }
                sb.AppendLine();
                sb.AppendLine();

                using (StreamWriter outfile = new StreamWriter(saveFileDialog1.FileName, true))
                {
                    outfile.Write(sb.ToString());
                }
            }
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
            listOutput.Items.Clear();
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

        private void алгоритмФлойдаУоршаллаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOutput.Items.Clear();
            if (graph != null)
            {
                dgwOutput.Visible = true;
                listOutput.Visible = true;
                FloydYorshall.AlgFloydYorshall(pictureBox1, graph, dgwOutput, listOutput);
            }
            else
                listOutput.Items.Add(" Граф не завантажений ");
        }

        private void алгоритмДейкстриToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Theory theory = new Theory();
            theory.deijkstraChoose();
            theory.ShowDialog();
        }

        private void алгоритмФлойдаУоршаллаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Theory theory = new Theory();
            theory.yorshallChoose();
            theory.ShowDialog();
        }

        private void порівяннняАлгоритмівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compare compare = new Compare();
            if (File.Exists("deijkstraAlg.txt") != true)
                AlgDeijkstra.algDeijkstra(pictureBox1, graph, dgwOutput, listOutput);
            FloydYorshall.AlgFloydYorshall(pictureBox1, graph, dgwOutput, listOutput);
            compare.ShowDialog();
        }

    }
}
