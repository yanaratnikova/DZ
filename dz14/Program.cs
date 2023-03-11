// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
        array[i] = new Random().Next(99,999);
    }
    return array;
}
int[] newArray = CreateArray(Prompt());

Console.WriteLine($"[{String.Join("," , newArray)}]");

int kol(int[] newArray)
{
int kol = 0;
for (int i = 0; i < newArray.Length; i++)
{
if (newArray[i] % 2 == 0)
kol = kol + 1;
}
return kol;
}


Console.Write($"\nКоличество чётных чисел в массиве: {kol(newArray)}");



