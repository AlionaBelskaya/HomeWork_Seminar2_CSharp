// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 & number < 1000)
{
    Console.WriteLine("Третье число:" + number%10);
}  
if (number > 999 & number < 10000)
{
    Console.WriteLine("Третье число:" + number/10%10);
}  
if (number > 9999  & number < 100000)
{
    Console.WriteLine("Третье число:" + number/100%10);
}  
if (number < 100)
{
    Console.WriteLine("Третьего числа нет");
}

