// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите числовое значение дня недели: ");
        int n;
        
        n = (int) inputValue();
        if (n == 6)
        {
            Console.WriteLine("Это выходной день");
        }
        else
        {
            if (n == 7)
            {
                Console.WriteLine("Это выходной день");
            }
            else
            {
                if (n > 7)
                {
                    Console.WriteLine("Такого дня не существует");
                }
                else
                {
                    if (n == 0)
                    {
                        Console.WriteLine("Такого дня не существует");
                    }
                    else
                    {
                        Console.WriteLine("Это будний день");
                    }
                }
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

