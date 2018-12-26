namespace DiscordGifSplitter
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gifNamePreview = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.finalName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.outputFormat = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridX = new System.Windows.Forms.NumericUpDown();
            this.gridY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.offsetY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.offsetX = new System.Windows.Forms.NumericUpDown();
            this.imageMetadata = new System.Windows.Forms.GroupBox();
            this.imageType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imageResolution = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.imageViewer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).BeginInit();
            this.imageMetadata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.imageMetadata);
            this.splitContainer1.Panel1.Controls.Add(this.create);
            this.splitContainer1.Panel1MinSize = 160;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imageViewer);
            this.splitContainer1.Panel2MinSize = 160;
            this.splitContainer1.Size = new System.Drawing.Size(660, 438);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gifNamePreview);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.finalName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.outputFormat);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 124);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output options";
            // 
            // gifNamePreview
            // 
            this.gifNamePreview.AutoSize = true;
            this.gifNamePreview.ForeColor = System.Drawing.Color.DarkGray;
            this.gifNamePreview.Location = new System.Drawing.Point(59, 16);
            this.gifNamePreview.Name = "gifNamePreview";
            this.gifNamePreview.Size = new System.Drawing.Size(0, 13);
            this.gifNamePreview.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Open folder when finished";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Output format";
            // 
            // finalName
            // 
            this.finalName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finalName.Location = new System.Drawing.Point(6, 32);
            this.finalName.Name = "finalName";
            this.finalName.Size = new System.Drawing.Size(148, 20);
            this.finalName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gif name";
            // 
            // outputFormat
            // 
            this.outputFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFormat.FormattingEnabled = true;
            this.outputFormat.Items.AddRange(new object[] {
            ".gif",
            ".png",
            ".jpg",
            ".apng"});
            this.outputFormat.Location = new System.Drawing.Point(6, 71);
            this.outputFormat.Name = "outputFormat";
            this.outputFormat.Size = new System.Drawing.Size(148, 21);
            this.outputFormat.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gridX);
            this.groupBox1.Controls.Add(this.gridY);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.offsetY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.offsetX);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 146);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grid options";
            // 
            // gridSize
            // 
            this.gridSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSize.DecimalPlaces = 3;
            this.gridSize.Location = new System.Drawing.Point(73, 18);
            this.gridSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.gridSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridSize.Name = "gridSize";
            this.gridSize.Size = new System.Drawing.Size(81, 20);
            this.gridSize.TabIndex = 1;
            this.gridSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columns";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rows";
            // 
            // gridX
            // 
            this.gridX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridX.Location = new System.Drawing.Point(73, 42);
            this.gridX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridX.Name = "gridX";
            this.gridX.Size = new System.Drawing.Size(81, 20);
            this.gridX.TabIndex = 3;
            this.gridX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gridY
            // 
            this.gridY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridY.Location = new System.Drawing.Point(72, 68);
            this.gridY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridY.Name = "gridY";
            this.gridY.Size = new System.Drawing.Size(82, 20);
            this.gridY.TabIndex = 4;
            this.gridY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "X Offset";
            // 
            // offsetY
            // 
            this.offsetY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offsetY.Location = new System.Drawing.Point(72, 120);
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(82, 20);
            this.offsetY.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y Offset";
            // 
            // offsetX
            // 
            this.offsetX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offsetX.Location = new System.Drawing.Point(72, 94);
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(82, 20);
            this.offsetX.TabIndex = 7;
            // 
            // imageMetadata
            // 
            this.imageMetadata.Controls.Add(this.imageType);
            this.imageMetadata.Controls.Add(this.label9);
            this.imageMetadata.Controls.Add(this.imageResolution);
            this.imageMetadata.Controls.Add(this.label8);
            this.imageMetadata.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageMetadata.Location = new System.Drawing.Point(0, 0);
            this.imageMetadata.Name = "imageMetadata";
            this.imageMetadata.Size = new System.Drawing.Size(160, 79);
            this.imageMetadata.TabIndex = 14;
            this.imageMetadata.TabStop = false;
            this.imageMetadata.Text = "Image metadata";
            // 
            // imageType
            // 
            this.imageType.AutoSize = true;
            this.imageType.Location = new System.Drawing.Point(8, 59);
            this.imageType.Name = "imageType";
            this.imageType.Size = new System.Drawing.Size(0, 13);
            this.imageType.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Type";
            // 
            // imageResolution
            // 
            this.imageResolution.AutoSize = true;
            this.imageResolution.Location = new System.Drawing.Point(8, 33);
            this.imageResolution.Name = "imageResolution";
            this.imageResolution.Size = new System.Drawing.Size(0, 13);
            this.imageResolution.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Resolution";
            // 
            // create
            // 
            this.create.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.create.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.create.Location = new System.Drawing.Point(0, 388);
            this.create.MinimumSize = new System.Drawing.Size(0, 50);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(160, 50);
            this.create.TabIndex = 9;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // imageViewer
            // 
            this.imageViewer.BackgroundImage = global::DiscordGifSplitter.Properties.Resources.drag_here;
            this.imageViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer.Location = new System.Drawing.Point(0, 0);
            this.imageViewer.Name = "imageViewer";
            this.imageViewer.Size = new System.Drawing.Size(496, 438);
            this.imageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageViewer.TabIndex = 0;
            this.imageViewer.TabStop = false;
            this.imageViewer.Paint += new System.Windows.Forms.PaintEventHandler(this.image_Paint);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MainWindow";
            this.Text = "Discord Gif Splitter";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).EndInit();
            this.imageMetadata.ResumeLayout(false);
            this.imageMetadata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imageViewer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown gridSize;
        private System.Windows.Forms.NumericUpDown gridX;
        private System.Windows.Forms.NumericUpDown gridY;
        private System.Windows.Forms.NumericUpDown offsetY;
        private System.Windows.Forms.NumericUpDown offsetX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.ComboBox outputFormat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox finalName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox imageMetadata;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label imageResolution;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label imageType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label gifNamePreview;
    }
}

