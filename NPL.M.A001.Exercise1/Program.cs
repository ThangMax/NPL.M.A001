// See https://aka.ms/new-console-template for more information
using System;

public class Exercise1
{
    public static void Main()
    {
        Console.WriteLine("Nhap gia tra cua x:");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            int y = 2 * x * x * x - 6 * x * x + 2 * x - 1;
            Console.WriteLine($"Voi x = {x}, y = {y}");
        }
    }
}

