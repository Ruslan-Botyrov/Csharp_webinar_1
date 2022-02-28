// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число A");
string inputNumberA = Console.ReadLine();
int A = int.Parse(inputNumberA);

Console.Write("Введите число B");
string inputNumberB = Console.ReadLine();
int B = int.Parse(inputNumberB);

Console.Write("Введите число C");
string inputNumberC = Console.ReadLine();
int C = int.Parse(inputNumberC);

int Maximum = A;
if (B>Maximum) Maximum = B;
if (C>Maximum) Maximum = C;

Console.Write($"Максимальное число {Maximum}");