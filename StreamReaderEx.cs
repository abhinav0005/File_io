using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class StreamReaderEx
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream("f:/bitu", FileMode.Open);
            StreamReader s1 = new StreamReader(f1);
            string msg = s1.ReadLine();
            Console.WriteLine(msg);
            s1.Close();
            f1.Close();
            Console.Read();
        }
    }
}
