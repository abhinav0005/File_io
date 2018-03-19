using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class StreamWriterEx
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream("f:/bitu", FileMode.Create);
            StreamWriter s1 = new StreamWriter(f1);
            s1.WriteLine("Hello C#");
            s1.Close();
            f1.Close();
            Console.WriteLine("Done.....");
            Console.Read();
        }
    }
}
