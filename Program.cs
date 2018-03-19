using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("f:\\b2.txt", FileMode.OpenOrCreate);
            f.WriteByte(65);
            Console.WriteLine();
            for(int i=65; i<90;i++)
            {
                f.WriteByte((byte)i);
            }
            f.Close();
            Console.Read();
        }
    }
}
