/* Напишите программу которая принемает на вход трехзначное 
число и на выходе последнюю цифру этого числа
*/
Console.WriteLine("Введи трехзначное число ");

int number = Convert.ToInt32(Console.ReadLine());
int integer = 0;

if (number < 100 || number > 999) Console.WriteLine ("Не тупи не будь как Фареник, трехзначное число ");
else {
integer = number% 10;
Console.WriteLine(integer);
}