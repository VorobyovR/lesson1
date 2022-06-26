int Max(int arg1, int arg2, int arg3)
{
    int resultMax = arg1;
    if (arg2 > resultMax) resultMax = arg2;
    if (arg3 > resultMax) resultMax = arg3;
    return resultMax;
}

int[] array = { 11, 201, 36, 14, 55, 16, -7, 218, 98 };
// array[0] = 12;
// Console.WriteLine(array[0]);

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
Console.WriteLine(max);




