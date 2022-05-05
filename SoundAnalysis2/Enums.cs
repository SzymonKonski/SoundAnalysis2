namespace SoundAnalysis2
{
    public enum FrameParameterType
    {
        FrequencyVolume,
        FrequencyCentroid,
        EffectiveBandwidth,
        BandEnergy
    }

    public enum WindowType
    {
        Rectangular,
        Hamming,
        Hann
    }

    public enum TabPage
    {
        Fourier,
        Spectrum,
        SoundFrequencyParameters
    }

    public enum FourierTransformScope
    {
        WholeClip,
        OneFrame
    }
}
