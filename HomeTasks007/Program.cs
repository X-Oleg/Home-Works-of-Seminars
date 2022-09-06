// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("\nTask-047\n");

double[,] arr47 = new double[3, 4];

void FillDoubleArray2D(double[,] arr, int min = 0, int max = 10)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLongLength(1); j++)
        {
            int temp = new Random().Next(min, max + 1);
            arr[i, j] = (double)temp / 10;
        }
}

void PrintDoubleArray2D(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLongLength(1); j++)
            Console.Write($"{arr[i, j]}  ");
        Console.Write("\n");
    }
}

FillDoubleArray2D(arr47, -100, 100);
PrintDoubleArray2D(arr47);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.Write("\nTask-050\n");

int[,] arr50 = new int[3, 4];

void FillIntArray2D(int[,] arr, int min = 0, int max = 10)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLongLength(1); j++)
            arr[i, j] = new Random().Next(min, max + 1);
}

void PrintIntArray2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLongLength(1); j++)
            Console.Write($"{arr[i, j]}  ");
        Console.Write("\n");
    }
}

FillIntArray2D(arr50);
PrintIntArray2D(arr50);


Console.Write("Введите строку в массиве (начиная с 1-ой): ");
int row, column;
int.TryParse(Console.ReadLine(), out row);
Console.Write("Введите столбец в массиве (начиная с 1-го): ");
int.TryParse(Console.ReadLine(), out column);

if (row - 1 >= arr50.GetLength(0) || column - 1 >= arr50.GetLength(1) ||
    row <= 0 || column <= 0)
    Console.Write("Вышли за размеры массива. Нет числа!");
else
    Console.Write($"На данной позиции число {arr50[row - 1, column - 1]}");
Console.Write("\n");

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("\nTask-052\n");

// int[,] arr52 = new int[3, 4]{1, 4, 7, 2, 5, 9, 2, 3, 8, 4, 2, 4}; // ??
int[,] arr52 = new int[3, 4];

FillIntArray2D(arr52); // функция определена выше (в задаче 50)
PrintIntArray2D(arr52); // функция определена выше (в задаче 50)

Console.Write("Среднее арифмитическое каждого столбца  ");
for (int j = 0; j < arr52.GetLength(1); j++)
{
    double avg = 0;
    for (int i = 0; i < arr52.GetLongLength(0); i++)
        avg += arr52[i, j];
    avg = avg / arr52.GetLongLength(0);
    Console.Write($"{Math.Round(avg, 1)}; ");
}
Console.Write("\n");