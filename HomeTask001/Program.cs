// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int num1 = new Random().Next(0, 100);
int num2 = new Random().Next(0, 100);

if( num1 > num2 )
    Console.WriteLine($"Number {num1} > {num2}. Max = {num1}");
else
    Console.WriteLine($"Number {num1} < {num2}. Max = {num2}");


