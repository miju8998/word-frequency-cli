using System;
using System.IO;

class FileReader
{
    public string[] ReadTxtFiles(string folderPath)
    {
        string[] files = Directory.GetFiles(folderPath, "*.txt");
        string[] contents = new string[files.Length];

        for (int i = 0; i < files.Length; i++)
        {
            contents[i] = File.ReadAllText(files[i]);
        }

        return contents;
    }
}