// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.



void PrintNum(int num)
{
    Console.Write(num + " ");
    if (num > 1) PrintNum(num - 1);
}

Console.WriteLine("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Натуральные числа в промежутке от {num} до 1: ");
PrintNum(num);