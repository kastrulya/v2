using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace v2
{
    class Graph
    {
        public int numberOfEdges { get; set; }
        public int[][] data{get; set; }
        public Node[] nodes;//{get; set; }
        public Edge[] edges{get; set; }
        public PointF[] point { get; set; }
        public DataGridView inputMatrix;

        public Graph(Node[] nodes, Edge[] edges)
        {
            this.nodes = nodes;
            this.edges = edges;
        }

        private void fillMatrix(DataGridView matrix)
        {
            matrix.ColumnCount = data.Length;
            for (int i = 0; i < data.Length; i++)
            {
                matrix.Columns[i].Name = Convert.ToString(i);
                matrix.Columns[i].Width = 132 / data.Length; ;
                matrix.Rows.Add();
                matrix.Rows[i].HeaderCell.Value = Convert.ToString(i);
            }
            for (int i = 0; i < data.Length; i++)
                for (int j = 0; j < data.Length; j++)
                    matrix.Rows[i].Cells[j].Value = data[i][j];
            matrix.ReadOnly = true;
        }

        public Graph(int[][] data )
        {
            this.data = data;
            inputMatrix = new DataGridView();
            SystemFunction.tableSettings(inputMatrix);
            fillMatrix(inputMatrix);
            point = SystemFunction.polarPoint(data, 130);

           /*---------------------Create Node-------------------------------*/
            this.nodes = new Node[data.Length];
            for (int i = 0; i < data.Length; i++)
                nodes[i] = new Node(point[i], "INF");
           /*---------------------------------------------------------------*/
           /*---------------------------------------------------------------*/
           /*----------------------Create edges-----------------------------*/
            this.numberOfEdges = SystemFunction.numberEdge(data);
            this.edges = new Edge[numberOfEdges];
            int k = 0;
            for (int i = 0; i < data.Length; i++)
                for (int j = 0; j < data.Length; j++)
                    if (data[i][j] != -1)
                    {
                        edges[k] = new Edge(point[i], point[j], data[i][j]);
                        k++;
                    }
           /*---------------------------------------------------------------*/
            
        }
    }
}
