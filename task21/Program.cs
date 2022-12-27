// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
Console.WriteLine("Enter A and B coordinates and I will calculate the distance between them.");
Console.WriteLine("Enter xA");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter yA");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter zA");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter xB");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter yB");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter zB");
int zB = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt((Math.Pow((xB-xA), 2))+(Math.Pow((yB-yA), 2))+(Math.Pow((zB-zA), 2)));
Console.WriteLine("Distance equals " + Math.Round(distance, 3));