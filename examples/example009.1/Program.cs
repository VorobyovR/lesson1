int[] array = {10, 56, 2, 3, 87, 89, 65, 87};
int n = array.Length;
int find = 87;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //если необходимо прервать операцию, в данном применре не учитывать такое же число , как ищем
    }
    index++;
}
