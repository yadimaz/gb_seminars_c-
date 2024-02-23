// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.
int num = new Random().Next();
Console.WriteLine($"{num} - Original Random number");

int m = num;
int count = 0;

while (m > 0)
{
  count++;
  m /= 10;
}

while (count > 0)
{
  Console.Write($"{num / Convert.ToInt32(Math.Pow(10, count - 1)) % 10}");
  if (count > 1) Console.Write($", ");
  count--;
}
