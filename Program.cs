using System;
using System.IO;
using System.Net.Http.Headers;

class BinaryFilesDemo
{
    static void Main()
    {
        FileStream fs = new FileStream("data.bin", FileMode.Create);
        BinaryWriter w = new BinaryWriter(fs);
        w.Write("Ivan"); w.Write(57);
        w.Write("Irinia"); w.Write(31);
        w.Write("Marian"); w.Write(26);
        w.Close();
        fs.Close();

        fs = new FileStream("data.bin", FileMode.Open);
        BinaryReader r = new BinaryReader(fs);

        while(fs.Position < fs.Length - 1)
        {
            string name;
            int age;
            name = r.ReadString();
            age = r.ReadInt32();

            Console.WriteLine("Ime: {0}, Vazrast: {1}", name, age);
        }

        r.Close();
        Console.ReadKey();
    }
}