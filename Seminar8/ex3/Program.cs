// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Правила умножения: умножить каждый элемент строки одной матрицы, на каждый элемент столбца другой матрицы и сложить.
// Каждую строку перемножить с каждым стобцом + сумма этих произведений

int rowsFirst = ReadString("Введите количество строк первого массива: ");
int columnFirst = ReadString("Введите количество столбцов первого массива: ");
int rowsSecond = ReadString("Введите количество строк второго массива: ");
int columnSecond = ReadString("Введите количество столбцов второго массив: ");

int[,] matrixFirst = InputMatrix(rowsFirst, columnFirst);
OutputMatrix(matrixFirst, "Первый массив:");
int[,] matrixSecond = InputMatrix(rowsSecond, columnSecond);
OutputMatrix(matrixSecond, "Второй массив");

if ((rowsFirst != rowsSecond) || (columnFirst != columnSecond))
{
    Console.WriteLine("Введите одинаковые размеры массива");
    return;
} 

int[,] resultMatrix = ResultMultiMatrix(matrixFirst, matrixSecond);
OutputMatrix(resultMatrix, "Результат умножения двух матриц: ");



/// <summary>
/// Чтение информации с консоли
/// </summary>
/// <param name="text">Информационный текст</param>
/// <returns>Возвращает результат записи из консоли</returns>
int ReadString(string text)
{
    Console.Write(text);
    int readLine = Convert.ToInt32(Console.ReadLine());
    return readLine;
}

/// <summary>
/// Заполнение массива рандомными числами
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="column">Количество столбцов</param>
/// <returns>Возвращает заполненный массив</returns>
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

/// <summary>
///  Вывод заполненного массива
/// </summary>
/// <param name="matrix">Заполненный массив</param>
void OutputMatrix(int[,] matrix, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Умножение двух матриц.
/// </summary>
/// <param name="first">Первая матрица</param>
/// <param name="second">Вторая матрица</param>
/// <returns>Возвращается произведение двух матриц</returns>
int[,] ResultMultiMatrix(int[,] first, int[,] second)
{
    int[,] resultMatrix = new int[first.GetLength(0),first.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int f = 0; f < resultMatrix.GetLength(1); f++)
            {
                resultMatrix[i, j] = resultMatrix[i, j] + (first[i, f] * second[f, j]);
            }
        }
    }
    return resultMatrix;
}
