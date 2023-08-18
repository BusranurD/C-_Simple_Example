using System;

namespace stringforeach
{
    class Program
{
    static int vowel(char letter)
    {
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'ü' || letter == 'ö' 
            || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Ü' || letter == 'Ö')
            return 1;
        else
            return 0;
    }
    static void Main(string[] args)
    {
        string text;
        Console.WriteLine("text?");
        text = Console.ReadLine();
        int num = 0;
        foreach (var letter in text)
        {
            num += vowel(letter);
            Console.WriteLine(letter);
        }

        Console.WriteLine(num);
        string[] texts = new string[5];
        Console.WriteLine("texts?(5)");
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i] = Console.ReadLine();
        }
        string longWord = texts[0];
        foreach (var t in texts)
        {
            if (t.Length > longWord.Length)
                longWord = t;
            Console.WriteLine(t);
        }

        Console.WriteLine("longes word: "+longWord);
        Console.WriteLine("word lenght is "+longWord.Length);
    }
}
}
