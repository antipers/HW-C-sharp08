// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


void FromMinToMax(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            {
                for (int k = 0; k < matrix.GetLength(1) - 1; k++)

                {
                    if (matrix[i, k] > matrix[i, k + 1])
                    {
                        int temp = matrix[i, k + 1];
                         matrix[i, k + 1] = matrix[i, k];
                        matrix[i, k] = temp;
                    }

                }

            }


        }

    }
}

int[,] arr = GetMatrix(4, 4, 0, 10);
Console.WriteLine("Origin");
PrintMatrix(arr);
System.Console.WriteLine(" Sorted from Min to Max");
FromMinToMax(arr);
PrintMatrix(arr);