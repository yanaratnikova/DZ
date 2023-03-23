// Напишите программу, которая заполнит спирально массив 4 на 4.



    
    int N, M;
    N=4;
    M=4;
    int[,] a = new int[M,N];
        
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
    
    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= N * M)
    {
        a[i, j] = k;
      
        if (i == N && j == M)
        {

        }
       
        if (i == Ibeg && j < M - Jfin - 1)
            ++j;
        else if (j == M - Jfin - 1 && i < N - Ifin - 1)
            ++i;
        else if (i == N - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1))
        {
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
           
        }
        ++k;
       
    }
    
 int[,] CreateOutputArray( int[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (array[i,j] /10 <=0)
            Console.Write($" {array[i,j]}  ");
            else Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
    return array;
}

    
CreateOutputArray(a);
