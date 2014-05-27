using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v2
{
    class FloydYorshall
    {
        public FloydYorshall() {}

        public static void AlgFloydYorshall(PictureBox pictureBox1, Graph graph, DataGridView matrix, ListBox listOutput)
        {
            listOutput.Items.Add(" Алгоритм Флойда-Уоршала. ");
            listOutput.Items.Add(" Матриця найкоротших шляхів.");
            matrix.ColumnCount = graph.nodes.Length;
            for (int i = 0; i < graph.nodes.Length; i++)
            {
                matrix.Columns[i].Name = Convert.ToString(i);
                matrix.Columns[i].Width = matrix.Width / (graph.nodes.Length + 1);
                matrix.Rows.Add();
            }

            int[][] D;
            D = graph.data;
            for (int i = 0; i < D.Length; i++)
                for (int j = 0; j < D.Length; j++)
                    if (D[i][j] == -1) D[i][j] = 1000;
            
            for (int k = 0; k < D.Length; k++)
                for (int i = 0; i < D.Length; i++)
                    for (int j = 0; j < D.Length; j++)
                        D[i][j] = Math.Min(D[i][j], D[i][k] + D[k][j]);
           
            for (int i = 0; i < D.Length; i++)
                D[i][i] = 0;

                for (int i = 0; i < D.Length; i++)
                    for (int j = 0; j < D.Length; j++)
                        if (D[i][j] != 1000)
                            matrix.Rows[i].Cells[j].Value = D[i][j];
                        else matrix.Rows[i].Cells[j].Value = '∞';
        }
    }
}
