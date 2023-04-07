// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

using System;
namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
                               //Ввод строк с клавиатуры и образование нового массива
            string[] AS;
            int count;
            string s=null;
            string [] AS2;
            Console.WriteLine("Введите строку: ");
            count = 0;
            AS = new string[count];

            do
            {
                s = Console.ReadLine();
                if (s != "")
                {
                    count++;
                    AS2 = new string[count];
                    for (int i = 0; i < AS2.Length - 1; i++)
                    
                    AS2[i] = AS[i];
                    AS2[count - 1] = s;
                    AS = AS2;
                    
                   
                }
            }
            
            while (s != "");
            Console.WriteLine("массив из строк, длина которых меньше, либо равна 3 символам: ");
            for (int i = 0; i < AS.Length; i++)
            if (AS[i].Length <= 3)
            
               Console.Write(AS[i] + "\t");                                          
        }
    }
}
