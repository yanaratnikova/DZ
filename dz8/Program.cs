
//Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a<9999 && a<99999)
{
    Console.WriteLine("Это не пятизначное число");
    
    
}
else{
        

int[] array = {0, 0, 0, 0, 0};

int l = array.Length;

int index = 0;

while (index < l)
{
    array[index] = a%10;
    a=(a-a%10)/10;
    
    
        //Console.WriteLine(array[index]);
        
    
    index++;
}
if (array[0] == array[l-1] && array[1] == array[l-2])
{
    Console.WriteLine("Это число является палиндромом");
}
else{
    Console.WriteLine("Это число не является палиндромом");
}
}


