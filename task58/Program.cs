// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int[,] MultMatrix(int[,] mtrx1, int[,] mtrx2)
{
    
    int[,] resultMatrix = new int[mtrx1.GetLength(0), mtrx2.GetLength(1)];

        for (int i = 0; i < mtrx1.GetLength(0); i++) 
        {
            for (int j = 0; j < mtrx2.GetLength(1); j++) 
            {
                for (int k = 0; k < mtrx2.GetLength(0); k++) 
                {
                    resultMatrix[i, j] += mtrx1[i, k] * mtrx2[k, j];
                }
            }
        }
        return resultMatrix;
}
int[,] matrixA = GetMatrix(3, 3, 0, 5);
Console.WriteLine("Matrix A");
PrintMatrix(matrixA);
int[,] matrixB = GetMatrix(3, 3, 0, 5);
Console.WriteLine("Matrix B");
PrintMatrix(matrixB);
Console.WriteLine("Matrix A * Matrix B=");
int[,] matrixC = MultMatrix(matrixA,matrixB);
PrintMatrix(matrixC);