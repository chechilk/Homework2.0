// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
double first = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double second = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double third = Convert.ToDouble(Console.ReadLine());

double max = 0;
double i = 0;

while (i <= 3)
{
    if (first > max) {
    max = first;
}
else if (second > max) {
    max = second;
}
else if (third > max)
    max = third;
i++;
}
Console.Write("Максимальное число = " + max);