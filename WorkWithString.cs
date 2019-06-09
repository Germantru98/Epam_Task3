using System;
using System.Collections.Generic;
using System.Linq;

namespace Epam_Task3
{
    internal class WorkWithString
    {
        public List<string> Preprocessing(string line)
        {
            char[] splitChars = { ' ', '.', ',', '?', '!', ':', ';' };
            return line.Split(splitChars, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public List<string> UniqueWords(string line)
        {
            List<string> tmp = Preprocessing(line);
            tmp.Sort();
            for (int i = 0; i < tmp.Count - 1; i++)
            {
                if (tmp[i] == tmp[i + 1])
                {
                    tmp.RemoveAll(x => x == tmp[i]);
                }
            }
            return tmp;
        }
    }
}