// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("\nTask-054\n");

int[,] array = new int[new Random().Next(4, 6), new Random().Next(4, 6)];

int[,] FillArray(int row, int clmn, int num = 10)
{
    int[,] tmpArr = new int[row, clmn];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < clmn; j++)
            tmpArr[i, j] = new Random().Next(num);
    return tmpArr;
}

array = FillArray(array.GetLength(0), array.GetLength(1));

int[,] SortRows(int[,] arr)
{
    int[,] tempArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            tempArr[i, j] = arr[i, j];


    for (int i = 0; i < arr.GetLength(0); i++) // сортировка
    {
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (tempArr[i, j] < tempArr[i, j + 1])
                {
                    int temp = tempArr[i, j];
                    tempArr[i, j] = tempArr[i, j + 1];
                    tempArr[i, j + 1] = temp;
                }
            }
        }
    }
    return tempArr;
}

void PrintArray(int[,] tarray)
{
    for (int i = 0; i < tarray.GetLength(0); i++)
    {
        for (int j = 0; j < tarray.GetLength(1); j++)
        {
            Console.Write($"{tarray[i, j]} ");
        }
        Console.Write($"\n");
    }
}

PrintArray(array);
Console.WriteLine();
PrintArray(SortRows(array));


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка


Console.Write("\nTask-056\n");

int MinRows(int[,] arr)
{
    int minRows = 0;
    int tmpSum = 0;
    int minSum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tmpSum += arr[i, j];
        }
        if (i == 0)
            minSum = tmpSum;
        if (i > 0 && tmpSum < minSum)
        {
            minRows = i;
            minSum = tmpSum;

        }
        Console.Write($"{i + 1} -> {tmpSum}  ");
        tmpSum = 0;
    }
    return minRows + 1;
}

Console.Write($"\nNumber of row with min sum: {MinRows(array)}\n");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("\nTask-058\n");

// int[,] arrayA = new int[2,2] {{2, 4}, {3, 2}}; // control A
// int[,] arrayB = new int[2,2] {{3, 4}, {3, 3}}; // control B

int[,] arrayA = new int[new Random().Next(2, 5), new Random().Next(2, 5)];
int[,] arrayB = new int[arrayA.GetLength(1), new Random().Next(2, 5)];

int[,] arrayC = new int[arrayA.GetLength(0),arrayB.GetLength(1)];

arrayA = FillArray(arrayA.GetLength(0), arrayA.GetLength(1));
arrayB = FillArray(arrayB.GetLength(0), arrayB.GetLength(1));

PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();

int[,] multiplyArrays( int[,] arrA, int[,] arrB)
{
    int[,] tmpArr = new int [arrA.GetLength(0), arrB.GetLength(1)];
    if(arrA.GetLength(1) != arrB.GetLength(0)) // Must: column A == row B
        return tmpArr;
    for( int i = 0; i < arrA.GetLength(0); i++)
    {
        for(int j = 0; j < arrB.GetLength(1); j++)
        {
            for(int k = 0; k < arrA.GetLength(1); k++)
                tmpArr[i, j] += arrA[i, k] * arrB[k, j];
        }
    }
    return tmpArr;
}

PrintArray(multiplyArrays(arrayA, arrayB));
Console.WriteLine();


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("\nTask-060\n");

int[,,] array3D = new int[new Random().Next(2, 4), new Random().Next(2, 4), new Random().Next(2, 4)];

int[,,] FillArray3D(int row, int clmn, int depth, int num = 10)
{
    int[,,] tmpArr = new int[row, clmn, depth];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < clmn; j++)
            for (int k = 0; k < depth; k++)
                tmpArr[i, j, k] = new Random().Next(num);
    return tmpArr;
}

void PrintArray3D(int[,,] tarray)
{
    for (int i = 0; i < tarray.GetLength(0); i++)
    {
        for (int j = 0; j < tarray.GetLength(1); j++)
        {
            for (int k = 0; k < tarray.GetLength(2); k++)
            {
                Console.Write($"{tarray[i, j, k]}({i},{j},{k})  ");
            }
            Console.Write($"\n");
        }
        Console.Write($"\n");
    }
}

array3D = FillArray3D(array3D.GetLength(0), array3D.GetLength(1), array3D.GetLength(2), 100);
PrintArray3D(array3D);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("\nTask-062\n");

int[,] SpiralFillArray(int cube = 4)
{
    int[,] tmpArr = new int[cube, cube];
    int count = 1;
    int step = 0;

    for (int i = 0, j = 0; j < cube; tmpArr[i, j] = count, count++, j++) ;
    for (int i = 1, j = cube - 1; i < cube; tmpArr[i, j] = count, count++, i++) ;
    for (int i = cube - 1, j = cube - 2; j >= 0; tmpArr[i, j] = count, count++, j--) ;
    for (int i = cube - 2, j = 0; i > 0; tmpArr[i, j] = count, count++, i--) ;
    step++;
    for (int i = 1, j = 1; j < cube - 1; tmpArr[i, j] = count, count++, j++) ;
    for (int i = 2, j = cube - 2; i < cube - 1; tmpArr[i, j] = count, count++, i++) ;
    for (int i = cube - 2, j = cube - 3; j >= (0 + step) && count <= cube * cube; tmpArr[i, j] = count, count++, j--) ;
//    for (int i = cube - (2+step), j = step; i > step && count <= cube * cube; tmpArr[i, j] = count, count++, j--) ;

    return tmpArr;
}

PrintArray(SpiralFillArray());