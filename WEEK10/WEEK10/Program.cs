using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK10
{
    class Program
    {
        static void Main(string[] args)
        {
            var tp = new TextProcessing();
            tp.Run();
            Console.Read();
        }
    class TextProcessing
        {
            public void Run()
            {
                using (StreamReader file = new StreamReader("C:/Users/Admin/ASSIGNMENT/WEEK10/WEEK10/TextFile1.TXT"))
                {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                        counter++;
                    }
                    file.Close();
                    Console.WriteLine($"File has {counter} lines.");
                }
            }
        }
    }
}
