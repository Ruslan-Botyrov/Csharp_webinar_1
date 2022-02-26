// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число A");
string inputNumberA = Console.ReadLine();
int A = int.Parse(inputNumberA);

Console.Write("Введите число B");
string inputNumberB = Console.ReadLine();
int B = int.Parse(inputNumberB);

if (A>B) Console.Write($"Max = {A}");
else Console.Write($"Max = {B}");
