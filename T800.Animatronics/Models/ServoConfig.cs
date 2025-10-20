using T800.Animatronics.Constants;

namespace T800.Animatronics.Models;

internal class ServoConfig
{
    private int _channel;
    private int _minimumPosition;
    private int _maximumPosition;
    private InitialPosition _initialPosition;

    internal ServoConfig(int channel, int minimumPosition, int maximumPosition, InitialPosition initialPosition)
    {
        Channel = channel;
        MinimumPosition = minimumPosition;
        MaximumPosition = maximumPosition;
        InitialPosition = initialPosition;
    }

    internal int Channel => _channel;
    internal int MinimumPosition => _minimumPosition;
    internal int MaximumPosition => _maximumPositionl;
    internal InitialPosition InitialPosition => _initialPosition;
}