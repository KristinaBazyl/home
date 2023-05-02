// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// bool Palindrom(string num)
// {  
//     for (int first = 0, last = num.Length - 1; first < last; ++first, --last)
//     {
//         if (num[first] != num[last])
//         {
//             return false;
//         }
//     }

    // return true;


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
