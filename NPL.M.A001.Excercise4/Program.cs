// See https://aka.ms/new-console-template for more information

public class Exercise4
{
    public static void Main()
    {
        Console.WriteLine("Nhap mot so nguyen duong:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            var isPrime = CheckPrimeNumber(number);
            if (isPrime)
            {
                Console.WriteLine($"{number} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{number} khong phai la so nguyen to.");
            }
        }
        else
        {
            Console.WriteLine("Gia tri nhap vao khong hop le.");
        }
    }

    public static bool CheckPrimeNumber(int number)
    {
        if (number <= 1)
        { 
            return false;
        }
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

