// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

bool CheckPolindrom(string str)
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - 1 - i]) 
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine("Введите слово");
string str = Console.ReadLine()!;

if (CheckPolindrom(str) == true) Console.WriteLine("This is polindrom");
else Console.WriteLine("This is not polindrom");
