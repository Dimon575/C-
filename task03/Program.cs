/* Напишите программу которая на вход принемает одно число
(n), а на выходе показывает все целые числа в промежутке
 от -n до n
*/

Console.WriteLine("Введи число ");
 int number = Convert.ToInt32(Console.ReadLine());

for (int i = -number; i <= number; i++)
{
    Console.Write (i+" ");
}

