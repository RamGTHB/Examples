﻿Console.Clear();

// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find.

// Задаем массив
// index        0   1   2   3    4   5   6   7   8   9
int[] array = {11, 211, 31, 61, 41, 15, 61, 17, 18, 19};

int n = array.Length; // указывает длинну(количество элементов) массива.
int find = 61; // Нужно найти это цифру
int index = 0; //Ставим счетчик:

while(index < n)// Ставим цикл нахождения
{
    if (array[index] == find)
    {
        Console.WriteLine(index); // покажет в консоли индекс искомой цифры
        break; // Остановит цикл при нахождении первого искомого числа, если есть повторяющиеся
    }
    index++;
}
