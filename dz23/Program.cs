// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

int [,] CreateArray()
{
  int m = 5; //new Random().Next(2, 10);
  int n = 6; //new Random().Next(2, 10);
  int [,] matrix = new int [m, n];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  
  }
  return matrix;
}
int [,] PrintArray(int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
            Console.Write(matrix[i, j] + "\t");
    }
  Console.WriteLine();
  }
  return matrix;
}

Console.WriteLine("Исходный массив:");
Console.WriteLine();

int [,] matrix = CreateArray();

PrintArray (matrix);
Console.WriteLine();

//Функция вычисления суммы элементов в строке

int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
       sum +=array[i,j];
    }
     Console.Write(sum + "\t");
    return sum;   
}
int minSum = 1;
int sum = SumLine(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    if (sum > SumLine(matrix, i))
    {
        sum = SumLine(matrix, i);
        minSum = i + 1;
    }
    
}
Console.WriteLine($"\n Строка с наименьшей суммой элементов: {minSum}");
