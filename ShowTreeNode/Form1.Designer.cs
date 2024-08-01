namespace ShowTreeNode
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
            splitContainerHorizontal = new SplitContainer();
            richTextBox1 = new RichTextBox();
            splitContainerVertical = new SplitContainer();
            pictureBox1 = new PictureBox();
            buttonSave = new Button();
            trackBar1 = new TrackBar();
            buttonClear = new Button();
            buttonShow = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainerHorizontal).BeginInit();
            splitContainerHorizontal.Panel1.SuspendLayout();
            splitContainerHorizontal.Panel2.SuspendLayout();
            splitContainerHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerVertical).BeginInit();
            splitContainerVertical.Panel1.SuspendLayout();
            splitContainerVertical.Panel2.SuspendLayout();
            splitContainerVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // splitContainerHorizontal
            // 
            splitContainerHorizontal.BorderStyle = BorderStyle.Fixed3D;
            splitContainerHorizontal.Dock = DockStyle.Fill;
            splitContainerHorizontal.Location = new Point(0, 0);
            splitContainerHorizontal.Name = "splitContainerHorizontal";
            splitContainerHorizontal.Orientation = Orientation.Horizontal;
            // 
            // splitContainerHorizontal.Panel1
            // 
            splitContainerHorizontal.Panel1.Controls.Add(richTextBox1);
            // 
            // splitContainerHorizontal.Panel2
            // 
            splitContainerHorizontal.Panel2.Controls.Add(splitContainerVertical);
            splitContainerHorizontal.Size = new Size(765, 466);
            splitContainerHorizontal.SplitterDistance = 136;
            splitContainerHorizontal.SplitterWidth = 10;
            splitContainerHorizontal.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(761, 132);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "[1,2,null,3,4,5,null,6,7]";
            // 
            // splitContainerVertical
            // 
            splitContainerVertical.Dock = DockStyle.Fill;
            splitContainerVertical.FixedPanel = FixedPanel.Panel2;
            splitContainerVertical.IsSplitterFixed = true;
            splitContainerVertical.Location = new Point(0, 0);
            splitContainerVertical.Name = "splitContainerVertical";
            // 
            // splitContainerVertical.Panel1
            // 
            splitContainerVertical.Panel1.BackColor = Color.Gainsboro;
            splitContainerVertical.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainerVertical.Panel2
            // 
            splitContainerVertical.Panel2.Controls.Add(buttonSave);
            splitContainerVertical.Panel2.Controls.Add(trackBar1);
            splitContainerVertical.Panel2.Controls.Add(buttonClear);
            splitContainerVertical.Panel2.Controls.Add(buttonShow);
            splitContainerVertical.Size = new Size(761, 316);
            splitContainerVertical.SplitterDistance = 621;
            splitContainerVertical.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(621, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(65, 99);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(68, 47);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.Silver;
            trackBar1.Location = new Point(3, 99);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 5;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(56, 207);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 35;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(1, 49);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(135, 44);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(1, 3);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(132, 43);
            buttonShow.TabIndex = 0;
            buttonShow.Text = "Show";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 466);
            Controls.Add(splitContainerHorizontal);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Binary Tree";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            splitContainerHorizontal.Panel1.ResumeLayout(false);
            splitContainerHorizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerHorizontal).EndInit();
            splitContainerHorizontal.ResumeLayout(false);
            splitContainerVertical.Panel1.ResumeLayout(false);
            splitContainerVertical.Panel2.ResumeLayout(false);
            splitContainerVertical.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerVertical).EndInit();
            splitContainerVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainerHorizontal;
        private RichTextBox richTextBox1;
        private SplitContainer splitContainerVertical;
        private Button buttonShow;
        private Button buttonClear;
        private TrackBar trackBar1;
        private Button buttonSave;
        private PictureBox pictureBox1;
    }
}
