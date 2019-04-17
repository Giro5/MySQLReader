namespace MySQLReader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabC = new System.Windows.Forms.TabControl();
            this.connectionTP = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectBTN = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.portTB = new System.Windows.Forms.TextBox();
            this.hostnameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerTP = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.codepublishTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pagesTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.titlebookTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.codebookTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SelRowCB = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rightCB = new System.Windows.Forms.ComboBox();
            this.leftCB = new System.Windows.Forms.ComboBox();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.DB_CB = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.mainTabC.SuspendLayout();
            this.connectionTP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ServerTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabC
            // 
            this.mainTabC.Controls.Add(this.connectionTP);
            this.mainTabC.Controls.Add(this.ServerTP);
            this.mainTabC.Controls.Add(this.tabPage1);
            this.mainTabC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabC.Location = new System.Drawing.Point(0, 0);
            this.mainTabC.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabC.Name = "mainTabC";
            this.mainTabC.Padding = new System.Drawing.Point(0, 0);
            this.mainTabC.SelectedIndex = 0;
            this.mainTabC.Size = new System.Drawing.Size(1184, 661);
            this.mainTabC.TabIndex = 1;
            // 
            // connectionTP
            // 
            this.connectionTP.Controls.Add(this.panel1);
            this.connectionTP.Location = new System.Drawing.Point(4, 22);
            this.connectionTP.Margin = new System.Windows.Forms.Padding(0);
            this.connectionTP.Name = "connectionTP";
            this.connectionTP.Size = new System.Drawing.Size(1176, 635);
            this.connectionTP.TabIndex = 0;
            this.connectionTP.Text = "Connection";
            this.connectionTP.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.connectBTN);
            this.panel1.Controls.Add(this.passwordTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.usernameTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.portTB);
            this.panel1.Controls.Add(this.hostnameTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(401, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 218);
            this.panel1.TabIndex = 0;
            // 
            // connectBTN
            // 
            this.connectBTN.Location = new System.Drawing.Point(4, 192);
            this.connectBTN.Name = "connectBTN";
            this.connectBTN.Size = new System.Drawing.Size(368, 23);
            this.connectBTN.TabIndex = 8;
            this.connectBTN.Text = "Connect";
            this.connectBTN.UseVisualStyleBackColor = true;
            this.connectBTN.Click += new System.EventHandler(this.connectBTN_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(4, 148);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(368, 20);
            this.passwordTB.TabIndex = 7;
            this.passwordTB.Text = "123654";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "password";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(4, 89);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(368, 20);
            this.usernameTB.TabIndex = 5;
            this.usernameTB.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "username";
            // 
            // portTB
            // 
            this.portTB.Location = new System.Drawing.Point(255, 33);
            this.portTB.Name = "portTB";
            this.portTB.Size = new System.Drawing.Size(117, 20);
            this.portTB.TabIndex = 3;
            this.portTB.Text = "3306";
            // 
            // hostnameTB
            // 
            this.hostnameTB.Location = new System.Drawing.Point(4, 33);
            this.hostnameTB.Name = "hostnameTB";
            this.hostnameTB.Size = new System.Drawing.Size(245, 20);
            this.hostnameTB.TabIndex = 2;
            this.hostnameTB.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "hostname";
            // 
            // ServerTP
            // 
            this.ServerTP.Controls.Add(this.splitContainer1);
            this.ServerTP.Location = new System.Drawing.Point(4, 22);
            this.ServerTP.Name = "ServerTP";
            this.ServerTP.Padding = new System.Windows.Forms.Padding(3);
            this.ServerTP.Size = new System.Drawing.Size(1176, 635);
            this.ServerTP.TabIndex = 1;
            this.ServerTP.Text = "Server";
            this.ServerTP.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1170, 629);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(197, 603);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(197, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Gray;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.menuStrip3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.dataGrid);
            this.splitContainer2.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer2.Size = new System.Drawing.Size(959, 627);
            this.splitContainer2.SplitterDistance = 261;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(959, 237);
            this.textBox1.TabIndex = 1;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(959, 24);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.executeToolStripMenuItem_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 24);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(959, 332);
            this.dataGrid.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyToolStripMenuItem,
            this.revertToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.applyToolStripMenuItem.Text = "Apply";
            this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
            // 
            // revertToolStripMenuItem
            // 
            this.revertToolStripMenuItem.Name = "revertToolStripMenuItem";
            this.revertToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.revertToolStripMenuItem.Text = "Revert";
            this.revertToolStripMenuItem.Click += new System.EventHandler(this.revertToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem1.Text = "result";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deleteBtn);
            this.tabPage1.Controls.Add(this.updateBtn);
            this.tabPage1.Controls.Add(this.insertBtn);
            this.tabPage1.Controls.Add(this.codepublishTB);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.pagesTB);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.titlebookTB);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.codebookTB);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.SelRowCB);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.rightCB);
            this.tabPage1.Controls.Add(this.leftCB);
            this.tabPage1.Controls.Add(this.menuStrip4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1176, 635);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Coupling";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // codepublishTB
            // 
            this.codepublishTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codepublishTB.Location = new System.Drawing.Point(849, 235);
            this.codepublishTB.Name = "codepublishTB";
            this.codepublishTB.Size = new System.Drawing.Size(319, 20);
            this.codepublishTB.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(846, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Code_publish";
            // 
            // pagesTB
            // 
            this.pagesTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pagesTB.Location = new System.Drawing.Point(849, 180);
            this.pagesTB.Name = "pagesTB";
            this.pagesTB.Size = new System.Drawing.Size(319, 20);
            this.pagesTB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(846, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pages";
            // 
            // titlebookTB
            // 
            this.titlebookTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titlebookTB.Location = new System.Drawing.Point(848, 126);
            this.titlebookTB.Name = "titlebookTB";
            this.titlebookTB.Size = new System.Drawing.Size(319, 20);
            this.titlebookTB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(845, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Title_book";
            // 
            // codebookTB
            // 
            this.codebookTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codebookTB.Location = new System.Drawing.Point(849, 75);
            this.codebookTB.Name = "codebookTB";
            this.codebookTB.Size = new System.Drawing.Size(319, 20);
            this.codebookTB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(846, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Code_book";
            // 
            // SelRowCB
            // 
            this.SelRowCB.FormattingEnabled = true;
            this.SelRowCB.Location = new System.Drawing.Point(3, 31);
            this.SelRowCB.Name = "SelRowCB";
            this.SelRowCB.Size = new System.Drawing.Size(390, 21);
            this.SelRowCB.TabIndex = 5;
            this.SelRowCB.SelectedIndexChanged += new System.EventHandler(this.SelRowCB_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(835, 574);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(755, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(166, 24);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // rightCB
            // 
            this.rightCB.FormattingEnabled = true;
            this.rightCB.Location = new System.Drawing.Point(608, 28);
            this.rightCB.Name = "rightCB";
            this.rightCB.Size = new System.Drawing.Size(121, 21);
            this.rightCB.TabIndex = 2;
            this.rightCB.Visible = false;
            this.rightCB.SelectedIndexChanged += new System.EventHandler(this.rightCB_SelectedIndexChanged);
            // 
            // leftCB
            // 
            this.leftCB.FormattingEnabled = true;
            this.leftCB.Location = new System.Drawing.Point(481, 28);
            this.leftCB.Name = "leftCB";
            this.leftCB.Size = new System.Drawing.Size(121, 21);
            this.leftCB.TabIndex = 1;
            this.leftCB.Visible = false;
            this.leftCB.SelectedIndexChanged += new System.EventHandler(this.leftCB_SelectedIndexChanged);
            // 
            // menuStrip4
            // 
            this.menuStrip4.Enabled = false;
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DB_CB,
            this.toolStripMenuItem2});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(1176, 27);
            this.menuStrip4.TabIndex = 0;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // DB_CB
            // 
            this.DB_CB.Name = "DB_CB";
            this.DB_CB.Size = new System.Drawing.Size(121, 23);
            this.DB_CB.SelectedIndexChanged += new System.EventHandler(this.DB_CB_SelectedIndexChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 23);
            this.toolStripMenuItem2.Text = " ";
            // 
            // insertBtn
            // 
            this.insertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertBtn.Location = new System.Drawing.Point(849, 285);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 14;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.Location = new System.Drawing.Point(969, 285);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(1093, 285);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.mainTabC);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabC.ResumeLayout(false);
            this.connectionTP.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ServerTP.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabC;
        private System.Windows.Forms.TabPage connectionTP;
        private System.Windows.Forms.TabPage ServerTP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox hostnameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectBTN;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portTB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox rightCB;
        private System.Windows.Forms.ComboBox leftCB;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripComboBox DB_CB;
        private System.Windows.Forms.ComboBox SelRowCB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TextBox codepublishTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pagesTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titlebookTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox codebookTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button insertBtn;
    }
}

