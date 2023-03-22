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

Method2("текст сообшения", 2);
