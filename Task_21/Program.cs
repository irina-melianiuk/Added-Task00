// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.Write("X1: ");
int xc1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int yc1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int zc1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты второй точки");
Console.Write("X2: ");
int xc2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int yc2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int zc2 = Convert.ToInt32(Console.ReadLine());


double result = Distance (xc1, yc1, zc1, xc2, yc2, zc2);   
Console.WriteLine(result);

double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
   return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2, MidpointRounding.ToZero);

}
