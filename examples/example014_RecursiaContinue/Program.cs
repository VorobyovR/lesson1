/* числа от а до b
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result+=$"{i} ";
    }
    return result;
}
string NumbersRec(int a, int b)
{
    if(a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}
Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));
*/
/* числа 0 а до n
int SumFor(int n)
{
    int result = 0;
    for (int i = 0; i <= n; i++)
    {
        result+=i;
    }
    return result;
}
int SumRec(int n)
{
    if(n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));
*/
/* факториал числа
int SumFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result*=i;
    }
    return result;
}
int SumRec(int n)
{
    if(n == 1) return 1;
    else return n * SumRec(n - 1);
}
Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));
*/
/* //степень
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result*=a;
    }
    return result;
}
int PoweRec(int a, int n)
{
    if(n == 0) return 1;
    else return a * PoweRec(a, n - 1);
}
int PowerRecMath(int a, int n)
{
    if(n == 0) return 1;
    else if(n % 2 == 0) return PowerRecMath(a*a, n/2);
    else return PowerRecMath(a, n-1)*a;
}
Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PoweRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));
*/
/*
Console.Clear();
int n = 0;
void FindWords(string alfabet, char[] word, int length = 0)
{
    if (length == word.Length) 
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alfabet.Length; i++)
    {
        word[length] = alfabet[i];
        FindWords(alfabet, word, length + 1);
    }
}
FindWords("аисв", new char[3]);
*/
// работа с папками и файлами
/* 
string path = "D:/02. Education/01. SQL";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/
int count1 = 0;
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if(count > 1) Towers(with, some, on, count -1);
    Console.WriteLine($"{with} >> {on}");
    if(count > 1) Towers(some, on, with, count -1);
    count1++;
    // Console.WriteLine(count1);
}
Towers();
Console.WriteLine(count1);
