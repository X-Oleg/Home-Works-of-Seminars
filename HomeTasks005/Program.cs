// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("\nTask-034\n");

Console.Write("Введите размер массива: ");
int size = 0;
int.TryParse(Console.ReadLine(), out size);

int[] arr34 = new int[size];

void FillArray(int[] arr, int min = 0, int max = 10)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(min, max + 1);
}

FillArray(arr34, 100, 1000);
int count34 = 0;
Console.Write("[");
foreach (var elt in arr34)
{
    Console.Write($"{elt}, ");
    count34 += elt % 2 == 0 ? 1 : 0;
}
Console.Write($"\b\b] -> {count34}\n");


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("\nTask-036\n");

Console.Write("Введите размер массива: ");
int size36 = 0;
int.TryParse(Console.ReadLine(), out size36);

int[] arr36 = new int[size36];

FillArray(arr36, -99, 100); // функция определена выше в задаче 34

int sum36 = 0;
for( int i = 0; i < size36; i+=2)
    sum36 += arr36[i];

Console.Write("[");
foreach (var elt in arr36)
    Console.Write($"{elt}, ");
Console.Write($"\b\b] -> {sum36}\n");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("\nTask-038\n");

Console.Write("Введите размер массива (более 1): ");
int size38 = 0;
int.TryParse(Console.ReadLine(), out size38);

int[] arr38 = new int[size38];
FillArray(arr38, 0, 100); // функция определена выше в задаче 34

int max38 = arr38[1];
int min38 = arr38[0];
if( arr38[0] > arr38[1] )
{
    max38 = arr38[0];
    min38 = arr38[1];
}

for( int i =2; i < size38; i++)
{
    if( arr38[i] > max38 ) max38 = arr38[i];
    if( arr38[i] < min38 ) min38 = arr38[i];
}

Console.Write("[");
foreach (var elt in arr38)
    Console.Write($"{elt}, ");
Console.Write($"\b\b] -> {max38 - min38}\n");
Console.Write($"max {max38}, min {min38}\n");

