// // ============1 ГРУППА методов - которые ничего не принимают и не возвращают

// void metod1()
// {
//     Console.WriteLine("Что либо.....");
// }
// // metod1();

// // =============2 ГРУППА методов - которые ничего не возвращают, но принимают какие-то аргументы

// void metod2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Выводим значение "msg"
// // metod2("Любое значение - например текст");

// void metod21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Выводим значение "msg" - 4 раза:
// // metod21(msg: "Любое значение - например текст", count: 4);

// // ============3 ГРУППА методов - которые что-то возвращают, но не принимают какие-то аргументы. Необходтмо использовать - return

// int metod3()
// {
//     // возвращаем текущий год
//     return DateTime.Now.Year;
// }
// int resYear = metod3();
// // Console.WriteLine(resYear);

// // ============4 ГРУППА методов - которые что-то возвращают, но и принимают какие-то аргументы.

// string metod4(int count, string text1)
// {
//     int i = 0;
//     // String.Empty - пустая строка
//     string result = String.Empty;
//     // использование цикла While
//     while (i < count)
//     {
//         // перед например - result - НЕ НАДО СТАВИТЬ INT, STRING и т.д.
//         result = result + text1;
//         i++;
//     }
//     return result;
// }
// // string res = metod4(10, "ABC");
// // Console.WriteLine(res);

// string metod41(int count, string text1)
// {
//     // String.Empty - инициализация  + пустая строка
//     string result = String.Empty;
//     // использование цикла For
//     for (int i = 0; i < count; i++)
//     {
//         // перед например - result - НЕ НАДО СТАВИТЬ INT, STRING и т.д.
//         result = result + text1;
//     }
//     return result;
// }
// string res = metod41(10, "WF");
// Console.WriteLine(res);

// =====Использование цикла в цикле!!!

// for (int i = 1; i <= 10; i++)
// {
//     for (int j = 1; j <= 10; j++)
//     {
//         // интерпаляция строк $"{}+{}" и т.д.
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     // делаем определенный разрыв
//     Console.WriteLine();
// }

// ====Работа с текстом 
// Дан текст, в тексте необходимо все пробелы заменить черточками, маленькие "к" заменть большими "К", а большие "С" заменть маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винцеслава,"
//             + "вы бы взяли приступом согласие Прусского короля."
//             + "вы так красноречивы, вы дадите мне чаю";
// string s = "qwerty";
//             012345
// s[3] == "r"

// string Replase(string text, char oldValue, char newValue)
// {
//     // String.Empty - инициализация  result + пустая строка
//     string result = String.Empty;
//     // считаем длину текста
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// не работаю "", необходимо использовать '' 
// string newText = Replase(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// string newText1 = Replase(newText, 'к', 'К');
// Console.WriteLine(newText1);
// Console.WriteLine();
// string newText2 = Replase(newText1, 'В', 'в');
// Console.WriteLine(newText2);

int[] arr = { 7, 1, 9, 4, 5, 9, 1, 2, 3, 45, 0, 98, -1 };

void printArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int miniPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[miniPosition]) miniPosition = j;
        }
        int temporary = array[i];
        array[i] = array[miniPosition];
        array[miniPosition] = temporary;
        Console.Write($"{array[i]} ");
    }
}

printArray(arr);
SelectionSort(arr);


