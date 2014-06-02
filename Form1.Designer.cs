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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonClear = new System.Windows.Forms.Button();
            this.dgwMatrix = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paintPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AboutProgram = new System.Windows.Forms.Panel();
            this.aboutProgramPanel = new System.Windows.Forms.Panel();
            this.bttnNext = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.howToUsePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.saveGraph = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aboutAuthorPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
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
            this.FordaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.порівнянняАлгоритмівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теоретичніВідомостіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмДейкстриToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмФлойдаУоршаллаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмБелманаФордаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.порівяннняАлгоритмівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrix)).BeginInit();
            this.panel1.SuspendLayout();
            this.paintPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AboutProgram.SuspendLayout();
            this.aboutProgramPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnNext)).BeginInit();
            this.howToUsePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.aboutAuthorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOutput)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(532, 456);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(67, 30);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистити екран";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Visible = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dgwMatrix
            // 
            this.dgwMatrix.AllowUserToAddRows = false;
            this.dgwMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwMatrix.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgwMatrix.GridColor = System.Drawing.Color.White;
            this.dgwMatrix.Location = new System.Drawing.Point(9, 14);
            this.dgwMatrix.Name = "dgwMatrix";
            this.dgwMatrix.Size = new System.Drawing.Size(218, 176);
            this.dgwMatrix.TabIndex = 8;
            this.dgwMatrix.Visible = false;
            this.dgwMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMatrix_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.paintPanel);
            this.panel1.Controls.Add(this.AboutProgram);
            this.panel1.Controls.Add(this.saveGraph);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Location = new System.Drawing.Point(244, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 486);
            this.panel1.TabIndex = 14;
            // 
            // paintPanel
            // 
            this.paintPanel.Controls.Add(this.pictureBox1);
            this.paintPanel.Location = new System.Drawing.Point(16, 27);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(574, 423);
            this.paintPanel.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 395);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AboutProgram
            // 
            this.AboutProgram.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutProgram.Controls.Add(this.aboutProgramPanel);
            this.AboutProgram.Controls.Add(this.label1);
            this.AboutProgram.Controls.Add(this.howToUsePanel);
            this.AboutProgram.Location = new System.Drawing.Point(16, 28);
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(574, 422);
            this.AboutProgram.TabIndex = 9;
            this.AboutProgram.Visible = false;
            // 
            // aboutProgramPanel
            // 
            this.aboutProgramPanel.Controls.Add(this.bttnNext);
            this.aboutProgramPanel.Controls.Add(this.label5);
            this.aboutProgramPanel.Location = new System.Drawing.Point(30, 61);
            this.aboutProgramPanel.Name = "aboutProgramPanel";
            this.aboutProgramPanel.Size = new System.Drawing.Size(533, 345);
            this.aboutProgramPanel.TabIndex = 1;
            // 
            // bttnNext
            // 
            this.bttnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnNext.Image = global::v2.Properties.Resources.arrow;
            this.bttnNext.Location = new System.Drawing.Point(450, 286);
            this.bttnNext.Name = "bttnNext";
            this.bttnNext.Size = new System.Drawing.Size(61, 52);
            this.bttnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttnNext.TabIndex = 9;
            this.bttnNext.TabStop = false;
            this.bttnNext.Click += new System.EventHandler(this.bttnNext_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(27, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(475, 284);
            this.label5.TabIndex = 0;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(132, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Електронний довідник \"Графи\"";
            // 
            // howToUsePanel
            // 
            this.howToUsePanel.Controls.Add(this.label3);
            this.howToUsePanel.Controls.Add(this.pictureBox2);
            this.howToUsePanel.Controls.Add(this.pictureBox5);
            this.howToUsePanel.Controls.Add(this.label2);
            this.howToUsePanel.Controls.Add(this.pictureBox3);
            this.howToUsePanel.Controls.Add(this.label4);
            this.howToUsePanel.Controls.Add(this.pictureBox4);
            this.howToUsePanel.Location = new System.Drawing.Point(30, 55);
            this.howToUsePanel.Name = "howToUsePanel";
            this.howToUsePanel.Size = new System.Drawing.Size(536, 354);
            this.howToUsePanel.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(375, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 112);
            this.label3.TabIndex = 2;
            this.label3.Text = "Для створення вершини просто натисніть  \r\nправу кнопку миші на робочій поверхні(б" +
    "іле полотно)\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::v2.Properties.Resources.AboutProgram1_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::v2.Properties.Resources.AboutProgram4;
            this.pictureBox5.Location = new System.Drawing.Point(386, 188);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(125, 128);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "Оберіть перший пункт аби завантажити готовий\r\n граф або створіть свій власний.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::v2.Properties.Resources.AboutProgram2;
            this.pictureBox3.Location = new System.Drawing.Point(230, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 93);
            this.label4.TabIndex = 3;
            this.label4.Text = "Введіть вагу ребра в матрицю суміжності \r\nдля його створення, або оберіть відпові" +
    "дні\r\n вершини для з’єднання подвійним кліком\r\n правої кнопки миші\r\n";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::v2.Properties.Resources.AboutProgram3;
            this.pictureBox4.Location = new System.Drawing.Point(273, 188);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(96, 81);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // saveGraph
            // 
            this.saveGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveGraph.BackColor = System.Drawing.Color.LightSeaGreen;
            this.saveGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveGraph.ForeColor = System.Drawing.Color.White;
            this.saveGraph.Location = new System.Drawing.Point(448, 456);
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
            this.panel2.Controls.Add(this.aboutAuthorPanel);
            this.panel2.Controls.Add(this.dgwMatrix);
            this.panel2.Controls.Add(this.listOutput);
            this.panel2.Controls.Add(this.dgwOutput);
            this.panel2.Location = new System.Drawing.Point(4, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 486);
            this.panel2.TabIndex = 15;
            // 
            // aboutAuthorPanel
            // 
            this.aboutAuthorPanel.Controls.Add(this.label6);
            this.aboutAuthorPanel.Location = new System.Drawing.Point(0, 0);
            this.aboutAuthorPanel.Name = "aboutAuthorPanel";
            this.aboutAuthorPanel.Size = new System.Drawing.Size(234, 486);
            this.aboutAuthorPanel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 361);
            this.label6.TabIndex = 0;
            this.label6.Text = resources.GetString("label6.Text");
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listOutput
            // 
            this.listOutput.BackColor = System.Drawing.SystemColors.Control;
            this.listOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOutput.Cursor = System.Windows.Forms.Cursors.Help;
            this.listOutput.FormattingEnabled = true;
            this.listOutput.Location = new System.Drawing.Point(9, 215);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(214, 39);
            this.listOutput.TabIndex = 1;
            // 
            // dgwOutput
            // 
            this.dgwOutput.AllowUserToAddRows = false;
            this.dgwOutput.BackgroundColor = System.Drawing.Color.White;
            this.dgwOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOutput.Location = new System.Drawing.Point(8, 263);
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
            this.panel3.Size = new System.Drawing.Size(865, 25);
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
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
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
            this.FordaToolStripMenuItem,
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
            // FordaToolStripMenuItem
            // 
            this.FordaToolStripMenuItem.Name = "FordaToolStripMenuItem";
            this.FordaToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.FordaToolStripMenuItem.Text = "Алгоритм Белмана-Форда";
            this.FordaToolStripMenuItem.Click += new System.EventHandler(this.FordaToolStripMenuItem_Click);
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
            this.алгоритмБелманаФордаToolStripMenuItem1.Click += new System.EventHandler(this.алгоритмБелманаФордаToolStripMenuItem1_Click);
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
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(858, 528);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graphs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMatrix)).EndInit();
            this.panel1.ResumeLayout(false);
            this.paintPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AboutProgram.ResumeLayout(false);
            this.aboutProgramPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bttnNext)).EndInit();
            this.howToUsePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.aboutAuthorPanel.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem FordaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теоретичніВідомостіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмДейкстриToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem алгоритмФлойдаУоршаллаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem алгоритмБелманаФордаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem порівяннняАлгоритмівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem порівнянняАлгоритмівToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel AboutProgram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel aboutProgramPanel;
        private System.Windows.Forms.PictureBox bttnNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel howToUsePanel;
        private System.Windows.Forms.Panel paintPanel;
        private System.Windows.Forms.Panel aboutAuthorPanel;
        private System.Windows.Forms.Label label6;
    }
}

