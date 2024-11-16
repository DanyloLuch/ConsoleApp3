using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть ціле число:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine($"Ви ввели число {number}");
        }
        else
        {
            Console.WriteLine("Це не є цілим числом.");
        }
    }
}
