// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
string num = Convert.ToString(new Random().Next());


for (int i=0; i<num.Length;i++)
{
    Console.Write($"{num[i]}, ");
}

