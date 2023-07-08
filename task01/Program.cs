/* Напишите программу, которая на вход принимает два числа
и проверяет, евляется ли первое число 
квадратом второго*/

Console.WriteLine ("введите два числа ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2* number2)
Console.WriteLine ("true");
else
Console.WriteLine ("false");