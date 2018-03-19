using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIO
{
    class TextReaderEx1
    {
        static void Main(string[] args)
        {
            using (TextReader reader = File.OpenText("f:/s.txt"))
            {
                Console.WriteLine(reader.ReadLine());
            }
            Console.Read();
        }
    }
}
