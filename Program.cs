using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter folder path: ");
        string folderPath = Console.ReadLine();

        Console.Write("Enter N (minimum word length): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter M (characters to remove): ");
        int m = int.Parse(Console.ReadLine());

        FileReader reader = new FileReader();
        TextProcessor processor = new TextProcessor();
        WordCounter counter = new WordCounter();

        List<string> allWords = new List<string>();

        string[] texts = reader.ReadTxtFiles(folderPath);

        foreach (string text in texts)
        {
            List<string> words = processor.ProcessText(text, n, m);
            allWords.AddRange(words);
        }

        Dictionary<string, int> result = counter.CountWords(allWords);

        Console.WriteLine("\nWord Frequencies:\n");

        foreach (var item in result)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}