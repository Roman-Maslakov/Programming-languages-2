// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

Console.WriteLine("Genetating a new nimber");
int N = new Random().Next(100,1000);
Console.WriteLine(N);

int A = N / 100;
int B = N % 10;

Console.WriteLine("Running...");
Console.WriteLine($"Here is the number {A}{B}");