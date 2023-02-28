// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n;
        
        Console.WriteLine("Введите числовое значение дня недели");
        n = (int) inputValue();
        if (0 < n && n < 6)
        {
            Console.WriteLine("Это будний день");
        }
        else
        {
            if (n == 6 && n == 7)
            {
                Console.WriteLine("Это выходной день");
            }
            else
            {
                Console.WriteLine("Такого дня не существует");
            }
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

