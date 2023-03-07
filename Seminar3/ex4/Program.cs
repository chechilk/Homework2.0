// Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада. На вход будет подаваться число (сумма вклада). 
// При значении меньше 100, будет начислено 5 %, 
// если значение находится в диапазоне от ста до двухсот — 7 %, 
// если больше — 10 %. Отработав, программа должна вывести общую сумму с начисленными процентами.

Console.Write("Введите сумму вклада: ");
double cash = Convert.ToDouble(Console.ReadLine());
double result = 0;

if (cash < 100)
{
    result = ((double)cash / 100) * 5;
    Console.WriteLine($"Сумма вклада {cash} + 5% = {result + cash}");
}
else if (cash > 100 && cash < 200)
{
    result = ((double)cash / 100) * 7;
    Console.WriteLine($"Сумма вклада {cash} + 7% = {result + cash}");
}
else if (result > 200)
{
    result = ((double)cash / 100) * 10;
    Console.WriteLine($"Сумма вклада {cash} + 10% = {result + cash}");
}