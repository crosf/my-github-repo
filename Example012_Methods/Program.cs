//  Вид 1
void Method1()
{
    Console.WriteLine("Автор я ");
}
// Method1();


// Вид 2

void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}

//Method2(msg:"текст сообшения", count: 2);

// Вид3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

// Вид 4

// string Method4 (int count, string c)
// {
//     int i = 0;
//     string result = string.Empty;

//     while (i<count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string c)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;

    }
    return result;
}

string res = Method4(10, "asdad");
//Console.WriteLine(res);



// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }



//           Работа с текстоь
// дАН ТЕКСТ. в тексте все проблемы заменить черточками
// маленькие  буквы к заменить на большие к
// а большие С заменить на маленькие с

// ЯСНА ЛИ ЗАДАЧА?


string text = "- Я думаю, сказал князь, улыбаясь, что, "
            + "ежели бы вас послали вместо нашего милого Винцегерода,"
            + "вы бы взяли приступом согласие пруского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
//   s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";

    }


    return result;
}

string newText = Replace(text, ' ', '|');


Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
