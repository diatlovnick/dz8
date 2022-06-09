/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

int GetMinRow(int [,] matrix)
{
    int sum = 0;
    int searchMinSum = 0;
    int numberRow = 0;
    double[] array = new double [matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = (matrix[j,i] + sum);
               
        }
        Console.WriteLine(sum);
        if (sum < searchMinSum)
        {
            searchMinSum = sum;
            numberRow = j;
            Console.WriteLine(j);
        }
        sum = 0;
    }
    return numberRow;

}

int GetDemension(string message)
{
    Console.WriteLine(message);
    int demension = int.Parse(Console.ReadLine());
    return demension;
}

int [,] InitMatrix(int row, int col)
{
    int [,] matrix = new int[row, col];
    Random rnd = new Random();
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        matrix[i, j] = rnd.Next(1,20);
    }

    return matrix;
}


void PrintMatrix(int [,] matrix)
{
    Console.WriteLine("Заполненная матрица");
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} ");

    Console.WriteLine();
    }
}

int row = GetDemension("Введите длину для первого разряда матрицы:");
int col = GetDemension("Введите длину для второго разряда матрицы:");

int [,] resultMatrix = InitMatrix(row, col);
PrintMatrix(matrix: resultMatrix);
int minRow = GetMinRow(resultMatrix);
Console.WriteLine(minRow);
