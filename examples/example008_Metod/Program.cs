int Max(int arg1, int arg2, int arg3)
{
    int resultMax = arg1;
    if (arg2 > resultMax) resultMax = arg2;
    if (arg3 > resultMax) resultMax = arg3;
    return resultMax;
}

int a = 2;
int b = 6;
int c = 86;

int a1 = -3;
int b1 = 14;
int c1 = 45;

int a2 = 3;
int b2 = -12;
int c2 = 20;


// int max = a;

// if (b > max) max = b;
// if (c > max) max = c;

// if (a1 > max) max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// int max1 = Max(a, b, c);
// int max2 = Max(a1, b1, c1);
// int max3 = Max(a2, b2, c2);

// int max = Max(max1, max2, max3);
int max = Max(Max(a, b, c), Max(a1, b1, c1), Max(a2, b2, c2)); 

Console.WriteLine(max);