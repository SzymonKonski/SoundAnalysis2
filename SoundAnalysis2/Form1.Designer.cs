namespace SoundAnalysis2
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.recordingPlotView = new OxyPlot.WindowsForms.PlotView();
            this.mpfGroupBox = new System.Windows.Forms.GroupBox();
            this.mpfButton = new System.Windows.Forms.Button();
            this.mpfTextBox = new System.Windows.Forms.TextBox();
            this.windowTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.windowTypeComboBox = new System.Windows.Forms.ComboBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.fourierTransformTabPage = new System.Windows.Forms.TabPage();
            this.fourierTransformTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fourierPlotView = new OxyPlot.WindowsForms.PlotView();
            this.fourierTransformScopePanel = new System.Windows.Forms.Panel();
            this.oneFrameRadioButton = new System.Windows.Forms.RadioButton();
            this.wholeClipRadioButton = new System.Windows.Forms.RadioButton();
            this.fourierFrameTimePanel = new System.Windows.Forms.Panel();
            this.frameStartTextBox = new System.Windows.Forms.TextBox();
            this.frameStartLabel = new System.Windows.Forms.Label();
            this.spectrumTabPage = new System.Windows.Forms.TabPage();
            this.spectrumTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.spectrogramPlotView = new OxyPlot.WindowsForms.PlotView();
            this.frameOverlappingPanel = new System.Windows.Forms.Panel();
            this.frameOverlappingLabel = new System.Windows.Forms.Label();
            this.frameOverlappingTrackBar = new System.Windows.Forms.TrackBar();
            this.frequencyParamsTabPage = new System.Windows.Forms.TabPage();
            this.freqParamsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bandStartPanel = new System.Windows.Forms.Panel();
            this.bandStartNumeric = new System.Windows.Forms.NumericUpDown();
            this.bandStartLabel = new System.Windows.Forms.Label();
            this.bandEndPanel = new System.Windows.Forms.Panel();
            this.bandEndNumeric = new System.Windows.Forms.NumericUpDown();
            this.bandEndLabel = new System.Windows.Forms.Label();
            this.freqParamsChartsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.frequencyParamsLabelsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.beValueLabel = new System.Windows.Forms.Label();
            this.bwValueLabel = new System.Windows.Forms.Label();
            this.fcValueLabel = new System.Windows.Forms.Label();
            this.freqVolumeLabel = new System.Windows.Forms.Label();
            this.fcLabel = new System.Windows.Forms.Label();
            this.bwLabel = new System.Windows.Forms.Label();
            this.beLabel = new System.Windows.Forms.Label();
            this.freqVolumeValueLabel = new System.Windows.Forms.Label();
            this.frequencyParamsChartsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.freqVolumePlotView = new OxyPlot.WindowsForms.PlotView();
            this.fcPlotView = new OxyPlot.WindowsForms.PlotView();
            this.bwPlotView = new OxyPlot.WindowsForms.PlotView();
            this.bePlotView = new OxyPlot.WindowsForms.PlotView();
            this.applyBandButton = new System.Windows.Forms.Button();
            this.frameOverlappingValueLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            this.mpfGroupBox.SuspendLayout();
            this.windowTypeGroupBox.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.fourierTransformTabPage.SuspendLayout();
            this.fourierTransformTableLayoutPanel.SuspendLayout();
            this.fourierTransformScopePanel.SuspendLayout();
            this.fourierFrameTimePanel.SuspendLayout();
            this.spectrumTabPage.SuspendLayout();
            this.spectrumTableLayoutPanel.SuspendLayout();
            this.frameOverlappingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameOverlappingTrackBar)).BeginInit();
            this.frequencyParamsTabPage.SuspendLayout();
            this.freqParamsTableLayoutPanel.SuspendLayout();
            this.bandStartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandStartNumeric)).BeginInit();
            this.bandEndPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandEndNumeric)).BeginInit();
            this.freqParamsChartsTableLayoutPanel.SuspendLayout();
            this.frequencyParamsLabelsTableLayoutPanel.SuspendLayout();
            this.frequencyParamsChartsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.mainLayoutPanel.Controls.Add(this.recordingPlotView, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.mpfGroupBox, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.windowTypeGroupBox, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.mainTabControl, 0, 2);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.992006F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.38089F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.6271F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(1350, 705);
            this.mainLayoutPanel.TabIndex = 2;
            // 
            // recordingPlotView
            // 
            this.recordingPlotView.BackColor = System.Drawing.Color.White;
            this.recordingPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordingPlotView.Location = new System.Drawing.Point(273, 3);
            this.recordingPlotView.Name = "recordingPlotView";
            this.recordingPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.mainLayoutPanel.SetRowSpan(this.recordingPlotView, 2);
            this.recordingPlotView.Size = new System.Drawing.Size(1074, 144);
            this.recordingPlotView.TabIndex = 0;
            this.recordingPlotView.Text = "recordingPlotView";
            this.recordingPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.recordingPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.recordingPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // mpfGroupBox
            // 
            this.mpfGroupBox.Controls.Add(this.mpfButton);
            this.mpfGroupBox.Controls.Add(this.mpfTextBox);
            this.mpfGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpfGroupBox.Location = new System.Drawing.Point(3, 3);
            this.mpfGroupBox.Name = "mpfGroupBox";
            this.mpfGroupBox.Size = new System.Drawing.Size(264, 64);
            this.mpfGroupBox.TabIndex = 1;
            this.mpfGroupBox.TabStop = false;
            this.mpfGroupBox.Text = "Miliseconds per frame";
            // 
            // mpfButton
            // 
            this.mpfButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mpfButton.Location = new System.Drawing.Point(153, 25);
            this.mpfButton.Name = "mpfButton";
            this.mpfButton.Size = new System.Drawing.Size(75, 23);
            this.mpfButton.TabIndex = 1;
            this.mpfButton.Text = "Apply";
            this.mpfButton.UseVisualStyleBackColor = true;
            this.mpfButton.Click += new System.EventHandler(this.mpfButton_Click);
            // 
            // mpfTextBox
            // 
            this.mpfTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mpfTextBox.Location = new System.Drawing.Point(17, 25);
            this.mpfTextBox.Name = "mpfTextBox";
            this.mpfTextBox.Size = new System.Drawing.Size(100, 23);
            this.mpfTextBox.TabIndex = 0;
            // 
            // windowTypeGroupBox
            // 
            this.windowTypeGroupBox.Controls.Add(this.windowTypeComboBox);
            this.windowTypeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowTypeGroupBox.Location = new System.Drawing.Point(3, 73);
            this.windowTypeGroupBox.Name = "windowTypeGroupBox";
            this.windowTypeGroupBox.Size = new System.Drawing.Size(264, 74);
            this.windowTypeGroupBox.TabIndex = 2;
            this.windowTypeGroupBox.TabStop = false;
            this.windowTypeGroupBox.Text = "Window type";
            // 
            // windowTypeComboBox
            // 
            this.windowTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.windowTypeComboBox.FormattingEnabled = true;
            this.windowTypeComboBox.Items.AddRange(new object[] {
            "Rectangular",
            "Hamming",
            "Hann"});
            this.windowTypeComboBox.Location = new System.Drawing.Point(69, 29);
            this.windowTypeComboBox.Name = "windowTypeComboBox";
            this.windowTypeComboBox.Size = new System.Drawing.Size(144, 23);
            this.windowTypeComboBox.TabIndex = 0;
            this.windowTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.windowTypeComboBox_SelectedIndexChanged);
            // 
            // mainTabControl
            // 
            this.mainLayoutPanel.SetColumnSpan(this.mainTabControl, 2);
            this.mainTabControl.Controls.Add(this.fourierTransformTabPage);
            this.mainTabControl.Controls.Add(this.spectrumTabPage);
            this.mainTabControl.Controls.Add(this.frequencyParamsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(3, 153);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(0, 0);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1344, 549);
            this.mainTabControl.TabIndex = 3;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // fourierTransformTabPage
            // 
            this.fourierTransformTabPage.Controls.Add(this.fourierTransformTableLayoutPanel);
            this.fourierTransformTabPage.Location = new System.Drawing.Point(4, 24);
            this.fourierTransformTabPage.Name = "fourierTransformTabPage";
            this.fourierTransformTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fourierTransformTabPage.Size = new System.Drawing.Size(1336, 521);
            this.fourierTransformTabPage.TabIndex = 0;
            this.fourierTransformTabPage.Text = "Fourier Transform";
            this.fourierTransformTabPage.UseVisualStyleBackColor = true;
            // 
            // fourierTransformTableLayoutPanel
            // 
            this.fourierTransformTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.fourierTransformTableLayoutPanel.ColumnCount = 2;
            this.fourierTransformTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fourierTransformTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fourierTransformTableLayoutPanel.Controls.Add(this.fourierPlotView, 0, 1);
            this.fourierTransformTableLayoutPanel.Controls.Add(this.fourierTransformScopePanel, 0, 0);
            this.fourierTransformTableLayoutPanel.Controls.Add(this.fourierFrameTimePanel, 1, 0);
            this.fourierTransformTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourierTransformTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.fourierTransformTableLayoutPanel.Name = "fourierTransformTableLayoutPanel";
            this.fourierTransformTableLayoutPanel.RowCount = 2;
            this.fourierTransformTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.fourierTransformTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fourierTransformTableLayoutPanel.Size = new System.Drawing.Size(1330, 515);
            this.fourierTransformTableLayoutPanel.TabIndex = 0;
            // 
            // fourierPlotView
            // 
            this.fourierPlotView.BackColor = System.Drawing.Color.White;
            this.fourierTransformTableLayoutPanel.SetColumnSpan(this.fourierPlotView, 2);
            this.fourierPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourierPlotView.Location = new System.Drawing.Point(3, 33);
            this.fourierPlotView.Name = "fourierPlotView";
            this.fourierPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.fourierPlotView.Size = new System.Drawing.Size(1324, 479);
            this.fourierPlotView.TabIndex = 0;
            this.fourierPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.fourierPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.fourierPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // fourierTransformScopePanel
            // 
            this.fourierTransformScopePanel.Controls.Add(this.oneFrameRadioButton);
            this.fourierTransformScopePanel.Controls.Add(this.wholeClipRadioButton);
            this.fourierTransformScopePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourierTransformScopePanel.Location = new System.Drawing.Point(3, 3);
            this.fourierTransformScopePanel.Name = "fourierTransformScopePanel";
            this.fourierTransformScopePanel.Size = new System.Drawing.Size(659, 24);
            this.fourierTransformScopePanel.TabIndex = 1;
            // 
            // oneFrameRadioButton
            // 
            this.oneFrameRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.oneFrameRadioButton.AutoSize = true;
            this.oneFrameRadioButton.Location = new System.Drawing.Point(171, 2);
            this.oneFrameRadioButton.Name = "oneFrameRadioButton";
            this.oneFrameRadioButton.Size = new System.Drawing.Size(83, 19);
            this.oneFrameRadioButton.TabIndex = 1;
            this.oneFrameRadioButton.TabStop = true;
            this.oneFrameRadioButton.Text = "One Frame";
            this.oneFrameRadioButton.UseVisualStyleBackColor = true;
            this.oneFrameRadioButton.CheckedChanged += new System.EventHandler(this.oneFrameRadioButton_CheckedChanged);
            // 
            // wholeClipRadioButton
            // 
            this.wholeClipRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wholeClipRadioButton.AutoSize = true;
            this.wholeClipRadioButton.Checked = true;
            this.wholeClipRadioButton.Location = new System.Drawing.Point(26, 3);
            this.wholeClipRadioButton.Name = "wholeClipRadioButton";
            this.wholeClipRadioButton.Size = new System.Drawing.Size(83, 19);
            this.wholeClipRadioButton.TabIndex = 0;
            this.wholeClipRadioButton.TabStop = true;
            this.wholeClipRadioButton.Text = "Whole Clip";
            this.wholeClipRadioButton.UseVisualStyleBackColor = true;
            this.wholeClipRadioButton.CheckedChanged += new System.EventHandler(this.wholeClipRadioButton_CheckedChanged);
            // 
            // fourierFrameTimePanel
            // 
            this.fourierFrameTimePanel.Controls.Add(this.frameStartTextBox);
            this.fourierFrameTimePanel.Controls.Add(this.frameStartLabel);
            this.fourierFrameTimePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourierFrameTimePanel.Location = new System.Drawing.Point(668, 3);
            this.fourierFrameTimePanel.Name = "fourierFrameTimePanel";
            this.fourierFrameTimePanel.Size = new System.Drawing.Size(659, 24);
            this.fourierFrameTimePanel.TabIndex = 2;
            // 
            // frameStartTextBox
            // 
            this.frameStartTextBox.Enabled = false;
            this.frameStartTextBox.Location = new System.Drawing.Point(208, 0);
            this.frameStartTextBox.Name = "frameStartTextBox";
            this.frameStartTextBox.Size = new System.Drawing.Size(100, 23);
            this.frameStartTextBox.TabIndex = 1;
            this.frameStartTextBox.Text = "0";
            this.frameStartTextBox.TextChanged += new System.EventHandler(this.frameStartTextBox_TextChanged);
            // 
            // frameStartLabel
            // 
            this.frameStartLabel.AutoSize = true;
            this.frameStartLabel.Location = new System.Drawing.Point(44, 5);
            this.frameStartLabel.Name = "frameStartLabel";
            this.frameStartLabel.Size = new System.Drawing.Size(137, 15);
            this.frameStartLabel.TabIndex = 0;
            this.frameStartLabel.Text = "Frame Start (in seconds):";
            // 
            // spectrumTabPage
            // 
            this.spectrumTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.spectrumTabPage.Controls.Add(this.spectrumTableLayoutPanel);
            this.spectrumTabPage.Location = new System.Drawing.Point(4, 24);
            this.spectrumTabPage.Name = "spectrumTabPage";
            this.spectrumTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.spectrumTabPage.Size = new System.Drawing.Size(1336, 521);
            this.spectrumTabPage.TabIndex = 1;
            this.spectrumTabPage.Text = "Spectrum";
            // 
            // spectrumTableLayoutPanel
            // 
            this.spectrumTableLayoutPanel.CausesValidation = false;
            this.spectrumTableLayoutPanel.ColumnCount = 2;
            this.spectrumTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.50376F));
            this.spectrumTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.49624F));
            this.spectrumTableLayoutPanel.Controls.Add(this.spectrogramPlotView, 0, 1);
            this.spectrumTableLayoutPanel.Controls.Add(this.frameOverlappingPanel, 0, 0);
            this.spectrumTableLayoutPanel.Controls.Add(this.frameOverlappingTrackBar, 1, 0);
            this.spectrumTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spectrumTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.spectrumTableLayoutPanel.Name = "spectrumTableLayoutPanel";
            this.spectrumTableLayoutPanel.RowCount = 2;
            this.spectrumTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.spectrumTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.spectrumTableLayoutPanel.Size = new System.Drawing.Size(1330, 515);
            this.spectrumTableLayoutPanel.TabIndex = 0;
            // 
            // spectrogramPlotView
            // 
            this.spectrogramPlotView.BackColor = System.Drawing.Color.White;
            this.spectrumTableLayoutPanel.SetColumnSpan(this.spectrogramPlotView, 2);
            this.spectrogramPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spectrogramPlotView.Location = new System.Drawing.Point(3, 33);
            this.spectrogramPlotView.Name = "spectrogramPlotView";
            this.spectrogramPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.spectrogramPlotView.Size = new System.Drawing.Size(1324, 479);
            this.spectrogramPlotView.TabIndex = 0;
            this.spectrogramPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.spectrogramPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.spectrogramPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // frameOverlappingPanel
            // 
            this.frameOverlappingPanel.Controls.Add(this.frameOverlappingValueLabel);
            this.frameOverlappingPanel.Controls.Add(this.frameOverlappingLabel);
            this.frameOverlappingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameOverlappingPanel.Location = new System.Drawing.Point(3, 3);
            this.frameOverlappingPanel.Name = "frameOverlappingPanel";
            this.frameOverlappingPanel.Size = new System.Drawing.Size(147, 24);
            this.frameOverlappingPanel.TabIndex = 1;
            // 
            // frameOverlappingLabel
            // 
            this.frameOverlappingLabel.AutoSize = true;
            this.frameOverlappingLabel.Location = new System.Drawing.Point(8, 4);
            this.frameOverlappingLabel.Name = "frameOverlappingLabel";
            this.frameOverlappingLabel.Size = new System.Drawing.Size(109, 15);
            this.frameOverlappingLabel.TabIndex = 0;
            this.frameOverlappingLabel.Text = "Frame overlapping:";
            // 
            // frameOverlappingTrackBar
            // 
            this.frameOverlappingTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameOverlappingTrackBar.LargeChange = 10;
            this.frameOverlappingTrackBar.Location = new System.Drawing.Point(156, 3);
            this.frameOverlappingTrackBar.Maximum = 99;
            this.frameOverlappingTrackBar.Name = "frameOverlappingTrackBar";
            this.frameOverlappingTrackBar.Size = new System.Drawing.Size(1171, 24);
            this.frameOverlappingTrackBar.SmallChange = 5;
            this.frameOverlappingTrackBar.TabIndex = 2;
            this.frameOverlappingTrackBar.Value = 50;
            this.frameOverlappingTrackBar.ValueChanged += new System.EventHandler(this.frameOverlappingTrackBar_ValueChanged);
            // 
            // frequencyParamsTabPage
            // 
            this.frequencyParamsTabPage.Controls.Add(this.freqParamsTableLayoutPanel);
            this.frequencyParamsTabPage.Location = new System.Drawing.Point(4, 24);
            this.frequencyParamsTabPage.Name = "frequencyParamsTabPage";
            this.frequencyParamsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.frequencyParamsTabPage.Size = new System.Drawing.Size(1336, 521);
            this.frequencyParamsTabPage.TabIndex = 2;
            this.frequencyParamsTabPage.Text = "Frequency Parameters";
            // 
            // freqParamsTableLayoutPanel
            // 
            this.freqParamsTableLayoutPanel.ColumnCount = 2;
            this.freqParamsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.freqParamsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.freqParamsTableLayoutPanel.Controls.Add(this.bandStartPanel, 0, 0);
            this.freqParamsTableLayoutPanel.Controls.Add(this.bandEndPanel, 1, 0);
            this.freqParamsTableLayoutPanel.Controls.Add(this.freqParamsChartsTableLayoutPanel, 0, 1);
            this.freqParamsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freqParamsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.freqParamsTableLayoutPanel.Name = "freqParamsTableLayoutPanel";
            this.freqParamsTableLayoutPanel.RowCount = 2;
            this.freqParamsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.freqParamsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.freqParamsTableLayoutPanel.Size = new System.Drawing.Size(1330, 515);
            this.freqParamsTableLayoutPanel.TabIndex = 0;
            // 
            // bandStartPanel
            // 
            this.bandStartPanel.Controls.Add(this.bandStartNumeric);
            this.bandStartPanel.Controls.Add(this.bandStartLabel);
            this.bandStartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandStartPanel.Location = new System.Drawing.Point(3, 3);
            this.bandStartPanel.Name = "bandStartPanel";
            this.bandStartPanel.Size = new System.Drawing.Size(659, 24);
            this.bandStartPanel.TabIndex = 0;
            // 
            // bandStartNumeric
            // 
            this.bandStartNumeric.Location = new System.Drawing.Point(239, 1);
            this.bandStartNumeric.Name = "bandStartNumeric";
            this.bandStartNumeric.Size = new System.Drawing.Size(120, 23);
            this.bandStartNumeric.TabIndex = 1;
            // 
            // bandStartLabel
            // 
            this.bandStartLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bandStartLabel.AutoSize = true;
            this.bandStartLabel.Location = new System.Drawing.Point(121, 4);
            this.bandStartLabel.Name = "bandStartLabel";
            this.bandStartLabel.Size = new System.Drawing.Size(110, 15);
            this.bandStartLabel.TabIndex = 0;
            this.bandStartLabel.Text = "Band Start (in herz):";
            // 
            // bandEndPanel
            // 
            this.bandEndPanel.Controls.Add(this.applyBandButton);
            this.bandEndPanel.Controls.Add(this.bandEndNumeric);
            this.bandEndPanel.Controls.Add(this.bandEndLabel);
            this.bandEndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandEndPanel.Location = new System.Drawing.Point(668, 3);
            this.bandEndPanel.Name = "bandEndPanel";
            this.bandEndPanel.Size = new System.Drawing.Size(659, 24);
            this.bandEndPanel.TabIndex = 1;
            // 
            // bandEndNumeric
            // 
            this.bandEndNumeric.Location = new System.Drawing.Point(127, 0);
            this.bandEndNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bandEndNumeric.Name = "bandEndNumeric";
            this.bandEndNumeric.Size = new System.Drawing.Size(120, 23);
            this.bandEndNumeric.TabIndex = 1;
            this.bandEndNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // bandEndLabel
            // 
            this.bandEndLabel.AutoSize = true;
            this.bandEndLabel.Location = new System.Drawing.Point(16, 3);
            this.bandEndLabel.Name = "bandEndLabel";
            this.bandEndLabel.Size = new System.Drawing.Size(106, 15);
            this.bandEndLabel.TabIndex = 0;
            this.bandEndLabel.Text = "Band End (in herz):";
            // 
            // freqParamsChartsTableLayoutPanel
            // 
            this.freqParamsChartsTableLayoutPanel.ColumnCount = 2;
            this.freqParamsTableLayoutPanel.SetColumnSpan(this.freqParamsChartsTableLayoutPanel, 2);
            this.freqParamsChartsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.27F));
            this.freqParamsChartsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.73F));
            this.freqParamsChartsTableLayoutPanel.Controls.Add(this.frequencyParamsLabelsTableLayoutPanel, 0, 0);
            this.freqParamsChartsTableLayoutPanel.Controls.Add(this.frequencyParamsChartsTableLayoutPanel, 1, 0);
            this.freqParamsChartsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freqParamsChartsTableLayoutPanel.Location = new System.Drawing.Point(3, 33);
            this.freqParamsChartsTableLayoutPanel.Name = "freqParamsChartsTableLayoutPanel";
            this.freqParamsChartsTableLayoutPanel.RowCount = 1;
            this.freqParamsChartsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.freqParamsChartsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.freqParamsChartsTableLayoutPanel.Size = new System.Drawing.Size(1324, 479);
            this.freqParamsChartsTableLayoutPanel.TabIndex = 2;
            // 
            // frequencyParamsLabelsTableLayoutPanel
            // 
            this.frequencyParamsLabelsTableLayoutPanel.ColumnCount = 2;
            this.frequencyParamsLabelsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.frequencyParamsLabelsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.beValueLabel, 1, 3);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.bwValueLabel, 1, 2);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.fcValueLabel, 1, 1);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.freqVolumeLabel, 0, 0);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.fcLabel, 0, 1);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.bwLabel, 0, 2);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.beLabel, 0, 3);
            this.frequencyParamsLabelsTableLayoutPanel.Controls.Add(this.freqVolumeValueLabel, 1, 0);
            this.frequencyParamsLabelsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyParamsLabelsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.frequencyParamsLabelsTableLayoutPanel.Name = "frequencyParamsLabelsTableLayoutPanel";
            this.frequencyParamsLabelsTableLayoutPanel.RowCount = 4;
            this.frequencyParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsLabelsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsLabelsTableLayoutPanel.Size = new System.Drawing.Size(262, 473);
            this.frequencyParamsLabelsTableLayoutPanel.TabIndex = 0;
            // 
            // beValueLabel
            // 
            this.beValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.beValueLabel.AutoSize = true;
            this.beValueLabel.Location = new System.Drawing.Point(186, 406);
            this.beValueLabel.Name = "beValueLabel";
            this.beValueLabel.Size = new System.Drawing.Size(13, 15);
            this.beValueLabel.TabIndex = 7;
            this.beValueLabel.Text = "0";
            // 
            // bwValueLabel
            // 
            this.bwValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bwValueLabel.AutoSize = true;
            this.bwValueLabel.Location = new System.Drawing.Point(186, 287);
            this.bwValueLabel.Name = "bwValueLabel";
            this.bwValueLabel.Size = new System.Drawing.Size(13, 15);
            this.bwValueLabel.TabIndex = 6;
            this.bwValueLabel.Text = "0";
            // 
            // fcValueLabel
            // 
            this.fcValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fcValueLabel.AutoSize = true;
            this.fcValueLabel.Location = new System.Drawing.Point(186, 169);
            this.fcValueLabel.Name = "fcValueLabel";
            this.fcValueLabel.Size = new System.Drawing.Size(13, 15);
            this.fcValueLabel.TabIndex = 5;
            this.fcValueLabel.Text = "0";
            // 
            // freqVolumeLabel
            // 
            this.freqVolumeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.freqVolumeLabel.AutoSize = true;
            this.freqVolumeLabel.Location = new System.Drawing.Point(130, 51);
            this.freqVolumeLabel.Name = "freqVolumeLabel";
            this.freqVolumeLabel.Size = new System.Drawing.Size(50, 15);
            this.freqVolumeLabel.TabIndex = 0;
            this.freqVolumeLabel.Text = "Volume:";
            // 
            // fcLabel
            // 
            this.fcLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fcLabel.AutoSize = true;
            this.fcLabel.Location = new System.Drawing.Point(41, 169);
            this.fcLabel.Name = "fcLabel";
            this.fcLabel.Size = new System.Drawing.Size(139, 15);
            this.fcLabel.TabIndex = 1;
            this.fcLabel.Text = "Frequency Centroid (FC):";
            // 
            // bwLabel
            // 
            this.bwLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bwLabel.AutoSize = true;
            this.bwLabel.Location = new System.Drawing.Point(36, 287);
            this.bwLabel.Name = "bwLabel";
            this.bwLabel.Size = new System.Drawing.Size(144, 15);
            this.bwLabel.TabIndex = 2;
            this.bwLabel.Text = "Effective Bandwidth (BW):";
            // 
            // beLabel
            // 
            this.beLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.beLabel.AutoSize = true;
            this.beLabel.Location = new System.Drawing.Point(80, 406);
            this.beLabel.Name = "beLabel";
            this.beLabel.Size = new System.Drawing.Size(100, 15);
            this.beLabel.TabIndex = 3;
            this.beLabel.Text = "Band Energy (BE):";
            // 
            // freqVolumeValueLabel
            // 
            this.freqVolumeValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.freqVolumeValueLabel.AutoSize = true;
            this.freqVolumeValueLabel.Location = new System.Drawing.Point(186, 51);
            this.freqVolumeValueLabel.Name = "freqVolumeValueLabel";
            this.freqVolumeValueLabel.Size = new System.Drawing.Size(13, 15);
            this.freqVolumeValueLabel.TabIndex = 4;
            this.freqVolumeValueLabel.Text = "0";
            // 
            // frequencyParamsChartsTableLayoutPanel
            // 
            this.frequencyParamsChartsTableLayoutPanel.ColumnCount = 1;
            this.frequencyParamsChartsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.frequencyParamsChartsTableLayoutPanel.Controls.Add(this.bePlotView, 0, 3);
            this.frequencyParamsChartsTableLayoutPanel.Controls.Add(this.bwPlotView, 0, 2);
            this.frequencyParamsChartsTableLayoutPanel.Controls.Add(this.fcPlotView, 0, 1);
            this.frequencyParamsChartsTableLayoutPanel.Controls.Add(this.freqVolumePlotView, 0, 0);
            this.frequencyParamsChartsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyParamsChartsTableLayoutPanel.Location = new System.Drawing.Point(271, 3);
            this.frequencyParamsChartsTableLayoutPanel.Name = "frequencyParamsChartsTableLayoutPanel";
            this.frequencyParamsChartsTableLayoutPanel.RowCount = 4;
            this.frequencyParamsChartsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsChartsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsChartsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsChartsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.frequencyParamsChartsTableLayoutPanel.Size = new System.Drawing.Size(1050, 473);
            this.frequencyParamsChartsTableLayoutPanel.TabIndex = 1;
            // 
            // freqVolumePlotView
            // 
            this.freqVolumePlotView.BackColor = System.Drawing.Color.White;
            this.freqVolumePlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freqVolumePlotView.Location = new System.Drawing.Point(3, 3);
            this.freqVolumePlotView.Name = "freqVolumePlotView";
            this.freqVolumePlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.freqVolumePlotView.Size = new System.Drawing.Size(1044, 112);
            this.freqVolumePlotView.TabIndex = 0;
            this.freqVolumePlotView.Text = "freqVolumePlotView";
            this.freqVolumePlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.freqVolumePlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.freqVolumePlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // fcPlotView
            // 
            this.fcPlotView.BackColor = System.Drawing.Color.White;
            this.fcPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcPlotView.Location = new System.Drawing.Point(3, 121);
            this.fcPlotView.Name = "fcPlotView";
            this.fcPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.fcPlotView.Size = new System.Drawing.Size(1044, 112);
            this.fcPlotView.TabIndex = 1;
            this.fcPlotView.Text = "plotView1";
            this.fcPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.fcPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.fcPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // bwPlotView
            // 
            this.bwPlotView.BackColor = System.Drawing.Color.White;
            this.bwPlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bwPlotView.Location = new System.Drawing.Point(3, 239);
            this.bwPlotView.Name = "bwPlotView";
            this.bwPlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.bwPlotView.Size = new System.Drawing.Size(1044, 112);
            this.bwPlotView.TabIndex = 2;
            this.bwPlotView.Text = "plotView2";
            this.bwPlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.bwPlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bwPlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // bePlotView
            // 
            this.bePlotView.BackColor = System.Drawing.Color.White;
            this.bePlotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bePlotView.Location = new System.Drawing.Point(3, 357);
            this.bePlotView.Name = "bePlotView";
            this.bePlotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.bePlotView.Size = new System.Drawing.Size(1044, 113);
            this.bePlotView.TabIndex = 3;
            this.bePlotView.Text = "plotView3";
            this.bePlotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.bePlotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bePlotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // applyBandButton
            // 
            this.applyBandButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.applyBandButton.Location = new System.Drawing.Point(327, -2);
            this.applyBandButton.Name = "applyBandButton";
            this.applyBandButton.Size = new System.Drawing.Size(75, 23);
            this.applyBandButton.TabIndex = 2;
            this.applyBandButton.Text = "Apply";
            this.applyBandButton.UseVisualStyleBackColor = true;
            this.applyBandButton.Click += new System.EventHandler(this.applyBandButton_Click);
            // 
            // frameOverlappingValueLabel
            // 
            this.frameOverlappingValueLabel.AutoSize = true;
            this.frameOverlappingValueLabel.Location = new System.Drawing.Point(122, 4);
            this.frameOverlappingValueLabel.Name = "frameOverlappingValueLabel";
            this.frameOverlappingValueLabel.Size = new System.Drawing.Size(22, 15);
            this.frameOverlappingValueLabel.TabIndex = 1;
            this.frameOverlappingValueLabel.Text = "0.5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.mainLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Sound analysis 2";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainLayoutPanel.ResumeLayout(false);
            this.mpfGroupBox.ResumeLayout(false);
            this.mpfGroupBox.PerformLayout();
            this.windowTypeGroupBox.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.fourierTransformTabPage.ResumeLayout(false);
            this.fourierTransformTableLayoutPanel.ResumeLayout(false);
            this.fourierTransformScopePanel.ResumeLayout(false);
            this.fourierTransformScopePanel.PerformLayout();
            this.fourierFrameTimePanel.ResumeLayout(false);
            this.fourierFrameTimePanel.PerformLayout();
            this.spectrumTabPage.ResumeLayout(false);
            this.spectrumTableLayoutPanel.ResumeLayout(false);
            this.spectrumTableLayoutPanel.PerformLayout();
            this.frameOverlappingPanel.ResumeLayout(false);
            this.frameOverlappingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameOverlappingTrackBar)).EndInit();
            this.frequencyParamsTabPage.ResumeLayout(false);
            this.freqParamsTableLayoutPanel.ResumeLayout(false);
            this.bandStartPanel.ResumeLayout(false);
            this.bandStartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandStartNumeric)).EndInit();
            this.bandEndPanel.ResumeLayout(false);
            this.bandEndPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandEndNumeric)).EndInit();
            this.freqParamsChartsTableLayoutPanel.ResumeLayout(false);
            this.frequencyParamsLabelsTableLayoutPanel.ResumeLayout(false);
            this.frequencyParamsLabelsTableLayoutPanel.PerformLayout();
            this.frequencyParamsChartsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private TableLayoutPanel mainLayoutPanel;
        private OxyPlot.WindowsForms.PlotView recordingPlotView;
        private GroupBox mpfGroupBox;
        private GroupBox windowTypeGroupBox;
        private ComboBox windowTypeComboBox;
        private TextBox mpfTextBox;
        private Button mpfButton;
        private TabControl mainTabControl;
        private TableLayoutPanel fourierTransformTableLayoutPanel;
        private OxyPlot.WindowsForms.PlotView fourierPlotView;
        private Panel fourierTransformScopePanel;
        private Panel fourierFrameTimePanel;
        private RadioButton wholeClipRadioButton;
        private RadioButton oneFrameRadioButton;
        private TextBox frameStartTextBox;
        private Label frameStartLabel;
        private TableLayoutPanel spectrumTableLayoutPanel;
        private OxyPlot.WindowsForms.PlotView spectrogramPlotView;
        private Panel frameOverlappingPanel;
        private Label frameOverlappingLabel;
        private TrackBar frameOverlappingTrackBar;
        private TableLayoutPanel freqParamsTableLayoutPanel;
        private Panel bandStartPanel;
        private NumericUpDown bandStartNumeric;
        private Label bandStartLabel;
        private Panel bandEndPanel;
        private NumericUpDown bandEndNumeric;
        private Label bandEndLabel;
        private TableLayoutPanel freqParamsChartsTableLayoutPanel;
        private System.Windows.Forms.TabPage fourierTransformTabPage;
        private System.Windows.Forms.TabPage spectrumTabPage;
        private System.Windows.Forms.TabPage frequencyParamsTabPage;
        private TableLayoutPanel frequencyParamsLabelsTableLayoutPanel;
        private Label freqVolumeLabel;
        private Label fcLabel;
        private Label bwLabel;
        private Label beLabel;
        private Label beValueLabel;
        private Label bwValueLabel;
        private Label fcValueLabel;
        private Label freqVolumeValueLabel;
        private TableLayoutPanel frequencyParamsChartsTableLayoutPanel;
        private OxyPlot.WindowsForms.PlotView bePlotView;
        private OxyPlot.WindowsForms.PlotView bwPlotView;
        private OxyPlot.WindowsForms.PlotView fcPlotView;
        private OxyPlot.WindowsForms.PlotView freqVolumePlotView;
        private Button applyBandButton;
        private Label frameOverlappingValueLabel;
    }
}