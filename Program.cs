// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// // -------methods-----
// // 1    
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// //  Сортировка массива [,] по убыванию

// void SortArrayDescend(int[,] array)
// {
//     bool sorted = true;
//     while (sorted == true)
//     {
//         sorted = false;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1) - 1; j++)
//             {
//                 if (array[i, j] < array[i, j + 1])
//                 {
//                     int temp = array[i, j + 1];
//                     array[i, j + 1] = array[i, j];
//                     array[i, j] = temp;
//                     sorted = true;
//                 }
//             }
//         }
//     }
// }

// // 3
// void PrintArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"[{array[i,j]}]");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Enter a number of rows: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Enter a number of columns: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, -5, 8);
// PrintArray(array);
// SortArrayDescend(array);
// Console.WriteLine();
// PrintArray(array);

// _________________________________________________________________________________________________________________________________________________________

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// // -------methods-----
// // 1    
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// // 2
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"[{array[i, j]}]");
//         }
//         Console.WriteLine();
//     }
// }

// // 3  Суммы строк [,]массива

// int[] SumsInRows(int[,] array)
// {
//     int[] sums = new int[array.GetLength(0)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];
//             sums[i] = sum;
//         }
//     }
//     return sums;
// }

// //  4  поиск минимального значения

// int NumberOfMinRow(int[] array)
// {
//     int numberMinRow = 0;
//     int min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//             numberMinRow = i;
//         }

//     }
//     return numberMinRow;
// }

// int[,] array = GetArray(8, 3, 0, 5);
// PrintArray(array);
// Console.WriteLine();
// System.Console.WriteLine();
// Console.Write($"индекс строки с минимальной суммой: {NumberOfMinRow(SumsInRows(array))}");



// ____________________________________________________________________________________________________________________________________________________________________________


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// --------------------Methods-----------------

//  1

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

// 2

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}]");
        }
        Console.WriteLine();
    }
}

//  3  

int[,] MatrixProduct (int[,]arr1 , int[,]arr2)
{
    int[,]matrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            for(int k=0; k<matrix.GetLength(1); k++)
            {
                matrix[i,j] += arr1[i,k]*arr2[k,j];
            }
        }
    }
    return matrix;
}

int[,]arr1 = GetArray(2,2,1,3);
int[,]arr2 = GetArray(2,2,1,5);
PrintArray(arr1);
System.Console.WriteLine();
PrintArray(arr2);
System.Console.WriteLine();
int[,]matrix = MatrixProduct(arr1,arr2);
PrintArray(matrix);


