/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.*/


Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int result = (num /10) % 10;
Console.WriteLine(result);