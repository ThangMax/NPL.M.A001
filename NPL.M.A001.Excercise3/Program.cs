// See https://aka.ms/new-console-template for more information
public class Exercise3
{
    public static void Main()
    {
        Console.Write("Nhap so luong cac so Fibonacci can in: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Fibonacci(n);
        }
        else
        {
            Console.WriteLine("Gia tri nhap vao khong hop le");
        }
    }

    public static void Fibonacci(int n)
    {
        if (n == 1)
        {
            Console.WriteLine(1);
            return;
        }

        int a = 1, b = 1;
        Console.WriteLine(a);
        Console.WriteLine(b);

        for (int i = 3; i <= n; i++)
        {
            int c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }
}

