
//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int [,] CreateArray()                              //создание массива
{
  int m = 2; //new Random().Next(2, 10);
  int n = 2; //new Random().Next(2, 10);
  
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
int [,] PrintArray(int [,] matrix)                   // печать массива
{
        for (int i = 0; i < matrix.GetLength(0); i++)
  {
   
    for (int j = 0; j < matrix.GetLength(1); j++)        
    {
            Console.Write(matrix[i, j] + "\t ");
    }
Console.WriteLine();
  }
  return matrix;
}
var matrix1 = CreateArray();
var matrix2 = CreateArray();
Console.WriteLine("Первая матрица:");
PrintArray (matrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintArray (matrix2);
Console.WriteLine();

static int[,]  Multiplication(int[,] matr1, int[,] matr2) // Перемножение массивов
{
    //if (matr1.GetLength(1) != matr2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    var resMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (var i = 0; i < matr1.GetLength(0); i++)
        {
            for (var j = 0; j < matr2.GetLength(1); j++)
            {
               //resMatr[i,j] = 0;
               for (var k = 0; k < matr2.GetLength(0); k++) 
               {
                resMatr[i,j] += matr1[i,k] * matr2[k,j];
               }
            }
        }
    return resMatr;     
}
var resultMatrix = Multiplication(matrix1, matrix2);
Console.WriteLine("Произведение первой и второй матрицы: ");
PrintArray (resultMatrix);

