//  56 _____найти строку с наименьшей суммой элементов____________


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
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

int[] SumStringValue(int[,] matrix)
{
    int[] stringSum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            stringSum[i] += matrix[i, j];
    }
    return stringSum;
}

int MinSumStringValue(int[] sumStr)
{
    int minSum = sumStr[0];
    int index = 0;
    for (int i = 1; i < sumStr.Length; i++)
    {
        if (minSum > sumStr[i])
        {
            minSum = sumStr[i];
            index = i;
        }
    }
    return index + 1;
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
int[] sumString = SumStringValue(matrix);
Console.WriteLine($"Суммы строк: {string.Join(", ", sumString)}");
Console.WriteLine($"строка с наименьшей суммой элементов: {MinSumStringValue(sumString)}");
