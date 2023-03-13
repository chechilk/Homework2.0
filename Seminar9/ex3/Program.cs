// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// m = 0 -> A(n+1)
// m > 0, n = 0 -> A(m-1,1)
// m > 0, n > 0 -> A(m-1, A(m,n-1))

// Console.Write("Введите первое число: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int N = Convert.ToInt32(Console.ReadLine());

int GetAccerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (M > 0 && N == 0)
    {
        return (GetAccerman(M - 1, 1));
    }
    return (GetAccerman(M - 1, GetAccerman(M, N - 1)));
}

//Построение таблицы значений A(m,n), где M от 0 до 5, N от 0 до 3
for (int i = 0; i <= 3; i++)
{
    for (int j = 0; j <= 5; j++)
    {
        Console.WriteLine($"При N = {i}, M = {j} число Аккермана = {GetAccerman(i, j)}");
    }
    Console.WriteLine();
}
