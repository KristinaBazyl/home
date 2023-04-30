// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
int Palindrom(int num)
{
    int revers = 0;
    while (num > 0)
    {
        revers = revers * 10 + num / 10;
        num /= 10;
    }
    return revers;
}



Console.WriteLine("Введите число");
int numPalindrom = Convert.ToUInt32(Console.ReadLine());
if (numPalindrom < 0)
{
    Console.WriteLine($"{numPalindrom} не является палиндромом, введите число > 0");
}
if (numPalindrom == Palindrom(numPalindrom))
{
    Console.WriteLine($"{numPalindrom} является палиндромом");
}
else
{
    Console.WriteLine($"{numPalindrom} не является палиндромом");
}
