// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int Prompt()
{
    Console.WriteLine("Введите количество елементов");
    return Convert.ToInt32(Console.ReadLine());
}
int[] CreateArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,10);
    }
    return array;
}
int[] newArray = CreateArray(Prompt());

Console.WriteLine($"[{String.Join("," , newArray)}]");

