﻿//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число:");
string num = Console.ReadLine();
if (num.Length > 2)
{
    System.Console.WriteLine("Третья цифра: " + num[2]);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}

