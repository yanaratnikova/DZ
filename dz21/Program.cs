// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n=Convert.ToInt32(Console.ReadLine());

int[,] randomArrey = new int[m,n];


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
void arif(int m, int n)
{
Console.Write("Среднее арифметическое каждого столбца: ");
int i,j;
Random rand = new Random();
for (j = 0; j < n; j++)
{
double sum = 0;
for (i = 0; i < m; i++)
{
sum = sum + randomArrey[i,j];
}
Console.Write($"{sum/m:F1}; ");
}
}
mas(m,n);
arif(m,n);




