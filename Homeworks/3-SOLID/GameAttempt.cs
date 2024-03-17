using Homeworks._3_SOLID.Abstractions;

namespace Homeworks._3_SOLID;

public class GameAttempt : IGameAttempt
{
    public int RandomNumber { get; private set; }
    public int Attempts { get; private set; }
    public int CurrentAttempt { get; private set; } = 1;
    public IGameAttemptSettings Settings { get; private set; }
    
    public void Start()
    {
        RandomNumber = GenerateNumber();
        
        Console.WriteLine($"Компьютер загадал число, попробуйте угадать за {Attempts} попыток.\n\n");
        
        while (CurrentAttempt <= Attempts)
        {
            Console.WriteLine($"Попытка номер {CurrentAttempt}. Введите число:");
            var input = Console.ReadLine();
            
            bool success = int.TryParse(input, out var number);
    
            if (success)
            {
                if (number > RandomNumber) Console.WriteLine("Загаданное число меньше");
                if (number < RandomNumber) Console.WriteLine("Загаданное число больше");
    
                if (number == RandomNumber)
                {
                    Console.WriteLine("Вы угадали, поздравляем!");
                    
                    return;
                }
            }
            
            CurrentAttempt += 1;
        }

        Console.WriteLine("К сожалению попытки закончились :(");
    }
    
    public void Configure(IGameAttemptSettings gameAttemptSettings)
    {
        Settings = gameAttemptSettings;
        Attempts = gameAttemptSettings.Attempts;
    }
    
    public int GenerateNumber()
    {
        var rnd = new Random();
        var randomNumber = rnd.Next(Settings.MaxRandomNumber); 
        
        return randomNumber;
    }
}