namespace Homeworks._3_SOLID.Abstractions;

public interface IGeneratedNumber
{
    int RandomNumber { get; }
    
    int GenerateNumber();
}