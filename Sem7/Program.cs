//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// string GetListNatNums(int num, int index = 1)
// {
//     if (index == num)
//     { return Convert.ToString(index); }
//     return index + " " + GetListNatNums(num, index + 1);   
// }

// Console.Write("Введите натуральное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetListNatNums(num));

//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// void GetListNatNums(int num, int index = 1)
// {
//     if (index == num)
//     { 
//         Console.Write($"{index} ");
//         return; 
//     }
    
//     GetListNatNums(num, index + 1);   
//     Console.Write($"{index} ");
// }

// Console.Write("Введите натуральное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// //Console.WriteLine(GetListNatNums(num));
// GetListNatNums(num);




void Buk(string str ) 
{
    if (str == "")
    {
        return;
    }
    string list = "aoeyuiAOEYUI";

    if (!list.Contains(str[0]))
{
    Console.Write($"{str[0]} ");
}
Buk(str[1..]);
}

Console.Write ("Введите строку ");
string str = Console.ReadLine()!;
Buk (str);

void PrintStringWOVowels(string str, int startIndex = 0)
{
    string Vowels = "aeiouyAEIOUY";
    if (startIndex == str.Length - 1)
    { return; }
    if (!Vowels.Contains(str[startIndex]))
    {Console.Write($"{str[startIndex]}");}
    PrintStringWOVowels(str, startIndex + 1);
}

Console.Write("Введите строку: ");
string inputStr = Console.ReadLine()!;
PrintStringWOVowels(inputStr);