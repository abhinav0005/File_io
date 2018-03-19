using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class BinaryWriterEx1
    {
        static void Main(string[] args)
        {
            string fileN = "F:\\FileIO\\binary.data";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileN, FileMode.Create)))
            {
                writer.Write(2.4);
                writer.Write("this is float data");
                writer.Write(true);
            }
            Console.WriteLine("done........");
            Console.Read();
        }
    }
}
