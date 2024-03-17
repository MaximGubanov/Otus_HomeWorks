namespace Homeworks._3_SOLID.Abstractions;

public interface IGameLoop : IGame, IGeneratedNumber, IConfigurable<IGameLoopSettings>
{
    public bool Loop { get; }
}