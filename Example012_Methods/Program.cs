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

string Method4 (int count, string c)
{
    int i = 0;
    string result = string.Empty;

    while (i<count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "asdad");
Console.WriteLine(res);
