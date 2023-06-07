//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
    System.Console.WriteLine();
}

int [] SummRowsNewArray(int[,] array)
{
    int[] myarray = new int[array.GetLength(0)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            myarray[i] += array[i, j];
        }
    }
    return myarray;
}

int MinSummRows(int[] myarray)
{
    int min = myarray[0];
    int minRows = 0;
    for (int i = 0; i < myarray.Length; i++)
    { 
        if(myarray[i]<myarray[0])
        min= myarray[i];
        minRows = i;
    }
    return minRows;
}


Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
int [] myarray = SummRowsNewArray(array);
int minSummRows = MinSummRows(myarray);
System.Console.WriteLine($"{minSummRows +1} строка с наименьшей суммой элементов");
