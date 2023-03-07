// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0) {
    Console.Write("Введите корректное число N!");
}
else
{
    Console.Write("Числа от 1 до " + N + ": ");
    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
        else Console.Write("Чётных чисел нет"); // В случае, если ввести N = 1.
    }
}
