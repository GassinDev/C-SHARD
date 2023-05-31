using System;
using System.IO;

namespace ClaseFiccheroBinarioExplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream("binario.bin", FileMode.Create);
            //BinaryWriter bw = new BinaryWriter(fs);

            //bw.Write(1);
            //bw.Write(2);
            //bw.Write(3);
            //bw.Write(4);
            //bw.Write(5);
            //bw.Write(0.1);
            //bw.Write("Texto");

            //bw.Close();
            //fs.Close();

            FileStream fs = new FileStream("binario.bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            int n1 = br.ReadInt32();
            int n2 = br.ReadInt32();
            int n3 = br.ReadInt32();
            int n4 = br.ReadInt32();
            int n5 = br.ReadInt32();

            double d = br.ReadDouble();


            string s = br.ReadString();

            Console.WriteLine(n1 + ", " + n2 + ", " + n3 + ", " + n4 + ", " + n5);
            Console.WriteLine(d);
            Console.WriteLine(s);


            br.Close();
            fs.Close();



            //int n;

            //while(fs.Position < fs.Length)
            //{
            //    n = br.ReadInt32();
            //    Console.WriteLine(n);
            //}

            //br.Close();
            //fs.Close();

        }
    }
}
