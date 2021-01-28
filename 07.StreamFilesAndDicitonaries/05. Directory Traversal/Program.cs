using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace _05._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            using ZipArchive zipFile = ZipFile.Open("zipfile.zip", ZipArchiveMode.Create);
            ZipArchiveEntry zipArchiveEntry = zipFile.CreateEntryFromFile("output.txt", "outputEntry.txt");

            string directoryPath = Directory.GetCurrentDirectory();
            string[] fileNames = Directory.GetFiles(directoryPath);
            Dictionary<string, Dictionary<string, double>> filesData = new Dictionary<string, Dictionary<string, double>>();

            foreach (string fullName in fileNames)
            {

                FileInfo fileInfo = new FileInfo(fullName);
                string extension = fileInfo.Extension;
                long size = fileInfo.Length;
                double kbSize = Math.Round(size / 1024.0, 3);
                if (!filesData.ContainsKey(extension))
                {
                    filesData.Add(extension, new Dictionary<string, double>());

                }

                filesData[extension].Add(fileInfo.Name, kbSize);

                Dictionary<string, Dictionary<string, double>> sortedDict = filesData.OrderByDescending(k => k.Value.Count).ThenBy(k => k.Key).ToDictionary(k => k.Key, v => v.Value);


                List<string> result = new List<string>();

                foreach (var item in sortedDict)
                {

                    result.Add(item.Key);
                    foreach (var fileData in item.Value.OrderBy(x=>x.Value))
                    {
                        result.Add($"--{fileData.Key} - {fileData.Value}kb");
                    }
                }
                File.WriteAllLines("output.txt",result);
            }
        }
    }
}
