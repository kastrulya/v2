using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace v2
{
    class BelmanaForda
    {
        public static int count = 0;
        public static void Algoritm_Forda(PictureBox pictureBox1, Graph graph, DataGridView matrix, ListBox listOutput)
        {
            listOutput.Items.Clear();
            listOutput.Items.Add("Алгоритм Белмана-Форда");
            listOutput.Items.Add("Матриця найкоротших війдстаней");
            count = 0; 

            matrix.ColumnCount = graph.nodes.Length;
            for (int i = 0; i < graph.nodes.Length; i++)
            {
                matrix.Columns[i].Name = Convert.ToString(i);
                matrix.Columns[i].Width = matrix.Width / (graph.nodes.Length + 1);
                matrix.Rows.Add();
            }
            int[][] D = new int[graph.data.Length][];

            for (int i = 0; i < graph.data.Length; i++)
                D[i] = belman(graph, i);
            
            for (int i = 0; i < D.Length; i++)
                for (int j = 0; j < D.Length; j++)
                    if (D[i][j] != 1000)
                        matrix.Rows[i].Cells[j].Value = D[i][j];
                    else matrix.Rows[i].Cells[j].Value = '∞';
            
            StreamWriter sw;
            if (File.Exists("fordaAlg.txt") == true)
                File.Delete("fordaAlgg.txt");
            sw = File.CreateText("fordaAlg.txt");
            sw.WriteLine(Convert.ToString(graph.data.Length));
            for (int i = 0; i < D.Length; i++)
                for (int j = 0; j < D.Length; j++)
                    sw.WriteLine(D[i][j]);
            sw.WriteLine(count);
            sw.Close();
        }

           private static int[] belman(Graph graph, int v)
           {
            int[]D;
            D = graph.data[v];
            for (int i = 0; i < D.Length; i++)
                if (D[i] == -1) D[i] = 1000;
               
            D[v] = 0;
            int n = graph.data.Length;
            int m = graph.edges.Length;
            //for (int i=0; i<n-1; ++i)
                for (int j = 0; j < m; ++j)
                {
                   if (D[Array.IndexOf(graph.nodes, graph.edges[j].startNode)] < 1000)
                        D[Array.IndexOf(graph.nodes, graph.edges[j].endNode)] =
                            Math.Min(D[Array.IndexOf(graph.nodes, graph.edges[j].endNode)], D[Array.IndexOf(graph.nodes, graph.edges[j].startNode)] + graph.edges[j].weightEdge);
                    count++;
                }
               return D;
            }
     }
}
