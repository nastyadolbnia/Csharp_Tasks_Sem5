// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении 
//которых расположен наименьший элемент массива. 
//Под удалением понимается создание нового двумерного массива без строки и столбца

int ReadInt(string text)
{
    System.Console.Write(text);
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

void PrintMatrix(int[,] matrixForPrint)
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

int[] FinMinNumberIndexes(int[,] matrix)
{
    int[] minNumberPosition = new int[2];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minNumberPosition[0], minNumberPosition[1]])
            {
                minNumberPosition[0] = i;
                minNumberPosition[1] = j;
            }
        }
    }

    return minNumberPosition;
}

int[,] DeleteRowAndCol(int[,] oldMatrix, int[] indexes)
{
    var newMatrix = new int[oldMatrix.GetLength(0) - 1, oldMatrix.GetLength(1) - 1];

    for (int i = 0, x = 0; i < oldMatrix.GetLength(0); i++)
    {
        if(i == indexes[0]) continue;

        for (int j = 0, y = 0; j < oldMatrix.GetLength(1); j++)
        {
            if(j == indexes[1]) continue;

            newMatrix[x, y] = oldMatrix[i, j];
            y++;
        }
        x++;
    }

    return newMatrix;
}
///----------
///
int rows = ReadInt("Введите количество строк в матрице: ");

int cols = ReadInt("Введите количество столбцов в матрице: ");

var matrix = GenerateMatrix(rows, cols, 1, 10);

PrintMatrix(matrix);

System.Console.WriteLine();

var minNumberPosition = FinMinNumberIndexes(matrix);

System.Console.WriteLine(string.Join(" ", minNumberPosition));
System.Console.WriteLine();
PrintMatrix(DeleteRowAndCol(matrix, minNumberPosition));
