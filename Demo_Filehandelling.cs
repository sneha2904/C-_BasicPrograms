﻿using System;
using System.IO;

namespace Demo_Filehandelling
{
    using System.IO;

    namespace Files_handlings
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                System.Console.WriteLine("File_Handling.......!!");
                FileStream fs = new FileStream("D:\\SnehaDetails.txt\\", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine("We Can Read and Display From File");
                string str = sr.ReadToEnd();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }

                fs.Flush();
                fs.Close();
                FileStream fwrite = new FileStream("D:\\SnehaDetails.txt\\", FileMode.Append);
                StreamWriter swrite = new StreamWriter(fwrite);
                Console.WriteLine("Enter Your Content to File..");
                string content = Console.ReadLine();
                swrite.Write(content);
                swrite.Flush();
                fwrite.Flush();
                fwrite.Close();
            }

        }
    }
}
