// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateRandom3DArray()

{

    Console.Write("введите X:");
    int X = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите Y: ");
    int Y = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите Z: ");
    int Z = Convert.ToInt32(Console.ReadLine());
    int[,,] array3D = new int[X, Y, Z];

    for (int i = 0; i < X; i++)

        for (int j = 0; j < Y; j++)

            for (int k = 0; k < Z; k++)

                array3D[i, j, k] = new Random().Next(10, 99);

    return array3D;

}



void Show3DArray(int[,,] array3D)

{

    for (int i = 0; i < array3D.GetLength(0); i++)

    {

        for (int j = 0; j < array3D.GetLength(1); j++)

        {

            Console.WriteLine();

            for (int k = 0; k < array3D.GetLength(2); k++)

            {

                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");

            }

        }

    }

}


int[,,] myArray = CreateRandom3DArray();

Show3DArray(myArray);
