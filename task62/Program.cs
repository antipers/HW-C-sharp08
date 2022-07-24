/* Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */

int size = 4;
int[,] matrix = GetMatrixBySPIRALL(size);
PrintMatrix(matrix);

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write(mtrx[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrixBySPIRALL(int length)
{
    int[,] array = new int[length, length];
    int number = 1;
    for (int j = 0; j < length; j++)
    {
        for (int i = 0 + j; i < length - j; i++) 
        {
            array[0 + j, i] = number++;
        }
        number--;
        for (int i = 0 + j; i <= length - 1 - j; i++) 
        {
            array[i, length - 1 - j] = number++; 
        }
        number--;
        for (int i = length - 1 - j; i >= 0 + j; i--)
        {
            array[length - 1 - j, i] = number++;
        }
        number--;
        for (int i = length - 1 - j; i > 0 + j; i--)
        {
            array[i, 0 + j] = number++;
        }
    }
    return array;
}