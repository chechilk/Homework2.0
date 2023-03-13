// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите начальное число промежутка: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число промежутка: ");
int N = Convert.ToInt32(Console.ReadLine());

int summ = 0;

if (M > N)
{
    Console.Write("Сумма элементов в промежутке: ");
    Console.Write(GetSumm(N, M));
}
else
{
    Console.Write("Сумма элементов в промежутке: ");
    Console.Write(GetSumm(M, N));
}

int GetSumm(int start, int end)
{
    if (start == end) return summ += end;
    return (summ += start + GetSumm(start + 1, end));
}