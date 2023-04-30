//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.WriteLine("Введите число");
double num = Convert.ToDouble(Console.ReadLine());

double firstNum = 1;
double result = 0;
while (firstNum <= num)
{
    result = Math.Pow(firstNum, 3);
    Console.Write($" {result}");
    firstNum++;
}
