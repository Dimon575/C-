/*Напишите программу которая выводит случайное трехзначное
число и удаляет вторую цифру этого числа*/

int rundomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное число - {rundomNumber}");
int number1 = rundomNumber % 10;
int number2 = rundomNumber / 100;
int resoult = number2* 10 + number1;
Console.WriteLine(resoult);
