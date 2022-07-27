//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int num = 1;
        
        while (N>num)
        {
        
            if (num % 2 == 0)
            {
            
            Console.WriteLine($"{num}");
            }
            num = num + 1;        
        
        }

            
     
        
        
    }
}