/*программа принимает число и проверяет кратно
 ли оно 7 и 23
*/
Console.Write("Введите 1 число - ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 7 == 0 && Number % 23 == 0)

   Console.WriteLine($"Число {Number} кратно 7 и 23");

else
   Console.WriteLine($"Число {Number} не кратно 7 и 23");   
