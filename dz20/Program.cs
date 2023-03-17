// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите количество строк: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n=Convert.ToInt32(Console.ReadLine());

int[,] randomArrey = new int[m,n];
Console.Write("Введите позицию строки: ");
int m1=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию солбца: ");
int n1=Convert.ToInt32(Console.ReadLine());

void mas(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i=0; i<m; i++)
    {
        Console.WriteLine();
        for (j=0; j<n; j++)
        {
            randomArrey[i,j]=new Random().Next(0,10);
            Console.Write($"{randomArrey[i,j]}   ");
        }
       Console.WriteLine(); 
    }
}
mas(m,n);
if (m1<1 || n1<1)
Console.Write("Позиции строк не могут быть отрицательными ");
else
if (m1<=m+1 && n1<=n+1)
Console.Write($"Значение искомого элемента равно {randomArrey[m1-1,n1-1]}");
else
Console.Write("Такого элемента не существует ");

