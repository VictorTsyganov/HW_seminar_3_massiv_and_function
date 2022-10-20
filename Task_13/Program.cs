// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
string number = (Math.Abs(n)).ToString();

if (number.Length < 3)
{
    Console.Write($"{n} -> третьей цифры нет.");
}
else
{
    Console.Write($"{n} -> третья цифра {number[2]}.");
}
