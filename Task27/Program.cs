﻿void Summaring (int A)
{
    int Sum = 0;
    while (A > 0)
    {
        Sum = Sum + (A % 10);
        A = A / 10;
    }
    Console.WriteLine(Sum);
}

Console.WriteLine("Введите натуральное число");
int Number = Convert.ToInt32(Console.ReadLine());

Summaring(Number);
