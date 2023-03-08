// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int sum, n;
        
        n = (int) inputValue();
        if (n < 0 && n == 0)
        {
            Console.WriteLine("Это не целое число. Повторите ввод.");
        }
        else
        {
            sum = 0;
            while ((double) n / 10 > 0)
            {
                sum = sum + n % 10;
                n = (int) ((double) (n - n % 10) / 10);
            }
            sum = sum + n % 10;
            Console.WriteLine(sum);
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

