// Методы заполнения масиива и печать массива на экран
//void - метод ничего не возвращает, здесь не нужно вводить return
void FillArray(int[] collection)
{
    int lenght = collection.Length; // находим длинну массива
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10); //рандомное число из диапазона 1 - 10

        index++; // index = index + 1
    }
}

void PrintArray(int[] col)// метод void, который будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position< count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;//если не встречается не одного элемента из массива выведется -1

    while (index<count)
    {
        if(collection[index]==find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10]; // любые 10 чисел в массиве

FillArray(array); // заполняет массив
array[4] = 4;//заменили в массиве под индексом 4 число на 4
array[6] = 4;//заменили в массиве под индексом 6 число на 4
PrintArray(array); // выводит массив

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

