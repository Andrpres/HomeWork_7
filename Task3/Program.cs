/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


//задать матрицу и заполнить ее числами
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

//распечатать матрицу
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Ищем среднее арифметическое элементов в каждом столбце
void FindElement(int[,] matrix){
    double summNumbers0 = 0;
    double summNumbers1 = 0;
    double summNumbers2 = 0;
    double summNumbers3 = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");

    summNumbers0 = matrix[0, 0] + matrix[1, 0] + matrix[2, 0] + matrix[3, 0];
    summNumbers1 = matrix[0, 1] + matrix[1, 1] + matrix[2, 1] + matrix[3, 1];
    summNumbers2 = matrix[0, 2] + matrix[1, 2] + matrix[2, 2] + matrix[3, 2];
    summNumbers3 = matrix[0, 3] + matrix[1, 3] + matrix[2, 3] + matrix[3, 3];

    Console.Write($"{summNumbers0 / 4}; ");
    Console.Write($"{summNumbers1 / 4}; ");
    Console.Write($"{summNumbers2 / 4}; ");
    Console.Write($"{summNumbers3 / 4}; ");
    
}

int[,] matrix = GetMatrix(4, 4);
PrintMatrix(matrix);
FindElement(matrix);