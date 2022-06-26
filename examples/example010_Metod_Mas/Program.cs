void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] colect)
{
    int count = colect.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(colect[position]);
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find) 
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создать новый массив с количество элементов = 10

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 9);
Console.WriteLine(pos);

