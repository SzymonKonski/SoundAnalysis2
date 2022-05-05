using System.Globalization;
using NAudio.Wave;
using OxyPlot;
using SoundAnalysis2.Calculators;
using SoundAnalysis2.Libraries;

namespace SoundAnalysis2
{
    public partial class Form1 : Form
    {
        private int bandEnd = 100;
        private int bandStart;
        private double frameOverlapping = 0.5;
        private  int millisecondsPerFrame = 20;
        private DataPoint[] discreteSignal;
        private double sampleRate;
        private int samplesPerFrame;
        private double selectedFrameStartTime;
        private TabPage selectedTabPage = TabPage.Fourier;
        private FourierTransformScope selectedFourierTransformScope = FourierTransformScope.WholeClip;
        private WindowType selectedWindowType = WindowType.Rectangular;
        private readonly Dictionary<TabPage, bool> shouldReDrawChart;


        public Form1()
        {
            InitializeComponent();

            shouldReDrawChart = new Dictionary<TabPage, bool>
            {
                {TabPage.Fourier, true},
                {TabPage.Spectrum, true},
                {TabPage.SoundFrequencyParameters, true}
            };

            windowTypeComboBox.SelectedIndex = 0;
            mpfTextBox.Text = millisecondsPerFrame.ToString();
        }

        private void LoadFile(string filePath)
        {
            using var reader = new AudioFileReader(filePath);
            var lengthInBytes = reader.Length;
            var lengthInSamples = (int)lengthInBytes / 4;
            var wholeFile = new List<float>(lengthInSamples);
            var buffer = new float[reader.WaveFormat.SampleRate * reader.WaveFormat.Channels];
            int samplesRead;
            while ((samplesRead = reader.Read(buffer, 0, buffer.Length)) > 0)
                wholeFile.AddRange(buffer.Take(samplesRead));

            var fileName = Path.GetFileName(filePath);
            discreteSignal = new DataPoint[wholeFile.Count];
            sampleRate = reader.WaveFormat.SampleRate;
            samplesPerFrame = millisecondsPerFrame * reader.WaveFormat.SampleRate / 1000;
            for (var i = 0; i < wholeFile.Count; i++)
            {
                var timeInSeconds = i / sampleRate;
                discreteSignal[i] = new DataPoint(timeInSeconds, wholeFile[i]);
            }

            recordingPlotView.Model = PlotLibrary.UpdateWaveformPlot(discreteSignal, "Time [s]", "", fileName);
        }

        private void UpdateFrequencyParameters()
        {
            UpdateParameter(FrameParameterType.FrequencyVolume, freqVolumeValueLabel, freqVolumePlotView);
            UpdateParameter(FrameParameterType.FrequencyCentroid, fcValueLabel, fcPlotView);
            UpdateParameter(FrameParameterType.EffectiveBandwidth, bwValueLabel, bwPlotView);
            UpdateParameter(FrameParameterType.BandEnergy, beValueLabel, bePlotView);
        }

        private void UpdateParameter(FrameParameterType parameter, Label label, OxyPlot.WindowsForms.PlotView chart)
        {
            var (value, valueInFrames) = FrequencyParametersCalculator.CalculateFrameLevelParameter(parameter, discreteSignal, samplesPerFrame, selectedWindowType, sampleRate, bandStart, bandEnd);

            label.Text = value.ToString("0.000");
            var resultPoints = new DataPoint[valueInFrames.Length];
            var frameCenter = -samplesPerFrame / 2;
            var samplesInLastFrame = discreteSignal.Length % samplesPerFrame;

            for (var i = 0; i < valueInFrames.Length; i++)
            {
                if (i == valueInFrames.Length - 1)
                    frameCenter += (samplesPerFrame + samplesInLastFrame) / 2;
                else
                    frameCenter += samplesPerFrame;

                var timeInSeconds = frameCenter / sampleRate;
                resultPoints[i] = new DataPoint(timeInSeconds, valueInFrames[i]);
            }

            chart.Model = PlotLibrary.UpdateFrameLevelChart(resultPoints);
        }

        private void UpdateAnalysisResults(TabPage tabPage)
        {
            switch (tabPage)
            {
                case TabPage.Fourier:
                    UpdateFourierTransform();
                    break;
                case TabPage.Spectrum:
                    UpdateSpectrum();
                    break;
                case TabPage.SoundFrequencyParameters:
                    UpdateFrequencyParameters();
                    break;
            }

            shouldReDrawChart[tabPage] = false;
        }

        private void UpdateFourierTransform()
        {
            var fourierResult = selectedFourierTransformScope switch
            {
                FourierTransformScope.WholeClip => FourierHelpers.CalculateFourierTransform(discreteSignal, sampleRate,
                    selectedWindowType),
                FourierTransformScope.OneFrame => FourierHelpers.CalculateFourierTransform(discreteSignal, sampleRate,
                    selectedWindowType, samplesPerFrame, (int) (sampleRate * selectedFrameStartTime)),
                _ => new DataPoint[1]
            };

            fourierPlotView.Model = PlotLibrary.UpdateWaveformPlot(fourierResult, "Frequency [Hz]", "Magnitude", "Fourier Transform");
        }

        private void UpdateSpectrum()
        {
            var transformResult = SpectrogramCalculator.CalculateSpectrogram(discreteSignal, selectedWindowType, samplesPerFrame, frameOverlapping);
            spectrogramPlotView.Model = PlotLibrary.UpdateSpectrogram(transformResult, discreteSignal.Last().X, sampleRate);
        }


        #region Form functions

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "\\.";
            openFileDialog.Filter = @"Wave form audio format (*.wav)|*.wav|MP3 audio file (*.mp3)|*.mp3";

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var filePath = openFileDialog.FileName;
            LoadFile(filePath);
            UpdateAnalysisResults(selectedTabPage);
        }

        private void mpfButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(mpfTextBox.Text, out millisecondsPerFrame)) return;
            samplesPerFrame = millisecondsPerFrame * (int)sampleRate / 1000;

            foreach (var pageType in shouldReDrawChart.Keys.ToList())
                shouldReDrawChart[pageType] = true;

            if (discreteSignal != null && discreteSignal.Length != 0)
                UpdateAnalysisResults(selectedTabPage);
        }

        private void windowTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWindowType = (WindowType)windowTypeComboBox.SelectedIndex;

            shouldReDrawChart[TabPage.Fourier] = true;
            shouldReDrawChart[TabPage.Spectrum] = true;
            shouldReDrawChart[TabPage.SoundFrequencyParameters] = true;

            if (discreteSignal != null && discreteSignal.Length != 0)
                UpdateAnalysisResults(selectedTabPage);
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            windowTypeComboBox.SelectedItem = selectedWindowType;
            selectedTabPage = (TabPage)mainTabControl.SelectedIndex;
            if (discreteSignal != null && discreteSignal.Length != 0 && shouldReDrawChart[selectedTabPage])
                UpdateAnalysisResults(selectedTabPage);
        }

        private void wholeClipRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedFourierTransformScope = FourierTransformScope.WholeClip;
            frameStartTextBox.Enabled = false;
            shouldReDrawChart[TabPage.Fourier] = true;
            if (discreteSignal != null && discreteSignal.Length != 0)
                UpdateAnalysisResults(TabPage.Fourier);
        }

        private void oneFrameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedFourierTransformScope = FourierTransformScope.OneFrame;
            frameStartTextBox.Enabled = true;
            shouldReDrawChart[TabPage.Fourier] = true;
            if (discreteSignal != null && discreteSignal.Length != 0)
                UpdateAnalysisResults(TabPage.Fourier);
        }

        private void frameStartTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(frameStartTextBox.Text, out selectedFrameStartTime) && selectedFrameStartTime >= 0)
            {
                if (selectedFrameStartTime > (discreteSignal.Length - samplesPerFrame) / sampleRate)
                {
                    selectedFrameStartTime = (discreteSignal.Length - samplesPerFrame) / sampleRate;
                    frameStartTextBox.Text = selectedFrameStartTime.ToString("N3");
                }

                shouldReDrawChart[TabPage.Fourier] = true;
                if (discreteSignal != null && discreteSignal.Length != 0)
                    UpdateAnalysisResults(TabPage.Fourier);
            }
            else
            {
                frameStartTextBox.Text = selectedFrameStartTime.ToString("N3");
            }
        }

        private void applyBandButton_Click(object sender, EventArgs e)
        {
            var oldStart = bandStart;
            var oldEnd = bandEnd;

            bandStart = (int)bandStartNumeric.Value;
            bandEnd = (int)bandEndNumeric.Value;

            if (oldStart == bandStart && oldEnd == bandEnd) return;

            shouldReDrawChart[TabPage.SoundFrequencyParameters] = true;
            if (discreteSignal != null && discreteSignal.Length != 0)
            {
                UpdateParameter(FrameParameterType.BandEnergy, beValueLabel, bePlotView);
            }
        }

        private void frameOverlappingTrackBar_ValueChanged(object sender, EventArgs e)
        {
            frameOverlappingTrackBar.Value = frameOverlappingTrackBar.Value;
            frameOverlapping = frameOverlappingTrackBar.Value / 100.0;
            frameOverlappingValueLabel.Text = frameOverlapping.ToString(CultureInfo.InvariantCulture);
            shouldReDrawChart[TabPage.Spectrum] = true;
            if (discreteSignal != null && discreteSignal.Length != 0)
                UpdateAnalysisResults(selectedTabPage);
        }

        #endregion
    }
}