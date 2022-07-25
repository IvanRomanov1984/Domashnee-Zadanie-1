// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое для сравнения число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе для сравнения число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int max = 0;
        int min = 0;

        if (num1 > num2)
        {
        max = num1;
        min = num2;
        }
        
        else  if (num1 < num2)
        {
        max = num2;
        min = num1;
        }
        
    
        Console.WriteLine($" Наибольшее {max}  Наименьшее {min}");
    }
}