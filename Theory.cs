using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v2
{
    public partial class Theory : Form
    {
        public Theory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PZDeijkstra.Show();
            complexityDeijkstra.Hide();
            mathDeijkstra.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PZDeijkstra.Hide();
            complexityDeijkstra.Hide();
            mathDeijkstra.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PZDeijkstra.Hide();
            complexityDeijkstra.Show();
            mathDeijkstra.Hide();
        }


        private void button3Yorshall_Click(object sender, EventArgs e)
        {
            PZYorshall.Hide();
            ComplexityYorshall.Show();
            AlgorithmYorshall.Hide();
        }


        private void button2Yorshall_Click(object sender, EventArgs e)
        {
            PZYorshall.Hide();
            ComplexityYorshall.Hide();
            AlgorithmYorshall.Show();
        }

        private void button1Yorshall_Click(object sender, EventArgs e)
        {
            PZYorshall.Show();
            ComplexityYorshall.Hide();
            AlgorithmYorshall.Hide();
        }

        public void deijkstraChoose()
        {
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        public void yorshallChoose()
        {
            this.button3.Click -= new System.EventHandler(this.button3_Click);
            this.button2.Click -= new System.EventHandler(this.button2_Click);
            this.button1.Click -= new System.EventHandler(this.button1_Click);

            this.button3.Click += new System.EventHandler(this.button3Yorshall_Click);
            this.button2.Click += new System.EventHandler(this.button2Yorshall_Click);
            this.button1.Click += new System.EventHandler(this.button1Yorshall_Click);

            DeijkstraPanel.Hide();
            YorshallPanel.Show();
            PZYorshall.Show();
        }

        private void button3Belmana_Click(object sender, EventArgs e)
        {
            PZBelmana.Hide();
            ComplexityBelmana.Show();
            AlgoritmBelmana.Hide();
        }

        private void button2Belmana_Click(object sender, EventArgs e)
        {
            PZBelmana.Hide();
            ComplexityBelmana.Hide();
            AlgoritmBelmana.Show();
        }

        private void button1Belmana_Click(object sender, EventArgs e)
        {
            PZBelmana.Show();
            ComplexityBelmana.Hide();
            AlgoritmBelmana.Hide();
        }

        public void belmanaChoose()
        {
            this.button3.Click += new System.EventHandler(this.button3Belmana_Click);
            this.button2.Click += new System.EventHandler(this.button2Belmana_Click);
            this.button1.Click += new System.EventHandler(this.button1Belmana_Click);           
        }

    }
}
