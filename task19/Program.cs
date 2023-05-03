// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом



int Palindrom(int num)
{
    int revers = 0;
    while (num > 0)
    {
        revers = revers * 10 + num %10;
        num /= 10;
    }
    return revers;
}



Console.WriteLine("Введите число");
int numPalindrom = Convert.ToInt32(Console.ReadLine());
if (numPalindrom == Palindrom(numPalindrom))
{
    Console.WriteLine($"{numPalindrom} является палиндромом");
}
else
{
    Console.WriteLine($"{numPalindrom} не является палиндромом");

}
