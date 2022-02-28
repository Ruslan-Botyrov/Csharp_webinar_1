// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число");
string inputNumber = Console.ReadLine();
int N = int.Parse(inputNumber);

int A = 0;

while (A < N-1)
{
    A = A + 2;
    Console.Write(A + " ");
}
