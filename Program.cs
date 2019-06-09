using System;

namespace Epam_Task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WorkWithString wws = new WorkWithString();
            LineReader line = new LineReader();
            foreach (var i in wws.UniqueWords(line.ReadFromFile("input.txt")))
            {
                Console.WriteLine(i);
            }
        }
    }
}