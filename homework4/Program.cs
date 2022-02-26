// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число");
string inputNumber = Console.ReadLine();
int N = int.Parse(inputNumber);

int A = 1;
Console.Write(A+" ");
while (A < N)
{
    A = A + 1;
Console.Write(A+" ");
}
