// Сравнение чисел
Console.Write("Введите число a =>");
string InputA = Console.ReadLine();
int numberA = int.Parse(InputA);

Console.Write("Введите число b =>");
string InputB = Console.ReadLine();
int numberB = int.Parse(InputB);

int value = numberA * numberA;
if (numberB == value) Console.WriteLine("Да");
else
{
    Console.WriteLine("Нет");
}
