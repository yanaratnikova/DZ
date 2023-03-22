// See https://aka.ms/new-console-template for more information
int [,,] CreateArray()
{
  int m = new Random().Next(2, 4);
  int n = new Random().Next(2, 4);
  int k = new Random().Next(2, 4);
  int [,,] matrix = new int [m, n, k];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int z = 0; z < matrix.GetLength(2); z++)
        {
             matrix[i, j, z] = new Random().Next(10, 100);
        }
     
    }
  
  }
  return matrix;
}
int [,,] PrintArray(int [,,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
          for (int z = 0; z < matrix.GetLength(2); z++)
          {
            Console.Write($"({i},{j},{z})");
            Console.Write(matrix[i, j, z] + "\t");
           
          }  
            
    }
  Console.WriteLine();
  }
  return matrix;
}
int [,,] matrix = CreateArray();
PrintArray (matrix);
Console.WriteLine();
