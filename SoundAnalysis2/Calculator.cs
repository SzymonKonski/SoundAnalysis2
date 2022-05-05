using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using OxyPlot;

namespace SoundAnalysis2
{
    public static class Calculator
    {
        public static (double, double[]) CalculateFrameLevelParameter(FrameParameterType parameter, DataPoint[] discreteSignal, int samplesPerFrame, WindowType selectedWindowType, double sampleRate, int bandStart, int bandEnd)
        {
            var framesCount = discreteSignal.Length / samplesPerFrame;

            if (parameter == FrameParameterType.EffectiveBandwidth)
            {
                var (val, frequencyCentroid) = GetFrequencyCentroid(discreteSignal, sampleRate, selectedWindowType, samplesPerFrame, framesCount);
                return GetEffectiveBandwith(discreteSignal, sampleRate, selectedWindowType, samplesPerFrame, framesCount, frequencyCentroid);
            }

            if (parameter == FrameParameterType.FrequencyVolume)
            {
                var (result, volume) = GetFrequencyVolume(discreteSignal, sampleRate, selectedWindowType, samplesPerFrame, framesCount);
                var avgVolume = Normalize(ref volume);
                return (avgVolume, volume);
            }

            return parameter switch
            {
                FrameParameterType.BandEnergy => GetBandEnergy(discreteSignal, sampleRate, selectedWindowType, samplesPerFrame, framesCount, bandStart, bandEnd),
                FrameParameterType.FrequencyCentroid => GetFrequencyCentroid(discreteSignal, sampleRate, selectedWindowType, samplesPerFrame, framesCount),
                _ => (0.0, new double[framesCount])
            };
        }


        public static double Normalize(ref double[] points)
        {
            var max = points.Max();
            var avg = 0.0;

            for (var i = 0; i < points.Length; i++)
            {
                points[i] /= max;
                avg += points[i];
            }

            return avg / points.Length;
        }

        #region Frequency Parameters

        public static (double, double[]) GetFrequencyVolume(DataPoint[] discreteSignal, double sampleRate, WindowType selectedWindowType, int samplesPerFrame, int framesCount)
        {
            var resultInFrames = new double[framesCount];
            var sampleIndex = 0;
            var avgResult = 0.0;

            // Need to shift all the values so that min value is set to 0 
            var wholeClipTransform = CalculateFourierTransform(discreteSignal, sampleRate, selectedWindowType);
            var shift = Math.Abs(wholeClipTransform.Min(p => p.Y));

            for (var i = 0; i < framesCount; i++)
            {
                var transformResult = CalculateFourierTransform(discreteSignal, sampleRate, selectedWindowType, samplesPerFrame, sampleIndex);

                foreach (var spectrumPoint in transformResult)
                {
                    var spectrumValue = spectrumPoint.Y + shift;
                    resultInFrames[i] += spectrumValue * spectrumValue;
                }

                resultInFrames[i] /= transformResult.Length;
                avgResult += resultInFrames[i];

                sampleIndex += samplesPerFrame;
            }

            avgResult /= framesCount;
            return (avgResult, resultInFrames);
        }

        public static (double, double[]) GetFrequencyCentroid(DataPoint[] discreteSignal, double sampleRate, WindowType selectedWindowType, int samplesPerFrame, int framesCount)
        {
            var resultInFrames = new double[framesCount];
            var sampleIndex = 0;
            var avgResult = 0.0;

            for (var i = 0; i < framesCount; i++)
            {
                var transformResult = CalculateFourierTransform(discreteSignal, sampleRate, selectedWindowType, samplesPerFrame, sampleIndex);

                var nominator = 0.0;
                var denominator = 0.0;
                foreach (var spectrumPoint in transformResult)
                {
                    var spectrumValue = spectrumPoint.Y;

                    nominator += spectrumPoint.X * spectrumValue;
                    denominator += spectrumValue;
                }

                resultInFrames[i] = nominator / denominator;
                avgResult += resultInFrames[i];

                sampleIndex += samplesPerFrame;
            }

            avgResult /= framesCount;
            return (avgResult, resultInFrames);
        }

        public static (double, double[]) GetEffectiveBandwith(DataPoint[] discreteSignal, double sampleRate, WindowType selectedWindowType, int samplesPerFrame, int framesCount, double[] frequencyCentroid)
        {
            var resultInFrames = new double[framesCount];
            var sampleIndex = 0;
            var avgResult = 0.0;

            // Need to shift all the values so that min value is set to 0 
            //CalculateFourierTransform(discreteSignal, sampleRate, selectedWindowType, out DataPoint[] wholeClipTransform);
            //var shift = Math.Abs(wholeClipTransform.Min(p => p.Y));

            for (var i = 0; i < framesCount; i++)
            {
                var transformResult = CalculateFourierTransform(discreteSignal, sampleRate, selectedWindowType, samplesPerFrame, sampleIndex);

                var nominator = 0.0;
                var denominator = 0.0;
                foreach (var spectrumPoint in transformResult)
                {
                    var spectrumValue = spectrumPoint.Y; /*+ shift;*/

                    nominator += Math.Pow((spectrumPoint.X - frequencyCentroid[i]) * spectrumValue, 2);
                    denominator += spectrumValue * spectrumValue;
                }

                resultInFrames[i] = Math.Sqrt(nominator / denominator);
                avgResult += resultInFrames[i];

                sampleIndex += samplesPerFrame;
            }

            avgResult /= framesCount;
            return (avgResult, resultInFrames);
            ;
        }

        public static (double, double[]) GetBandEnergy(DataPoint[] discreteSignal, double sampleRate, WindowType selectedWindowType, int samplesPerFrame, int framesCount, int bandStart, int bandEnd)
        {
            var resultInFrames = new double[framesCount];
            var sampleIndex = 0;
            var avgResult = 0.0;

            // Need to shift all the values so that min value is set to 0 
            var wholeClipTransform = CalculateFourierTransform(discreteSignal, sampleRate, selectedWindowType);
            var shift = Math.Abs(wholeClipTransform.Min(p => p.Y));
            var discreteSignalShift = Math.Abs(discreteSignal.Min(p => p.Y));

            for (var i = 0; i < framesCount; i++)
            {
                var transformResult = CalculateFourierTransform(discreteSignal, sampleRate, selectedWindowType, samplesPerFrame, sampleIndex);

                var nominator = 0.0;
                var denominator = 0.0;
                var spectrumPoints = transformResult.Where(p => p.X >= bandStart && p.X <= bandEnd);
                foreach (var spectrumPoint in spectrumPoints)
                {
                    var spectrumValue = spectrumPoint.Y + shift;

                    nominator += spectrumValue * spectrumValue;
                }

                for (var j = 0; j < samplesPerFrame; j++)
                    denominator += discreteSignal[sampleIndex + j].Y + discreteSignalShift;

                resultInFrames[i] = nominator / denominator;
                avgResult += resultInFrames[i] / spectrumPoints.Count();

                sampleIndex += samplesPerFrame;
            }

            avgResult /= framesCount;
            return (avgResult, resultInFrames);
        }

        #endregion


        #region Frequency Analysis

        public static DataPoint[] CalculateFourierTransform(DataPoint[] discreteSignal, double sampleRate, WindowType selectedWindowType, int samplesPerFrame = 1, int? selectedSampleIndex = null)
        {
            // Get the samples for analysis
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

            // Perform transformation
            var transformResult = new DataPoint[newSamplesCount / 2];
            Fourier.Forward(transformData);

            // Compute frequency and magnitute to return
            var herzPerSample = sampleRate / newSamplesCount;
            for (var i = 0; i < newSamplesCount / 2; i++)
            {
                transformResult[i] = new DataPoint(i * herzPerSample, Math.Log10(transformData[i].MagnitudeSquared()) + 10);
            }

            return transformResult;
        }

        public static void CalculateSpectrogram(DataPoint[] discreteSignal, WindowType selectedWindowType, int samplesPerFrame, double frameOverlapping, out double[,] transformResult)
        {
            // Get data for analysis
            var samplesToTransform = GetSamplesForSpectrogram(discreteSignal, samplesPerFrame, frameOverlapping,
                selectedWindowType, out var rowCount, out var columnCount, out _);

            // Perform transformation
            transformResult = new double[columnCount, rowCount / 2];

            for (var i = 0; i < samplesToTransform.Length; i++)
            {
                Fourier.Forward(samplesToTransform[i]);

                // Compute value to return
                for (var j = 0; j < samplesToTransform[i].Length / 2; j++)
                    transformResult[i, j] = 10 * Math.Log10(samplesToTransform[i][j].MagnitudeSquared());
            }
        }

        #endregion

        #region Fourier Helpers

        private static Complex32[] GetSamplesForFourier(IEnumerable<DataPoint> samplesToTransform, WindowType selectedWindowType, out int newSamplesCount)
        {
            // Get window function for analysis
            double[] window = null;
            switch (selectedWindowType)
            {
                case WindowType.Rectangular:
                    window = Window.Dirichlet(samplesToTransform.Count());
                    break;
                case WindowType.Hamming:
                    window = Window.Hamming(samplesToTransform.Count());
                    break;
                case WindowType.Hann:
                    window = Window.Hann(samplesToTransform.Count());
                    break;
            }

            // Align samples number to next power of 2
            var closestPowerOfTwo = (int)Math.Ceiling(Math.Log(samplesToTransform.Count(), 2));
            newSamplesCount = (int)Math.Pow(2, closestPowerOfTwo);
            var transformData = new Complex32[newSamplesCount];

            // Assign data to array of Complex
            for (var i = 0; i < samplesToTransform.Count(); i++)
                transformData[i] = (float)(samplesToTransform.ElementAt(i).Y * window[i]);

            return transformData;
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

        #endregion
    }
}
