// This is branch Lesson-1
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





