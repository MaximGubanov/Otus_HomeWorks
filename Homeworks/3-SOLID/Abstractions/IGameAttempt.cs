namespace Homeworks._3_SOLID.Abstractions;

public interface IGameAttempt : IGame, IGeneratedNumber, IConfigurable<IGameAttemptSettings>
{
    public int Attempts { get; }
    public int CurrentAttempt { get; }
}