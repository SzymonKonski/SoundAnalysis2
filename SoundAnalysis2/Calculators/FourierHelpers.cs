using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using OxyPlot;

namespace SoundAnalysis2.Calculators
{
    public class FourierHelpers
    {
        public static DataPoint[] CalculateFourierTransform(DataPoint[] discreteSignal, double sampleRate, WindowType selectedWindowType, int samplesPerFrame = 1, int? selectedSampleIndex = null)
        {
            var samplesToTransform = new List<DataPoint>();
            Complex32[] transformData;
            int newSamplesCount;

            if (selectedSampleIndex != null)
            {
                if (selectedSampleIndex.Value + samplesPerFrame >= discreteSignal.Length)
                    selectedSampleIndex = discreteSignal.Length - samplesPerFrame - 1;

                for (var i = 0; i < samplesPerFrame; i++)
                    samplesToTransform.Add(discreteSignal[selectedSampleIndex.Value + i]);

                transformData = GetSamplesForFourier(samplesToTransform, selectedWindowType, out newSamplesCount);
            }
            else
            {
                transformData = GetSamplesForFourier(discreteSignal, selectedWindowType, out newSamplesCount);
            }

            var transformResult = new DataPoint[newSamplesCount / 2];
            Fourier.Forward(transformData);

            var herzPerSample = sampleRate / newSamplesCount;
            for (var i = 0; i < newSamplesCount / 2; i++)
            {
                transformResult[i] = new DataPoint(i * herzPerSample, Math.Log10(transformData[i].MagnitudeSquared()) + 10);
            }

            return transformResult;
        }

        private static Complex32[] GetSamplesForFourier(IEnumerable<DataPoint> samplesToTransform, WindowType selectedWindowType, out int newSamplesCount)
        {
            double[]? window = null;
            var toTransform = samplesToTransform.ToList();

            window = selectedWindowType switch
            {
                WindowType.Rectangular => Window.Dirichlet(toTransform.Count),
                WindowType.Hamming => Window.Hamming(toTransform.Count),
                WindowType.Hann => Window.Hann(toTransform.Count),
                _ => window
            };

            var closestPowerOfTwo = (int)Math.Ceiling(Math.Log(toTransform.Count, 2));
            newSamplesCount = (int)Math.Pow(2, closestPowerOfTwo);
            var transformData = new Complex32[newSamplesCount];

            for (var i = 0; i < toTransform.Count(); i++)
                transformData[i] = (float)(toTransform.ElementAt(i).Y * window[i]);

            return transformData;
        }

      
    }
}
