// СЕМИНАР №3

//1 группа методов которые ничего не возвращают и ничего не принимают
//void Method1()
//{
//    Console.WriteLine("Я Автор этого проекта");
//}
//Method1();

// 2.методы которые ничего не возвращают, но могут принимать какие-то аргументы

//void Method2(string msg)
//{
// Console.WriteLine(msg);
//}
//Method2("Здесь у нас будет отображаться текст");

//void Method21(string msg, int count)
//{
//    int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Покажем этот текст 4 раза", 4);

// 3.Третья группа методов - которые что-то возвращают, но ничего не принимают 
//(Обязательно указать тип данных возвращение которых мы ожидаем, return обязательно)

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// 4.Методы которые что-то принимают и что-то возвращают
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // ""

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(3, "Этот текст мы повторим 3 раза");
// Console.WriteLine(res);

// 5. Применение 4го метода с циклом фор
// string Method4(int count, string text)
// {
//     string result = String.Empty; // ""
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string result = Method4(3, "Этот текст мы повторим 3 раза");
// Console.WriteLine(result);

// Пример использования цикла в цикле - Вывод таблицы умножения на экран
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}*{j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// =====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

// string text = " — Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого"
//             + "Винценгероде, вы бы взяли приступом согласие"
//             + "прусского короля. Вы так красноречивы. Вы"
//             + "дадите мне чаю?";
// // string s = "q w e r t y"
//       s[]=  0 1 2 3 4 5
//      s[3] = r
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, 'к' , 'К');
// Console.WriteLine(newText);


// Сортировка массива и упорядочивание его

// int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length -1 ; i++)
//     {
//         int minPosition = i;
//         for (int j= i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(array);
// SelectionSort(array);

// PrintArray(array);

    int[] myArray = { 5, 6, 1, 7, 3, 9, 34, 5, 87, 54, 12, 23, 45, 60, 0, 5, 3, 1 };
    int[] result = GetAttay(myArray);
    PrintArray(result);