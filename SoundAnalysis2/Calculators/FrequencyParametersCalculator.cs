using OxyPlot;

namespace SoundAnalysis2.Calculators
{
    public class FrequencyParametersCalculator
    {
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


        public static (double, double[]) GetFrequencyVolume(DataPoint[] discreteSignal, double sampleRate, WindowType selectedWindowType, int samplesPerFrame, int framesCount)
        {
            var resultInFrames = new double[framesCount];
            var sampleIndex = 0;
            var avgResult = 0.0;

            var wholeClipTransform = FourierHelpers.CalculateFourierTransform(discreteSignal, sampleRate, selectedWindowType);
            var shift = Math.Abs(wholeClipTransform.Min(p => p.Y));

            for (var i = 0; i < framesCount; i++)
            {
                var transformResult = FourierHelpers.CalculateFourierTransform(discreteSignal, sampleRate, selectedWindowType, samplesPerFrame, sampleIndex);

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
                var transformResult = FourierHelpers.CalculateFourierTransform(discreteSignal, sampleRate, selectedWindowType, samplesPerFrame, sampleIndex);

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

            for (var i = 0; i < framesCount; i++)
            {
                var transformResult = FourierHelpers.CalculateFourierTransform(discreteSignal, sampleRate, selectedWindowType, samplesPerFrame, sampleIndex);

                var nominator = 0.0;
                var denominator = 0.0;
                foreach (var spectrumPoint in transformResult)
                {
                    var spectrumValue = spectrumPoint.Y;

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

            var wholeClipTransform = FourierHelpers.CalculateFourierTransform(discreteSignal, sampleRate, selectedWindowType);
            var shift = Math.Abs(wholeClipTransform.Min(p => p.Y));
            var discreteSignalShift = Math.Abs(discreteSignal.Min(p => p.Y));

            for (var i = 0; i < framesCount; i++)
            {
                var transformResult = FourierHelpers.CalculateFourierTransform(discreteSignal, sampleRate, selectedWindowType, samplesPerFrame, sampleIndex);

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

    }
}
