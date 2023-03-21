// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива
int [,] CreateArray()
{
  int m = new Random().Next(2, 10);
  int n = new Random().Next(2, 10);
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
//Сортировка элементов массива по убыванию
void SortArray(int[,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i,k] < array[i, k+1])
                {
                    int temp = array[i, k+1];
                    array[i, k+1] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
}
SortArray(matrix);
Console.WriteLine("Упорядоченный массив:");
PrintArray(matrix);
