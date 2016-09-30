﻿namespace TextInject
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRead = new System.Windows.Forms.Button();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.splitContainer5 = new System.Windows.Forms.SplitContainer();
			this.label2 = new System.Windows.Forms.Label();
			this.rtbText = new System.Windows.Forms.RichTextBox();
			this.splitContainer6 = new System.Windows.Forms.SplitContainer();
			this.comboFileEncoding = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.rtbSelectedFile = new System.Windows.Forms.RichTextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.bInject = new System.Windows.Forms.Button();
			this.comboAncor = new System.Windows.Forms.ComboBox();
			this.numOffset = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.lblFolder = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
			this.splitContainer5.Panel1.SuspendLayout();
			this.splitContainer5.Panel2.SuspendLayout();
			this.splitContainer5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
			this.splitContainer6.Panel1.SuspendLayout();
			this.splitContainer6.Panel2.SuspendLayout();
			this.splitContainer6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numOffset)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1204, 628);
			this.splitContainer1.SplitterDistance = 30;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
			this.splitContainer2.Size = new System.Drawing.Size(1204, 594);
			this.splitContainer2.SplitterDistance = 350;
			this.splitContainer2.SplitterWidth = 15;
			this.splitContainer2.TabIndex = 0;
			this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer3.IsSplitterFixed = true;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.AutoScroll = true;
			this.splitContainer3.Panel1.Controls.Add(this.tbSearch);
			this.splitContainer3.Panel1.Controls.Add(this.label1);
			this.splitContainer3.Panel1.Controls.Add(this.btnRead);
			this.splitContainer3.Panel1.Controls.Add(this.lblFolder);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.treeView1);
			this.splitContainer3.Size = new System.Drawing.Size(346, 590);
			this.splitContainer3.SplitterDistance = 42;
			this.splitContainer3.TabIndex = 0;
			this.splitContainer3.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer3_SplitterMoved);
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(92, 4);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(88, 26);
			this.tbSearch.TabIndex = 4;
			this.tbSearch.Text = "*.txt";
			this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Search for:";
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(190, 4);
			this.btnRead.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(84, 34);
			this.btnRead.TabIndex = 2;
			this.btnRead.Text = "Read";
			this.btnRead.UseVisualStyleBackColor = true;
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// treeView1
			// 
			this.treeView1.AllowDrop = true;
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeView1.CheckBoxes = true;
			this.treeView1.Location = new System.Drawing.Point(3, 3);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(343, 757);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
			this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
			this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
			// 
			// splitContainer4
			// 
			this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Name = "splitContainer4";
			this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.splitContainer5);
			this.splitContainer4.Panel1MinSize = 10;
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.splitContainer6);
			this.splitContainer4.Size = new System.Drawing.Size(839, 594);
			this.splitContainer4.SplitterDistance = 147;
			this.splitContainer4.SplitterWidth = 15;
			this.splitContainer4.TabIndex = 0;
			// 
			// splitContainer5
			// 
			this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer5.IsSplitterFixed = true;
			this.splitContainer5.Location = new System.Drawing.Point(0, 0);
			this.splitContainer5.Name = "splitContainer5";
			this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer5.Panel1
			// 
			this.splitContainer5.Panel1.AutoScroll = true;
			this.splitContainer5.Panel1.Controls.Add(this.label4);
			this.splitContainer5.Panel1.Controls.Add(this.numOffset);
			this.splitContainer5.Panel1.Controls.Add(this.comboAncor);
			this.splitContainer5.Panel1.Controls.Add(this.bInject);
			this.splitContainer5.Panel1.Controls.Add(this.label2);
			this.splitContainer5.Panel1MinSize = 10;
			// 
			// splitContainer5.Panel2
			// 
			this.splitContainer5.Panel2.Controls.Add(this.rtbText);
			this.splitContainer5.Panel2MinSize = 10;
			this.splitContainer5.Size = new System.Drawing.Size(835, 143);
			this.splitContainer5.SplitterDistance = 30;
			this.splitContainer5.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Text to insert";
			// 
			// rtbText
			// 
			this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbText.Location = new System.Drawing.Point(0, 0);
			this.rtbText.Name = "rtbText";
			this.rtbText.Size = new System.Drawing.Size(835, 109);
			this.rtbText.TabIndex = 0;
			this.rtbText.Text = "";
			// 
			// splitContainer6
			// 
			this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer6.IsSplitterFixed = true;
			this.splitContainer6.Location = new System.Drawing.Point(0, 0);
			this.splitContainer6.Name = "splitContainer6";
			this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer6.Panel1
			// 
			this.splitContainer6.Panel1.AutoScroll = true;
			this.splitContainer6.Panel1.AutoScrollMargin = new System.Drawing.Size(2, 2);
			this.splitContainer6.Panel1.Controls.Add(this.comboFileEncoding);
			this.splitContainer6.Panel1.Controls.Add(this.label3);
			this.splitContainer6.Panel1MinSize = 10;
			// 
			// splitContainer6.Panel2
			// 
			this.splitContainer6.Panel2.Controls.Add(this.rtbSelectedFile);
			this.splitContainer6.Panel2MinSize = 0;
			this.splitContainer6.Size = new System.Drawing.Size(835, 428);
			this.splitContainer6.SplitterDistance = 25;
			this.splitContainer6.TabIndex = 0;
			// 
			// comboFileEncoding
			// 
			this.comboFileEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFileEncoding.FormattingEnabled = true;
			this.comboFileEncoding.Items.AddRange(new object[] {
            "Default",
            "UTF-8",
            "ISO-8859-1"});
			this.comboFileEncoding.Location = new System.Drawing.Point(170, 2);
			this.comboFileEncoding.Name = "comboFileEncoding";
			this.comboFileEncoding.Size = new System.Drawing.Size(121, 28);
			this.comboFileEncoding.TabIndex = 1;
			this.comboFileEncoding.SelectedIndexChanged += new System.EventHandler(this.cboFileEncoding_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Selected file:";
			// 
			// rtbSelectedFile
			// 
			this.rtbSelectedFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbSelectedFile.Location = new System.Drawing.Point(0, 0);
			this.rtbSelectedFile.Name = "rtbSelectedFile";
			this.rtbSelectedFile.Size = new System.Drawing.Size(835, 399);
			this.rtbSelectedFile.TabIndex = 0;
			this.rtbSelectedFile.Text = "";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// bInject
			// 
			this.bInject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bInject.Location = new System.Drawing.Point(710, 6);
			this.bInject.Name = "bInject";
			this.bInject.Size = new System.Drawing.Size(75, 35);
			this.bInject.TabIndex = 1;
			this.bInject.Text = "Inject";
			this.bInject.UseVisualStyleBackColor = true;
			this.bInject.Click += new System.EventHandler(this.bInject_Click);
			// 
			// comboAncor
			// 
			this.comboAncor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboAncor.FormattingEnabled = true;
			this.comboAncor.Items.AddRange(new object[] {
            "Top",
            "Bottom"});
			this.comboAncor.Location = new System.Drawing.Point(280, 6);
			this.comboAncor.Name = "comboAncor";
			this.comboAncor.Size = new System.Drawing.Size(85, 28);
			this.comboAncor.TabIndex = 2;
			// 
			// numOffset
			// 
			this.numOffset.Location = new System.Drawing.Point(112, 7);
			this.numOffset.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numOffset.Name = "numOffset";
			this.numOffset.Size = new System.Drawing.Size(49, 26);
			this.numOffset.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(168, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "lines from the";
			// 
			// lblFolder
			// 
			this.lblFolder.AutoSize = true;
			this.lblFolder.Location = new System.Drawing.Point(10, 43);
			this.lblFolder.Name = "lblFolder";
			this.lblFolder.Size = new System.Drawing.Size(73, 20);
			this.lblFolder.TabIndex = 0;
			this.lblFolder.Text = "                ";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(1026, -1);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(178, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.browseToolStripMenuItem,
            this.productPageToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(32, 29);
			this.aboutToolStripMenuItem.Text = "?";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(211, 30);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
			// 
			// browseToolStripMenuItem
			// 
			this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
			this.browseToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
			this.browseToolStripMenuItem.Text = "Browse";
			this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
			// 
			// productPageToolStripMenuItem
			// 
			this.productPageToolStripMenuItem.Name = "productPageToolStripMenuItem";
			this.productPageToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
			this.productPageToolStripMenuItem.Text = "Product page";
			this.productPageToolStripMenuItem.Click += new System.EventHandler(this.productPageToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1204, 628);
			this.Controls.Add(this.splitContainer1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Text inject";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
			this.splitContainer4.ResumeLayout(false);
			this.splitContainer5.Panel1.ResumeLayout(false);
			this.splitContainer5.Panel1.PerformLayout();
			this.splitContainer5.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
			this.splitContainer5.ResumeLayout(false);
			this.splitContainer6.Panel1.ResumeLayout(false);
			this.splitContainer6.Panel1.PerformLayout();
			this.splitContainer6.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
			this.splitContainer6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numOffset)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.SplitContainer splitContainer5;
		private System.Windows.Forms.SplitContainer splitContainer6;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox rtbText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox rtbSelectedFile;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.ComboBox comboFileEncoding;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button bInject;
		private System.Windows.Forms.ComboBox comboAncor;
		private System.Windows.Forms.NumericUpDown numOffset;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblFolder;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productPageToolStripMenuItem;
	}
}

