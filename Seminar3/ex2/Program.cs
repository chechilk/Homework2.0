// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A!");
Console.Write("Введите координаты точки x1:\t");
var x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки y1:\t");
var y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки c1:\t");
var c1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки В!");
Console.Write("Введите координаты точки x2:\t");
var x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки y2:\t");
var y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки c2:\t");
var c2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"Расстояние между точками A и B равно {Math.Round((Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(c1 - c2, 2))),2)}");
