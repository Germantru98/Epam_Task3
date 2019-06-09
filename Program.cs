using System;

namespace Epam_Task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WorkWithString wws = new WorkWithString();
            LineReader line = new LineReader();
            string input = line.ReadFromFile("input.txt");
            Console.WriteLine($"Начальная строка:\n{input}\nРезультат:");

            foreach (var i in wws.UniqueWords(input))
            {
                Console.Write(i + " ");
            }
        }
    }
}