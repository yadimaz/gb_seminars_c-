﻿// // // // See https://aka.ms/new-console-template for more information
// // // // Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.

// // // // Примеры

// // // // [1 3 4 19 3], 8 => Нет
// // // // [-4 3 4 1], 3 => Да
// // // // Задайте массив. Напишите программу, которая определяет, присутствует ли 
// // // // заданное число в массиве. Программа должна выдать ответ: Да/Нет.

// // // // Примеры

// // // // [1 3 4 19 3], 8 => Нет
// // // // [-4 3 4 1], 3 => Да

// // // Console.Write("Введите размерность массива: ");
// // // int n = Convert.ToInt32(Console.ReadLine());
// // // int[] mas = new int[n];
// // // int[] mas_2 = new int[n];
// // // // Console.WriteLine(mas);


// // // //whihe
// // // int ind = 0;
// // // while (ind < mas.Length)
// // // {
// // //   Console.Write($"{mas[ind]} ");
// // //   ind++;
// // // }
// // // Console.WriteLine();

// // // //for
// // // for (int i = 0; i < mas.Length; i++)
// // // {
// // //   Console.Write($"{mas[i]} ");
// // // }
// // // Console.WriteLine();

// // // //foreach
// // // foreach (var item in mas)
// // // {
// // //   Console.Write($"{item} ");
// // // }
// // // Console.WriteLine();

// // // //функция
// // // void Print_mas(int[] col)
// // // {
// // //   foreach (var item in col)
// // //   {
// // //     Console.Write($"{item} ");
// // //   }
// // //   Console.WriteLine();
// // // }

// // // Print_mas(mas);
// // // //функция Random
// // // int[] Random_mas(int[] col)
// // // {
// // //   for (int i = 0; i < col.Length; i++)
// // //   {
// // //     col[i] = new Random().Next(1,10);
// // //   }
// // //   return col;
// // // }

// // // int[] new_mas = Random_mas(mas);
// // // Print_mas(new_mas);

// // // int[] ReadLine_mas(int[] col)
// // // {
// // //     for (int i = 0; i < col.Length; i++)
// // //   {
// // //     Console.WriteLine($"Введите {i} элемент массива");
// // //     col[i] = Convert.ToInt32(Console.ReadLine());
// // //   }
// // //   return col;
// // // }

// // // int[] new_mas_2 = ReadLine_mas(mas_2);
// // // Print_mas(new_mas_2);


// // // Console.Write("Введите искомое число: ");
// // // int m = Convert.ToInt32(Console.ReadLine());

// // // int c_R = 0;
// // // int c_C = 0;

// // // for (int i = 0; i < mas.Length; i++)
// // // {
// // //   if(new_mas[i] == m)
// // //   {
// // //     c_R ++;
// // //   } 
// // //   if(new_mas_2[i] == m) 
// // //   {
// // //     c_C ++;
// // //   }
// // // }

// // // if (c_R == 0 && c_C == 0)
// // // {
// // //   Console.WriteLine("Нет");
// // // }
// // // else
// // // {
// // //   if (c_R > 0) Console.WriteLine("Искомый элемент найден в массиве new_mas");
// // //   if (c_C > 0) Console.WriteLine("Искомый элемент найден в массиве new_mas_2");
// // // }

// // // Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
// // //Замените отрицательные элементы на положительные, а положительные на отрицательные.
// // // Пример
// // // [1 -5 6]
// // // => [-1 5 -6]

// // void RandomFillArray(int[] arr)
// // {
// //   for (int i = 0; i < arr.Length; i++)
// //   {
// //     Random rnd = new Random();
// //     arr[i] = rnd.Next(-10, 10);
// //   }
// // }

// // void PrintArrayToScreen(int[] arr)
// // {
// //   foreach(var e in arr)
// //   { Console.Write($"{e} "); }
// //   Console.WriteLine();
// // }

// // int[] array = new int[10];
// // RandomFillArray(array);

// // PrintArrayToScreen(array);

// // for(int i = 0; i < array.Length; i++)
// // {
// //   array[i] *= -1;
// // }

// // PrintArrayToScreen(array);


// // Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.
// // Пример
// // [1 3 2 4 2 3] => [3 6 8]
// // [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)





// // Найдите произведения пар чисел в одномерном массиве. Парой считаем первый 
// // и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.

// // Пример

// // [1 3 2 4 2 3] => [3 6 8]
// // [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)


// //функция
// // void Print_mas(int[] col)
// // {
// //   foreach (var item in col)
// //   {
// //     Console.Write($"{item} ");
// //   }
// //   Console.WriteLine();
// // }


// // //функция Random
// // int[] Random_mas(int[] col)
// // {
// //   for (int i = 0; i < col.Length; i++)
// //   {
// //     col[i] = new Random().Next(1,10);
// //   }
// //   return col;
// // }

// // Console.Write("Введите размерность массива: ");
// // int n = Convert.ToInt32(Console.ReadLine());

// // int[] mas = Random_mas(new int[n]);

// // Print_mas(mas);

// // int[] mas_new = new int[mas.Length / 2];

// // for (int i = 0; i < mas_new.Length; i++)
// // {
// //   mas_new[i] = mas[i] * mas[mas.Length - 1 - i];
// // }

// // Print_mas(mas_new);




// // Дано натуральное трёхзначное число. Создайте массив, состоящий из 
// // цифр этого числа. Младший разряд числа должен располагаться на 0-м индексе массива, 
// // старший – на 2-м. 

// // Пример
// // 456  =>  [6 5 4]
// // 781  =>  [1 8 7]

// void Print_mas(int[] col)
// {
//   foreach (var item in col)
//   {
//     Console.Write($"{item} ");
//   }
//   Console.WriteLine();
// }

// int n = new Random().Next(100, 1000);
// Console.WriteLine(n);

// int[] mas = new int[3];
// for (int i = 0; i < mas.Length; i++)
// {
//   mas[i] = n % 10;
//   n /= 10;
// }
// Print_mas(mas);