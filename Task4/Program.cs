﻿Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

int i = 2;
while (i <= number)
{
    System.Console.Write( i + ",");
    i = i + 2;
}