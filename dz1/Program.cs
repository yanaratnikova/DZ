// Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, max;
        Console.WriteLine("Введите два числа: ");
        
        a = (int) inputValue();
        b = (int) inputValue();
        if (a < b)
        {
            max = b;
        }
        else
        {
            max = a;
        }
        Console.Write("Максимальное число: ");
        Console.WriteLine(max);
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

