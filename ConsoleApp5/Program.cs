using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum Darkland
        {
            регистрация = 1,
            авторизация = 2,
            бой = 4,
            выход = 5
        }
        static void Main()
        {
            Console.WriteLine($"Для {Darkland.регистрация} нажмите {(int)Darkland.регистрация}") ;
    
            Console.WriteLine($"Для {Darkland.бой} нажмите {(int)Darkland.бой}");
            Console.WriteLine($"Для {Darkland.выход}а нажмите {(int)Darkland.выход}");
        }
    }
}

