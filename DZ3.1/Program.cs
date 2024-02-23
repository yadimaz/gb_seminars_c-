// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
// Начальные условия:
// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5

// function Create Random Array
// using System.Reflection.Metadata.Ecma335;

// int[] CreateRandomArray(int[] mas)
// {
//     for (int i = 0; i < mas.Length - 1; i++) mas[i] = new Random().Next(1, 99);
//     return mas;
// }

// // function Print Array
// void PrintArrayToScreen(int[] mas)
// {
//     foreach (var item in mas) Console.Write($"{item} ");
//     Console.WriteLine();
// }

// int num = 10;
// int[] mas = CreateRandomArray(new int[num]);
// PrintArrayToScreen(mas);

// int cnt = 0;
// for (int i = 0; i < mas.Length; i++)
// {
//     if(mas[i] >=10 && mas[i]<=90) cnt++;
// }
// Console.Write($"Count the number in range [10,90] in array: {cnt}");


using System;
using System.Linq;
using System.Security.Cryptography;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
        int cnt = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= minRange && numbers[i] <= maxRange) cnt++;
            //Console.WriteLine(cnt);
        }
        //Console.WriteLine($"Count the number in range [10,90] in array: {cnt}");
        return cnt;
    }

    public static void PrintResult(int[] array)
    {
        int min = 10;
        int max = 90;
        //int cnt = CountItemsRange(array,min,max);
        int cnt = CountItemsRange(array, min, max);
        Console.Write(cnt);
    }

    //Не удаляйте и не меняйте класс Answer!
    class Answer
    {
        public static void Main(string[] args)
        {
            int[] array;
            

            if (args.Length >= 1) {
                // Объединяем все аргументы командной строки в одну строку
                string joinedArgs = string.Join(" ", args);

                // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
                array = joinedArgs.Split(", ")
                                    .Select(int.Parse)
                                    .ToArray();
                
                // Теперь arr содержит преобразованные в целые числа из командной строки
            
            } else {
            // Если аргументов на входе нет
                array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
            }
            UserInputToCompileForTest.PrintResult(array);
        }
    }
}