﻿namespace QMStuff_v2
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
			this.stepCounter = new System.Windows.Forms.NumericUpDown();
			this.yProbValue = new System.Windows.Forms.NumericUpDown();
			this.xProbValue = new System.Windows.Forms.NumericUpDown();
			this.yProbLabel = new System.Windows.Forms.Label();
			this.xProbLabel = new System.Windows.Forms.Label();
			this.xProbBar = new System.Windows.Forms.TrackBar();
			this.restartButton = new System.Windows.Forms.Button();
			this.backButton = new System.Windows.Forms.Button();
			this.yProbBar = new System.Windows.Forms.TrackBar();
			this.playButton = new System.Windows.Forms.Button();
			this.fwdButton = new System.Windows.Forms.Button();
			this.speedBar = new System.Windows.Forms.TrackBar();
			this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
			this.probGroup = new System.Windows.Forms.Panel();
			this.LatSizeLabel = new System.Windows.Forms.Label();
			this.LatSizeValue = new System.Windows.Forms.NumericUpDown();
			this.initTitle = new System.Windows.Forms.Label();
			this.HelpButton = new System.Windows.Forms.Button();
			this.gammaLabel = new System.Windows.Forms.Label();
			this.gammaValue = new System.Windows.Forms.NumericUpDown();
			this.gammaBar = new System.Windows.Forms.TrackBar();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.playGroup = new System.Windows.Forms.Panel();
			this.skipToEndButton = new System.Windows.Forms.Button();
			this.skipToBeginningButton = new System.Windows.Forms.Button();
			this.splitPanel = new System.Windows.Forms.SplitContainer();
			this.ControlsSplitContainer = new System.Windows.Forms.SplitContainer();
			this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.zoomGroup = new System.Windows.Forms.Panel();
			this.zoomTitle = new System.Windows.Forms.Label();
			this.zoomButton4 = new System.Windows.Forms.RadioButton();
			this.zoomButton3 = new System.Windows.Forms.RadioButton();
			this.zoomButton2 = new System.Windows.Forms.RadioButton();
			this.zoomButton1 = new System.Windows.Forms.RadioButton();
			this.ExportGroup = new System.Windows.Forms.Panel();
			this.ResChooser = new System.Windows.Forms.ComboBox();
			this.ResolutionLabel = new System.Windows.Forms.Label();
			this.FpsChooser = new System.Windows.Forms.ComboBox();
			this.FpsLabel = new System.Windows.Forms.Label();
			this.ExportLabel = new System.Windows.Forms.Label();
			this.ExportButton = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.AnalyticsTab = new System.Windows.Forms.TabPage();
			this.AreaLabel = new System.Windows.Forms.Label();
			this.BoxFitNextButton = new System.Windows.Forms.Button();
			this.BoxFitSizeValue = new System.Windows.Forms.NumericUpDown();
			this.AnalysisStartButton = new System.Windows.Forms.Button();
			this.GraphsTab = new System.Windows.Forms.TabPage();
			this.PerimeterLabel = new System.Windows.Forms.Label();
			this.DensityLabel = new System.Windows.Forms.Label();
			this.MouseLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.stepCounter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yProbValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xProbValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xProbBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yProbBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
			this.probGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LatSizeValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gammaValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gammaBar)).BeginInit();
			this.playGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitPanel)).BeginInit();
			this.splitPanel.Panel1.SuspendLayout();
			this.splitPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ControlsSplitContainer)).BeginInit();
			this.ControlsSplitContainer.Panel1.SuspendLayout();
			this.ControlsSplitContainer.Panel2.SuspendLayout();
			this.ControlsSplitContainer.SuspendLayout();
			this.FlowLayout.SuspendLayout();
			this.zoomGroup.SuspendLayout();
			this.ExportGroup.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.AnalyticsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BoxFitSizeValue)).BeginInit();
			this.SuspendLayout();
			// 
			// stepCounter
			// 
			this.stepCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.stepCounter.Location = new System.Drawing.Point(223, 19);
			this.stepCounter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.stepCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.stepCounter.Name = "stepCounter";
			this.stepCounter.Size = new System.Drawing.Size(53, 23);
			this.stepCounter.TabIndex = 14;
			this.stepCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.stepCounter.ValueChanged += new System.EventHandler(this.stepCounter_ValueChanged);
			// 
			// yProbValue
			// 
			this.yProbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.yProbValue.Location = new System.Drawing.Point(53, 108);
			this.yProbValue.Name = "yProbValue";
			this.yProbValue.Size = new System.Drawing.Size(49, 23);
			this.yProbValue.TabIndex = 12;
			this.yProbValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.yProbValue.ValueChanged += new System.EventHandler(this.yProbValue_ValueChanged);
			// 
			// xProbValue
			// 
			this.xProbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.xProbValue.Location = new System.Drawing.Point(53, 57);
			this.xProbValue.Name = "xProbValue";
			this.xProbValue.Size = new System.Drawing.Size(49, 23);
			this.xProbValue.TabIndex = 11;
			this.xProbValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.xProbValue.ValueChanged += new System.EventHandler(this.xProbValue_ValueChanged);
			// 
			// yProbLabel
			// 
			this.yProbLabel.AutoSize = true;
			this.yProbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yProbLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.yProbLabel.Location = new System.Drawing.Point(23, 108);
			this.yProbLabel.Name = "yProbLabel";
			this.yProbLabel.Size = new System.Drawing.Size(24, 17);
			this.yProbLabel.TabIndex = 10;
			this.yProbLabel.Text = "Py";
			// 
			// xProbLabel
			// 
			this.xProbLabel.AutoSize = true;
			this.xProbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xProbLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.xProbLabel.Location = new System.Drawing.Point(23, 57);
			this.xProbLabel.Name = "xProbLabel";
			this.xProbLabel.Size = new System.Drawing.Size(23, 17);
			this.xProbLabel.TabIndex = 9;
			this.xProbLabel.Text = "Px";
			// 
			// xProbBar
			// 
			this.xProbBar.Location = new System.Drawing.Point(108, 57);
			this.xProbBar.Maximum = 100;
			this.xProbBar.Name = "xProbBar";
			this.xProbBar.Size = new System.Drawing.Size(197, 45);
			this.xProbBar.TabIndex = 8;
			this.xProbBar.TickFrequency = 10;
			this.xProbBar.Value = 100;
			this.xProbBar.Scroll += new System.EventHandler(this.xProbBar_Scroll);
			// 
			// restartButton
			// 
			this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.restartButton.Location = new System.Drawing.Point(114, 9);
			this.restartButton.Name = "restartButton";
			this.restartButton.Size = new System.Drawing.Size(69, 40);
			this.restartButton.TabIndex = 7;
			this.restartButton.Text = "Restart";
			this.restartButton.UseVisualStyleBackColor = true;
			this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(69, 66);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(40, 40);
			this.backButton.TabIndex = 0;
			this.backButton.Text = "<";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// yProbBar
			// 
			this.yProbBar.Location = new System.Drawing.Point(108, 108);
			this.yProbBar.Maximum = 100;
			this.yProbBar.Name = "yProbBar";
			this.yProbBar.Size = new System.Drawing.Size(197, 45);
			this.yProbBar.TabIndex = 3;
			this.yProbBar.TickFrequency = 10;
			this.yProbBar.Value = 100;
			this.yProbBar.Scroll += new System.EventHandler(this.yProbBar_Scroll);
			// 
			// playButton
			// 
			this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playButton.Location = new System.Drawing.Point(115, 66);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(69, 40);
			this.playButton.TabIndex = 1;
			this.playButton.Text = "Play";
			this.playButton.UseVisualStyleBackColor = true;
			this.playButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// fwdButton
			// 
			this.fwdButton.Location = new System.Drawing.Point(190, 66);
			this.fwdButton.Name = "fwdButton";
			this.fwdButton.Size = new System.Drawing.Size(40, 40);
			this.fwdButton.TabIndex = 2;
			this.fwdButton.Text = ">";
			this.fwdButton.UseVisualStyleBackColor = true;
			this.fwdButton.Click += new System.EventHandler(this.fwdButton_Click);
			// 
			// speedBar
			// 
			this.speedBar.Location = new System.Drawing.Point(23, 125);
			this.speedBar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.speedBar.Maximum = 100;
			this.speedBar.Name = "speedBar";
			this.speedBar.Size = new System.Drawing.Size(253, 45);
			this.speedBar.TabIndex = 5;
			this.speedBar.TickFrequency = 10;
			this.speedBar.Value = 50;
			this.speedBar.Visible = false;
			this.speedBar.Scroll += new System.EventHandler(this.speedBar_Scroll);
			// 
			// BottomToolStripPanel
			// 
			this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.BottomToolStripPanel.Name = "BottomToolStripPanel";
			this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// TopToolStripPanel
			// 
			this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.TopToolStripPanel.Name = "TopToolStripPanel";
			this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// RightToolStripPanel
			// 
			this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.RightToolStripPanel.Name = "RightToolStripPanel";
			this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// LeftToolStripPanel
			// 
			this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftToolStripPanel.Name = "LeftToolStripPanel";
			this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// ContentPanel
			// 
			this.ContentPanel.Size = new System.Drawing.Size(150, 150);
			// 
			// probGroup
			// 
			this.probGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
			this.probGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.probGroup.Controls.Add(this.LatSizeLabel);
			this.probGroup.Controls.Add(this.LatSizeValue);
			this.probGroup.Controls.Add(this.initTitle);
			this.probGroup.Controls.Add(this.HelpButton);
			this.probGroup.Controls.Add(this.gammaLabel);
			this.probGroup.Controls.Add(this.gammaValue);
			this.probGroup.Controls.Add(this.gammaBar);
			this.probGroup.Controls.Add(this.GenerateButton);
			this.probGroup.Controls.Add(this.yProbLabel);
			this.probGroup.Controls.Add(this.yProbBar);
			this.probGroup.Controls.Add(this.yProbValue);
			this.probGroup.Controls.Add(this.xProbBar);
			this.probGroup.Controls.Add(this.xProbValue);
			this.probGroup.Controls.Add(this.xProbLabel);
			this.probGroup.Location = new System.Drawing.Point(30, 30);
			this.probGroup.Margin = new System.Windows.Forms.Padding(20);
			this.probGroup.Name = "probGroup";
			this.probGroup.Padding = new System.Windows.Forms.Padding(20);
			this.probGroup.Size = new System.Drawing.Size(643, 214);
			this.probGroup.TabIndex = 0;
			// 
			// LatSizeLabel
			// 
			this.LatSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LatSizeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.LatSizeLabel.Location = new System.Drawing.Point(342, 57);
			this.LatSizeLabel.Name = "LatSizeLabel";
			this.LatSizeLabel.Size = new System.Drawing.Size(54, 40);
			this.LatSizeLabel.TabIndex = 30;
			this.LatSizeLabel.Text = "Lattice Size";
			this.LatSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LatSizeValue
			// 
			this.LatSizeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.LatSizeValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.LatSizeValue.Location = new System.Drawing.Point(404, 66);
			this.LatSizeValue.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
			this.LatSizeValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.LatSizeValue.Name = "LatSizeValue";
			this.LatSizeValue.Size = new System.Drawing.Size(49, 23);
			this.LatSizeValue.TabIndex = 29;
			this.LatSizeValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// initTitle
			// 
			this.initTitle.AutoSize = true;
			this.initTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.initTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.initTitle.Location = new System.Drawing.Point(266, 20);
			this.initTitle.Name = "initTitle";
			this.initTitle.Size = new System.Drawing.Size(117, 17);
			this.initTitle.TabIndex = 28;
			this.initTitle.Text = "Initial Parameters";
			// 
			// HelpButton
			// 
			this.HelpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.HelpButton.Location = new System.Drawing.Point(487, 108);
			this.HelpButton.Name = "HelpButton";
			this.HelpButton.Size = new System.Drawing.Size(131, 40);
			this.HelpButton.TabIndex = 17;
			this.HelpButton.Text = "Help";
			this.HelpButton.UseVisualStyleBackColor = true;
			this.HelpButton.Click += new System.EventHandler(this.helpButton_Click);
			// 
			// gammaLabel
			// 
			this.gammaLabel.AutoSize = true;
			this.gammaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gammaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.gammaLabel.Location = new System.Drawing.Point(23, 159);
			this.gammaLabel.Name = "gammaLabel";
			this.gammaLabel.Size = new System.Drawing.Size(16, 17);
			this.gammaLabel.TabIndex = 16;
			this.gammaLabel.Text = "Γ";
			// 
			// gammaValue
			// 
			this.gammaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.gammaValue.Location = new System.Drawing.Point(53, 159);
			this.gammaValue.Name = "gammaValue";
			this.gammaValue.Size = new System.Drawing.Size(49, 23);
			this.gammaValue.TabIndex = 15;
			this.gammaValue.ValueChanged += new System.EventHandler(this.gammaValue_ValueChanged);
			// 
			// gammaBar
			// 
			this.gammaBar.Location = new System.Drawing.Point(108, 159);
			this.gammaBar.Maximum = 100;
			this.gammaBar.Name = "gammaBar";
			this.gammaBar.Size = new System.Drawing.Size(197, 45);
			this.gammaBar.TabIndex = 14;
			this.gammaBar.TickFrequency = 10;
			this.gammaBar.Scroll += new System.EventHandler(this.gammaBar_Scroll);
			// 
			// GenerateButton
			// 
			this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.GenerateButton.Location = new System.Drawing.Point(487, 57);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(131, 40);
			this.GenerateButton.TabIndex = 13;
			this.GenerateButton.Text = "Generate";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// playGroup
			// 
			this.playGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.playGroup.Controls.Add(this.skipToEndButton);
			this.playGroup.Controls.Add(this.skipToBeginningButton);
			this.playGroup.Controls.Add(this.speedBar);
			this.playGroup.Controls.Add(this.stepCounter);
			this.playGroup.Controls.Add(this.fwdButton);
			this.playGroup.Controls.Add(this.restartButton);
			this.playGroup.Controls.Add(this.playButton);
			this.playGroup.Controls.Add(this.backButton);
			this.playGroup.Enabled = false;
			this.playGroup.Location = new System.Drawing.Point(372, 284);
			this.playGroup.Margin = new System.Windows.Forms.Padding(20);
			this.playGroup.Name = "playGroup";
			this.playGroup.Padding = new System.Windows.Forms.Padding(20);
			this.playGroup.Size = new System.Drawing.Size(301, 187);
			this.playGroup.TabIndex = 15;
			// 
			// skipToEndButton
			// 
			this.skipToEndButton.Location = new System.Drawing.Point(236, 66);
			this.skipToEndButton.Name = "skipToEndButton";
			this.skipToEndButton.Size = new System.Drawing.Size(40, 40);
			this.skipToEndButton.TabIndex = 16;
			this.skipToEndButton.Text = ">>";
			this.skipToEndButton.UseVisualStyleBackColor = true;
			this.skipToEndButton.Click += new System.EventHandler(this.skipToEndButton_Click);
			// 
			// skipToBeginningButton
			// 
			this.skipToBeginningButton.Location = new System.Drawing.Point(23, 66);
			this.skipToBeginningButton.Name = "skipToBeginningButton";
			this.skipToBeginningButton.Size = new System.Drawing.Size(40, 40);
			this.skipToBeginningButton.TabIndex = 15;
			this.skipToBeginningButton.Text = "<<";
			this.skipToBeginningButton.UseVisualStyleBackColor = true;
			this.skipToBeginningButton.Click += new System.EventHandler(this.skipToBeginningButton_Click);
			// 
			// splitPanel
			// 
			this.splitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitPanel.Location = new System.Drawing.Point(0, 0);
			this.splitPanel.Name = "splitPanel";
			// 
			// splitPanel.Panel1
			// 
			this.splitPanel.Panel1.Controls.Add(this.ControlsSplitContainer);
			this.splitPanel.Size = new System.Drawing.Size(1362, 775);
			this.splitPanel.SplitterDistance = 802;
			this.splitPanel.TabIndex = 10;
			// 
			// ControlsSplitContainer
			// 
			this.ControlsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ControlsSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.ControlsSplitContainer.Name = "ControlsSplitContainer";
			this.ControlsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// ControlsSplitContainer.Panel1
			// 
			this.ControlsSplitContainer.Panel1.Controls.Add(this.FlowLayout);
			// 
			// ControlsSplitContainer.Panel2
			// 
			this.ControlsSplitContainer.Panel2.BackColor = System.Drawing.Color.SlateGray;
			this.ControlsSplitContainer.Panel2.Controls.Add(this.tabControl1);
			this.ControlsSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(15);
			this.ControlsSplitContainer.Size = new System.Drawing.Size(802, 775);
			this.ControlsSplitContainer.SplitterDistance = 540;
			this.ControlsSplitContainer.TabIndex = 35;
			// 
			// FlowLayout
			// 
			this.FlowLayout.AutoScroll = true;
			this.FlowLayout.Controls.Add(this.probGroup);
			this.FlowLayout.Controls.Add(this.zoomGroup);
			this.FlowLayout.Controls.Add(this.playGroup);
			this.FlowLayout.Controls.Add(this.ExportGroup);
			this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlowLayout.Location = new System.Drawing.Point(0, 0);
			this.FlowLayout.Name = "FlowLayout";
			this.FlowLayout.Padding = new System.Windows.Forms.Padding(10);
			this.FlowLayout.Size = new System.Drawing.Size(802, 540);
			this.FlowLayout.TabIndex = 16;
			// 
			// zoomGroup
			// 
			this.zoomGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.zoomGroup.Controls.Add(this.zoomTitle);
			this.zoomGroup.Controls.Add(this.zoomButton4);
			this.zoomGroup.Controls.Add(this.zoomButton3);
			this.zoomGroup.Controls.Add(this.zoomButton2);
			this.zoomGroup.Controls.Add(this.zoomButton1);
			this.zoomGroup.Location = new System.Drawing.Point(30, 284);
			this.zoomGroup.Margin = new System.Windows.Forms.Padding(20);
			this.zoomGroup.Name = "zoomGroup";
			this.zoomGroup.Padding = new System.Windows.Forms.Padding(10);
			this.zoomGroup.Size = new System.Drawing.Size(302, 187);
			this.zoomGroup.TabIndex = 16;
			// 
			// zoomTitle
			// 
			this.zoomTitle.AutoSize = true;
			this.zoomTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.zoomTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.zoomTitle.Location = new System.Drawing.Point(105, 21);
			this.zoomTitle.Name = "zoomTitle";
			this.zoomTitle.Size = new System.Drawing.Size(93, 17);
			this.zoomTitle.TabIndex = 27;
			this.zoomTitle.Text = "Zoom Control";
			// 
			// zoomButton4
			// 
			this.zoomButton4.Appearance = System.Windows.Forms.Appearance.Button;
			this.zoomButton4.Checked = true;
			this.zoomButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.zoomButton4.Location = new System.Drawing.Point(225, 66);
			this.zoomButton4.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
			this.zoomButton4.Name = "zoomButton4";
			this.zoomButton4.Size = new System.Drawing.Size(60, 60);
			this.zoomButton4.TabIndex = 26;
			this.zoomButton4.TabStop = true;
			this.zoomButton4.Text = "1.0";
			this.zoomButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.zoomButton4.UseVisualStyleBackColor = true;
			this.zoomButton4.CheckedChanged += new System.EventHandler(this.zoomButton4_CheckedChanged);
			// 
			// zoomButton3
			// 
			this.zoomButton3.Appearance = System.Windows.Forms.Appearance.Button;
			this.zoomButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.zoomButton3.Location = new System.Drawing.Point(155, 66);
			this.zoomButton3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
			this.zoomButton3.Name = "zoomButton3";
			this.zoomButton3.Size = new System.Drawing.Size(60, 60);
			this.zoomButton3.TabIndex = 25;
			this.zoomButton3.TabStop = true;
			this.zoomButton3.Text = "0.5";
			this.zoomButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.zoomButton3.UseVisualStyleBackColor = true;
			this.zoomButton3.CheckedChanged += new System.EventHandler(this.zoomButton3_CheckedChanged);
			// 
			// zoomButton2
			// 
			this.zoomButton2.Appearance = System.Windows.Forms.Appearance.Button;
			this.zoomButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.zoomButton2.Location = new System.Drawing.Point(85, 66);
			this.zoomButton2.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
			this.zoomButton2.Name = "zoomButton2";
			this.zoomButton2.Size = new System.Drawing.Size(60, 60);
			this.zoomButton2.TabIndex = 24;
			this.zoomButton2.TabStop = true;
			this.zoomButton2.Text = "0.25";
			this.zoomButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.zoomButton2.UseVisualStyleBackColor = true;
			this.zoomButton2.CheckedChanged += new System.EventHandler(this.zoomButton2_CheckedChanged);
			// 
			// zoomButton1
			// 
			this.zoomButton1.Appearance = System.Windows.Forms.Appearance.Button;
			this.zoomButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.zoomButton1.Location = new System.Drawing.Point(15, 66);
			this.zoomButton1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
			this.zoomButton1.Name = "zoomButton1";
			this.zoomButton1.Size = new System.Drawing.Size(60, 60);
			this.zoomButton1.TabIndex = 23;
			this.zoomButton1.TabStop = true;
			this.zoomButton1.Text = "0.125";
			this.zoomButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.zoomButton1.UseVisualStyleBackColor = true;
			this.zoomButton1.CheckedChanged += new System.EventHandler(this.zoomButton1_CheckedChanged);
			// 
			// ExportGroup
			// 
			this.ExportGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
			this.ExportGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ExportGroup.Controls.Add(this.ResChooser);
			this.ExportGroup.Controls.Add(this.ResolutionLabel);
			this.ExportGroup.Controls.Add(this.FpsChooser);
			this.ExportGroup.Controls.Add(this.FpsLabel);
			this.ExportGroup.Controls.Add(this.ExportLabel);
			this.ExportGroup.Controls.Add(this.ExportButton);
			this.ExportGroup.Location = new System.Drawing.Point(30, 511);
			this.ExportGroup.Margin = new System.Windows.Forms.Padding(20);
			this.ExportGroup.Name = "ExportGroup";
			this.ExportGroup.Padding = new System.Windows.Forms.Padding(20);
			this.ExportGroup.Size = new System.Drawing.Size(243, 214);
			this.ExportGroup.TabIndex = 31;
			// 
			// ResChooser
			// 
			this.ResChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ResChooser.FormattingEnabled = true;
			this.ResChooser.Items.AddRange(new object[] {
            "800 x 800",
            "600 x 600",
            "400 x 400"});
			this.ResChooser.Location = new System.Drawing.Point(114, 104);
			this.ResChooser.Name = "ResChooser";
			this.ResChooser.Size = new System.Drawing.Size(101, 21);
			this.ResChooser.TabIndex = 33;
			// 
			// ResolutionLabel
			// 
			this.ResolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResolutionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.ResolutionLabel.Location = new System.Drawing.Point(21, 105);
			this.ResolutionLabel.Name = "ResolutionLabel";
			this.ResolutionLabel.Size = new System.Drawing.Size(81, 21);
			this.ResolutionLabel.TabIndex = 32;
			this.ResolutionLabel.Text = "Resolution";
			// 
			// FpsChooser
			// 
			this.FpsChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FpsChooser.FormattingEnabled = true;
			this.FpsChooser.Items.AddRange(new object[] {
            "24 Hz (fastest video)",
            "10 Hz",
            "5 Hz",
            "2 Hz (slowest video)"});
			this.FpsChooser.Location = new System.Drawing.Point(69, 61);
			this.FpsChooser.Name = "FpsChooser";
			this.FpsChooser.Size = new System.Drawing.Size(146, 21);
			this.FpsChooser.TabIndex = 31;
			// 
			// FpsLabel
			// 
			this.FpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FpsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.FpsLabel.Location = new System.Drawing.Point(21, 61);
			this.FpsLabel.Name = "FpsLabel";
			this.FpsLabel.Size = new System.Drawing.Size(54, 21);
			this.FpsLabel.TabIndex = 30;
			this.FpsLabel.Text = "FPS";
			// 
			// ExportLabel
			// 
			this.ExportLabel.AutoSize = true;
			this.ExportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.ExportLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.ExportLabel.Location = new System.Drawing.Point(73, 20);
			this.ExportLabel.Name = "ExportLabel";
			this.ExportLabel.Size = new System.Drawing.Size(88, 17);
			this.ExportLabel.TabIndex = 28;
			this.ExportLabel.Text = "Export Video";
			this.ExportLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// ExportButton
			// 
			this.ExportButton.Enabled = false;
			this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.ExportButton.Location = new System.Drawing.Point(53, 150);
			this.ExportButton.Name = "ExportButton";
			this.ExportButton.Size = new System.Drawing.Size(131, 40);
			this.ExportButton.TabIndex = 13;
			this.ExportButton.Text = "Export";
			this.ExportButton.UseVisualStyleBackColor = true;
			this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.AnalyticsTab);
			this.tabControl1.Controls.Add(this.GraphsTab);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tabControl1.Location = new System.Drawing.Point(15, 15);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(772, 201);
			this.tabControl1.TabIndex = 17;
			// 
			// AnalyticsTab
			// 
			this.AnalyticsTab.BackColor = System.Drawing.SystemColors.ControlLight;
			this.AnalyticsTab.Controls.Add(this.MouseLabel);
			this.AnalyticsTab.Controls.Add(this.DensityLabel);
			this.AnalyticsTab.Controls.Add(this.PerimeterLabel);
			this.AnalyticsTab.Controls.Add(this.AreaLabel);
			this.AnalyticsTab.Controls.Add(this.BoxFitNextButton);
			this.AnalyticsTab.Controls.Add(this.BoxFitSizeValue);
			this.AnalyticsTab.Controls.Add(this.AnalysisStartButton);
			this.AnalyticsTab.Location = new System.Drawing.Point(4, 25);
			this.AnalyticsTab.Name = "AnalyticsTab";
			this.AnalyticsTab.Padding = new System.Windows.Forms.Padding(10);
			this.AnalyticsTab.Size = new System.Drawing.Size(764, 172);
			this.AnalyticsTab.TabIndex = 0;
			this.AnalyticsTab.Text = "Analytics";
			// 
			// AreaLabel
			// 
			this.AreaLabel.AutoSize = true;
			this.AreaLabel.Location = new System.Drawing.Point(244, 31);
			this.AreaLabel.Name = "AreaLabel";
			this.AreaLabel.Size = new System.Drawing.Size(42, 17);
			this.AreaLabel.TabIndex = 35;
			this.AreaLabel.Text = "Area:";
			// 
			// BoxFitNextButton
			// 
			this.BoxFitNextButton.Location = new System.Drawing.Point(104, 73);
			this.BoxFitNextButton.Name = "BoxFitNextButton";
			this.BoxFitNextButton.Size = new System.Drawing.Size(40, 40);
			this.BoxFitNextButton.TabIndex = 19;
			this.BoxFitNextButton.Text = ">";
			this.BoxFitNextButton.UseVisualStyleBackColor = true;
			this.BoxFitNextButton.Click += new System.EventHandler(this.BoxFitNextButton_Click);
			// 
			// BoxFitSizeValue
			// 
			this.BoxFitSizeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.BoxFitSizeValue.Location = new System.Drawing.Point(13, 83);
			this.BoxFitSizeValue.Name = "BoxFitSizeValue";
			this.BoxFitSizeValue.Size = new System.Drawing.Size(42, 23);
			this.BoxFitSizeValue.TabIndex = 29;
			this.BoxFitSizeValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// AnalysisStartButton
			// 
			this.AnalysisStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.AnalysisStartButton.Location = new System.Drawing.Point(13, 119);
			this.AnalysisStartButton.Name = "AnalysisStartButton";
			this.AnalysisStartButton.Size = new System.Drawing.Size(131, 40);
			this.AnalysisStartButton.TabIndex = 34;
			this.AnalysisStartButton.Text = "Start";
			this.AnalysisStartButton.UseVisualStyleBackColor = true;
			this.AnalysisStartButton.Click += new System.EventHandler(this.AnalysisStartButton_Click);
			// 
			// GraphsTab
			// 
			this.GraphsTab.Location = new System.Drawing.Point(4, 25);
			this.GraphsTab.Name = "GraphsTab";
			this.GraphsTab.Padding = new System.Windows.Forms.Padding(3);
			this.GraphsTab.Size = new System.Drawing.Size(764, 201);
			this.GraphsTab.TabIndex = 1;
			this.GraphsTab.Text = "Graphs";
			this.GraphsTab.UseVisualStyleBackColor = true;
			// 
			// PerimeterLabel
			// 
			this.PerimeterLabel.AutoSize = true;
			this.PerimeterLabel.Location = new System.Drawing.Point(244, 60);
			this.PerimeterLabel.Name = "PerimeterLabel";
			this.PerimeterLabel.Size = new System.Drawing.Size(73, 17);
			this.PerimeterLabel.TabIndex = 36;
			this.PerimeterLabel.Text = "Perimeter:";
			// 
			// DensityLabel
			// 
			this.DensityLabel.AutoSize = true;
			this.DensityLabel.Location = new System.Drawing.Point(244, 90);
			this.DensityLabel.Name = "DensityLabel";
			this.DensityLabel.Size = new System.Drawing.Size(59, 17);
			this.DensityLabel.TabIndex = 37;
			this.DensityLabel.Text = "Density:";
			// 
			// MouseLabel
			// 
			this.MouseLabel.AutoSize = true;
			this.MouseLabel.Location = new System.Drawing.Point(13, 10);
			this.MouseLabel.Name = "MouseLabel";
			this.MouseLabel.Size = new System.Drawing.Size(82, 17);
			this.MouseLabel.TabIndex = 38;
			this.MouseLabel.Text = "(0.00, 0.00)";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1362, 775);
			this.Controls.Add(this.splitPanel);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Square Lattice 2D v2";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.stepCounter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yProbValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xProbValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xProbBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yProbBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
			this.probGroup.ResumeLayout(false);
			this.probGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.LatSizeValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gammaValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gammaBar)).EndInit();
			this.playGroup.ResumeLayout(false);
			this.playGroup.PerformLayout();
			this.splitPanel.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitPanel)).EndInit();
			this.splitPanel.ResumeLayout(false);
			this.ControlsSplitContainer.Panel1.ResumeLayout(false);
			this.ControlsSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ControlsSplitContainer)).EndInit();
			this.ControlsSplitContainer.ResumeLayout(false);
			this.FlowLayout.ResumeLayout(false);
			this.zoomGroup.ResumeLayout(false);
			this.zoomGroup.PerformLayout();
			this.ExportGroup.ResumeLayout(false);
			this.ExportGroup.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.AnalyticsTab.ResumeLayout(false);
			this.AnalyticsTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BoxFitSizeValue)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TrackBar yProbBar;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button fwdButton;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.TrackBar xProbBar;
        private System.Windows.Forms.Label xProbLabel;
        private System.Windows.Forms.Label yProbLabel;
		private System.Windows.Forms.NumericUpDown yProbValue;
		private System.Windows.Forms.NumericUpDown xProbValue;
		private System.Windows.Forms.NumericUpDown stepCounter;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		private System.Windows.Forms.Panel playGroup;
		private System.Windows.Forms.Panel probGroup;
		private System.Windows.Forms.SplitContainer splitPanel;
		private System.Windows.Forms.FlowLayoutPanel FlowLayout;
		private System.Windows.Forms.Panel zoomGroup;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage AnalyticsTab;
		private System.Windows.Forms.TabPage GraphsTab;
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.Button skipToEndButton;
		private System.Windows.Forms.Button skipToBeginningButton;
		private System.Windows.Forms.RadioButton zoomButton4;
		private System.Windows.Forms.RadioButton zoomButton3;
		private System.Windows.Forms.RadioButton zoomButton2;
		private System.Windows.Forms.RadioButton zoomButton1;
		private System.Windows.Forms.Label zoomTitle;
		private System.Windows.Forms.Label gammaLabel;
		private System.Windows.Forms.NumericUpDown gammaValue;
		private System.Windows.Forms.TrackBar gammaBar;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Label initTitle;
		private System.Windows.Forms.Label LatSizeLabel;
		private System.Windows.Forms.NumericUpDown LatSizeValue;
		private System.Windows.Forms.Panel ExportGroup;
		private System.Windows.Forms.ComboBox FpsChooser;
		private System.Windows.Forms.Label FpsLabel;
		private System.Windows.Forms.Label ExportLabel;
		private System.Windows.Forms.Button ExportButton;
		private System.Windows.Forms.ComboBox ResChooser;
		private System.Windows.Forms.Label ResolutionLabel;
		private System.Windows.Forms.Button AnalysisStartButton;
		private System.Windows.Forms.NumericUpDown BoxFitSizeValue;
		private System.Windows.Forms.Button BoxFitNextButton;
		private System.Windows.Forms.SplitContainer ControlsSplitContainer;
		private System.Windows.Forms.Label AreaLabel;
		private System.Windows.Forms.Label DensityLabel;
		private System.Windows.Forms.Label PerimeterLabel;
		private System.Windows.Forms.Label MouseLabel;
	}
}

