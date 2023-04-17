using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите число B: ");
        int b = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = a; i <= b; i++)
        {
            sum += i * i;
        }

        Console.WriteLine($"Сумма квадратов от {a} до {b} равна {sum}");
    }
}
