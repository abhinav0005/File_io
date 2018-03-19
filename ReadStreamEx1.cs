using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class ReadStreamEx1
    {
        static void Main(string[] args)
        {
            FileStream f1 = new FileStream("f:/z.txt", FileMode.OpenOrCreate);
            StreamReader s1 = new StreamReader(f1);
            string s2 = "";
            while ((s2 = s1.ReadLine()) != null) ;
            Console.WriteLine(s2);
            s1.Close();
            f1.Close();
            Console.Read();
        }
    }
}
