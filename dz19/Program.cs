// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int Promt(string message)
{
  Console.WriteLine(message);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

double[,] CreateOutputArray(int m, int n)
{
  double[,] matrix = new double[m, n];
  Random rand = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      
      matrix[i, j] = Math.Round(rand.Next(-100, 101)*0.1,1);
      Console.Write(matrix[i, j] + "   ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
  return matrix;
}



int m = Promt ("Введите количество строк: ");
int n = Promt ("Введите количество столбцов: ");

Console.WriteLine(CreateOutputArray(m, n));
