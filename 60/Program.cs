// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[, ,] CreateMatrixRnd(int row, int col,int err, int min, int max) 
{

    int[,,] matrix = new int[row, col, err];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        
        
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(10, 99);
                int t = matrix[i, j, k];
                 int w = 0;
                  if (w ==t)
                    break;
                if (w != t)
                t = w;
           }
    }
    return matrix;
}

void PrintArrayWithIdex(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k]);
                Console.Write("({0},{1},{2})\t", i, j, k);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

int[,,] matrix = CreateMatrixRnd(4, 4, 4, 0, 10);
PrintArrayWithIdex(matrix);



