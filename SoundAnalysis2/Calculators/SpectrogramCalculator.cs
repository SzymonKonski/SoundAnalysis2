using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using OxyPlot;

namespace SoundAnalysis2.Calculators
{
    public static class SpectrogramCalculator
    {
        public static void CalculateSpectrogram(DataPoint[] discreteSignal, WindowType selectedWindowType, int samplesPerFrame, double frameOverlapping, out double[,] transformResult)
        {
            var samplesToTransform = GetSamplesForSpectrogram(discreteSignal, samplesPerFrame, frameOverlapping,
                selectedWindowType, out var rowCount, out var columnCount, out _);

            transformResult = new double[columnCount, rowCount / 2];

            for (var i = 0; i < samplesToTransform.Length; i++)
            {
                Fourier.Forward(samplesToTransform[i]);

                for (var j = 0; j < samplesToTransform[i].Length / 2; j++)
                    transformResult[i, j] = 10 * Math.Log10(samplesToTransform[i][j].MagnitudeSquared());
            }
        }

        private static Complex32[][] GetSamplesForSpectrogram(DataPoint[] discreteSignal, int samplesPerFrame, double frameOverlapping, WindowType selectedWindowType, out int rowCount, out int columnCount, out int frameOffset)
        {
            frameOffset = (int)((1 - frameOverlapping) * samplesPerFrame);
            if (frameOffset == 0)
                frameOffset = 1;

            rowCount = samplesPerFrame;
            columnCount = (discreteSignal.Length - samplesPerFrame) / frameOffset;

            var result = new Complex32[columnCount][];

            double[] window = null;
            switch (selectedWindowType)
            {
                case WindowType.Rectangular:
                    window = Window.Dirichlet(discreteSignal.Length);
                    break;
                case WindowType.Hamming:
                    window = Window.Hamming(discreteSignal.Length);
                    break;
                case WindowType.Hann:
                    window = Window.Hann(discreteSignal.Length);
                    break;
            }

            for (var i = 0; i < columnCount; i++)
            {
                result[i] = new Complex32[rowCount];

                for (var j = 0; j < rowCount; j++)
                {
                    int sampleIdx;
                    if ((sampleIdx = j + i * frameOffset) < discreteSignal.Length)
                        result[i][j] = (float)(discreteSignal[sampleIdx].Y * window[sampleIdx]);
                    else
                        result[i][j] = 0;
                }
            }

            return result;
        }
    }
}
