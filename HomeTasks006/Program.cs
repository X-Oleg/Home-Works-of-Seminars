// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("\nTask-041\n");

Console.Write("Введите размер массива M: ");
int size = 0;
int.TryParse(Console.ReadLine(), out size);

int[] arr41 = new int[size];

void FillArray(int[] arr, int min = 0, int max = 10)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(min, max + 1);
}

FillArray(arr41, -1000, 1000);
int count41 = 0;
Console.Write("[");
foreach (var elt in arr41)
{
    Console.Write($"{elt}, ");
    count41 += elt > 0 ? 1 : 0;
}
Console.Write($"\b\b] -> {count41}\n");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("\nTask-043\n");

Console.Write("Введите коэффициенты для уравнений y = k1 * x + b1, y = k2 * x + b2 \n");
int k1, k2, b1, b2;

Console.Write("Введите b1: ");
int.TryParse(Console.ReadLine(), out b1);
Console.Write("Введите k1: ");
int.TryParse(Console.ReadLine(), out k1);

Console.Write("Введите b2: ");
int.TryParse(Console.ReadLine(), out b2);
Console.Write("Введите k2: ");
int.TryParse(Console.ReadLine(), out k2);

string LinesCross(int d1, int e1, int d2, int e2)
{
    if ( d1 == d2 )
        return "не имеют точки пересечения. Введите другие коэффициенты";
    else
    {
        double x = (double)(e2-e1)/(double)(d1-d2);
        double y = d1 * x + e1;
        return ( "пересекаются в точке X " + x + " Y " + y);
    }
}

Console.Write($"Прямые y = {k1}*x + {b1} и y = {k2}*x + {b2} ");
Console.Write($"{LinesCross(k1,b1,k2,b2)}");
