// Указать индекс искомого числа в массиве

int [] array = {31,22,43,4,75,56,78,78};

int n = array.Length; // указываем, что возможнно любое количество чисел в массиве
int find = 78;

int index = 0;

while (index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break; // прервать выполнение действия
    }
    index++; // index = index + 1
}

