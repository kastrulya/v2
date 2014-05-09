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
            this.button1 = new System.Windows.Forms.Button();
            this.dgwMatrix = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.drawGraph = new System.Windows.Forms.Button();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.adownloadFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.adrawGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.Deijkstra = new System.Windows.Forms.ToolStripMenuItem();
            this.Floyda = new System.Windows.Forms.ToolStripMenuItem();
            this.Belmana = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrix)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(198, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 335);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // dgwMatrix
            // 
            this.dgwMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwMatrix.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMatrix.Location = new System.Drawing.Point(0, 28);
            this.dgwMatrix.Name = "dgwMatrix";
            this.dgwMatrix.Size = new System.Drawing.Size(192, 182);
            this.dgwMatrix.TabIndex = 8;
            this.dgwMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMatrix_CellValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Завантажити граф з файлу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.downloadFromFile_Click);
            // 
            // drawGraph
            // 
            this.drawGraph.Location = new System.Drawing.Point(314, 2);
            this.drawGraph.Name = "drawGraph";
            this.drawGraph.Size = new System.Drawing.Size(165, 23);
            this.drawGraph.TabIndex = 10;
            this.drawGraph.Text = "Намалювати граф власноруч";
            this.drawGraph.UseVisualStyleBackColor = true;
            this.drawGraph.Click += new System.EventHandler(this.drawGraph_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adownloadFromFile,
            this.adrawGraph});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // adownloadFromFile
            // 
            this.adownloadFromFile.Name = "adownloadFromFile";
            this.adownloadFromFile.Size = new System.Drawing.Size(267, 22);
            this.adownloadFromFile.Text = "Завнтажити матрицю суміжностей";
            this.adownloadFromFile.Click += new System.EventHandler(this.downloadFromFile_Click);
            // 
            // adrawGraph
            // 
            this.adrawGraph.Name = "adrawGraph";
            this.adrawGraph.Size = new System.Drawing.Size(267, 22);
            this.adrawGraph.Text = "Намалювати граф власноруч";
            this.adrawGraph.Click += new System.EventHandler(this.drawGraph_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 394);
            this.Controls.Add(this.drawGraph);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgwMatrix);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrix)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgwMatrix;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button drawGraph;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem adownloadFromFile;
        private System.Windows.Forms.ToolStripMenuItem adrawGraph;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem Deijkstra;
        private System.Windows.Forms.ToolStripMenuItem Floyda;
        private System.Windows.Forms.ToolStripMenuItem Belmana;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

