// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная.

using System.Dynamic;
using System.Globalization;

Console.Clear();

int SumNum(int num)
{
    int sumnum = 0;
    if (num / 10 == 0) return num;
    else
    {
        while (num != 0)
        {
            sumnum += (num % 10);
            num /= 10;
        }
        return sumnum;
    }
}

bool CheckEven(int num)
{
    return (num % 2 == 0);
}

while (true)
{
    Console.Write("Введите целое число:");
    string vvod = Console.ReadLine()!;
    if (int.TryParse(vvod, out int onenumber))
    {
        onenumber = SumNum(onenumber);
        if(CheckEven(onenumber)== true) break;
    }
    else if (vvod.Length == 1 && vvod[0] == 'q') break;
}