// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Task-019");

string Check5Polndrom(int numb19)
{
    string rersult = "No";
    if (numb19/10000 == numb19%10 && numb19/1000%10 == numb19%100/10)
        rersult = "Yes";
    return rersult;
}

Console.Write("Введите 5-ти значное целое число (полиндром?): ");
int number19 = 0;
int.TryParse(Console.ReadLine(), out number19);
Console.Write($"Number {number19} polindrom? -> {Check5Polndrom(number19)} \n");

number19 = 14212;
Console.Write($"Number {number19} polindrom? -> {Check5Polndrom(number19)} \n");
number19 = 12821;
Console.Write($"Number {number19} polindrom? -> {Check5Polndrom(number19)} \n");
number19 = 23432;
Console.Write($"Number {number19} polindrom? -> {Check5Polndrom(number19)} \n");


// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("\nTask-021\n");

double Distance3D(int[] pA, int[] pB)
{
    return Math.Sqrt(Math.Pow((pA[0]-pB[0]), 2) +
                     Math.Pow((pA[1]-pB[1]), 2) +
                     Math.Pow((pA[2]-pB[2]), 2) );
}

void PrintResult21(int[] pA, int[] pB)
{
    Console.Write($"A ({pA[0]},{pA[1]},{pA[2]}); ");
    Console.Write($"B ({pB[0]},{pB[1]},{pB[2]}) ");
    Console.Write($"-> {Distance3D(pA, pB)}\n");
}

Console.Write("Введите три координаты точки A: ");
int[] pointA0 = new int[3];
for(int i = 0; i < 3; i++)
    int.TryParse(Console.ReadLine(), out pointA0[i]);

Console.Write("Введите три координаты точки B: ");
int[] pointB0 = new int[3];
for(int i = 0; i < 3; i++)
    int.TryParse(Console.ReadLine(), out pointB0[i]);

PrintResult21(pointA0, pointB0);

int[] pointA1 = {3, 6, 8};
int[] pointB1 = {2, 1, -7};

PrintResult21(pointA1, pointB1);

int[] pointA2 = {7, -5, 0};
int[] pointB2 = {1, -1, 9};

PrintResult21(pointA2, pointB2);


// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("\nTask-023\n");

Console.Write("Введите целое число: ");
int number23 = 0;
int.TryParse(Console.ReadLine(), out number23);

string PrintNumbCub(int num)
{
    string result = "";
    for(int i=1; i <= num; i++)
        result = result + Math.Pow(i, 3) + ", ";
    return result;
}

Console.Write($"Number {number23} -> {PrintNumbCub(number23)}");

