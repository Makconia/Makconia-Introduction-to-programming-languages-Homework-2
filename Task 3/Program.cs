// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите порядковый номер дня в неделе:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 8 && num > 0)
{
    string rez = (num == 6 || num == 7) ? "День выходной" : "День не выходной";
    System.Console.WriteLine(rez);
}
else
{
    System.Console.WriteLine("Нет такого дня");
}