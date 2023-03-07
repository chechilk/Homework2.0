// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
double first = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double second = Convert.ToDouble(Console.ReadLine());

if (first > second) {
Console.WriteLine("Максимальное число = " + first + ", минимальное число = " + second);
}
else if (first < second){
Console.WriteLine("Максимальное число = " + second + ", минимальное число = " + first);
}
else {
    Console.WriteLine("Числа равны между собой");
}
