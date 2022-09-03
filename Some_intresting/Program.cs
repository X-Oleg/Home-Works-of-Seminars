// This is branch Main?
/*
double a = 50;
// int b = 70;

Console.Write("Insert Number: ");
double num = double.Parse(Console.ReadLine()!);

Console.Write("Insert Number2: ");
if (!(double.TryParse(Console.ReadLine(), out a)))
    Console.Write("Don't Number!!\n\n");
else
{
    Console.WriteLine(num + " ** " + a + "\n stepen");
    Console.Write(Math.Pow(num, a)); // num ** a
    Console.Write($"\n a =  {a}  Number =  {num}\n\n");
}
*/

/*          Seminar 2
// -------------------------------------------------------
int number = new Random().Next(10000, 100000);

// функция возвращает цифру стоящую на n месте (н) справа в числе
int DigitOfNumberR(int num, int n)
{
    int numTemp = num;
    int k = 1;
    while ((numTemp /= 10) != 0)
        k++;
    if (n > k)
        return -1;
    return (num / (int)Math.Pow(10, n - 1)) % 10;
}
// функция возвращает цифру стоящую на n месте (н) слева в числе
int DigitOfNumberL(int num, int n)
{
    int numTemp = num;
    int k = 1;
    while ((numTemp /= 10) != 0)
        k++;
    if (n > k)
        return -1;
    return (num / (int)Math.Pow(10, k - n)) % 10;
}

Console.Write($"{number}  <-4-  {DigitOfNumberR(number, 4)}\n");
Console.Write($"{number}  -4->  {DigitOfNumberL(number, 4)}\n");

int number3 = new Random().Next(100, 1000);

// формула принимает трехзначное число и возвращает двухзначное 
// удалив вторую цифру
Console.Write($"{number3}  --->  {number3 / 100 * 10 + number3 % 10}\n");

Char[] array = { number3.ToString()[0], number3.ToString()[2] };
Console.WriteLine(array);

// кратные or не кратные числа

int n1 = new Random().Next(10, 100);
int n2 = new Random().Next(1, 10);

if (n1 % n2 == 0)
    Console.WriteLine($"{n1} кратно {n2}");
else
    Console.WriteLine($"{n1} не кратно {n2}, остаток {n1 % n2}");
*/

/*                  Lecture 3
// ----------------------------------------------------------

//  two size matrix
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} - ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // 0 - row
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // 1 - column
        {
            matr[i, j] = new Random().Next(1, 10);
        }

    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

// Recursion

double Factorial(int n)
{
    if (n == 1) return 1;
    else return (n * Factorial(n - 1));
}

Console.WriteLine(Factorial(10));

// Fibonachy

double Fibonachy(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonachy(n - 1) + Fibonachy(n - 2);
}
for (int i = 1; i < 10; i++)
    Console.WriteLine(Fibonachy(i));

*/

/*              Seminar 03
// ----------------------------------------------------


int Q = 0;
Console.Write("Write squeare: ");
int.TryParse(Console.ReadLine(), out Q);

switch (Q)
{
    case 1:
        Console.Write("X > 0 && Y > 0");
        break;
    case 2:
        Console.Write("X < 0 && Y > 0");
        break;
    case 3:
        Console.Write("X < 0 && Y < 0");
        break;
    case 4:
    case 7:
        Console.Write("X > 0 && Y < 0");
        break;
    default:
        Console.Write("No entry!");
        break;
}

Console.Write("\n");

string QuarterCondition(int q)
{
    switch (q)
    {
        case 1:
            return ("X > 0 && Y > 0");
        case 2:
            return ("X < 0 && Y > 0");
        case 3:
            return ("X < 0 && Y < 0");
        case 4:
        case 7:
            return ("X > 0 && Y < 0");
        default:
            return ("No entry!");
    }
}

Console.Write(QuarterCondition(Q));

// Distance 

int[] A = { 7, -5 };
int[] B = { 1, -1 };

double Distance(int[] a, int[] b)
{
    return Math.Sqrt(Math.Pow((a[0] - b[0]), 2) + Math.Pow((a[1] - b[1]), 2));
}

Console.Write(Distance(A, B));

void SquareLine()
{
    Console.Write("Insert number N: ");
    int.TryParse(Console.ReadLine(), out int N);
    for (int i = 1; i <= N; Console.Write($"{i * i} "), i++) ;
}

SquareLine();
*/


/*              Seminar 04
// ----------------------------------------------------

// Count digits of number
Console.Write("Insert number A: ");
int A = 0;
int.TryParse(Console.ReadLine(), out A);

int DigitCount(int a)
{
    int k = 0;
    while (a > 0)
    {
        a /= 10;
        k++;
    }
    return k;
}

Console.Write($" {DigitCount(A)} digit in your number {A} \n");
//
// Factorial in cicle
Console.Write("Insert number F: ");
int F = 0;
int.TryParse(Console.ReadLine(), out F);

double Factoriall(int f)
{
    double result = 1;
    for (int i = 1; i <= f; result *= i, i++) ;
    return result;
}

Console.Write($" Factorial {F}! = {Factoriall(F)} \n");

// Function Create Array
int[] array = new int[8];

void CreateArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(2);
}

CreateArray(array);
foreach (var el in array)
    Console.Write($"{el} - ");

//

int A = 10;

void RecursPrint(int i, int a)
{
    Console.Write($"{i} ");
    if (i < a)
        RecursPrint(i + 1, a);
}

RecursPrint(3, A);

int RecursSum(int i, int a, int sum = 0)
{
    if (i <= a)
        return RecursSum(i + 1, a, sum + i);
        return sum;
}
Console.Write($"Sum = {RecursSum(3, A)} \n");

*/

/*            Seminar 05
// -----------------------------------------------
//

List<string> array = new List<string> { "1", "2", "3" };

foreach (var element in array)
    Console.Write($"{element} - ");

// ----- строку в массив...

string user = Console.ReadLine()!;
int[] arrayStr = new int[user.Length];

int i = 0;
foreach (var elem in user)
{
    if (elem >= '0' && elem <= '9')
    {
        string temp = "";
        temp += elem;
        arrayStr[i] = Convert.ToInt32(temp);
    }
    i++;
}

foreach (var el in arrayStr)
    Console.Write($"{el} ");

// сумма положит и отицат элементов массива ТЕРНАРНЫЕ опер

int[] arrayN = new int[12];
for (int j = 0; j < arrayN.Length; j++)
    arrayN[j] = new Random().Next(-9, 10);
foreach (var elt in arrayN)
    Console.Write($"{elt} ");

int posSum = 0;
int negSum = 0;

foreach (var elt in arrayN)
{
    // if (elt > 0)
    //     posSum += elt;
    // else
    //     negSum += elt;
    posSum += elt > 0 ? elt : 0;
    negSum += elt < 0 ? elt : 0;
}

Console.Write($"\nPositive Sum = {posSum}\nNegative Sum = {negSum}\n");

int aa = -20;
int bb = aa > 0 ? (aa < 10 ? 10 : 5) :2;
// -------- !!!!! -------------
*/
// найти произведение парных от центра чисел массива

int[] arrayRn = new int[new Random().Next(5, 9)];

// Console.Write("Insert number for search: ");
// int nn = 0;
// int.TryParse(Console.ReadLine(), out nn);

for (int i = 0; i < arrayRn.Length; i++)
{
    arrayRn[i] = new Random().Next(0, 10);
    Console.Write($"{arrayRn[i]} ");
}

Console.Write("\n");

for (int j = 0; j < (arrayRn.Length) / 2; j++)
{
    Console.Write($"{arrayRn[j] * arrayRn[arrayRn.Length - 1 - j]}  ");
}
if (arrayRn.Length % 2 != 0)
    Console.Write($"{arrayRn[(arrayRn.Length) / 2]}");






