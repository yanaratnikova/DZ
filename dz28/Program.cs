//  Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
int RecAkkerman(int m, int n)

{
       if (m == 0) return n +1;  
       else if (n == 0) return RecAkkerman(m-1,1); 
       else return RecAkkerman(m-1, RecAkkerman(m, n-1)); 
  
}

Console.Write(RecAkkerman(3,2));
