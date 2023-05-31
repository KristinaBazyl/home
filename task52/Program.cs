// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}


void AvarageSummCols(int[,] array, int rows)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avarage = 0;
        int n = rows;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avarage = (avarage + array[i, j]);
        }
        avarage = avarage / n;
        Console.Write(avarage + "; ");

    }
}


/*double[] AvarageSumm(int[,] array)
{
    double[] myarray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            myarray[j] += Convert.ToDouble(array[i, j]);
        }
    }
    for (int i = 0; i < myarray.Length; i++)
        myarray[i] /= array.GetLength(0);
    return myarray;
}


void PrintArrayTwo(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i],3}    ");
    }
    System.Console.WriteLine();
}
*/


Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
AvarageSummCols(array, rows);
// double [] arrayNew = AvarageSumm(array);
// PrintArrayTwo(arrayNew);

