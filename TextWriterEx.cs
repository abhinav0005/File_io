using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class TextWriterEx
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("f:/s.txt"))
            {
                writer.WriteLine("Welcome to India");
                writer.WriteLine("Hello......");
            }
            Console.WriteLine("done....");
            Console.Read();
        }
    }
}
