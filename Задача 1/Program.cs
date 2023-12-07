//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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
int? CheckElement(int [,] array, int row,int col)
{ 
    if(row>=0 && row < array.GetLength(0) && col >=0 &&  col<array.GetLength(1)-1 )
    {
        return array[row,col];
    }
    else
    {
        return null;
    }

}

int rows = ReadInt("Введите кол-во строк");
int cols = ReadInt("Введите кол-во столбцов");
int [,] matrix = GenerateMatrix(rows,cols,1,10);
PrintMatrix(matrix);
int? element = CheckElement(matrix,2,5);
Console.WriteLine();
Console.WriteLine(element);
