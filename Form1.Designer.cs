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
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveGraph = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listOutput = new System.Windows.Forms.ListBox();
            this.dgwOutput = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмДейкстриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algDeijkstraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмФлойдаУоршаллаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмБелманаФордаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.порівнянняАлгоритмівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теоретичніВідомостіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмДейкстриToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмФлойдаУоршаллаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмБелманаФордаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.порівяннняАлгоритмівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrix)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOutput)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(244, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 444);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(461, 459);
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
            this.dgwMatrix.Location = new System.Drawing.Point(0, 8);
            this.dgwMatrix.Name = "dgwMatrix";
            this.dgwMatrix.Size = new System.Drawing.Size(218, 176);
            this.dgwMatrix.TabIndex = 8;
            this.dgwMatrix.Visible = false;
            this.dgwMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMatrix_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.saveGraph);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Location = new System.Drawing.Point(228, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 489);
            this.panel1.TabIndex = 14;
            // 
            // saveGraph
            // 
            this.saveGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveGraph.BackColor = System.Drawing.Color.LightSeaGreen;
            this.saveGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveGraph.ForeColor = System.Drawing.Color.White;
            this.saveGraph.Location = new System.Drawing.Point(377, 459);
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
            this.panel2.Location = new System.Drawing.Point(4, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 489);
            this.panel2.TabIndex = 15;
            // 
            // listOutput
            // 
            this.listOutput.BackColor = System.Drawing.SystemColors.Control;
            this.listOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOutput.Cursor = System.Windows.Forms.Cursors.Help;
            this.listOutput.FormattingEnabled = true;
            this.listOutput.Location = new System.Drawing.Point(0, 191);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(228, 39);
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
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(-5, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 44);
            this.panel3.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem,
            this.алгоритмДейкстриToolStripMenuItem,
            this.теоретичніВідомостіToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadFromFileToolStripMenuItem,
            this.drawGraphToolStripMenuItem});
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.graphToolStripMenuItem.Text = "Граф..";
            // 
            // downloadFromFileToolStripMenuItem
            // 
            this.downloadFromFileToolStripMenuItem.Name = "downloadFromFileToolStripMenuItem";
            this.downloadFromFileToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.downloadFromFileToolStripMenuItem.Text = "Завантажити з файлу";
            this.downloadFromFileToolStripMenuItem.Click += new System.EventHandler(this.downloadFromFile_Click);
            // 
            // drawGraphToolStripMenuItem
            // 
            this.drawGraphToolStripMenuItem.Name = "drawGraphToolStripMenuItem";
            this.drawGraphToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.drawGraphToolStripMenuItem.Text = "Намалювати власноруч";
            this.drawGraphToolStripMenuItem.Click += new System.EventHandler(this.drawGraph_Click);
            // 
            // алгоритмДейкстриToolStripMenuItem
            // 
            this.алгоритмДейкстриToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algDeijkstraToolStripMenuItem1,
            this.алгоритмФлойдаУоршаллаToolStripMenuItem,
            this.алгоритмБелманаФордаToolStripMenuItem,
            this.порівнянняАлгоритмівToolStripMenuItem});
            this.алгоритмДейкстриToolStripMenuItem.Name = "алгоритмДейкстриToolStripMenuItem";
            this.алгоритмДейкстриToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.алгоритмДейкстриToolStripMenuItem.Text = "Алгоритми..";
            // 
            // algDeijkstraToolStripMenuItem1
            // 
            this.algDeijkstraToolStripMenuItem1.Name = "algDeijkstraToolStripMenuItem1";
            this.algDeijkstraToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.algDeijkstraToolStripMenuItem1.Text = "Алгоритм Дейкстри";
            this.algDeijkstraToolStripMenuItem1.Click += new System.EventHandler(this.Deijkstra_Click);
            // 
            // алгоритмФлойдаУоршаллаToolStripMenuItem
            // 
            this.алгоритмФлойдаУоршаллаToolStripMenuItem.Name = "алгоритмФлойдаУоршаллаToolStripMenuItem";
            this.алгоритмФлойдаУоршаллаToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.алгоритмФлойдаУоршаллаToolStripMenuItem.Text = "Алгоритм Флойда-Уоршалла";
            this.алгоритмФлойдаУоршаллаToolStripMenuItem.Click += new System.EventHandler(this.алгоритмФлойдаУоршаллаToolStripMenuItem_Click);
            // 
            // алгоритмБелманаФордаToolStripMenuItem
            // 
            this.алгоритмБелманаФордаToolStripMenuItem.Name = "алгоритмБелманаФордаToolStripMenuItem";
            this.алгоритмБелманаФордаToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.алгоритмБелманаФордаToolStripMenuItem.Text = "Алгоритм Белмана-Форда";
            // 
            // порівнянняАлгоритмівToolStripMenuItem
            // 
            this.порівнянняАлгоритмівToolStripMenuItem.Name = "порівнянняАлгоритмівToolStripMenuItem";
            this.порівнянняАлгоритмівToolStripMenuItem.ShowShortcutKeys = false;
            this.порівнянняАлгоритмівToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.порівнянняАлгоритмівToolStripMenuItem.Text = "Порівняння алгоритмів";
            this.порівнянняАлгоритмівToolStripMenuItem.Click += new System.EventHandler(this.порівяннняАлгоритмівToolStripMenuItem_Click);
            // 
            // теоретичніВідомостіToolStripMenuItem
            // 
            this.теоретичніВідомостіToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.алгоритмДейкстриToolStripMenuItem2,
            this.алгоритмФлойдаУоршаллаToolStripMenuItem1,
            this.алгоритмБелманаФордаToolStripMenuItem1,
            this.порівяннняАлгоритмівToolStripMenuItem});
            this.теоретичніВідомостіToolStripMenuItem.Name = "теоретичніВідомостіToolStripMenuItem";
            this.теоретичніВідомостіToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.теоретичніВідомостіToolStripMenuItem.Text = "Теоретичні відомості";
            // 
            // алгоритмДейкстриToolStripMenuItem2
            // 
            this.алгоритмДейкстриToolStripMenuItem2.Name = "алгоритмДейкстриToolStripMenuItem2";
            this.алгоритмДейкстриToolStripMenuItem2.Size = new System.Drawing.Size(237, 22);
            this.алгоритмДейкстриToolStripMenuItem2.Text = "Алгоритм Дейкстри";
            this.алгоритмДейкстриToolStripMenuItem2.Click += new System.EventHandler(this.алгоритмДейкстриToolStripMenuItem2_Click);
            // 
            // алгоритмФлойдаУоршаллаToolStripMenuItem1
            // 
            this.алгоритмФлойдаУоршаллаToolStripMenuItem1.Name = "алгоритмФлойдаУоршаллаToolStripMenuItem1";
            this.алгоритмФлойдаУоршаллаToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.алгоритмФлойдаУоршаллаToolStripMenuItem1.Text = "Алгоритм Флойда-Уоршалла";
            this.алгоритмФлойдаУоршаллаToolStripMenuItem1.Click += new System.EventHandler(this.алгоритмФлойдаУоршаллаToolStripMenuItem1_Click);
            // 
            // алгоритмБелманаФордаToolStripMenuItem1
            // 
            this.алгоритмБелманаФордаToolStripMenuItem1.Name = "алгоритмБелманаФордаToolStripMenuItem1";
            this.алгоритмБелманаФордаToolStripMenuItem1.Size = new System.Drawing.Size(237, 22);
            this.алгоритмБелманаФордаToolStripMenuItem1.Text = "Алгоритм Белмана-Форда";
            // 
            // порівяннняАлгоритмівToolStripMenuItem
            // 
            this.порівяннняАлгоритмівToolStripMenuItem.Name = "порівяннняАлгоритмівToolStripMenuItem";
            this.порівяннняАлгоритмівToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.порівяннняАлгоритмівToolStripMenuItem.Text = "Порівянння алгоритмів";
            this.порівяннняАлгоритмівToolStripMenuItem.Click += new System.EventHandler(this.порівяннняАлгоритмівToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 528);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graphs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrix)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOutput)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dgwMatrix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button saveGraph;
        private System.Windows.Forms.DataGridView dgwOutput;
        private System.Windows.Forms.ListBox listOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмДейкстриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algDeijkstraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem алгоритмФлойдаУоршаллаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмБелманаФордаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теоретичніВідомостіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмДейкстриToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem алгоритмФлойдаУоршаллаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem алгоритмБелманаФордаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem порівяннняАлгоритмівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem порівнянняАлгоритмівToolStripMenuItem;
    }
}

