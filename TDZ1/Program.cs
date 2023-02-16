//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write("Input a number > ");
// int AAA = Convert.ToInt32(Console.ReadLine());
// int secondN = 0;

// if (AAA / 100 > 9 || AAA / 100 == 0) Console.WriteLine("Input a three-digit number!)");
// else secondN = AAA / 10 % 10;

// Console.WriteLine("There are tens of your number - " + secondN);

int Prompt (string message)
{
    System.Console.Write(message);
    int AAA = Convert.ToInt32(Console.ReadLine());
    return AAA;
}
 int number = Prompt("Введите трехзначное число > ");
 
 if (number / 100 > 9 || number / 100 == 0)
 {
    Console.WriteLine("Input a three-digit number!)");
    return;
 }
 Console.WriteLine($"Введенное число `{number}`");
 int secondN = number / 10 % 10;
 Console.WriteLine("There are tens of your number - " + secondN);