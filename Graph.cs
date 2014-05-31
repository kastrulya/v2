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
        public int numberOfEdges;
        public int[][] data;
        public Node[] nodes;
        public Edge[] edges;
        public PointF[] point;
//        public DataGridView inputMatrix;

        public Graph(Node[] nodes, Edge[] edges)
        {
            this.nodes = nodes;
            this.edges = edges;
            data = new int[nodes.Length][];
            for (int i = 0; i < data.Length; i++)
                data[i] = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
                for (int j = 0; j < data.Length; j++)
                    data[i][j] = -1;
            for(int i = 0; i < edges.Length; i++)
                data[Convert.ToInt32(edges[i].startNode.label.Text)]
                    [Convert.ToInt32(edges[i].endNode.label.Text)] = edges[i].weightEdge;
        }

        private void fillMatrix(DataGridView matrix)
        {
            matrix.ColumnCount = data.Length;
            for (int i = 0; i < data.Length; i++)
            {
                matrix.Columns[i].Name = Convert.ToString(i);
                matrix.Columns[i].Width = matrix.Width / (data.Length+1) ;
                matrix.Rows.Add();
                matrix.Rows[i].HeaderCell.Value = Convert.ToString(i);
            }
            for (int i = 0; i < data.Length; i++)
                for (int j = 0; j < data.Length; j++)
                    matrix.Rows[i].Cells[j].Value = data[i][j];
            matrix.ReadOnly = true;
        }

        public Graph(DataGridView inputMatrix, int[][] data )
        {
            this.data = data;
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
                        edges[k] = new Edge(ref nodes[i],ref nodes[j], data[i][j]);
                        k++;
                    }
           /*---------------------------------------------------------------*/
            
        }
    }
}
