//  Задача 60. Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно
//  выводить массив, добавляя индексы каждого элемента.

/* Задача 60. Сформируйте трёхмерный массив 
из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно
 выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1) */

Console.WriteLine("Количество листов: ");
int lists = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int minRandom = 10;
int maxRandom = 99;


int[,,] matrix = GetMatrix(rows, columns, lists, minRandom, maxRandom);
PrintMatrix(matrix);
PrintIndexMatrix(matrix);

int[,,] GetMatrix(int row, int colmn, int list, int min, int max)
{
    int[,,] arr = new int[lists, rows, columns];
    var rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (minRandom<=maxRandom)
                {
                    arr[i, j, k] = minRandom;
                    minRandom++;
                }
                else
                {
                   Console.WriteLine("Программа не расчичитана на генерацию массивов с числами больше 99");
                }
            }
        }
    }
    return arr;
}

void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("Page №" + (i + 1));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void PrintIndexMatrix(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("Page №" + (i + 1));
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}