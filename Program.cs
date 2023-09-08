// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

// int[,] matrix = new int[3, 4];
// GetMatrixRandom(matrix);
// PrintMatrix(matrix);
// SortToLower(matrix);
// Console.WriteLine();
// PrintMatrix(matrix);

// void GetMatrixRandom(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int l = 0; l < matrix.GetLength(1); l++)
//         {
//             matrix[i, l] = new Random().Next(1, 10);
//         }
//     }
// }


// void SortToLower(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int l = 0; l < matrix.GetLength(1); l++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     int temp = matrix[i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int l = 0; l < matrix.GetLength(1); l++)
//         {
//             Console.Write($"{matrix[i, l]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] matrix = new int[3, 4];
// GetMatrixRandom(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// MinSum(matrix);


// void MinSum(int[,] matrix)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         minRow += matrix[0, i];
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int l = 0; l < matrix.GetLength(1); l++) sumRow += matrix[i, l];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка");
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int l = 0; l < matrix.GetLength(1); l++)
//         {
//             Console.Write($"{matrix[i, l]} ");
//         }
//         Console.WriteLine();
//     }
// }


// void GetMatrixRandom(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int l = 0; l < matrix.GetLength(1); l++)
//         {
//             matrix[i, l] = new Random().Next(1, 10);
//         }
//     }
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] matrix = new int[2, 2, 2];
GetMatrix(matrix);
PrintIndex(matrix);


void PrintIndex(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void GetMatrix(int[,,] matrix)
{
    int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[k, i, j] += count;
                count += 3;
            }
        }
    }
}