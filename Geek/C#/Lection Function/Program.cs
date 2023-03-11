// //Вид 1 не принимают и не возвращают

// void   Method1()
// {
//     Console.WriteLine("Автор ..");
// }

// //Method1();







//Вид 2 принимает, но не возвращаетт

// void Method2(string msg)


// {
//     Console.WriteLine(msg);

// }
// //Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)

// {
//     int i = 0;
//     while (i< count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
//Method21("Текст", 4);
//Method21(msg:"Текст", count:4);
//Method21(count:4, msg:"Текст");





//Вид 3 не принимают, что то возрващают

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// //int year = Method3();
// //Console.WriteLine(year);







//Вид 4 принимают и возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; //пустая строка

//         while(i < count)
//         {
//             result = result + text;
//         }
//         return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {

//     string result = string.Empty;

//     for(int i = 0; i < count; i++)

//     {
//         result = result + text;

//     }
//         return result;
// }

// string res = Method4(10, "x");
// Console.WriteLine(res);


//Задача

//Дан текст. Заменить пробелы черточками.
//Маленькие к, заменить большими К.
//большие С, заменить маленькими с.

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";


// // string s = “qwerty”
// // 012345

// //s[3]//r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++) 
//     {
//     if(text[i] == oldValue) result = result + $"{newValue}";
//     else result = result + $"{text[i]}";
    
//     }
//     return result;
// }

// string newText =  Replace(text,' ','|' );
// Console.WriteLine(newText);

// Console.WriteLine(newText); 
// Console.WriteLine();
// newText = Replace(newText,'к', 'К');
//  Console.WriteLine(newText);

// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.