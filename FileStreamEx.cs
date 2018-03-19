using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIO
{
    class FileStreamEx
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream("f:/b2.txt", FileMode.OpenOrCreate);
            int i = 0;
            while((i = f1.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f1.Close();
            Console.Read();
        }
    }
}
