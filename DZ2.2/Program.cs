// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Write("Vvedite koordinatu X=");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Vvedite koordinatu Y=");
int y = Convert.ToInt32(Console.ReadLine());
int num_chetvert = 0;
Console.Write($"Koordinaty, X={x}, Y={y}. ");
if (x == 0 || y == 0) Console.WriteLine($"Nomer chetverti neopredelen");
else
{
    if (x > 0 && y > 0) num_chetvert = 1;
    else if (x > 0 && y < 0) num_chetvert = 4;
    else if (x < 0 && y > 0) num_chetvert = 2;
    else num_chetvert = 3;
    Console.WriteLine($"Nomer chetverti koordinat budet, {num_chetvert}");
}