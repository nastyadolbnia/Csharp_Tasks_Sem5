// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return tempMatrix;
}

void PrintMatrix(int [,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int FindSumIndex(int[,] arrayForSum)
        {
            // Получаем количество строк и столбцов массива
int rows =  arrayForSum.GetLength(0);
int cols =  arrayForSum.GetLength(1);
if (rows > 0 && cols > 0)
{
    int minIndex = -1;
    int minSum = int.MaxValue;
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < cols; j++)
        {
            sum +=  arrayForSum[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minIndex = i;
        }
    }

    return minIndex;
    }
    else
    {
    return -1;
    }
    }

int rows = ReadInt("Введите кол-во строк");
int cols = ReadInt("Введите кол-во столбцов");
int [,] matrix = GenerateMatrix(rows,cols,5,10);
PrintMatrix(matrix);
FindSumIndex(matrix);
Console.WriteLine();
int minsum = FindSumIndex(matrix);
Console.WriteLine($"Индекс строки с минимальной суммой = {minsum}");
