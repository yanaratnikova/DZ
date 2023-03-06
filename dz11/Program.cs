// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B

using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, i;
        
        Console.WriteLine("Введите число, возводимое в степень: ");
        a = (int) inputValue();
        Console.WriteLine("Введите степень, в которую надо возвести число: ");
        b = (int) inputValue();
        c = 1;
        if (b < 0)
        {
            Console.WriteLine("число должно быть натуральным. Повторите ввод.");
        }
        else
        {
            for (i = 1; i <= b; i++)
            {
                c = c * a;
            }
            Console.WriteLine(c);
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
