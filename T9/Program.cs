// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки");
int[] point1 = new int[2];
for (int i = 0; i < point1.Length; i++) point1[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
int[] point2 = new int[2];
for (int i = 0; i < point2.Length; i++) point2[i] = Convert.ToInt32(Console.ReadLine());

double measure = Math.Sqrt(Math.Pow(point2[0] - point1[0], 2) + Math.Pow(point2[1] - point1[1], 2));
Console.WriteLine("Расстояние между точками = " + measure);


