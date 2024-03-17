namespace Homeworks._3_SOLID.Abstractions;

public interface IGameAttemptSettings : ISettings
{
    public int Attempts { get; }
    public int MaxRandomNumber { get; }
}