using Homeworks._3_SOLID.Abstractions;

namespace Homeworks._3_SOLID;

public class GameLoopSettings : IGameLoopSettings
{
    public bool Loop { get; }
    public int StartRange { get; }
    public int EndRange { get; }

    public GameLoopSettings(int startRange, int endRange)
    {
        StartRange = startRange;
        EndRange = endRange;
    }
}