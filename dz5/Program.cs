// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число");
        int n, res, res1;
        
        n = (int) inputValue();
        res = n % 100;
        res1 = (int) ((double) (res - res % 10) / 10);
        Console.WriteLine(res1);
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
