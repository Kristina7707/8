
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
     Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

int[,] СompositionMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            result[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write (j < matrix.GetLength(1) -1?
            $"{matrix[i, j], 3}" :$"{matrix[i, j], 3} ");
        }
        Console.WriteLine();
    }
}

int row = 2;
int col = 3;

int[,] matrix1 = CreateMatrix(row, col, 1, 10);
int[,] matrix2 = CreateMatrix(row, col, 1, 10);
int[,] result = СompositionMatrix(matrix1, matrix2);
Console.WriteLine("Матрица № 1");
PrintMatrix(matrix1);
Console.WriteLine("Матрица № 2");
PrintMatrix(matrix2);
Console.WriteLine("Произведение");
PrintMatrix(result);