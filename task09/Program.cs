int rundomNumber = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число - {rundomNumber}");
int number1 = rundomNumber % 10;
int number2 = rundomNumber / 10;
Console.Write($"У числа {rundomNumber} большая цифра ");
if (number1 > number2)
Console.WriteLine(number1);
else
Console.WriteLine(number2);

