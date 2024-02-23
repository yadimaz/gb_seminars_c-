// Задача 3: Напишите программу, которая принимает на вход 
//целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Insert number from range 10,99");
int num = Convert.ToInt32(Console.ReadLine());
int num_max = 0;

if (num >= 10 && num <= 99)
{
    num_max = num % 10;
    int num1 = num / 10;
    if (num_max < num1) num_max = num1;
    Console.WriteLine($"Highest number is {num_max}");
}
else Console.WriteLine($"The number is out of range");