namespace Homeworks._3_SOLID.Abstractions;

public interface IGameLoopSettings : ISettings
{
    bool Loop { get; }
    int StartRange { get; }
    int EndRange { get; }
}