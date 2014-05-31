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

namespace v2
{
    public partial class Compare : Form
    {
        public Compare()
        {
            InitializeComponent();
        }

        private void pasteAnswer(DataGridView dgwMatrix, Label lbl, string path)
        {
            StreamReader sr = File.OpenText(path);
            int length = Convert.ToInt32(sr.ReadLine());

            for (int i = 0; i < length; i++)
            {
                dgwMatrix.Columns.Add(Convert.ToString(i), Convert.ToString(i));
                dgwMatrix.Columns[i].Width = (dgwMatrix.Width - 40) / length;
            }
            for (int i = 0; i < length; i++)
            { 
                dgwMatrix.Rows.Add();
                dgwMatrix.Rows[i].Height = (dgwMatrix.Height - 35) / length;
            }

            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    dgwMatrix.Rows[i].Cells[j].Value = sr.ReadLine();
            string answer = "Під час виконання алгоритму виконується " + sr.ReadLine() + " ітерацій. ";
            lbl.Text = answer;
            lbl.Refresh();
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pasteAnswer(dataGridView1, label4, "deijkstraAlg.txt");

            pasteAnswer(dataGridView2, label5, "floydaAlg.txt");

            pasteAnswer(dataGridView3, label6, "floydaAlg.txt");
        }
    }
}
