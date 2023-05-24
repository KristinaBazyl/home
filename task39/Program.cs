// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] FillArray(int size)
{
    double [] array1 = new double [size];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = Math.Round(new Random().NextDouble(),2) + new Random().Next(50);
            }
    return  array1;

}

void PrintArray(double [] array)
{
    foreach (double item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}


System.Console.WriteLine("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = FillArray(size);
PrintArray(array);

