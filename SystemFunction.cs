using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace v2
{
    class SystemFunction
    {
        public static int[][] readFile()
        {
            StreamReader data;
            string name = "data.txt";
            try
            {
                data = new StreamReader(name);
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
                return null;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                return null;
            }
            data = new StreamReader(name);
            int length = Convert.ToInt32(data.ReadLine());
            int[][] graph = new int[length][];
            for (int i = 0; i < length; i++)
            {
                graph[i] = new int[length];
                for (int j = 0; j < length; j++)
                    graph[i][j] = -1;
            }

            while (data.Peek() >= 0)
            {
                string strLine = data.ReadLine();
                string[] splitLine = strLine.Split(' ');
                int x = Convert.ToInt32(splitLine[0]);
                int y = Convert.ToInt32(splitLine[1]);
                graph[x - 1][y - 1] = Convert.ToInt32(splitLine[2]);
            }
            return graph;
        }

        public static int numberEdge(int[][] graph)
        {
            int k = 0;
            for (int i = 0; i < graph.Length; i++)
                for (int j = 0; j < graph.Length; j++)
                    if (graph[i][j] != -1)
                        k++;
            return k;
        }

        public static void outputGraph(ListBox panel, int[][] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                string strData = "";
                for (int j = 0; j < data.Length; j++)
                    strData += String.Format("{0, 4}", data[i][j]);
                panel.Items.Add(strData);
            }
        }

        public static PointF[] polarPoint(int[][] graph, int radius)
        {
            PointF[] point = new PointF[graph.Length];
            double deltaangle = 2 * Math.PI / graph.Length; // angle, remember about polar system
            double angle;
            for (int i = 0; i < graph.Length; i++)
            {
                angle = (i + 1) * deltaangle;
                point[i].X = (Int32)(radius * Math.Cos(angle) + 148); //Math.Abs(rad * Math.Cos(angle)));
                point[i].Y = (Int32)(radius * Math.Sin(angle) + 137.5); //Math.Abs(rad * Math.Sin(angle)));
            }
            return point;
        }

        public static void drawGraph(PictureBox panel, Graph graph)
        { 
            for (int i = 0; i < graph.data.Length; i++)
                graph.nodes[i].drawNode(panel);
            for (int i = 0; i < graph.numberOfEdges; i++)
                graph.edges[i].drawEdge(panel);
        }



    }
}
