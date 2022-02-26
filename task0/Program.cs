// See https://aka.ms/new-console-template for more information
Console.Write("Введите число =>");  //вывод приглашения для ввода
string strValue = Console.ReadLine();   //вывод строки
double value = double.Parse(strValue);        //преобразуем строку в целое число

double result = value * value;             //вычисление квадрата
Console.WriteLine($"Квадрат числа {value} равен: {result}");              //вывод результата