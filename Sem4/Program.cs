// Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13]  => 3

// int[] Random_mas(int num)
// {
//     int[] mas = new int[num];
//     for (int i = 0; i < mas.Length; i++)
//     {
//         mas[i] = new Random().Next(0, 21);
//     }
//     return mas;
// }

// void Print_mas(int[] mas)
// {
//     foreach (var i in mas)
//     {
//         Console.Write($"{i} ");
//     }
//     Console.WriteLine();
// }

// bool prost(int num)
// {
//     if(num == 0 || num == 1) return false;
//     else
//     {
//         for (int i = 2; i < num; i++)
//         {
//             if(num % i == 0) return false;
//         }
//         return true;
//     }
// }

// int Count(int[] col)
// {
//     int count = 0;
//     foreach (var i in col)
//     {
//         if(prost(i))
//         {
//             Console.Write($"{i} ");
//             count ++;
//         }
//     }
//     Console.WriteLine();
//     return count;
// }

// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arrey = Random_mas(n);
// Print_mas(arrey);
// Console.WriteLine(Count(arrey));
// Console.WriteLine(prost(7));




// Задайте массив из N случайных целых чисел (N вводится с клавиатуры). 
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7. 
// Пример [1 5 11 21 81 4 0 91 2 3] => 2

// int[] CreateArray(int len)
// {
//     int[] mas = new int[len];
//     for (int i = 0; i < mas.Length; i++)
//     {
//         mas[i] = new Random().Next(0, 99);
//     }
//     return mas;
// }

// void PrintArray(int[] mas)
// {
//     foreach (var item in mas)
//     {
//         Console.Write($"{item} ");
//     }
// }

// bool CheckNum1(int num)
// {
//     if (num % 10 == 1 && num % 7 == 0) return true;
//     else return false;
// }

// int CountNumInArray(int[] mas)
// {
//    int count = 0;
//    foreach (var item in mas)
//    {
//     if(CheckNum1(item)) count++;
//    } 
//    Console.WriteLine(count);
//    return count;
// }

// Console.WriteLine("Vvedite num:");
// int num = int.Parse(Console.ReadLine()!);
// int[] array = CreateArray(num);
// PrintArray(array);
// Console.WriteLine(CountNumInArray(array));





// int[] FillRandomArray(int size)
// {
//   int[] arr = new int[size];
//   for (int i = 0; i < arr.Length; i++)
//   {
//     arr[i] = new Random().Next(0, 1000);
//   }
//   return arr;
// }

// void PrintArray(int[] arr)
// {
//   foreach (int el in arr)
//   {
//     Console.Write($"{el} ");
//   }
//   Console.WriteLine();
// }

// int IsInteresting(int[] arr)
// {
//   int count = 0;
//   foreach(int el in arr)
//   {
//     if (HaveOne(el) && MultySeven(el))
//     {
//       count++;
//     }
//   }
//   return count;
// }

// bool HaveOne(int num)
// {
//   if (num % 10 == 1)
//   {
//     return true;
//   }
//   return false;
// }

// bool MultySeven(int num)
// {
//   if (num % 7 == 0)
//   { return true;}
//   return false;
// }

// Console.Write("Введите резмерность одномерного массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] arr = FillRandomArray(length);
// PrintArray(arr);
// Console.WriteLine($"Количество чисел удовлетворяющих условию: {IsInteresting(arr)}");



// Заполните массив на  N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. 
// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший – на последнем. 
// Пример [1 3 2 4 2 3] => 132423 [2 3 1] => 231

// int[] FillRandomArray(int size)
// {
//   int[] arr = new int[size];
//   for (int i = 0; i < arr.Length; i++)
//   {
//     arr[i] = new Random().Next(0, 10);
//   }
//   return arr;
// }

// void PrintArray(int[] arr)
// {
//   foreach (int el in arr)
//   {
//     Console.Write($"{el} ");
//   }
//   Console.WriteLine();
// }

// double num(int[] col) 
// {
//     double n = 0;
//     foreach (var item in col)
//     {
//         n = n * 10 + item;
//     }
//     return n;
// }

// Console.Write("Введите резмерность одномерного массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] arr = FillRandomArray(length);
// PrintArray(arr);
// Console.WriteLine(num(arr));




// for (int i = 0; i < 10; i++)
// {
//     if(i == 6) continue;
//     if (i == 8) break;
//     Console.WriteLine(i);
// }

// int i = 1;
// while (true)
// {
//     Console.WriteLine(i);
//     if(i ==150) break;
//     i++;
// }

