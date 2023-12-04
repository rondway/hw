//первая задача//
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());

        int result = GetElementValue(matrix, row, col);

        if (result != int.MinValue)
        {
            Console.WriteLine($"Значение элемента в позиции ({row}, {col}): {result}");
        }
        else
        {
            Console.WriteLine($"Элемента в позиции ({row}, {col}) не существует.");
        }
    }

    static int GetElementValue(int[,] matrix, int row, int col)
    {
        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
        {
            return matrix[row, col];
        }
        else
        {
            return int.MinValue;
        }
    }
}

//2 задача//
// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] matrix = {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}
//         };

//         Console.WriteLine("Исходный массив:");
//         PrintMatrix(matrix);

//         SwapRows(matrix, 0, matrix.GetLength(0) - 1);

//         Console.WriteLine("\nМассив после замены строк:");
//         PrintMatrix(matrix);
//     }

//     static void SwapRows(int[,] matrix, int row1, int row2)
//     {
//         if (row1 >= 0 && row1 < matrix.GetLength(0) && row2 >= 0 && row2 < matrix.GetLength(0))
//         {
        
//             for (int col = 0; col < matrix.GetLength(1); col++)
//             {
//                 int temp = matrix[row1, col];
//                 matrix[row1, col] = matrix[row2, col];
//                 matrix[row2, col] = temp;
//             }
//         }
//         else
//         {
//             Console.WriteLine("Одна из указанных строк не существует в матрице.");
//         }
//     }

//     static void PrintMatrix(int[,] matrix)
//     {
//         for (int row = 0; row < matrix.GetLength(0); row++)
//         {
//             for (int col = 0; col < matrix.GetLength(1); col++)
//             {
//                 Console.Write(matrix[row, col] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

//задача 3//
// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] matrix = GenerateRandomMatrix(3, 4);

//         Console.WriteLine("Исходный массив:");
//         PrintMatrix(matrix);

//         int minRow = FindRowWithMinSum(matrix);

//         Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minRow + 1}");
//     }

//     static int[,] GenerateRandomMatrix(int rows, int cols)
//     {
//         Random random = new Random();
//         int[,] matrix = new int[rows, cols];

//         for (int row = 0; row < rows; row++)
//         {
//             for (int col = 0; col < cols; col++)
//             {
//                 matrix[row, col] = random.Next(1, 101); 
//             }
//         }

//         return matrix;
//     }

//     static int FindRowWithMinSum(int[,] matrix)
//     {
//         int minSum = int.MaxValue;
//         int minRow = -1;

//         for (int row = 0; row < matrix.GetLength(0); row++)
//         {
//             int currentSum = 0;
//             for (int col = 0; col < matrix.GetLength(1); col++)
//             {
//                 currentSum += matrix[row, col];
//             }

//             if (currentSum < minSum)
//             {
//                 minSum = currentSum;
//                 minRow = row;
//             }
//         }

//         return minRow;
//     }

//     static void PrintMatrix(int[,] matrix)
//     {
//         for (int row = 0; row < matrix.GetLength(0); row++)
//         {
//             for (int col = 0; col < matrix.GetLength(1); col++)
//             {
//                 Console.Write(matrix[row, col] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }