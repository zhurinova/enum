using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum Darkland
        {
            регистрация = 1,
            авторизация = 2,
            генерацияперсонажа = 3,
            бой = 4,
            выход = 5
        }
        static void Main()
        {
            Console.WriteLine($"Для {Darkland.регистрация} нажмите {(int)Darkland.регистрация}") ;
            Console.WriteLine($"Для {Darkland.авторизация} нажмите {(int)Darkland.авторизация}");
            Console.WriteLine($"Для {Darkland.генерацияперсонажа} персонажа нажмите {(int)Darkland.генерацияперсонажа}");
            Console.WriteLine($"Для {Darkland.бой} нажмите {(int)Darkland.бой}");
            Console.WriteLine($"Для {Darkland.выход}а нажмите {(int)Darkland.выход}");
        }
    }
}

