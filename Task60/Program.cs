//  60 ___ трёхмерный массив из неповторяющихся двузначных чисел _________
//     ____построчно выестиь массив, добавляя индексы каждого элемента ___

void Input3dMatrix(int[,,] matrix)
{
    int value = 9;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)

            {
                matrix[i, j, k] = value + 1;
                value++;
            }
        }
    }
}
void Print3dMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) \t");
            Console.WriteLine();
        }
        Console.WriteLine();

    }
}
Console.Clear();
Console.Write("Введите размер трехмерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

while (size[0] * size[1] * size[2] > 90)
{
    Console.WriteLine("Массив слишком велик для двузначных чисел");
    Console.Write("Введите размер трехмерного массива: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] matrix = new int[size[0], size[1], size[2]];

Input3dMatrix(matrix);
Print3dMatrix(matrix);
