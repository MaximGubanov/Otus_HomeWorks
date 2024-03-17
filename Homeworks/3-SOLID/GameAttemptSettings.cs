using Homeworks._3_SOLID.Abstractions;

namespace Homeworks._3_SOLID;

public class GameAttemptSettings : IGameAttemptSettings
{
    public int Attempts { get; }
    public int MaxRandomNumber { get; }

    public GameAttemptSettings(int attempts, int maxRandomNumber)
    {
        Attempts = attempts;
        MaxRandomNumber = maxRandomNumber;
    }
}