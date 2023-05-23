//  Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
int[] arrayN (int size)
{
    int[] res = new int[size];
   
    for(int i=0; i<res.Length; i++)
    {
        System.Console.WriteLine($"Введите элемент массива с индексом {i}");
        res[i] = Convert.ToInt32(Console.ReadLine());
        }
    return res;
}


System.Console.WriteLine("Введите размер массива");
int x = Convert.ToInt32(Console.ReadLine());
int [] array = new int [x];
System.Console.WriteLine(string.Join("  ", arrayN(x))); 

