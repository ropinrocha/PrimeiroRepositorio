using System;

namespace ConversorDeSegundos
{
    class Program
    {
        static void Main(string[] args)
        {
            int SecOutPut = int.Parse(Console.ReadLine());
            int Hour, min , sec;

            Hour = SecOutPut / 3600;
            min = SecOutPut % 3600 / 60;
            sec = SecOutPut % 60;

            Console.WriteLine($"{Hour}:{min}:{sec}");
            Console.ReadKey();


        }
    }
}
