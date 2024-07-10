// See https://aka.ms/new-console-template for more information
public class Exercise2
{
    public static void Main()
    {
        Console.WriteLine("Nhap so nguyen he co so 10:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            string binary = Convert.ToString(number, 2);
            Console.WriteLine($"So nhi phan tuong ung ca {number} la {binary}");
        }
    }
}
