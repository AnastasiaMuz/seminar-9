//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine ("Введите M");
int numberM = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите N");
int numberN = Convert.ToInt32 (Console.ReadLine());

if (numberN < numberM)
{
    Console.WriteLine ("число M не может быть больше числа N");
}
else
{
    PrintNumbersToN(numberN, numberM);
}

void PrintNumbersToN (int n, int m)
{
    if(n<m) return;
    PrintNumbersToN( n - 1,m);
    Console.Write(n + " ");
}
