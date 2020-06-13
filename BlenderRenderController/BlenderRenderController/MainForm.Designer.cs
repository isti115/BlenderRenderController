namespace BlenderRenderController
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.renderSegmentButton = new System.Windows.Forms.Button();
            this.blendFileBrowseButton = new System.Windows.Forms.Button();
            this.renderProgressBar = new System.Windows.Forms.ProgressBar();
            this.blendFilePathTextBox = new System.Windows.Forms.TextBox();
            this.startFrameNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endFrameNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startFrameLabel = new System.Windows.Forms.Label();
            this.endFrameLabel = new System.Windows.Forms.Label();
            this.blendFileLabel = new System.Windows.Forms.Label();
            this.partsFolderBrowseButton = new System.Windows.Forms.Button();
            this.partsFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.partsFolderLabel = new System.Windows.Forms.Label();
            this.rendererLabel = new System.Windows.Forms.Label();
            this.rendererComboBox = new System.Windows.Forms.ComboBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.nextChunkButton = new System.Windows.Forms.Button();
            this.prevChunkButton = new System.Windows.Forms.Button();
            this.totalFrameCountLabel = new System.Windows.Forms.Label();
            this.totalFrameCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.processCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.processCountLabel = new System.Windows.Forms.Label();
            this.renderAllButton = new System.Windows.Forms.Button();
            this.concatenatePartsButton = new System.Windows.Forms.Button();
            this.ReadBlenderData = new System.Windows.Forms.Button();
            this.MixdownAudio = new System.Windows.Forms.Button();
            this.TotalTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autocombineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugShow = new System.Windows.Forms.ToolStripMenuItem();
            this.speToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.visitGithubPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isti115ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meTwentyFiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redRaptor93ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jendabekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMDArgsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.outFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.infoNoScenes = new System.Windows.Forms.TextBox();
            this.infoActiveScene = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activeWarn = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ajustOutDir = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.mergeAudioButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startFrameNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endFrameNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalFrameCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processCountNumericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // renderSegmentButton
            // 
            this.renderSegmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.renderSegmentButton.Location = new System.Drawing.Point(276, 294);
            this.renderSegmentButton.Name = "renderSegmentButton";
            this.renderSegmentButton.Size = new System.Drawing.Size(127, 39);
            this.renderSegmentButton.TabIndex = 0;
            this.renderSegmentButton.Text = "Render segment";
            this.toolTip1.SetToolTip(this.renderSegmentButton, "Render current segment");
            this.renderSegmentButton.UseVisualStyleBackColor = true;
            this.renderSegmentButton.Click += new System.EventHandler(this.renderSegmentButton_Click);
            // 
            // blendFileBrowseButton
            // 
            this.blendFileBrowseButton.Location = new System.Drawing.Point(565, 69);
            this.blendFileBrowseButton.Name = "blendFileBrowseButton";
            this.blendFileBrowseButton.Size = new System.Drawing.Size(76, 27);
            this.blendFileBrowseButton.TabIndex = 1;
            this.blendFileBrowseButton.Text = "Browse";
            this.blendFileBrowseButton.UseVisualStyleBackColor = true;
            this.blendFileBrowseButton.Click += new System.EventHandler(this.blendFileBrowseButton_Click);
            // 
            // renderProgressBar
            // 
            this.renderProgressBar.Location = new System.Drawing.Point(37, 343);
            this.renderProgressBar.Name = "renderProgressBar";
            this.renderProgressBar.Size = new System.Drawing.Size(604, 23);
            this.renderProgressBar.Step = 1;
            this.renderProgressBar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.renderProgressBar, "Progress bar");
            // 
            // blendFilePathTextBox
            // 
            this.blendFilePathTextBox.Location = new System.Drawing.Point(76, 72);
            this.blendFilePathTextBox.Name = "blendFilePathTextBox";
            this.blendFilePathTextBox.Size = new System.Drawing.Size(482, 20);
            this.blendFilePathTextBox.TabIndex = 3;
            // 
            // startFrameNumericUpDown
            // 
            this.startFrameNumericUpDown.Location = new System.Drawing.Point(86, 233);
            this.startFrameNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.startFrameNumericUpDown.Name = "startFrameNumericUpDown";
            this.startFrameNumericUpDown.Size = new System.Drawing.Size(78, 20);
            this.startFrameNumericUpDown.TabIndex = 4;
            this.toolTip1.SetToolTip(this.startFrameNumericUpDown, "Segment\'s starting frame");
            this.startFrameNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endFrameNumericUpDown
            // 
            this.endFrameNumericUpDown.Location = new System.Drawing.Point(86, 266);
            this.endFrameNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.endFrameNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endFrameNumericUpDown.Name = "endFrameNumericUpDown";
            this.endFrameNumericUpDown.Size = new System.Drawing.Size(78, 20);
            this.endFrameNumericUpDown.TabIndex = 5;
            this.toolTip1.SetToolTip(this.endFrameNumericUpDown, "Segment\'s end frame");
            this.endFrameNumericUpDown.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // startFrameLabel
            // 
            this.startFrameLabel.AutoSize = true;
            this.startFrameLabel.Location = new System.Drawing.Point(19, 235);
            this.startFrameLabel.Name = "startFrameLabel";
            this.startFrameLabel.Size = new System.Drawing.Size(61, 13);
            this.startFrameLabel.TabIndex = 6;
            this.startFrameLabel.Text = "Start frame:";
            this.toolTip1.SetToolTip(this.startFrameLabel, "Segment\'s starting frame");
            // 
            // endFrameLabel
            // 
            this.endFrameLabel.AutoSize = true;
            this.endFrameLabel.Location = new System.Drawing.Point(19, 268);
            this.endFrameLabel.Name = "endFrameLabel";
            this.endFrameLabel.Size = new System.Drawing.Size(58, 13);
            this.endFrameLabel.TabIndex = 7;
            this.endFrameLabel.Text = "End frame:";
            this.toolTip1.SetToolTip(this.endFrameLabel, "Segment\'s end frame");
            // 
            // blendFileLabel
            // 
            this.blendFileLabel.AutoSize = true;
            this.blendFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.blendFileLabel.Location = new System.Drawing.Point(6, 73);
            this.blendFileLabel.Name = "blendFileLabel";
            this.blendFileLabel.Size = new System.Drawing.Size(61, 15);
            this.blendFileLabel.TabIndex = 8;
            this.blendFileLabel.Text = "Blend file:";
            // 
            // partsFolderBrowseButton
            // 
            this.partsFolderBrowseButton.Location = new System.Drawing.Point(564, 403);
            this.partsFolderBrowseButton.Name = "partsFolderBrowseButton";
            this.partsFolderBrowseButton.Size = new System.Drawing.Size(76, 27);
            this.partsFolderBrowseButton.TabIndex = 1;
            this.partsFolderBrowseButton.Text = "Browse";
            this.partsFolderBrowseButton.UseVisualStyleBackColor = true;
            this.partsFolderBrowseButton.Click += new System.EventHandler(this.partsFolderBrowseButton_Click);
            // 
            // partsFolderPathTextBox
            // 
            this.partsFolderPathTextBox.Location = new System.Drawing.Point(111, 406);
            this.partsFolderPathTextBox.Name = "partsFolderPathTextBox";
            this.partsFolderPathTextBox.Size = new System.Drawing.Size(447, 20);
            this.partsFolderPathTextBox.TabIndex = 3;
            this.partsFolderPathTextBox.TextChanged += new System.EventHandler(this.outFolderPathTextBox_TextChanged);
            // 
            // partsFolderLabel
            // 
            this.partsFolderLabel.AutoSize = true;
            this.partsFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsFolderLabel.Location = new System.Drawing.Point(33, 408);
            this.partsFolderLabel.Name = "partsFolderLabel";
            this.partsFolderLabel.Size = new System.Drawing.Size(72, 15);
            this.partsFolderLabel.TabIndex = 8;
            this.partsFolderLabel.Text = "Parts folder:";
            // 
            // rendererLabel
            // 
            this.rendererLabel.AutoSize = true;
            this.rendererLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rendererLabel.Location = new System.Drawing.Point(421, 264);
            this.rendererLabel.Name = "rendererLabel";
            this.rendererLabel.Size = new System.Drawing.Size(62, 15);
            this.rendererLabel.TabIndex = 9;
            this.rendererLabel.Text = "Renderer:";
            // 
            // rendererComboBox
            // 
            this.rendererComboBox.FormattingEnabled = true;
            this.rendererComboBox.Items.AddRange(new object[] {
            "BLENDER_EEVEE",
            "BLENDER_WORKBENCH",
            "BLENDER_RENDER",
            "CYCLES"});
            this.rendererComboBox.Location = new System.Drawing.Point(489, 263);
            this.rendererComboBox.Name = "rendererComboBox";
            this.rendererComboBox.Size = new System.Drawing.Size(134, 21);
            this.rendererComboBox.TabIndex = 10;
            this.rendererComboBox.Text = "";
            // 
            // progressLabel
            // 
            this.progressLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.progressLabel.Location = new System.Drawing.Point(170, 313);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(53, 23);
            this.progressLabel.TabIndex = 11;
            this.progressLabel.Text = "0/0";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.progressLabel, "Progress");
            this.progressLabel.Visible = false;
            // 
            // nextChunkButton
            // 
            this.nextChunkButton.Location = new System.Drawing.Point(299, 259);
            this.nextChunkButton.Name = "nextChunkButton";
            this.nextChunkButton.Size = new System.Drawing.Size(74, 27);
            this.nextChunkButton.TabIndex = 12;
            this.nextChunkButton.Text = "Next chunk";
            this.toolTip1.SetToolTip(this.nextChunkButton, "Segment select");
            this.nextChunkButton.UseVisualStyleBackColor = true;
            this.nextChunkButton.Click += new System.EventHandler(this.nextChunkButton_Click);
            // 
            // prevChunkButton
            // 
            this.prevChunkButton.Location = new System.Drawing.Point(299, 226);
            this.prevChunkButton.Name = "prevChunkButton";
            this.prevChunkButton.Size = new System.Drawing.Size(74, 27);
            this.prevChunkButton.TabIndex = 12;
            this.prevChunkButton.Text = "Prev chunk";
            this.toolTip1.SetToolTip(this.prevChunkButton, "Segment select");
            this.prevChunkButton.UseVisualStyleBackColor = true;
            this.prevChunkButton.Click += new System.EventHandler(this.prevChunkButton_Click);
            // 
            // totalFrameCountLabel
            // 
            this.totalFrameCountLabel.AutoSize = true;
            this.totalFrameCountLabel.Location = new System.Drawing.Point(179, 246);
            this.totalFrameCountLabel.Name = "totalFrameCountLabel";
            this.totalFrameCountLabel.Size = new System.Drawing.Size(93, 13);
            this.totalFrameCountLabel.TabIndex = 13;
            this.totalFrameCountLabel.Text = "Total frame count:";
            this.toolTip1.SetToolTip(this.totalFrameCountLabel, "Project\'s end frame");
            // 
            // totalFrameCountNumericUpDown
            // 
            this.totalFrameCountNumericUpDown.Location = new System.Drawing.Point(182, 266);
            this.totalFrameCountNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.totalFrameCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.totalFrameCountNumericUpDown.Name = "totalFrameCountNumericUpDown";
            this.totalFrameCountNumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.totalFrameCountNumericUpDown.TabIndex = 5;
            this.toolTip1.SetToolTip(this.totalFrameCountNumericUpDown, "Project\'s end frame");
            this.totalFrameCountNumericUpDown.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // processCountNumericUpDown
            // 
            this.processCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processCountNumericUpDown.Location = new System.Drawing.Point(514, 229);
            this.processCountNumericUpDown.Name = "processCountNumericUpDown";
            this.processCountNumericUpDown.Size = new System.Drawing.Size(44, 21);
            this.processCountNumericUpDown.TabIndex = 14;
            this.toolTip1.SetToolTip(this.processCountNumericUpDown, "N# of processes. For best results set acording to \r\nhow many logical cores you ha" +
        "ve.");
            this.processCountNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // processCountLabel
            // 
            this.processCountLabel.AutoSize = true;
            this.processCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processCountLabel.Location = new System.Drawing.Point(421, 231);
            this.processCountLabel.Name = "processCountLabel";
            this.processCountLabel.Size = new System.Drawing.Size(87, 15);
            this.processCountLabel.TabIndex = 15;
            this.processCountLabel.Text = "Process count:";
            this.toolTip1.SetToolTip(this.processCountLabel, "N# of processes. For best results set acording to\r\nhow many logical cores you hav" +
        "e.");
            // 
            // renderAllButton
            // 
            this.renderAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.renderAllButton.Location = new System.Drawing.Point(470, 293);
            this.renderAllButton.Name = "renderAllButton";
            this.renderAllButton.Size = new System.Drawing.Size(171, 39);
            this.renderAllButton.TabIndex = 0;
            this.renderAllButton.Text = "Render all";
            this.toolTip1.SetToolTip(this.renderAllButton, "Render all segments");
            this.renderAllButton.UseVisualStyleBackColor = true;
            this.renderAllButton.Click += new System.EventHandler(this.renderAllButton_Click);
            // 
            // concatenatePartsButton
            // 
            this.concatenatePartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concatenatePartsButton.Location = new System.Drawing.Point(470, 436);
            this.concatenatePartsButton.Name = "concatenatePartsButton";
            this.concatenatePartsButton.Size = new System.Drawing.Size(173, 39);
            this.concatenatePartsButton.TabIndex = 16;
            this.concatenatePartsButton.Text = "Concatenate parts *";
            this.toolTip1.SetToolTip(this.concatenatePartsButton, "Combine segments in FFmpeg");
            this.concatenatePartsButton.UseVisualStyleBackColor = true;
            this.concatenatePartsButton.Click += new System.EventHandler(this.concatenatePartsButton_Click);
            // 
            // ReadBlenderData
            // 
            this.ReadBlenderData.Location = new System.Drawing.Point(566, 134);
            this.ReadBlenderData.Name = "ReadBlenderData";
            this.ReadBlenderData.Size = new System.Drawing.Size(75, 63);
            this.ReadBlenderData.TabIndex = 17;
            this.ReadBlenderData.Text = "Re-Read";
            this.toolTip1.SetToolTip(this.ReadBlenderData, "Re-read info from .blend");
            this.ReadBlenderData.UseVisualStyleBackColor = true;
            this.ReadBlenderData.Click += new System.EventHandler(this.ReadBlenderData_Click);
            // 
            // MixdownAudio
            // 
            this.MixdownAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MixdownAudio.Location = new System.Drawing.Point(177, 500);
            this.MixdownAudio.Name = "MixdownAudio";
            this.MixdownAudio.Size = new System.Drawing.Size(99, 51);
            this.MixdownAudio.TabIndex = 18;
            this.MixdownAudio.Text = "MixDown audio";
            this.MixdownAudio.UseVisualStyleBackColor = true;
            this.MixdownAudio.Click += new System.EventHandler(this.MixdownAudio_Click);
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSize = true;
            this.TotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.TotalTime.Location = new System.Drawing.Point(37, 316);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(127, 16);
            this.TotalTime.TabIndex = 19;
            this.TotalTime.Text = "Total Time: 00:00:00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipsToolStripMenuItem,
            this.autocombineToolStripMenuItem,
            this.debugShow,
            this.speToolStripMenuItem,
            this.visitGithubPageToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "Options";
            this.aboutToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.aboutToolStripMenuItem.ToolTipText = "Extra options";
            // 
            // tipsToolStripMenuItem
            // 
            this.tipsToolStripMenuItem.Checked = true;
            this.tipsToolStripMenuItem.CheckOnClick = true;
            this.tipsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tipsToolStripMenuItem.Name = "tipsToolStripMenuItem";
            this.tipsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tipsToolStripMenuItem.Text = "Tooltips";
            this.tipsToolStripMenuItem.Click += new System.EventHandler(this.tipsToolStripMenuItem_Click);
            // 
            // autocombineToolStripMenuItem
            // 
            this.autocombineToolStripMenuItem.CheckOnClick = true;
            this.autocombineToolStripMenuItem.Name = "autocombineToolStripMenuItem";
            this.autocombineToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.autocombineToolStripMenuItem.Text = "Auto-combine";
            this.autocombineToolStripMenuItem.ToolTipText = "Automatically combine parts when clicking \"Render all\"";
            this.autocombineToolStripMenuItem.Visible = false;
            // 
            // debugShow
            // 
            this.debugShow.CheckOnClick = true;
            this.debugShow.Name = "debugShow";
            this.debugShow.Size = new System.Drawing.Size(166, 22);
            this.debugShow.Text = "Debug menu";
            this.debugShow.Click += new System.EventHandler(this.debugMenuToolStripMenuItem_Click);
            // 
            // speToolStripMenuItem
            // 
            this.speToolStripMenuItem.Name = "speToolStripMenuItem";
            this.speToolStripMenuItem.Size = new System.Drawing.Size(163, 6);
            // 
            // visitGithubPageToolStripMenuItem
            // 
            this.visitGithubPageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isti115ToolStripMenuItem,
            this.meTwentyFiveToolStripMenuItem,
            this.redRaptor93ToolStripMenuItem,
            this.jendabekToolStripMenuItem});
            this.visitGithubPageToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitGithubPageToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.visitGithubPageToolStripMenuItem.Name = "visitGithubPageToolStripMenuItem";
            this.visitGithubPageToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.visitGithubPageToolStripMenuItem.Text = "Visit GitHub page";
            // 
            // isti115ToolStripMenuItem
            // 
            this.isti115ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isti115ToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.isti115ToolStripMenuItem.Name = "isti115ToolStripMenuItem";
            this.isti115ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.isti115ToolStripMenuItem.Text = "Isti115";
            this.isti115ToolStripMenuItem.Click += new System.EventHandler(this.isti115ToolStripMenuItem_Click);
            // 
            // meTwentyFiveToolStripMenuItem
            // 
            this.meTwentyFiveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meTwentyFiveToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.meTwentyFiveToolStripMenuItem.Name = "meTwentyFiveToolStripMenuItem";
            this.meTwentyFiveToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.meTwentyFiveToolStripMenuItem.Text = "MeTwentyFive";
            this.meTwentyFiveToolStripMenuItem.Click += new System.EventHandler(this.meTwentyFiveToolStripMenuItem_Click);
            // 
            // redRaptor93ToolStripMenuItem
            // 
            this.redRaptor93ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redRaptor93ToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.redRaptor93ToolStripMenuItem.Name = "redRaptor93ToolStripMenuItem";
            this.redRaptor93ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.redRaptor93ToolStripMenuItem.Text = "RedRaptor93";
            this.redRaptor93ToolStripMenuItem.Click += new System.EventHandler(this.redRaptor93ToolStripMenuItem_Click);
            // 
            // jendabekToolStripMenuItem
            // 
            this.jendabekToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.jendabekToolStripMenuItem.Name = "jendabekToolStripMenuItem";
            this.jendabekToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.jendabekToolStripMenuItem.Text = "jendabek";
            this.jendabekToolStripMenuItem.Click += new System.EventHandler(this.jendabekToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readmeToolStripMenuItem,
            this.jsonToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // readmeToolStripMenuItem
            // 
            this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
            this.readmeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.readmeToolStripMenuItem.Text = "Readme";
            this.readmeToolStripMenuItem.ToolTipText = "Open readme (WIP)";
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.jsonToolStripMenuItem.Text = "Json info";
            this.jsonToolStripMenuItem.ToolTipText = "Show contents of Json file";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.jsonToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteJsonToolStripMenuItem,
            this.cMDArgsToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Visible = false;
            // 
            // deleteJsonToolStripMenuItem
            // 
            this.deleteJsonToolStripMenuItem.Name = "deleteJsonToolStripMenuItem";
            this.deleteJsonToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.deleteJsonToolStripMenuItem.Text = "Delete json";
            this.deleteJsonToolStripMenuItem.Click += new System.EventHandler(this.deleteJsonToolStripMenuItem_Click);
            // 
            // cMDArgsToolStripMenuItem
            // 
            this.cMDArgsToolStripMenuItem.Name = "cMDArgsToolStripMenuItem";
            this.cMDArgsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cMDArgsToolStripMenuItem.Text = "CMD args";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Active scene name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.activeWarn.SetToolTip(this.label1, "This program will only render the ACTIVE scene, if you \r\nhave more then one scene" +
        " on your project sure you \r\nsave it with the scene you want OPEN.");
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.Info;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Controls.Add(this.outFolderPathTextBox);
            this.infoPanel.Controls.Add(this.label4);
            this.infoPanel.Controls.Add(this.infoNoScenes);
            this.infoPanel.Controls.Add(this.infoActiveScene);
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPanel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.infoPanel.Location = new System.Drawing.Point(76, 106);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(482, 112);
            this.infoPanel.TabIndex = 22;
            // 
            // outFolderPathTextBox
            // 
            this.outFolderPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outFolderPathTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.outFolderPathTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.outFolderPathTextBox.Location = new System.Drawing.Point(9, 30);
            this.outFolderPathTextBox.Name = "outFolderPathTextBox";
            this.outFolderPathTextBox.ReadOnly = true;
            this.outFolderPathTextBox.Size = new System.Drawing.Size(464, 20);
            this.outFolderPathTextBox.TabIndex = 28;
            this.outFolderPathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.activeWarn.SetToolTip(this.outFolderPathTextBox, "Render outputs will go here, must be changed in Blender.");
            this.outFolderPathTextBox.TextChanged += new System.EventHandler(this.outFolderPathTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = ".blend\'s Output folder:";
            this.activeWarn.SetToolTip(this.label4, "Render outputs will go here, must be changed in Blender.");
            // 
            // infoNoScenes
            // 
            this.infoNoScenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.infoNoScenes.BackColor = System.Drawing.SystemColors.Window;
            this.infoNoScenes.Cursor = System.Windows.Forms.Cursors.No;
            this.infoNoScenes.Location = new System.Drawing.Point(351, 78);
            this.infoNoScenes.Name = "infoNoScenes";
            this.infoNoScenes.ReadOnly = true;
            this.infoNoScenes.Size = new System.Drawing.Size(116, 20);
            this.infoNoScenes.TabIndex = 26;
            this.infoNoScenes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.infoNoScenes, "Number of scenes in project.");
            // 
            // infoActiveScene
            // 
            this.infoActiveScene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.infoActiveScene.BackColor = System.Drawing.SystemColors.Window;
            this.infoActiveScene.Cursor = System.Windows.Forms.Cursors.No;
            this.infoActiveScene.Location = new System.Drawing.Point(13, 80);
            this.infoActiveScene.Name = "infoActiveScene";
            this.infoActiveScene.ReadOnly = true;
            this.infoActiveScene.Size = new System.Drawing.Size(122, 20);
            this.infoActiveScene.TabIndex = 25;
            this.infoActiveScene.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.activeWarn.SetToolTip(this.infoActiveScene, "This program will only render the ACTIVE scene, if you \r\nhave more then one scene" +
        " on your project sure you \r\nsave it with the scene you want OPEN.");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Number of scenes:";
            this.activeWarn.SetToolTip(this.label3, "Number of scenes in project.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(28, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Infos:";
            // 
            // activeWarn
            // 
            this.activeWarn.AutomaticDelay = 1000;
            this.activeWarn.IsBalloon = true;
            this.activeWarn.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.activeWarn.ToolTipTitle = "Caution";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ajustOutDir
            // 
            this.ajustOutDir.AutoSize = true;
            this.ajustOutDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajustOutDir.Location = new System.Drawing.Point(111, 447);
            this.ajustOutDir.Name = "ajustOutDir";
            this.ajustOutDir.Size = new System.Drawing.Size(155, 19);
            this.ajustOutDir.TabIndex = 27;
            this.ajustOutDir.Text = "Remove FILE from path";
            this.toolTip1.SetToolTip(this.ajustOutDir, "If path ends in a file insted of a folder, use this to \r\npoint to intended direct" +
        "ory");
            this.ajustOutDir.UseVisualStyleBackColor = true;
            this.ajustOutDir.CheckedChanged += new System.EventHandler(this.ajustOutDir_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(33, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "2. Joining";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(33, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "1. Rendering";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Silver;
            this.line.ForeColor = System.Drawing.Color.Silver;
            this.line.Location = new System.Drawing.Point(142, 51);
            this.line.Margin = new System.Windows.Forms.Padding(0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(494, 5);
            this.line.TabIndex = 28;
            this.line.Text = "███";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.Silver;
            this.line2.ForeColor = System.Drawing.Color.Silver;
            this.line2.Location = new System.Drawing.Point(119, 384);
            this.line2.Margin = new System.Windows.Forms.Padding(0);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(517, 5);
            this.line2.TabIndex = 29;
            this.line2.Text = "███";
            // 
            // mergeAudioButton
            // 
            this.mergeAudioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeAudioButton.Location = new System.Drawing.Point(314, 500);
            this.mergeAudioButton.Name = "mergeAudioButton";
            this.mergeAudioButton.Size = new System.Drawing.Size(93, 51);
            this.mergeAudioButton.TabIndex = 30;
            this.mergeAudioButton.Text = "Merge audio *";
            this.mergeAudioButton.UseVisualStyleBackColor = true;
            this.mergeAudioButton.Click += new System.EventHandler(this.mergeAudioButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(33, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "3. Audio";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(119, 478);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(517, 5);
            this.label8.TabIndex = 29;
            this.label8.Text = "███";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(283, 516);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "-->";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(413, 490);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 64);
            this.label10.TabIndex = 31;
            this.label10.Text = "This button will replace the existing\r\naudio in concat_output.mp4 with\r\nthe mixed" +
    " down ac3 track and write the\r\nresult to audio_output.mp4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 64);
            this.label11.TabIndex = 31;
            this.label11.Text = "This button will export only\r\nthe audio track from the\r\nblend file into a\r\nsepara" +
    "te ac3 file.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(58, 571);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(532, 36);
            this.label12.TabIndex = 32;
            this.label12.Text = "*: A console window may pop up asking for confirmation if the file already exists" +
    ".\r\nIn this case type in the letter y and press Enter if you wish to overwrite it" +
    ".";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 616);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mergeAudioButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line);
            this.Controls.Add(this.ajustOutDir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.MixdownAudio);
            this.Controls.Add(this.ReadBlenderData);
            this.Controls.Add(this.concatenatePartsButton);
            this.Controls.Add(this.processCountLabel);
            this.Controls.Add(this.processCountNumericUpDown);
            this.Controls.Add(this.totalFrameCountLabel);
            this.Controls.Add(this.prevChunkButton);
            this.Controls.Add(this.nextChunkButton);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.rendererComboBox);
            this.Controls.Add(this.rendererLabel);
            this.Controls.Add(this.partsFolderLabel);
            this.Controls.Add(this.blendFileLabel);
            this.Controls.Add(this.endFrameLabel);
            this.Controls.Add(this.startFrameLabel);
            this.Controls.Add(this.totalFrameCountNumericUpDown);
            this.Controls.Add(this.endFrameNumericUpDown);
            this.Controls.Add(this.partsFolderPathTextBox);
            this.Controls.Add(this.startFrameNumericUpDown);
            this.Controls.Add(this.blendFilePathTextBox);
            this.Controls.Add(this.partsFolderBrowseButton);
            this.Controls.Add(this.renderProgressBar);
            this.Controls.Add(this.blendFileBrowseButton);
            this.Controls.Add(this.renderAllButton);
            this.Controls.Add(this.renderSegmentButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 280);
            this.Name = "MainForm";
            this.Text = "Blender Render Controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Close);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.startFrameNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endFrameNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalFrameCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processCountNumericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button renderSegmentButton;
        private System.Windows.Forms.Button blendFileBrowseButton;
        private System.Windows.Forms.ProgressBar renderProgressBar;
        private System.Windows.Forms.TextBox blendFilePathTextBox;
        private System.Windows.Forms.NumericUpDown startFrameNumericUpDown;
        private System.Windows.Forms.NumericUpDown endFrameNumericUpDown;
        private System.Windows.Forms.Label startFrameLabel;
        private System.Windows.Forms.Label endFrameLabel;
        private System.Windows.Forms.Label blendFileLabel;
        private System.Windows.Forms.Button partsFolderBrowseButton;
        private System.Windows.Forms.TextBox partsFolderPathTextBox;
        private System.Windows.Forms.Label partsFolderLabel;
        private System.Windows.Forms.Label rendererLabel;
        private System.Windows.Forms.ComboBox rendererComboBox;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button nextChunkButton;
        private System.Windows.Forms.Button prevChunkButton;
        private System.Windows.Forms.Label totalFrameCountLabel;
        private System.Windows.Forms.NumericUpDown totalFrameCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown processCountNumericUpDown;
        private System.Windows.Forms.Label processCountLabel;
        private System.Windows.Forms.Button renderAllButton;
        private System.Windows.Forms.Button concatenatePartsButton;
		private System.Windows.Forms.Button ReadBlenderData;
		private System.Windows.Forms.Button MixdownAudio;
		private System.Windows.Forms.Label TotalTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox infoNoScenes;
        private System.Windows.Forms.TextBox infoActiveScene;
        private System.Windows.Forms.ToolTip activeWarn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem tipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitGithubPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isti115ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meTwentyFiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redRaptor93ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jendabekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator speToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readmeToolStripMenuItem;
        private System.Windows.Forms.TextBox outFolderPathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ajustOutDir;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.ToolStripMenuItem autocombineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugShow;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cMDArgsToolStripMenuItem;
        private System.Windows.Forms.Button mergeAudioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

