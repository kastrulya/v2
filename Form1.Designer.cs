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
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveGraph = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listOutput = new System.Windows.Forms.ListBox();
            this.dgwOutput = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrix)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOutput)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(244, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 391);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(461, 401);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(67, 30);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистити екран";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dgwMatrix
            // 
            this.dgwMatrix.AllowUserToAddRows = false;
            this.dgwMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwMatrix.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgwMatrix.GridColor = System.Drawing.Color.White;
            this.dgwMatrix.Location = new System.Drawing.Point(3, 9);
            this.dgwMatrix.Name = "dgwMatrix";
            this.dgwMatrix.Size = new System.Drawing.Size(218, 176);
            this.dgwMatrix.TabIndex = 8;
            this.dgwMatrix.Visible = false;
            this.dgwMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMatrix_CellValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(30, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Завантажити граф з файлу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.downloadFromFile_Click);
            // 
            // drawGraph
            // 
            this.drawGraph.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawGraph.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.drawGraph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.drawGraph.Font = new System.Drawing.Font("Technic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawGraph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.drawGraph.Location = new System.Drawing.Point(30, 54);
            this.drawGraph.Name = "drawGraph";
            this.drawGraph.Size = new System.Drawing.Size(165, 37);
            this.drawGraph.TabIndex = 10;
            this.drawGraph.Text = "Намалювати граф власноруч";
            this.drawGraph.UseVisualStyleBackColor = false;
            this.drawGraph.Click += new System.EventHandler(this.drawGraph_Click);
            // 
            // bttnDeijkstra
            // 
            this.bttnDeijkstra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDeijkstra.BackColor = System.Drawing.Color.White;
            this.bttnDeijkstra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnDeijkstra.Location = new System.Drawing.Point(244, 28);
            this.bttnDeijkstra.Name = "bttnDeijkstra";
            this.bttnDeijkstra.Size = new System.Drawing.Size(138, 42);
            this.bttnDeijkstra.TabIndex = 11;
            this.bttnDeijkstra.Text = "Алгоритм Дейкстри";
            this.bttnDeijkstra.UseVisualStyleBackColor = false;
            this.bttnDeijkstra.Click += new System.EventHandler(this.Deijkstra_Click);
            // 
            // bttnFloyd
            // 
            this.bttnFloyd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnFloyd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnFloyd.Location = new System.Drawing.Point(403, 28);
            this.bttnFloyd.Name = "bttnFloyd";
            this.bttnFloyd.Size = new System.Drawing.Size(169, 42);
            this.bttnFloyd.TabIndex = 12;
            this.bttnFloyd.Text = "Алгоритм Флойда-Уоршалла";
            this.bttnFloyd.UseVisualStyleBackColor = true;
            // 
            // bttnFord
            // 
            this.bttnFord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnFord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnFord.Location = new System.Drawing.Point(591, 28);
            this.bttnFord.Name = "bttnFord";
            this.bttnFord.Size = new System.Drawing.Size(157, 42);
            this.bttnFord.TabIndex = 13;
            this.bttnFord.Text = "Алгоритм Белмана-Форда";
            this.bttnFord.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.saveGraph);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Location = new System.Drawing.Point(228, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 431);
            this.panel1.TabIndex = 14;
            // 
            // saveGraph
            // 
            this.saveGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveGraph.BackColor = System.Drawing.Color.LightSeaGreen;
            this.saveGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveGraph.ForeColor = System.Drawing.Color.White;
            this.saveGraph.Location = new System.Drawing.Point(377, 401);
            this.saveGraph.Name = "saveGraph";
            this.saveGraph.Size = new System.Drawing.Size(78, 30);
            this.saveGraph.TabIndex = 8;
            this.saveGraph.Text = "Зберегти";
            this.saveGraph.UseVisualStyleBackColor = false;
            this.saveGraph.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dgwMatrix);
            this.panel2.Controls.Add(this.listOutput);
            this.panel2.Controls.Add(this.dgwOutput);
            this.panel2.Location = new System.Drawing.Point(4, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 431);
            this.panel2.TabIndex = 15;
            // 
            // listOutput
            // 
            this.listOutput.BackColor = System.Drawing.SystemColors.Control;
            this.listOutput.FormattingEnabled = true;
            this.listOutput.Location = new System.Drawing.Point(0, 191);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(228, 43);
            this.listOutput.TabIndex = 1;
            // 
            // dgwOutput
            // 
            this.dgwOutput.AllowUserToAddRows = false;
            this.dgwOutput.BackgroundColor = System.Drawing.Color.White;
            this.dgwOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOutput.Location = new System.Drawing.Point(3, 240);
            this.dgwOutput.Name = "dgwOutput";
            this.dgwOutput.Size = new System.Drawing.Size(215, 183);
            this.dgwOutput.TabIndex = 0;
            this.dgwOutput.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.drawGraph);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(-5, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 103);
            this.panel3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 528);
            this.Controls.Add(this.bttnFord);
            this.Controls.Add(this.bttnFloyd);
            this.Controls.Add(this.bttnDeijkstra);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrix)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOutput)).EndInit();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button saveGraph;
        private System.Windows.Forms.DataGridView dgwOutput;
        private System.Windows.Forms.ListBox listOutput;
    }
}

