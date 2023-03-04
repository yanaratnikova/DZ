//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Double x1, x2, y1, y2, z1, z2, distance;
Console.WriteLine("Расстояние между двумя точками в 3D пространстве.");

Console.WriteLine("Введите координаты точки а: ");

Console.WriteLine("Введите координату x1: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату z1: ");
z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки b: ");

Console.WriteLine("Введите координату x2: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату z2: ");
z2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
distance = Math.Round(distance,2);
Console.WriteLine("Расстояние между двумя точками на плоскости равно: " + distance);
