// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Type a weekday > ");
int day = Convert.ToInt32(Console.ReadLine());

if (day <= 0 || day > 7) 
{
    Console.WriteLine("There isn't such a weekday!");
}
else if (day > 5) 
{
    Console.WriteLine("I caan't wait, for the weekend tooo begin(begin,begin,begin)");
}
else 
{
    Console.WriteLine("You're have a job to do");
}