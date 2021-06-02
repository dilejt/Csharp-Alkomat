using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Alkomat
{

    public class FileOperation
    {
        public double promile;
        string path = "results.csv";
        List<string> list = new List<string>();
        string[] lines;
        public string[][] descriptions; 

        public FileOperation()
        {
            string fileName = @"drunk.txt";
            this.descriptions = new string[5][];
            ReadFile(fileName);
        }
        public void ReadFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                int i = 0;
                string[] lines = new string[5];
                while ((line = reader.ReadLine()) != null)
                {
                    lines[i] = line;
                    i++;
                }
                for (i = 0; i<5; i++)
                {
                    descriptions[i] = lines[i].Split(';');
                }
            }
        }
        public void readFile()
        {
            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path);
            }
            else
            {
                File.Create(path);
            }
        }
        public void saveFile()
        {
            foreach (string line in lines)
            {
                list.Add(line);
            }
            list.Add(DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ", Promile: " + Convert.ToString(promile));
            File.WriteAllLines(path, list.Select(x => string.Join(",", x)));

        }
    }

}
