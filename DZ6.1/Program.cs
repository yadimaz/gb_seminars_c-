// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

char[,] chr = new char[,]
{ 
    { 'c', 'h', 'a', 'r', '-', '>' }, 
    { 'с', 'т', 'р', 'о', 'к', 'а' }
 };
string str = "";

for (int i = 0; i < chr.GetLength(0); i++)
{
    for (int j = 0; j < chr.GetLength(1); j++) str += chr[i,j];
}

Console.WriteLine(str);