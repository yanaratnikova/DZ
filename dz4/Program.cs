// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n, i;
        
        i = 1;
        Console.WriteLine("Введите число: ");
        n = (int) inputValue();
        while (i <= n)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            i = i + 1;
        }
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}

