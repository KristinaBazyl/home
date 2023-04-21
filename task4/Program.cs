// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());
int[] array = { num1, num2, num3 };
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if(array[i] > max)
     max = array[i];
}
Console.WriteLine($"max = {max}");
