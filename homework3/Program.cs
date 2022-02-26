// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число");
string inputNumber = Console.ReadLine();
int number = int.Parse(inputNumber);

if (number % 2 == 0) Console.Write("Четное");
else Console.Write("Нечетное");
