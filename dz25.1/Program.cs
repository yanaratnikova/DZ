// одномерный массив из неповторяющихся случайных чисел
using System;

public class MyProgram
{
    private static Random random = new Random();
    
    public static void Main(string[] args)
    {
        int x, y, z, k, temp, n;
        
        Console.WriteLine("Введите размеры 3D массива:");
        x = (int) inputValue();
        y = (int) inputValue();
        z = (int) inputValue();
        k = 0;
        int[] a = new int[x * y * z];
        
        for (k = 0; k <= x * y * z - 1; k++)
        {
            a[k] = random.Next(100);
            temp = random.Next(100);
            n = 0;
            while (n < k + 1)
            {
                if (a[k - n] == temp)
                {
                    temp = random.Next(100);
                    n = 0;
                }
                else
                {
                    n = n + 1;
                }
            }
            a[k] = temp;
            Console.Write(a[k]);
            Console.Write("    ");
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

