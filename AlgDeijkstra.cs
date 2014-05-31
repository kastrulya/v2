using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace v2
{
    class AlgDeijkstra
    {
        static int count = 0;
       
        static int findNextNode(int[][] labels)
        {
            /* return next node for visiting (not yet visited and minimal)
            if all nodes is visited already return (-1)     */

            int minIndex = -1;
            int minValue = Int32.MaxValue;

            for (int i = 0; i < labels.Length; i++)
                if (labels[i][1] == 0)
                    if (labels[i][0] <= minValue)
                    {
                        minIndex = i;
                        minValue = labels[i][0];
                    }
            return minIndex;
        }

        public static int[] deijkstra(PictureBox pictureBox1, int currNode, ref Edge[] edge, ref Node[] node, int[][] graph)
        {
            int size = node.Length;
            int[][]visitedNode = new int[size][];
            for (int i = 0; i < size; i++)
                visitedNode[i] = new int[2];    /*visitedNode[0] - current value of label, visitedNode[1] - 1 or 0. 
                                                visited or not visited accordingly*/
            
            for (int i = 0; i < size; i++)
                visitedNode[i][0] = Int32.MaxValue;
           
            visitedNode[currNode][0] = 0;
            node[currNode].label.Text = "0";
            node[currNode].label.Refresh();
            do 
            {
                for (int i = 0; i < size; i++)
                    if (graph[currNode][i] != -1 && visitedNode[i][1] != 1) // check if the nodes(currNode and i) are connected
                    {
                        Edge.highlightEdge(pictureBox1, edge, node[currNode], node[i]);
                        int possible = visitedNode[currNode][0] + graph[currNode][i];
                        if (visitedNode[i][0] > possible)              
                        {
                            visitedNode[i][0] = possible;
                            node[i].label.Text = Convert.ToString(possible);
                            count++;
                        }                      
                        node[i].highLight(pictureBox1, Color.YellowGreen);
                        node[i].label.Refresh();
                        Thread.Sleep(500);
                    }
                visitedNode[currNode][1] = 1;
                node[currNode].highLight(pictureBox1, Color.DarkGreen);
                currNode = findNextNode(visitedNode);

            }while(currNode != -1);
            
            int[] answer = new int[size];
            for (int i = 0; i < size; i++)
                answer[i] = visitedNode[i][0];
            return answer;
        }

        public static void algDeijkstra(PictureBox pictureBox1, Graph graph, DataGridView matrix, ListBox listOutput)
        {
            count = 0;
            listOutput.Items.Add(" Алгоритм Дейкстри. ");
            listOutput.Items.Add(" Матриця найкоротших шляхів.");
            matrix.ColumnCount = graph.nodes.Length;
            for (int i = 0; i < graph.nodes.Length; i++)
            {
                matrix.Columns[i].Name = Convert.ToString(i);
                matrix.Columns[i].Width = matrix.Width / (graph.nodes.Length + 1) ;
                matrix.Rows.Add();
            }
            int[][] ans = new int[graph.nodes.Length][];
            
            for (int i = 0; i < graph.data.Length; i++)
            {
                Edge[] edge = graph.edges;
                Node[] node = graph.nodes;
                node[i].highLight(pictureBox1, Color.Brown);
                ans[i] = deijkstra(pictureBox1, i, ref edge, ref node, graph.data);
                for (int j = 0; j < ans.Length; j++)
                    matrix.Rows[i].Cells[j].Value = Convert.ToString(ans[i][j]);
                Thread.Sleep(1000);
                SystemFunction.drawGraph(pictureBox1, graph);
            }

            StreamWriter sw;
            if (File.Exists("deijkstraAlg.txt") == true)
                File.Delete("deijkstraAlg.txt");
            sw = File.CreateText("deijkstraAlg.txt");
            sw.WriteLine(Convert.ToString(graph.data.Length));
            for (int i = 0; i < ans.Length; i++)
                for (int j = 0; j < ans.Length; j++)
                    sw.WriteLine(ans[i][j]);
            sw.WriteLine(count);
            sw.Close();
        }
    }
}
