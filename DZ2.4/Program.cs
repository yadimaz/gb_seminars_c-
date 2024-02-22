// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
//string num = Convert.ToString(new Random().Next());
string num = "1234";
int kef = num.Length;
int num_int = Convert.ToInt32(num);
Console.WriteLine(num_int);
Console.WriteLine(kef);

int nnu = 0;

while (kef >= 0)
{
    // Console.Write(num_int % Math.Pow(10, kef));
    //Console.WriteLine(kef);
  
    nnu = Convert.ToInt32(Math.Pow(10, kef - 1));
    //Console.WriteLine(nnu);
    Console.WriteLine((num_int / Convert.ToInt32(Math.Pow(10, kef) ) % 10));
    //Console.Write($"{num[i]}, ");
    kef = kef - 1;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;
int conunt = 0;
while (m > 0)
{
  conunt++;
  m /= 10;
}

while (conunt > 0)
{
  Console.Write($"{n / Convert.ToInt32(Math.Pow(10, conunt - 1)) % 10}, ");
  conunt--;
}
