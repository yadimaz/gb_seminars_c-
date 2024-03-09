// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 

Console.Clear();

int m = -1;
int n = -1;
int a = 0;
// Функция Аккермана
int PrintAkkerman(int n, int m)
{
    if (n == 0) return a = m + 1;
    else if (m == 0) return a = PrintAkkerman(n - 1, 1);
    else return a = PrintAkkerman(n - 1, PrintAkkerman(n, m - 1));
}

// Запрос натуральных чисел m и n 
while (m < 0 || n < 0)
{
    Console.Write("Введите натуральное число m: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральное число n: ");
    m = Convert.ToInt32(Console.ReadLine());
    if (n < 0 || m < 0) Console.WriteLine("n и m должны быть натуральными числами. Поробуйте снова");
}
Console.Write($"A(m,n) = {PrintAkkerman(n, m)}");