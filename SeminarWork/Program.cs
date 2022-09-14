// Console.Write("Insert number A: ");
// int A = 0;
// int.TryParse(Console.ReadLine(), out A);

// Console.WriteLine($"Number A {A} ");

/*Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.*/

// int[,] array = new int[new Random().Next(3, 6), new Random().Next(4, 7)];

// for (int i = 0; i < array.GetLength(0); i++)
//     for (int j = 0; j < array.GetLength(1); j++)
//         array[i, j] = new Random().Next(99);



// void PrintArray(int[,] tarray)
// {
//     for (int i = 0; i < tarray.GetLength(0); i++)
//     {
//         for (int j = 0; j < tarray.GetLength(1); j++)
//         {
//             Console.Write($"{tarray[i, j]} ");
//         }
//         Console.Write($"\n");
//     }
// }

// int[,] Delete2(int[,] tarray)
// {
//     int[,] newArray = new int[tarray.GetLength(0) - 1, tarray.GetLength(1) - 1];
//     int im = 0;
//     int jm = 0;
//     for (int i = 0; i < tarray.GetLength(0); i++)
//         for (int j = 0; j < tarray.GetLength(1); j++)
//             if (tarray[i, j] < tarray[im, jm])
//             {
//                 im = i;
//                 jm = j;
//             }
//     Console.Write($"Min {tarray[im,jm]} [{im}, {jm}] \n\n");
//     for (int i = 0, i2 = 0; i < tarray.GetLength(0); i++, i2++)
//     {
//         if (i != im)
//         {
//             for (int j = 0, j2 = 0; j < tarray.GetLength(1); j++, j2++)
//             {
//                 if (j != jm)
//                 {
//                     newArray[i2, j2] = tarray[i, j];
//                 }
//                 else
//                 {
//                     j2--;
//                 }
//             }
//         }
//         else
//             i2--;


//     }
//     return newArray;
// }

// PrintArray(array);
// Console.WriteLine();
// PrintArray((array));

// Рекурсия
// вывести натур числа от 1 до N

int N;
Console.Write("Insert number N: ");
int.TryParse(Console.ReadLine(), out N);

Console.WriteLine($"{PrintNumbers(1, N)}");

string PrintNumbers(int start, int end)
{
    if (start >= end)
        return start.ToString();
    return $"{start} {PrintNumbers(start + 1, end)}";
}

// вывести натур числа от N до M

int M;
Console.Write("Insert number M: ");
int.TryParse(Console.ReadLine(), out M);

string PrintNumbers2(int start, int end)
{
    if (start >= end)
        return start.ToString();
    if (start > 0)
        return $"{start} {PrintNumbers2(start + 1, end)}";
    else
        start = 1;
    return PrintNumbers2(start, end);
}

Console.WriteLine($"{PrintNumbers2(N, M)}");

// прогр, кот принимает число и возвращает сумму его цифр

int num;
Console.Write("Insert number : ");
int.TryParse(Console.ReadLine(), out num);

int SumDigits(int n)
{
    if (n > 10) // or 0
    {
        return n % 10 + SumDigits(n / 10);
    }
    return n % 10;
}

Console.WriteLine(SumDigits(num));

// возведение в степень M ** N

int Stepen(int numb, int grade)
{
    if (grade > 1)
        return numb * Stepen(numb, grade - 1);
    return numb;
}

Console.WriteLine(Stepen(M, N));

