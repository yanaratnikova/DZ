// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях

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

int kol(int[] newArray)
{
int sum = 0;
int i = 0;
while (i < newArray.Length)
{
sum = sum + newArray[i];
i = i + 2;
}
return sum;
}


Console.Write($"\nCумма элементов, стоящих на нечётных позициях: {kol(newArray)}");

