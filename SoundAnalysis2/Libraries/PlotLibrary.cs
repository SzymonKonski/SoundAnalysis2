using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace SoundAnalysis2.Libraries
{
    public static class PlotLibrary
    {
        private static readonly OxyColor Color = OxyColor.FromRgb(System.Drawing.Color.DodgerBlue.R,
            System.Drawing.Color.DodgerBlue.G, System.Drawing.Color.DodgerBlue.B);

        public static PlotModel UpdateWaveformPlot(DataPoint[] points, string labelX, string labelY, string title = null)
        {
            var plotModel = new PlotModel
            {
                PlotType = PlotType.XY,
                Background = OxyColors.White,
                Title = title,
                TitleFontSize = 10
            };

            var series = new LineSeries();
            var chartMaxY = 1.2 * points.Max(p => p.Y);
            var chartMinY = 1.2 * points.Min(p => p.Y);
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = labelY, Maximum = chartMaxY, Minimum = chartMinY });
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = labelX });

            series.Points.AddRange(points);
            series.Color = Color;
            plotModel.Series.Add(series);
            return plotModel;
        }

        public static PlotModel UpdateFrameLevelChart(DataPoint[] resultPoints)
        {
            var plotModel = new PlotModel
            {
                PlotType = PlotType.XY,
                Background = OxyColors.White
            };

            var chartMaxY = 1.2 * resultPoints.Max(p => p.Y);

            var series = new LineSeries();
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left,  Maximum = chartMaxY });
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });

            series.Points.AddRange(resultPoints);
            series.Color = Color;
            plotModel.Series.Add(series);
            return plotModel;
        }

        public static PlotModel UpdateSpectrogram(double[,] data, double lengthInSeconds, double sampleRate)
        {
            var plotModel = new PlotModel
            {
                PlotType = PlotType.XY,
                Background = OxyColors.White,
            };

            var heatMapSeries = new HeatMapSeries
            {
                X0 = 0,
                X1 = lengthInSeconds,
                Y0 = 0,
                Y1 = sampleRate / 2,
                Interpolate = true
            };

            plotModel.Axes.Add(new LinearAxis {Position = AxisPosition.Left, Title = "Frequency [Hz]"});
            plotModel.Axes.Add(new LinearAxis {Position = AxisPosition.Bottom, Title = "Time [s]"});

            heatMapSeries.Data = data;
            plotModel.Series.Add(heatMapSeries);
            plotModel.Axes.Add(new LinearColorAxis
            {
                Position = AxisPosition.Right,
                IsAxisVisible = false,
                Palette = OxyPalettes.Rainbow(100),
            });

            return plotModel;
        }
    }
}
