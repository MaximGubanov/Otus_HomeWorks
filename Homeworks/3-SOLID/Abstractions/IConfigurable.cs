namespace Homeworks._3_SOLID.Abstractions;

public interface IConfigurable<TGame> where TGame : ISettings
{
    TGame Settings { get; }
    
    public void Configure(TGame settings);
}