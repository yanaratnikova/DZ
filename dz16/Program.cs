// Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

int Prompt()
{
    Console.WriteLine("Введите количество елементов массива: ");
    return Convert.ToInt32(Console.ReadLine());
}double[] CreateArray(int size)
{
    double[] array = new double [size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.NextDouble();
    }
    return array;
}
double[] newArray = CreateArray(Prompt());

Console.WriteLine($"[{String.Join("," , newArray)}]");
//Console.Write("значение нулевого члена массива:");
//Console.WriteLine(newArray[0]);

double raz(double[] newArray)
{
    double min = newArray[0];
    double max = newArray[0];
    int i=1;
    while (i < newArray.Length)
    {
        if (max < newArray[i])
        max = newArray[i];
        if (min > newArray[i])
        min = newArray[i];
        i=i+1;
    }
    Console.Write($"\nМинимальный элемент массива: ");
    Console.Write(min);
    Console.Write($"\nМаксимальный элемент массива: ");
    Console.Write(max);
    return max-min;

}


Console.Write($"\nРазница между максимальным и минимальным элементом массива: {raz(newArray)}");