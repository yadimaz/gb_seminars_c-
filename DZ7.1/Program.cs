// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Clear();

int m = 0;
int n = 0;

// Рекурсивная функция, которая выводит натуральные числа диапозона
void PrintMN(int start, int end)
{
    if (start > end) return;
    if (start == m) Console.Write($"\"{start}, ");
    else if (start < end) Console.Write($"{start}, ");
    else if (start == end) Console.Write($"{start}\"");
    PrintMN(start + 1, end);
}

// Запрос диапазона натуральных чисел m..n 
while (m >= n || m < 1)
{
    Console.Write("Введите натуральное число m: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральное число n: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (m >= n || m < 1) Console.WriteLine("m должно быть меньше n и больше 0. Поробуйте снова");
}

// Вызов рекурсивной функции
PrintMN(m, n);