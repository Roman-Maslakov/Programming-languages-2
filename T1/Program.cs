//Random newNumber = new Random();
//int number = newNumber.Next(10,100);

int number = new Random().Next(10, 99);
Console.WriteLine("Сгенерировано число - " + number);

int a = number / 10;
int b = number % 10;

if (a < b) Console.WriteLine($"Вторая цифра больше - {b}");
else if (a > b) Console.WriteLine($"Первая цифра больше - {a}");
else Console.WriteLine($"Числа равны {a} = {b}");

// Console.WriteLine("Сгенерировано число - {0}, десятки - {1}, единицы - {2}", number, a, b);