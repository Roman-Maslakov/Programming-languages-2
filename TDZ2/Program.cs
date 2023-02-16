// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input a number > ");
int mysteryNumber = Convert.ToInt32(Console.ReadLine());
int thirdRank = 0;

if (mysteryNumber / 100 == 0) Console.WriteLine("Your number haven't the third rank, try again");
else while (mysteryNumber > 999)
{
    mysteryNumber /= 10;
    thirdRank = mysteryNumber % 10;
    if (mysteryNumber / 1000 == 0) Console.WriteLine(thirdRank);
}

