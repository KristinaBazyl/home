// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

 
int PositivNumbersArray(int[]array) 
{ 
    int count = 0; 
    for (int i = 0; i < array.Length; i++) 
     
        if (array[i] > 0) count++; 
    return count; 
} 
 
System.Console.WriteLine("Enter elements of array with gaps:"); 
int[] NewArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
 
System.Console.WriteLine($"There are {PositivNumbersArray(NewArray)} positive numbers in this array."); 
 
 