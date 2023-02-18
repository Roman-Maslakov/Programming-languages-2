// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите четверть");
int Quad = Convert.ToInt32(Console.ReadLine());

switch (Quad)
{
    case 1:
    Console.WriteLine("x > 0, y > 0");
    break;

    case 2:
    Console.WriteLine("x < 0, y > 0");
    break;

    case 3:
    Console.WriteLine("x < 0, y < 0");
    break;

    case 4:
    Console.WriteLine("x > 0, y < 0");
    break;

    default:
    Console.WriteLine("ERROR");
    break;
}