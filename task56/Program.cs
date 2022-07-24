// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
int[,] matrix = new int[6, 4]
            {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}, {5,2,6,7}, {7,8,0,3}, {1,9,3,4}};
PrintMatrix(matrix);

StringSum(matrix);

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void StringSum(int[,] matrix)
{
    int[] SUM = new int[matrix.GetLength(0)];
    int minSumLine = SUM[0];
    int minIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        SUM[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SUM[i] += matrix[i, j];
        }
        Console.WriteLine($"Сумма строки {i + 1} равна {String.Join(",", SUM[i])}");
    }
    for (int k = 1; k < SUM.Length; k++)
    {
        if (SUM[k] <= minSumLine) 
        {
            minSumLine = SUM[k];
            minIndex=k; 
        } 
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов {minIndex+1}");
}