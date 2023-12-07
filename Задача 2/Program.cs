// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
void SwapFirstandLastElement(int[,] array)
{
   int rows = array.GetLength(0);
   int cols = array.GetLength(1);

   if(rows >0 && cols>0)
   {
    for(int j =0; j < cols; j++)
    {
        int temp = array[0,j];
        array[0,j] = array[rows-1,j];
        array[rows-1,j]= temp;
    }
    
   }

   void PrintArray(int [,] array)
{
    System.Console.WriteLine($"[ {string.Join(" | ", array)} ]");
}
}
int rows = ReadInt("Введите кол-во строк");
int cols = ReadInt("Введите кол-во столбцов");
int [,] matrix = GenerateMatrix(rows,cols,5,10);
PrintMatrix(matrix);
SwapFirstandLastElement(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);