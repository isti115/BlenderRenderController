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
            this.renderButton = new System.Windows.Forms.Button();
            this.blendFileBrowseButton = new System.Windows.Forms.Button();
            this.renderProgressBar = new System.Windows.Forms.ProgressBar();
            this.blendFilePathTextBox = new System.Windows.Forms.TextBox();
            this.startFrameNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endFrameNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startFrameLabel = new System.Windows.Forms.Label();
            this.endFrameLabel = new System.Windows.Forms.Label();
            this.blendFileLabel = new System.Windows.Forms.Label();
            this.outFolderBrowseButton = new System.Windows.Forms.Button();
            this.outFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.outFolderLabel = new System.Windows.Forms.Label();
            this.rendererLabel = new System.Windows.Forms.Label();
            this.rendererComboBox = new System.Windows.Forms.ComboBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.nextChunkButton = new System.Windows.Forms.Button();
            this.prevChunkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startFrameNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endFrameNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // renderButton
            // 
            this.renderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renderButton.Location = new System.Drawing.Point(12, 174);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(440, 55);
            this.renderButton.TabIndex = 0;
            this.renderButton.Text = "Render";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.renderButton_Click);
            // 
            // blendFileBrowseButton
            // 
            this.blendFileBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blendFileBrowseButton.Location = new System.Drawing.Point(376, 10);
            this.blendFileBrowseButton.Name = "blendFileBrowseButton";
            this.blendFileBrowseButton.Size = new System.Drawing.Size(76, 23);
            this.blendFileBrowseButton.TabIndex = 1;
            this.blendFileBrowseButton.Text = "Browse";
            this.blendFileBrowseButton.UseVisualStyleBackColor = true;
            this.blendFileBrowseButton.Click += new System.EventHandler(this.blendFileBrowseButton_Click);
            // 
            // renderProgressBar
            // 
            this.renderProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renderProgressBar.Location = new System.Drawing.Point(12, 145);
            this.renderProgressBar.Name = "renderProgressBar";
            this.renderProgressBar.Size = new System.Drawing.Size(440, 23);
            this.renderProgressBar.TabIndex = 2;
            // 
            // blendFilePathTextBox
            // 
            this.blendFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blendFilePathTextBox.Location = new System.Drawing.Point(79, 12);
            this.blendFilePathTextBox.Name = "blendFilePathTextBox";
            this.blendFilePathTextBox.Size = new System.Drawing.Size(291, 20);
            this.blendFilePathTextBox.TabIndex = 3;
            // 
            // startFrameNumericUpDown
            // 
            this.startFrameNumericUpDown.Location = new System.Drawing.Point(79, 38);
            this.startFrameNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.startFrameNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startFrameNumericUpDown.Name = "startFrameNumericUpDown";
            this.startFrameNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.startFrameNumericUpDown.TabIndex = 4;
            this.startFrameNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endFrameNumericUpDown
            // 
            this.endFrameNumericUpDown.Location = new System.Drawing.Point(79, 64);
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
            this.endFrameNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.endFrameNumericUpDown.TabIndex = 5;
            this.endFrameNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // startFrameLabel
            // 
            this.startFrameLabel.AutoSize = true;
            this.startFrameLabel.Location = new System.Drawing.Point(12, 40);
            this.startFrameLabel.Name = "startFrameLabel";
            this.startFrameLabel.Size = new System.Drawing.Size(61, 13);
            this.startFrameLabel.TabIndex = 6;
            this.startFrameLabel.Text = "Start frame:";
            // 
            // endFrameLabel
            // 
            this.endFrameLabel.AutoSize = true;
            this.endFrameLabel.Location = new System.Drawing.Point(12, 66);
            this.endFrameLabel.Name = "endFrameLabel";
            this.endFrameLabel.Size = new System.Drawing.Size(58, 13);
            this.endFrameLabel.TabIndex = 7;
            this.endFrameLabel.Text = "End frame:";
            // 
            // blendFileLabel
            // 
            this.blendFileLabel.AutoSize = true;
            this.blendFileLabel.Location = new System.Drawing.Point(12, 15);
            this.blendFileLabel.Name = "blendFileLabel";
            this.blendFileLabel.Size = new System.Drawing.Size(53, 13);
            this.blendFileLabel.TabIndex = 8;
            this.blendFileLabel.Text = "Blend file:";
            // 
            // outFolderBrowseButton
            // 
            this.outFolderBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outFolderBrowseButton.Location = new System.Drawing.Point(376, 88);
            this.outFolderBrowseButton.Name = "outFolderBrowseButton";
            this.outFolderBrowseButton.Size = new System.Drawing.Size(76, 23);
            this.outFolderBrowseButton.TabIndex = 1;
            this.outFolderBrowseButton.Text = "Browse";
            this.outFolderBrowseButton.UseVisualStyleBackColor = true;
            this.outFolderBrowseButton.Click += new System.EventHandler(this.outFolderBrowseButton_Click);
            // 
            // outFolderPathTextBox
            // 
            this.outFolderPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outFolderPathTextBox.Location = new System.Drawing.Point(79, 90);
            this.outFolderPathTextBox.Name = "outFolderPathTextBox";
            this.outFolderPathTextBox.Size = new System.Drawing.Size(291, 20);
            this.outFolderPathTextBox.TabIndex = 3;
            // 
            // outFolderLabel
            // 
            this.outFolderLabel.AutoSize = true;
            this.outFolderLabel.Location = new System.Drawing.Point(12, 93);
            this.outFolderLabel.Name = "outFolderLabel";
            this.outFolderLabel.Size = new System.Drawing.Size(56, 13);
            this.outFolderLabel.TabIndex = 8;
            this.outFolderLabel.Text = "Out folder:";
            // 
            // rendererLabel
            // 
            this.rendererLabel.AutoSize = true;
            this.rendererLabel.Location = new System.Drawing.Point(12, 119);
            this.rendererLabel.Name = "rendererLabel";
            this.rendererLabel.Size = new System.Drawing.Size(54, 13);
            this.rendererLabel.TabIndex = 9;
            this.rendererLabel.Text = "Renderer:";
            // 
            // rendererComboBox
            // 
            this.rendererComboBox.FormattingEnabled = true;
            this.rendererComboBox.Items.AddRange(new object[] {
            "BLENDER_RENDER",
            "CYCLES"});
            this.rendererComboBox.Location = new System.Drawing.Point(79, 116);
            this.rendererComboBox.Name = "rendererComboBox";
            this.rendererComboBox.Size = new System.Drawing.Size(131, 21);
            this.rendererComboBox.TabIndex = 10;
            this.rendererComboBox.Text = "BLENDER_RENDER";
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLabel.Location = new System.Drawing.Point(376, 119);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(76, 23);
            this.progressLabel.TabIndex = 11;
            this.progressLabel.Text = "0/0";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nextChunkButton
            // 
            this.nextChunkButton.Location = new System.Drawing.Point(205, 62);
            this.nextChunkButton.Name = "nextChunkButton";
            this.nextChunkButton.Size = new System.Drawing.Size(75, 23);
            this.nextChunkButton.TabIndex = 12;
            this.nextChunkButton.Text = "Next chunk";
            this.nextChunkButton.UseVisualStyleBackColor = true;
            this.nextChunkButton.Click += new System.EventHandler(this.nextChunkButton_Click);
            // 
            // prevChunkButton
            // 
            this.prevChunkButton.Location = new System.Drawing.Point(205, 37);
            this.prevChunkButton.Name = "prevChunkButton";
            this.prevChunkButton.Size = new System.Drawing.Size(75, 23);
            this.prevChunkButton.TabIndex = 12;
            this.prevChunkButton.Text = "Prev chunk";
            this.prevChunkButton.UseVisualStyleBackColor = true;
            this.prevChunkButton.Click += new System.EventHandler(this.prevChunkButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 241);
            this.Controls.Add(this.prevChunkButton);
            this.Controls.Add(this.nextChunkButton);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.rendererComboBox);
            this.Controls.Add(this.rendererLabel);
            this.Controls.Add(this.outFolderLabel);
            this.Controls.Add(this.blendFileLabel);
            this.Controls.Add(this.endFrameLabel);
            this.Controls.Add(this.startFrameLabel);
            this.Controls.Add(this.endFrameNumericUpDown);
            this.Controls.Add(this.outFolderPathTextBox);
            this.Controls.Add(this.startFrameNumericUpDown);
            this.Controls.Add(this.blendFilePathTextBox);
            this.Controls.Add(this.outFolderBrowseButton);
            this.Controls.Add(this.renderProgressBar);
            this.Controls.Add(this.blendFileBrowseButton);
            this.Controls.Add(this.renderButton);
            this.MinimumSize = new System.Drawing.Size(480, 280);
            this.Name = "MainForm";
            this.Text = "Blender Render Controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startFrameNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endFrameNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.Button blendFileBrowseButton;
        private System.Windows.Forms.ProgressBar renderProgressBar;
        private System.Windows.Forms.TextBox blendFilePathTextBox;
        private System.Windows.Forms.NumericUpDown startFrameNumericUpDown;
        private System.Windows.Forms.NumericUpDown endFrameNumericUpDown;
        private System.Windows.Forms.Label startFrameLabel;
        private System.Windows.Forms.Label endFrameLabel;
        private System.Windows.Forms.Label blendFileLabel;
        private System.Windows.Forms.Button outFolderBrowseButton;
        private System.Windows.Forms.TextBox outFolderPathTextBox;
        private System.Windows.Forms.Label outFolderLabel;
        private System.Windows.Forms.Label rendererLabel;
        private System.Windows.Forms.ComboBox rendererComboBox;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button nextChunkButton;
        private System.Windows.Forms.Button prevChunkButton;
    }
}

