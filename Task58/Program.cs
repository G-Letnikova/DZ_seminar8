//  58 ___ две матрицы одного размера. Найти произведение матриц  _________

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 4); // [1, 3]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

while (size[0] != size[1])
{
    Console.WriteLine("Матрица не квадратная");
    Console.Write("Введите размер матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}

int[,] matrixA = new int[size[0], size[1]];
int[,] matrixB = new int[size[0], size[1]];
int[,] matrixC = new int[size[0], size[1]];

Console.WriteLine("Матрица A:");
InputMatrix(matrixA);
PrintMatrix(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица B:");
InputMatrix(matrixB);
PrintMatrix(matrixB);



for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int k = 0; k < matrixB.GetLength(1); k++)
    {
        int s = 0;
        for (int j = 0; j < matrixA.GetLength(0); j++)
        {
            s = matrixA[i, j] * matrixB[j, k] + s;
        }
        matrixC[i, k] = s;
    }
}
Console.WriteLine();
Console.WriteLine("Матрица A * Матрица B:");
PrintMatrix(matrixC);
