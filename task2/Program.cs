// День недели по номеру
Console.Write("Введите число");
string inputNumber = Console.ReadLine();
int number = int.Parse(inputNumber);

if (number == 1) Console.WriteLine("Понедельник");
if (number == 2) Console.WriteLine("Вторник");
if (number == 3) Console.WriteLine("Среда");
if (number == 4) Console.WriteLine("Четверг");
if (number == 5) Console.WriteLine("Пятница");
if (number == 6) Console.WriteLine("Суббота");
if (number == 7) Console.WriteLine("Воскресенье");
if (number > 7) Console.WriteLine("В неделе 7 дней"); 
if (number < 1) Console.WriteLine("В неделе 7 дней");