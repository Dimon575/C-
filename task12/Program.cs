/*программа которая принимает два числа
и выводит является ли второе число кратное первому,
 если не кратное то выводит остаток от деления
*/
Console.Write("Введите 1 число - ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число - ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int result = firstNumber % secondNumber;
if (result == 0)
   Console.WriteLine("True");
else
   Console.WriteLine(result);   