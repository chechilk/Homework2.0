// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = ReadString("Введите количество строк: ");
int column = ReadString("Введите количество столбцов: ");

//Проверка на прямоугольный двумерный массив
if (rows == column)
{
    Console.Write("Введите разные значения строка/столбец");
    return;
}
int[,] matrix = InputMatrix(rows, column);
OutputMatrix(matrix);
SearchMinSummString(matrix);

/// <summary>
/// Чтение информации с консоли
/// </summary>
/// <param name="text">Введённый текст с консоли</param>
/// <returns>Возврат строки с консоли</returns>
int ReadString(string text)
{
    Console.Write(text);
    int readLine = Convert.ToInt32(Console.ReadLine());
    return readLine;
}


/// <summary>
/// Заполнение массива рандомными числами от 1 до 10
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="column">Количество столбцов</param>
/// <returns>Возврат заполненного массива рандомными значениями</returns>
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
///  Вывод заполненного массива в консоль до перестановки
/// </summary>
/// <param name="matrix">Заполненный массив</param>
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
/// <summary>
/// Поиск номера строки с минимальной суммой элементов в этой строке
/// </summary>
/// <param name="matrix">исходный массив</param>
void SearchMinSummString(int[,] matrix)
{
    int minSumm = int.MaxValue;
    int indexMinSumm = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ = summ + matrix[i, j];
        }
        Console.WriteLine($"Cумма {i} строки = {summ};");
        if (minSumm > summ)
        {
            minSumm = summ;
            indexMinSumm = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой значений: {indexMinSumm}, сумма = {minSumm} ");
}

