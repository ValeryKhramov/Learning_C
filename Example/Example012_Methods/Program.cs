using static System.Console;
Clear();

// //Вид 1 (Ничего не принимают и ничеег не выводят)

// void Method1()
// {
//     WriteLine("Автор..");
// }

// Method1(); // Как вызываются.

// // Вид 2 (Что-то принимают, но ничего не выводят)

// void Method2(string msg)
// {
//     WriteLine(msg);
// }
// Method2("Текст сообщения.");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//         WriteLine(msg);
//         i++;
//     }
    
// }
// Method21(msg: "ТEКСТ сообщения.", count: 4); // Если исользуем именнованные аргументы, порядок соблюдать необязательно

// // Вид 3 (Что-то возырвщают, но ничего не принимают)

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();// Здесь необходимо поместить значение метода в переменную
// //WriteLine(year);

// // Вид 4 (Что-то получают и что-то возвращают -- самые распространенные)

// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty;

// //     while(i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++) //for( инициализация счетчика, проверка условия, инкримент(Увеличение счетчика))
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// //WriteLine(res);


// // for (int i = 2; i <= 10; i++)
// // {
// //     for (int j = 1; j <= 10; j++)
// //     {
// //         WriteLine($"{i} x {j} = {i*j}");
// //     }
// //     WriteLine();
// // }

// // =========== Работа с текстом
// // Дан текст, в тексте нужно амнть все пробелы черточками,
// // маленькие буквы "к" заменить большими "К",
// // а большие "С" заменить на маленькие "с"

// string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//             + "ежели бы вас послали вместо нашег милого Винценгероде,"
//             + "вы бы взяли риступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012
// // s[3] == r

// string Replace(string Text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = Text.Length;
//     for(int i = 0; i < length; i++)
//     {
//         if(Text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{Text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');
// WriteLine(newText);
// WriteLine();
// newText = Replace(newText, 'к', 'К');
// WriteLine(newText);
// WriteLine();
// newText = Replace(newText, 'C', 'c');
// WriteLine(newText);

//Сортировка методом выбора!
int[] arr = {1, 5, 4, 3, 2, 6, 7, 21, 17};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}


void SelectionSort(int[] array)
{

    for(int i = 0; i < array.Length - 1 ; i++)
    {
       int minPosition = i;
        for(int j = i + 1; j < array.Length ; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
       

       int temporary = array[i];
       array[i] = array[minPosition];
       array[minPosition] = temporary;
    }
    WriteLine();
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);