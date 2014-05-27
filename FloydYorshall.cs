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
            int[][] D;
            D = graph.getMatrixData();
            for (int i = 0; i < D.Length; i++)
                for (int j = 0; j < D.Length; j++)
                    if (D[i][j] == -1) D[i][j] = Int32.MaxValue;

            for (int k = 0; k < D.Length; k++)
                for (int i = 0; i < D.Length; i++)
                    for (int j = 0; j < D.Length; j++)
                        D[i][j] = Math.Min(D[i][j], D[i][k] + D[k][j]);

            listOutput.Items.Clear();
            listOutput.Items.Add("Алгоритм Флойда-Уоршалла.");
            listOutput.Items.Add("Матриця найкоротших шляхів. ");

            matrix.Rows.Clear(); // можливо, потрібно заново створювати рядки і колонки бо матриця датагрідвью не створено

            for (int i = 0; i < D.Length; i++)
                for (int j = 0; j < D.Length; j++)
                {
                    matrix.Columns.Add("col" + Convert.ToString(i), Convert.ToString(i));
                    matrix.Rows.Add();
                }


            for (int i = 0; i < D.Length; i++)
                for (int j = 0; j < D.Length; j++)
                    matrix.Rows[i].Cells[j].Value = D[i][j];
            //pictureBox1.Controls.Add(listOutput);
            //pictureBox1.Controls.Add(matrix);
            listOutput.Visible = true;
            matrix.Visible = true;
        }
    }
}
