﻿// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.


int RecNumbers(int m, int n)

{
       if (m == n) return n;   
    return m + RecNumbers(m+1, n); 
  
}

Console.Write(RecNumbers(1,15));
