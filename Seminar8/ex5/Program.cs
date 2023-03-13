// Задача 62.
// Спиральное заполнение массива 4x4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] array = SpiralMatrix(4, 4);
PrintMatrix(array);
Console.WriteLine();

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SpiralMatrix(int rows, int column)
{
    int[,] array = new int[rows, column];
    int padding = 0;    // смещение от края матрицы
    int indexRows = 0;    // текущая строка
    int indexColumn = 0;    // текущий столбец
    int value = 1;      // начальное значение

    int cycle = rows > column ? column / 2 : rows / 2;

    while (cycle > 0)
    {
        indexRows = padding; indexColumn = padding;
        for (indexColumn = padding; indexColumn < column - 1 - padding; indexColumn++)
        {
            array[indexRows, indexColumn] = value; 
            value++;
        }
        for (indexRows = padding; indexRows < rows - 1 - padding; indexRows++)
        {
            array[indexRows, indexColumn] = value; 
            value++;
        }
        for (indexColumn = column - 1 - padding; indexColumn > padding; indexColumn--)
        {
            array[indexRows, indexColumn] = value; 
            value++;
        }
        for (indexRows = rows - 1 - padding; indexRows > padding; indexRows--)
        {
            array[indexRows, indexColumn] = value; 
            value++;
        }
        padding++;
        cycle--;
    }
    return array;
}

