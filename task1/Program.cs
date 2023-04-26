// Задача необязательная 1: на входе целое или вещественное число,
// надо удалить вторую цифру слева этого числа.
// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123
 Console.WriteLine("Введите число");
 double num = Convert.ToDouble(Console.ReadLine());
 if (num > 9) {
    double part2 = num - Convert.ToUInt32(num);
    int part1 = Convert.ToInt32(num);
    int i = part1;
    int count = 0;
    while (i > 0) {
        count ++;
        i = i / 10;}
    int res = part1 / Convert.ToInt32(Math.Pow(10, count - 1)) * Convert.ToInt32(Math.Pow(10, count - 2)) + part1 % Convert.ToInt32((Math.Pow(10, count - 2)));
    Console.WriteLine(Convert.ToDouble(res) + part2);
 }
 else {
    Console.WriteLine("Нет");
 }
 

