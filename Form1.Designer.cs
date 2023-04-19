namespace SiteHiJack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            bt_cancle = new Button();
            bt_hijeck = new Button();
            tb_directory = new TextBox();
            tb_domain = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listBox1 = new ListBox();
            tabPage2 = new TabPage();
            listBox2 = new ListBox();
            tabPage3 = new TabPage();
            listBox3 = new ListBox();
            tabPage4 = new TabPage();
            listBox4 = new ListBox();
            groupBox2 = new GroupBox();
            bt_download = new Button();
            bt_open = new Button();
            bt_view = new Button();
            tb_uritarget = new TextBox();
            label3 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            groupBox3 = new GroupBox();
            tb_viewer = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_cancle);
            groupBox1.Controls.Add(bt_hijeck);
            groupBox1.Controls.Add(tb_directory);
            groupBox1.Controls.Add(tb_domain);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Web Site Address";
            // 
            // bt_cancle
            // 
            bt_cancle.Enabled = false;
            bt_cancle.Location = new Point(192, 79);
            bt_cancle.Name = "bt_cancle";
            bt_cancle.Size = new Size(96, 23);
            bt_cancle.TabIndex = 5;
            bt_cancle.Text = "Cancle";
            bt_cancle.UseVisualStyleBackColor = true;
            bt_cancle.Click += bt_cancle_Click;
            // 
            // bt_hijeck
            // 
            bt_hijeck.Location = new Point(68, 79);
            bt_hijeck.Name = "bt_hijeck";
            bt_hijeck.Size = new Size(101, 23);
            bt_hijeck.TabIndex = 4;
            bt_hijeck.Text = "Hijeck";
            bt_hijeck.UseVisualStyleBackColor = true;
            bt_hijeck.Click += bt_hijeck_Click;
            // 
            // tb_directory
            // 
            tb_directory.BackColor = Color.Black;
            tb_directory.BorderStyle = BorderStyle.FixedSingle;
            tb_directory.ForeColor = Color.Red;
            tb_directory.Location = new Point(68, 50);
            tb_directory.Name = "tb_directory";
            tb_directory.PlaceholderText = "https://example.com/";
            tb_directory.Size = new Size(220, 23);
            tb_directory.TabIndex = 3;
            // 
            // tb_domain
            // 
            tb_domain.BackColor = Color.Black;
            tb_domain.BorderStyle = BorderStyle.FixedSingle;
            tb_domain.ForeColor = Color.Red;
            tb_domain.Location = new Point(68, 16);
            tb_domain.Name = "tb_domain";
            tb_domain.PlaceholderText = "https://example.com/index.php";
            tb_domain.Size = new Size(220, 23);
            tb_domain.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 58);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Directory :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Domain :";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 131);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(294, 337);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(286, 309);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Links";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Black;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.ForeColor = Color.Lime;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(280, 302);
            listBox1.TabIndex = 0;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(286, 309);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Css";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Black;
            listBox2.ForeColor = Color.Lime;
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(2, 3);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(282, 304);
            listBox2.TabIndex = 0;
            listBox2.DoubleClick += listBox2_DoubleClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(listBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(286, 309);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Js";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.Black;
            listBox3.ForeColor = Color.Lime;
            listBox3.FormattingEnabled = true;
            listBox3.HorizontalScrollbar = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(3, 3);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(280, 304);
            listBox3.TabIndex = 0;
            listBox3.DoubleClick += listBox3_DoubleClick;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listBox4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(286, 309);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "images ";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBox4
            // 
            listBox4.BackColor = Color.Black;
            listBox4.ForeColor = Color.Lime;
            listBox4.FormattingEnabled = true;
            listBox4.HorizontalScrollbar = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(3, 3);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(280, 304);
            listBox4.TabIndex = 0;
            listBox4.DoubleClick += listBox4_DoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_download);
            groupBox2.Controls.Add(bt_open);
            groupBox2.Controls.Add(bt_view);
            groupBox2.Controls.Add(tb_uritarget);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(312, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 113);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tools";
            // 
            // bt_download
            // 
            bt_download.Location = new Point(224, 50);
            bt_download.Name = "bt_download";
            bt_download.Size = new Size(75, 52);
            bt_download.TabIndex = 4;
            bt_download.Text = "Download";
            bt_download.UseVisualStyleBackColor = true;
            bt_download.Click += bt_download_Click;
            // 
            // bt_open
            // 
            bt_open.Location = new Point(131, 50);
            bt_open.Name = "bt_open";
            bt_open.Size = new Size(75, 52);
            bt_open.TabIndex = 3;
            bt_open.Text = "Open";
            bt_open.UseVisualStyleBackColor = true;
            bt_open.Click += bt_open_Click;
            // 
            // bt_view
            // 
            bt_view.Location = new Point(37, 50);
            bt_view.Name = "bt_view";
            bt_view.Size = new Size(75, 52);
            bt_view.TabIndex = 2;
            bt_view.Text = "View";
            bt_view.UseVisualStyleBackColor = true;
            bt_view.Click += bt_view_Click;
            // 
            // tb_uritarget
            // 
            tb_uritarget.BackColor = Color.Black;
            tb_uritarget.BorderStyle = BorderStyle.FixedSingle;
            tb_uritarget.ForeColor = Color.Red;
            tb_uritarget.Location = new Point(37, 16);
            tb_uritarget.Name = "tb_uritarget";
            tb_uritarget.ReadOnly = true;
            tb_uritarget.Size = new Size(262, 23);
            tb_uritarget.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 24);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "URI :";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 473);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(629, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(124, 17);
            toolStripStatusLabel1.Text = "Enter Website Address";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tb_viewer);
            groupBox3.Location = new Point(312, 131);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(305, 337);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Viewer";
            // 
            // tb_viewer
            // 
            tb_viewer.BackColor = Color.Black;
            tb_viewer.ForeColor = Color.Lime;
            tb_viewer.Location = new Point(6, 22);
            tb_viewer.Multiline = true;
            tb_viewer.Name = "tb_viewer";
            tb_viewer.ScrollBars = ScrollBars.Both;
            tb_viewer.Size = new Size(293, 309);
            tb_viewer.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(629, 495);
            Controls.Add(groupBox3);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox2);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(645, 534);
            MinimumSize = new Size(645, 534);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Site HiJeck 0.2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tb_directory;
        private TextBox tb_domain;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox listBox1;
        private TabPage tabPage2;
        private Button bt_cancle;
        private Button bt_hijeck;
        private GroupBox groupBox2;
        private Button bt_view;
        private TextBox tb_uritarget;
        private Label label3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private GroupBox groupBox3;
        private TextBox tb_viewer;
        private Button bt_download;
        private Button bt_open;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private SaveFileDialog saveFileDialog1;
    }
}