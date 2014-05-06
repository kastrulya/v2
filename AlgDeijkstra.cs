using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace v2
{
    class AlgDeijkstra
    {
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

        public static string deijkstra(int currNode, ref Edge[] edge, ref Node[] node, int[][] graph)
        {
            int size = node.Length;
            int[][]visitedNode = new int[size][];
            for (int i = 0; i < size; i++)
                visitedNode[i] = new int[2];    /*visitedNode[0] - current value of label, visitedNode[1] - 1 or 0. 
                                                visited or not visited accordingly*/
            
            for (int i = 0; i < size; i++)
            {
                visitedNode[i][0] = Int32.MaxValue;
            }
           
            visitedNode[currNode][0] = 0;
            node[currNode].label.Text = "0";
            do 
            {
                for (int i = 0; i < size; i++)
                    if (graph[currNode][i] != -1 && visitedNode[i][1] != 1) // check if the nodes(currNode and i) are connected
                    {
                        node[i].colorNode = Color.YellowGreen;
                       // edge[i].label.BackColor = Color.YellowGreen;
                        int possible = visitedNode[currNode][0] + graph[currNode][i];
                        if (visitedNode[i][0] > possible)
                        {
                            visitedNode[i][0] = possible;
                            node[i].label.Text = Convert.ToString(possible);
                        }
                    }
                visitedNode[currNode][1] = 1;
                currNode = findNextNode(visitedNode);
            }while(currNode != -1);
            
            string answer = "";
            for (int i = 0; i < size; i++)
                answer += Convert.ToString(visitedNode[i][0]) + " ";
            return answer;
        }

        public static void algDeijkstra(Graph graph, PictureBox pictureBox1, ListBox graphDeijkstra)
        {
            string[] ans = new string[graph.data.Length];
            for (int i = 0; i < graph.data.Length; i++)
            {
                Edge[] edge = graph.edges;
                Node[] node = graph.nodes;
                ans[i] = deijkstra(i, ref edge, ref node, graph.data);
                graphDeijkstra.Items.Add(ans[i]);
                SystemFunction.drawGraph(pictureBox1, graph);
                // Thread.Sleep(1000);
            }
        }
    }
}
