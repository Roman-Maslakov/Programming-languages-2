// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите величину таблицу в числах");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
Console.WriteLine("Введите числа, которые необходимо возвести в квадрат по порядку");

for (int i = 0; i < N; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < N; i++)
{
    array[i] *= array[i];
    Console.Write(array[i] + " ");
}

