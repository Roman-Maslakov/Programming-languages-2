// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты x, y");
int[] points = new int[2];
for (int i = 0; i < points.Length; i++)
{
    while (true)
    {
        points[i] = Convert.ToInt32(Console.ReadLine());
        if (points[i] != 0) break;
        else Console.WriteLine("Введите координаты x, y");
    }
}

if (points[0] > 0 && points [1] > 0) Console.WriteLine("Точка находится в первой четверти");
else if (points[0] < 0 && points [1] > 0) Console.WriteLine("Точка находится во второй четверти");
else if (points[0] < 0 && points [1] < 0) Console.WriteLine("Точка находится в третьей четверти");
else Console.WriteLine("Точка находится в четвертой четверти");
