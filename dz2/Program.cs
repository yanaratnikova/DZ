// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, max;
        Console.WriteLine("Введите три целых числа: ");
        
        a = (int) inputValue();
        b = (int) inputValue();
        c = (int) inputValue();
        if (a > b)
        {
            max = a;
        }
        else
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
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

