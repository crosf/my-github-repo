// string NumbersFor(int a, int b) // числа от а до b
// {
//     string result = string.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a < b) return $"{a} " + NumbersRec(a + 1, b);
//     else return $"{b}";
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));


// int SumFor (int n) // сумма числе
// {
//     int result = 0;
//     for (int i = 0; i <= n; i++) result += i;
//     return result;
// }

// int SumRec (int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n-1);
// }

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));





// int n=1; // сбор слов из букв

// void FindWords(string alphabet, char[] word, int Length =0)
// {
//     if (Length == word.Length)
//     {
//         Console.WriteLine($"{n++ } {new String(word)}");
//         return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[Length] = alphabet[i];
//         FindWords(alphabet, word, Length + 1);
//     }
// }

// FindWords("fbcd", new char[3]);


