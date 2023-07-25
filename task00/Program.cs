// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System.ComponentModel;

int[] Input(string abc) // Записываем массив из строки, преобразуем строковой массив в числовой//На вход принимаем сообщение для пользователя
{
    Console.Write($"{abc} ");
    string[] input = Console.ReadLine()!.Split(new char[] {' ', ','});
    int[] numbers = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
        numbers[i] = Convert.ToInt32(input[i]);

    return numbers;
}

int Summ(int[] array) //Функция находит количество положительных элементов массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            count ++;
        }

    return count;
}

int[] array = Input("Введите числа через запятую или пробел:");
Console.WriteLine($"Количество положительных элементов массива = {Summ(array)}");