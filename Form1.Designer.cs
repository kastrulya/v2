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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dgwMatrix = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.drawGraph = new System.Windows.Forms.Button();
            this.bttnDeijkstra = new System.Windows.Forms.Button();
            this.bttnFloyd = new System.Windows.Forms.Button();
            this.bttnFord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(198, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 335);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonClear.Location = new System.Drawing.Point(592, 369);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(95, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистити екран";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
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
            this.button2.Location = new System.Drawing.Point(12, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Завантажити граф з файлу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.downloadFromFile_Click);
            // 
            // drawGraph
            // 
            this.drawGraph.Location = new System.Drawing.Point(223, 2);
            this.drawGraph.Name = "drawGraph";
            this.drawGraph.Size = new System.Drawing.Size(165, 23);
            this.drawGraph.TabIndex = 10;
            this.drawGraph.Text = "Намалювати граф власноруч";
            this.drawGraph.UseVisualStyleBackColor = true;
            this.drawGraph.Click += new System.EventHandler(this.drawGraph_Click);
            // 
            // bttnDeijkstra
            // 
            this.bttnDeijkstra.Location = new System.Drawing.Point(12, 369);
            this.bttnDeijkstra.Name = "bttnDeijkstra";
            this.bttnDeijkstra.Size = new System.Drawing.Size(138, 23);
            this.bttnDeijkstra.TabIndex = 11;
            this.bttnDeijkstra.Text = "Алгоритм Дейкстри";
            this.bttnDeijkstra.UseVisualStyleBackColor = true;
            this.bttnDeijkstra.Click += new System.EventHandler(this.Deijkstra_Click);
            // 
            // bttnFloyd
            // 
            this.bttnFloyd.Location = new System.Drawing.Point(168, 369);
            this.bttnFloyd.Name = "bttnFloyd";
            this.bttnFloyd.Size = new System.Drawing.Size(169, 23);
            this.bttnFloyd.TabIndex = 12;
            this.bttnFloyd.Text = "Алгоритм Флойда-Уоршалла";
            this.bttnFloyd.UseVisualStyleBackColor = true;
            // 
            // bttnFord
            // 
            this.bttnFord.Location = new System.Drawing.Point(355, 369);
            this.bttnFord.Name = "bttnFord";
            this.bttnFord.Size = new System.Drawing.Size(157, 23);
            this.bttnFord.TabIndex = 13;
            this.bttnFord.Text = "Алгоритм Белмана-Форда";
            this.bttnFord.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 394);
            this.Controls.Add(this.bttnFord);
            this.Controls.Add(this.bttnFloyd);
            this.Controls.Add(this.bttnDeijkstra);
            this.Controls.Add(this.drawGraph);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgwMatrix);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dgwMatrix;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button drawGraph;
        private System.Windows.Forms.Button bttnDeijkstra;
        private System.Windows.Forms.Button bttnFloyd;
        private System.Windows.Forms.Button bttnFord;
    }
}

