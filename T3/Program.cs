// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Input the first number");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b) Console.WriteLine("Yes, the first number is a square of the second number");
else if (b == a * a) Console.WriteLine("Yes, the second number is a square of the first number");
else Console.WriteLine("No, the is no such numbers");

