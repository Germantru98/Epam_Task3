using System.IO;

namespace Epam_Task3
{
    internal class LineReader
    {
        public string ReadFromFile(string filename)
        {
            using (StreamReader stream = new StreamReader(filename))
            {
                return stream.ReadLine();
            }
        }
    }
}