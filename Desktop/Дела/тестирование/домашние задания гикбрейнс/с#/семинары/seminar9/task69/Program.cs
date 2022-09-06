﻿//  Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine ("Введите A");
int numberA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите B");
int numberB = Convert.ToInt32 (Console.ReadLine());

int SqrAtoB (int a, int b)
{
    return b == 0 ? 1: SqrAtoB(a, b - 1)*a;
}

int result = SqrAtoB (numberA,numberB);
Console.WriteLine(result);