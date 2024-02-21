// Напишите программу, которая принимает на вход  трёхзначное число и удаляет вторую цифру этого числа

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

//int sum = num / 100 * 10 + num % 10;
//Console.WriteLine(sum);



// Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого числа в степень, равную третьей цифре.

// int num = new Random().Next(10,1000);
// Console.WriteLine(num);
// if(num <= 999 && num >= 100)
// {
//     int num_3 = num % 10;
//     int num_2 = num / 10 % 10; //123 / 10-> 12 % 10 -> 2 
//     Console.WriteLine(Math.Pow(num_2, num_3));
// }
// else
// {
//     Console.WriteLine("Число не трехзначное");
// }


// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.

// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 != 0)
// {
//     Console.WriteLine($"Число {num2} не является кратным {num1}! Остаток от деления: {num1 % num2}");
// }

// else
// {
//     Console.WriteLine($"Число {num2} является кратным {num1}!");
// }


// Напишите программу, которая выводит третью слева цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// // num < 100 -> третей цифры нет
// // num = 5789 / 10
// // num = 57
// int num2 = 0;
// if (num < 0) num = -num;

// if (num < 100)
// {
//     Console.WriteLine("третей цифры нет");
// }
// else
// {
//     while (num > 999)
//     {
//         num /= 10; // num = num / 10
//     }
//     Console.WriteLine(num);
//     num2 = num % 10;
//     Console.WriteLine(num2);
// }

// string num = Console.ReadLine()!;
// if (num.Length < 3)
// {
//     Console.WriteLine("третей цифры нет");
// }
// else
// {
//     Console.WriteLine(num[2]);
// }


