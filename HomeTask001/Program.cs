// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int num1 = new Random().Next(0, 100);
int num2 = new Random().Next(0, 100);

if (num1 > num2)
    Console.WriteLine($"Task-02  Number {num1} > {num2}. Max = {num1}");
else
    Console.WriteLine($"Task-02  Number {num1} < {num2}. Max = {num2}");

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int numb1 = new Random().Next(0, 100);
int numb2 = new Random().Next(0, 100);
int numb3 = new Random().Next(0, 100);

int max = numb1;
if (numb2 > max)
    max = numb2;
if (numb3 > max)
    max = numb3;

Console.WriteLine($"Task-04  Numbers {numb1}; {numb2}; {numb3}. Max = {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет  

int number = new Random().Next(-20, 20);

if (number % 2 == 0)
    Console.WriteLine($"Task-06  Number {number} is even. => Yes ");
else
    Console.WriteLine($"Task-06  Number {number} is odd. => No ");

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int numberN = new Random().Next(1, 30);
int i = 2;

Console.Write($"Task-08  Number {numberN} ->");

while (i <= numberN)
{
    if (i % 2 == 0)
        Console.Write($" {i},");
    i++;
}

