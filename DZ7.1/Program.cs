// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// Рекурсивная функция, которая выводит натуральные числа диапозона
void PrintMN(int m, int n)
{
    if (m > n) return;
    Console.Write($"{m} ");
    PrintMN(m + 1, n);
}

// Запрос диапазона m n 
int m = 0;
int n = 0;
while (m >= n)
{
    Console.Write("Введите натуральное число m: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральное число n: ");
    n = Convert.ToInt32(Console.ReadLine());
    if(m>=n) Console.WriteLine("m должно быть меньше n. Поробуйте снова");
}

// Вызов рекурсивной функции
PrintMN(m, n);
