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
            PZDeijkstra.Visible = true;
            complexityDeijkstra.Visible = false;
            mathDeijkstra.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PZDeijkstra.Visible = false;
            complexityDeijkstra.Visible = false;
            mathDeijkstra.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PZDeijkstra.Visible = false;
            complexityDeijkstra.Visible = true;
            mathDeijkstra.Visible = false;
            complexityDeijkstra.BringToFront();
            complexityDeijkstra.Refresh();
        }
    }
}
