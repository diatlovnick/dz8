/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по
убыванию элементы каждой строки двумерного массива.
*/

int [,] GetSort(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (matrix[i,j] > matrix[i,j+1])
           {
               int current = matrix[i,j];
               matrix[i,j] = matrix[i, j+1];
               matrix[i,j+1] = current;
           } 
        }
        
    }
    return matrix;

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

void PrintArray(double [] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");

    }
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
int [,] sorttMatrix = GetSort(resultMatrix);
PrintMatrix(sorttMatrix);
