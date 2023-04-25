// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
long num = Convert.ToInt64(Console.ReadLine());
if (num > 99)
{
    while (num > 999)
    {
       num = num / 10;
    }
    Console.WriteLine(num % 10);
}
else
{
    Console.WriteLine("третьей цифры нет");
}