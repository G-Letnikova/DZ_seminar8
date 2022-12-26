
//  62 _заполнение матрицы по спирали__________________________

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


void FillMatrix(int[,] matrix)
{
    int value = 1;
    int startRow = 0, endRow = matrix.GetLength(0) - 1;
    int startCol = 0, endCol = matrix.GetLength(1) - 1;

   while (startRow <= endRow && startCol <= endCol)
  { 
        for (int i = startCol; i <= endCol; i++)
        {
            matrix[startRow, i] = value;
            value++;
        }
        startRow++;
       for (int j = startRow; j <= endRow; j++)
        {
            matrix[j, endCol] = value;
            value++;
        }
        endCol--;
        for (int k = endCol; k >= startCol; k--)
        {
            matrix[endRow, k] = value;
            value++;
        }
        endRow--;
        for (int m = endRow; m >= startRow; m--)
        {
            matrix[m, startCol] = value;
            value++;
        }
        startCol++;
 
    } 
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
PrintMatrix(matrix);