Console.Clear();

void Fillarray(int[] collection)// Метод заполнения массива рандомными цифрами
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // Метод печатает массив в консоль
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while(index < count)
    {
        if(collection[index] == find);
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создать новый массив в десять элементов (По умолчанию создастся массив с десятью нулями)

Fillarray(array); // Метод заполнения массива рандомными цифрами
array[4] = 4;
array[6] = 4;
PrintArray(array); // Метод печатает массив в консоль
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
