/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.WriteLine("Введите координату  X первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату  y первой точки");
double y1 =Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Введите координату  z первой точки");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату  X второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату  y второй точки");
double y2 =Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Введите координату  z второй точки");
double z2 = Convert.ToDouble(Console.ReadLine());
double R=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.WriteLine($"Расстояние между двумя точками равно {R}");
