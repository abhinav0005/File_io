using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class BinaryReaderEx
    {
        static void Main(string[] args)
        {
            writeBinaryFile();
            readBinaryFile();
            Console.Read();
        }
        static void writeBinaryFile()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("f:/fileIO/binary.data", FileMode.Create)))
            {
                writer.Write(1.5);
                writer.Write("this is string");
                writer.Write(true); 

            }
        }
        static void readBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("f:/fileIO/binary.data", FileMode.Open)))
            {

                Console.WriteLine("Double value : " + reader.ReadDouble());
                Console.WriteLine("String : " + reader.ReadString());
                Console.WriteLine("Boolean : " + reader.ReadBoolean());
            }
        }
    }
}
