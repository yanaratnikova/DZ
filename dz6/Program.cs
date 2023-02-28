// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int n, res;
        
        n = (int) inputValue();
        if ((double) n / 100 < 1)
        {
            Console.WriteLine("Третьей цифры нет.");
        }
        else
        {
            if ((double) (n - n % 10) / 10 < 100)
            {
            }
            else
            {
                while ((double) (n - n % 10) / 10 > 100)
                {
                    n = (int) ((double) (n - n % 10) / 10);
                }
            }
            res = n % 10;
            Console.WriteLine(res);
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

