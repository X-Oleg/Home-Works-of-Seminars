// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("\nTask-064\n");

int num;
Console.Write("Insert number N: ");
int.TryParse(Console.ReadLine(), out num);

Console.WriteLine($"{PrintNumbers(num, 1)}");

string PrintNumbers(int start, int end)
{
    if (start <= end)
        return start.ToString();
    return $"{start} {PrintNumbers(start - 1, end)}";
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("\nTask-066\n");

int M;
Console.Write("Insert number M: ");
int.TryParse(Console.ReadLine(), out M);
int N;
Console.Write("Insert number N: ");
int.TryParse(Console.ReadLine(), out N);

int SumNumbers(int start, int end)
{
    if (start >= end)
        return end;
    return end + SumNumbers(start, end - 1);
}

Console.WriteLine(SumNumbers(M, N));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("\nTask-068\n");

int mA;
Console.Write("Insert number m: ");
int.TryParse(Console.ReadLine(), out mA);
int nA;
Console.Write("Insert number n: ");
int.TryParse(Console.ReadLine(), out nA);

double Accerman(double m, double n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Accerman(m - 1, 1);
    if (m > 0 && n > 0)
        return Accerman(m - 1, Accerman(m, n - 1));
    return -1;
}

Console.Write($"m = {mA}, n = {nA} -> A(m,n) = {Accerman(mA, nA)}");
