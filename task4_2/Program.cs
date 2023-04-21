// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2> num1)
{
    max = num2;
}
if (num3> num1)
{
    max = num3;
}

Console.WriteLine($"max = {max}");