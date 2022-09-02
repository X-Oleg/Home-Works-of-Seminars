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
    Console.WriteLine(num +" ** " + a + "\n stepen");
    Console.Write(Math.Pow(num, a)); // num ** a
    Console.Write($"\n a =  {a}  Number =  {num}\n\n");
}
*/

//          Seminar 2
/* -------------------------------------------------------
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

//                  Lecture 3
/* ----------------------------------------------------------

//  two size matrix
void PrintArray(int[,] matr)
{
    for(int i=0; i < matr.GetLength(0); i++)
    {
        for(int j=0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} - ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int i=0; i < matr.GetLength(0); i++) // 0 - row
    {
        for(int j=0; j < matr.GetLength(1); j++)  // 1 - column
        {
            matr[i,j] = new Random().Next(1, 10);
        }
        
    }
}

int[,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/

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
    if(n == 1 || n == 2) return 1;
    else return Fibonachy(n-1) + Fibonachy(n-2);
}
for(int i =1; i < 10; i++)
    Console.WriteLine(Fibonachy(i));


