// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. (exponent)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("\nTask-025\n");

Console.Write("Введите целое число: ");
int num25 = 0;
int.TryParse(Console.ReadLine(), out num25);

Console.Write("Введите целое число (степень): ");
int exp = 0;
int.TryParse(Console.ReadLine(), out exp);

double Exponent(int numb, int ex)
{
    double result = 1;
    for (int i = 1; i <= ex; i++)
        result *= numb;
    return result;
}

Console.Write($"{num25} ** {exp} -> {Exponent(num25, exp)} \n");


// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("\nTask-027\n");

Console.Write("Введите целое число: ");
int num27 = 0;
int.TryParse(Console.ReadLine(), out num27);

int sumDigit(int numb)
{
    int result = 0;
    while (numb > 0)
    {
        result += numb % 10;
        numb /= 10;
    }
    return result;
}

Console.Write($"{num27} -> {sumDigit(num27)} \n");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("\nTask-029\n");

Console.Write("Введите размер массива: ");
int size = 0;
int.TryParse(Console.ReadLine(), out size);

int[] arr29 = new int[size];

void CreateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(100);
}

CreateArray(arr29);

foreach (var el in arr29)
    Console.Write($"{el}, ");
Console.Write("\b\b -> [");    // \b - backspace
foreach (var el in arr29)
    Console.Write($"{el}, ");
Console.Write("\b\b]");
