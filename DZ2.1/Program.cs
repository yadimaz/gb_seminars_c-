// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.WriteLine("Vvedite chislo");
int num = Convert.ToInt32(Console.ReadLine());

if(num%7==0 && num%23==0) Console.WriteLine($"Chislo {num} krato 7 and 23");
else Console.WriteLine($"Chislo {num} ne krato 7 and 23");
