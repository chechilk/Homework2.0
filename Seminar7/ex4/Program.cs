// Сумма диагонали в матрице

int size = ReadString("Введите количество строк: ");
// Для рассчёта диагонали используется матрица NxN;
int[,] matrix = InputMatrix(size, size);
OutputMatrix(matrix);
SearchSummDiagonal(matrix);


int ReadString(string massege)
{
    Console.Write(massege);
    int readLine = Convert.ToInt32(Console.ReadLine());
    return readLine;
}


int[,] InputMatrix(int rows, int column)
{
    int[,] matrix = new int[rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
    return matrix;
}

void SearchSummDiagonal(int[,] matrix)
{
    int summ = 0;
    for (int i = 0, j = 0; i < matrix.GetLength(0); i++, j++)
    {
        summ = summ + matrix[i, j];
    }
    Console.Write($"Сумма диагонали: {summ}");
}

void OutputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}