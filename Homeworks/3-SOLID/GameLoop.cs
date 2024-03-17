using Homeworks._3_SOLID.Abstractions;

namespace Homeworks._3_SOLID;

public class GameLoop : IGameLoop
{
    private int _startRange = 0;
    private int _endRange = 0;
    
    public bool Loop { get; } = true;
    public int RandomNumber { get; private set; }
    
    public void Start()
    {
        RandomNumber = GenerateNumber();
        if (RandomNumber == -1) return;
        
        Console.WriteLine($"Компьютер загадал число от {_startRange} и до {_endRange}, попробуйте угадать. Кол-во попыток неограничено\n\n");
        
        while (Loop)
        {
            Console.WriteLine($"Введите число:");
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
        }
    }

    public int GenerateNumber()
    {
        var rnd = new Random();

        if (_startRange > 0 && _endRange > 0)
        {
            var randomNumber = rnd.Next(_startRange, _endRange); 
            return randomNumber;
        }

        Console.WriteLine("Игра не сконфигурирована, перед методом Start вызовите метод Configure");
        return -1;
    }
    
    public IGameLoopSettings Settings { get; private set; }
    
    public void Configure(IGameLoopSettings settings)
    {
        Settings = settings;
        _startRange = settings.StartRange;
        _endRange = settings.EndRange;   
    }
}