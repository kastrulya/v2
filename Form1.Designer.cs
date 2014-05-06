namespace v2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.graphDeijkstra = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.downloadFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.drawGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.Deijkstra = new System.Windows.Forms.ToolStripMenuItem();
            this.Floyda = new System.Windows.Forms.ToolStripMenuItem();
            this.Belmana = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(198, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 335);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // graphDeijkstra
            // 
            this.graphDeijkstra.FormattingEnabled = true;
            this.graphDeijkstra.Location = new System.Drawing.Point(11, 281);
            this.graphDeijkstra.Name = "graphDeijkstra";
            this.graphDeijkstra.Size = new System.Drawing.Size(181, 82);
            this.graphDeijkstra.TabIndex = 3;
            this.graphDeijkstra.SelectedIndexChanged += new System.EventHandler(this.graphDeijkstra_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton2,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(571, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadFromFile,
            this.drawGraph});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // downloadFromFile
            // 
            this.downloadFromFile.Name = "downloadFromFile";
            this.downloadFromFile.Size = new System.Drawing.Size(267, 22);
            this.downloadFromFile.Text = "Завнтажити матрицю суміжностей";
            this.downloadFromFile.Click += new System.EventHandler(this.downloadFromFile_Click);
            // 
            // drawGraph
            // 
            this.drawGraph.Name = "drawGraph";
            this.drawGraph.Size = new System.Drawing.Size(267, 22);
            this.drawGraph.Text = "Намалювати граф власноруч";
            this.drawGraph.Click += new System.EventHandler(this.drawGraph_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Deijkstra,
            this.Floyda,
            this.Belmana});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // Deijkstra
            // 
            this.Deijkstra.Name = "Deijkstra";
            this.Deijkstra.Size = new System.Drawing.Size(237, 22);
            this.Deijkstra.Text = "Алгоритм Дейкстри";
            this.Deijkstra.Click += new System.EventHandler(this.Deijkstra_Click);
            // 
            // Floyda
            // 
            this.Floyda.Name = "Floyda";
            this.Floyda.Size = new System.Drawing.Size(237, 22);
            this.Floyda.Text = "Алгоритм Флойда-Уоршалла";
            // 
            // Belmana
            // 
            this.Belmana.Name = "Belmana";
            this.Belmana.Size = new System.Drawing.Size(237, 22);
            this.Belmana.Text = "Алгоритм Белмана-Форда";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(464, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Очистити екран";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.graphDeijkstra);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox graphDeijkstra;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem downloadFromFile;
        private System.Windows.Forms.ToolStripMenuItem drawGraph;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem Deijkstra;
        private System.Windows.Forms.ToolStripMenuItem Floyda;
        private System.Windows.Forms.ToolStripMenuItem Belmana;
        private System.Windows.Forms.Button button1;
    }
}

