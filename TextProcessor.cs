using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class TextProcessor
{
    public List<string> ProcessText(string text, int n, int m)
    {
        List<string> wordsList = new List<string>();

        string[] words = Regex.Split(text.ToLower(), @"\W+");

        foreach (string word in words)
        {
            if (!string.IsNullOrWhiteSpace(word))
            {
                string processedWord = word;

                if (processedWord.Length > n && processedWord.Length > m)
                {
                    processedWord = processedWord.Substring(0, processedWord.Length - m);
                }

                wordsList.Add(processedWord);
            }
        }

        return wordsList;
    }
}