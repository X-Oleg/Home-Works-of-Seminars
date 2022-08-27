// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number3 = new Random().Next(100, 1000);
Console.WriteLine($"Task010 Number {number3} -2-> {number3.ToString()[1]}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number23 = new Random().Next(1, 10000);

int DigitOfNumberLeft(int num, int n)
{
    int numTemp = num;
    int k = 1;
    while ((numTemp /= 10) != 0)
        k++;
    if (n > k)
        return -1;
    return (num / (int)Math.Pow(10, k - n)) % 10;
}

int quest = DigitOfNumberLeft(number23, 3);

if (quest == -1)
    Console.WriteLine($"Task013 Number {number23} -> третьей цифры нет!");
else
    Console.WriteLine($"Task013 Number {number23} -3-> {quest}");

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int weekDay = new Random().Next(1, 8);

string WeekEnd(int day)
{
    if (day == 6 || day == 7)
        return "Yes";
    else
        return "No";
}

Console.WriteLine($"Task015 Is day {weekDay} weekend? -> {WeekEnd(weekDay)}\n");